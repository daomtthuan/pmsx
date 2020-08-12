using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Edit {
  internal partial class EditSessionForm : XtraForm {
    public EditSessionForm() {
      InitializeComponent();
    }

    private void EditSessionForm_Load(object sender, EventArgs e) {
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

    private void EditButton_Click(object sender, EventArgs e) {
      Session session = (Session)Tag;
      DateTime date = dateSelect.DateTime;
      object doctorPermission = GridUtility.Instance.GetSelected(doctorPermissionSelect);
      object technicianPermission = GridUtility.Instance.GetSelected(technicianPermissionSelect);
      string comment = commentInput.Text;
      int state = (int)stateRadio.EditValue;

      if (date == null) {
        AlertUtility.Instance.ShowWarning("Vui lòng chọn ngày phiên làm việc");
        return;
      }

      if (doctorPermission == null) {
        AlertUtility.Instance.ShowWarning("Vui lòng chọn bác sĩ phiên làm việc");
        return;
      }

      if (technicianPermission == null) {
        AlertUtility.Instance.ShowWarning("Vui lòng chọn kỹ thuật viên phiên làm việc");
        return;
      }

      List<Session> sessions = null;
      OverlayUtility.Instance.StartProcess(this, () => {
        sessions = SessionController.Instance.GetByDate(date);
      });
      if (sessions == null) {
        Application.Exit();
        DialogResult = DialogResult.No;
      } else if (sessions.Count != 0) {
        if (sessions[0].Id != session.Id) {
          AlertUtility.Instance.ShowWarning("Phiên làm việc ngày này đã có");
          return;
        }
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (SessionController.Instance.Edit(session.Id, date, ((Permission)doctorPermission).StaffId, ((Permission)technicianPermission).StaffId, state, comment) < 0) {
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