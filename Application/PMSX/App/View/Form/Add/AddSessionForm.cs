using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility.View.Control;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
  public partial class AddSessionForm : DevExpress.XtraEditors.XtraForm {
    public AddSessionForm() {
      InitializeComponent();
    }

    private void AddSessionForm_Load(object sender, EventArgs e) {
      dateSelect.DateTime = DateTime.Now;
      GridUtility.Instance.LoadData(doctorPermissionSelect, PermissionController.Instance.GetByRole(Authentication.Role.Doctor, 1), new[] { "StaffId", "StaffName" }, "StaffId", "StaffName");
      GridUtility.Instance.LoadData(technicianPermissionSelect, PermissionController.Instance.GetByRole(Authentication.Role.Technician, 1), new[] { "StaffId", "StaffName" }, "StaffId", "StaffName");
    }

    private void AddButton_Click(object sender, EventArgs e) {
      DateTime date = dateSelect.DateTime;
      Permission doctorPermission = (Permission)GridUtility.Instance.GetSelected(doctorPermissionSelect);
      Permission technicianPermission = (Permission)GridUtility.Instance.GetSelected(technicianPermissionSelect);
      string comment = commentInput.Text;

      SessionController.Instance.Add(date, doctorPermission.StaffId, technicianPermission.StaffId, comment);

      DialogResult = DialogResult.OK;
      Close();
    }
  }
}