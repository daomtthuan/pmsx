using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
  internal partial class AddPermissionForm : XtraForm {
    public AddPermissionForm() {
      InitializeComponent();
    }

    private void AddPermissionForm_Load(object sender, EventArgs e) {
      List<Staff> staffs = StaffController.Instance.GetByNoRoleName(Tag.ToString());
      if (staffs == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(staffSelect, staffs, new[] { "Id", "Username", "Name" }, "Id", "Name");
      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      OverlayUtility.Instance.StartProcess(this, () => {
        long staffId = ((Staff)GridUtility.Instance.GetSelected(staffSelect)).Id;
        int roleId = Array.IndexOf(Authentication.Instance.Roles, Tag.ToString()) + 1;
        string comment = commentInput.Text;

        if (PermissionController.Instance.Add(staffId, roleId, comment) < 0) {
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