using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
  internal partial class AddSessionForm : DevExpress.XtraEditors.XtraForm {
    public AddSessionForm() {
      InitializeComponent();
    }

    private void AddSessionForm_Load(object sender, EventArgs e) {
      dateSelect.DateTime = DateTime.Now;

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

      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      DateTime date = dateSelect.DateTime;
      object doctorPermission = GridUtility.Instance.GetSelected(doctorPermissionSelect);
      object technicianPermission = GridUtility.Instance.GetSelected(technicianPermissionSelect);
      string comment = commentInput.Text;

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
        return;
      } else if (sessions.Count != 0) {
        AlertUtility.Instance.ShowWarning("Phiên làm việc ngày này đã có");
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (SessionController.Instance.Add(date, ((Permission)doctorPermission).StaffId, ((Permission)technicianPermission).StaffId, comment) < 0) {
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