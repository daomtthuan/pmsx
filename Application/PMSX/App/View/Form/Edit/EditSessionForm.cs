using DevExpress.ClipboardSource.SpreadsheetML;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Edit {
  internal partial class EditSessionForm : DevExpress.XtraEditors.XtraForm {
    public EditSessionForm() {
      InitializeComponent();
    }

    private void EditSessionForm_Load(object sender, System.EventArgs e) {
      List<Permission> doctorPermissions = PermissionController.Instance.GetByRole(Authentication.Role.Doctor, 1);
      if (doctorPermissions == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(doctorPermissionSelect, doctorPermissions, new[] { "StaffId", "StaffName" }, "StaffId", "StaffName");

      List<Permission> technicianPermissions = PermissionController.Instance.GetByRole(Authentication.Role.Technician, 1);
      if (technicianPermissions == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(technicianPermissionSelect, technicianPermissions, new[] { "StaffId", "StaffName" }, "StaffId", "StaffName");

      Session session = (Session)Tag;
      dateSelect.DateTime = session.Date;
      doctorPermissionSelect.EditValue = session.DoctorId;
      technicianPermissionSelect.EditValue = session.TechnicianId;
      stateRadio.EditValue = session.GetStateNumber();
      commentInput.Text = session.Comment;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, System.EventArgs e) {
      OverlayUtility.Instance.StartProcess(this, () => {
        Session session = (Session)Tag;
        DateTime date = dateSelect.DateTime;
        Permission doctorPermission = (Permission)GridUtility.Instance.GetSelected(doctorPermissionSelect);
        Permission technicianPermission = (Permission)GridUtility.Instance.GetSelected(technicianPermissionSelect);
        int state = (int)stateRadio.EditValue;
        string comment = commentInput.Text;

        List<Session> sessions = SessionController.Instance.GetByDate(date);
        if (sessions == null) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else if (sessions.Count != 0) {
          if (sessions[0].Id != session.Id) {
            AlertUtility.Instance.ShowWarning("Phiên làm việc ngày này đã có");
            return;
          }
        }

        if (SessionController.Instance.Edit(session.Id, date, doctorPermission.StaffId, technicianPermission.StaffId, state, comment) < 0) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else {
          DialogResult = DialogResult.OK;
          Close();
        }
      });
    }
  }
}