using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
  public partial class AddSessionForm : DevExpress.XtraEditors.XtraForm {
    public AddSessionForm() {
      InitializeComponent();
    }

    private void AddSessionForm_Load(object sender, EventArgs e) {
      dateSelect.DateTime = DateTime.Now;

      System.Collections.Generic.List<Permission> doctorPermissions = PermissionController.Instance.GetByRole(Authentication.Role.Doctor, 1);
      if (doctorPermissions == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(doctorPermissionSelect, doctorPermissions, new[] { "StaffId", "StaffName" }, "StaffId", "StaffName");

      System.Collections.Generic.List<Permission> technicianPermissions = PermissionController.Instance.GetByRole(Authentication.Role.Technician, 1);
      if (technicianPermissions == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(technicianPermissionSelect, technicianPermissions, new[] { "StaffId", "StaffName" }, "StaffId", "StaffName");

      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      OverlayUtility.Instance.StartProcess(this, () => {
        DateTime date = dateSelect.DateTime;
        Permission doctorPermission = (Permission)GridUtility.Instance.GetSelected(doctorPermissionSelect);
        Permission technicianPermission = (Permission)GridUtility.Instance.GetSelected(technicianPermissionSelect);
        string comment = commentInput.Text;

        if (SessionController.Instance.Add(date, doctorPermission.StaffId, technicianPermission.StaffId, comment) < 0) {
          Application.Exit();
          return;
        }

        DialogResult = DialogResult.OK;
        Close();
      });
    }
  }
}