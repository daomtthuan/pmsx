using System;
using System.Collections.Generic;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class Permission : Pattern.Class.EscCloseForm {
    private readonly string roleId;
    private readonly List<Model.Staff> staffs;

    public Permission(string roleId, List<Model.Staff> staffs) {
      InitializeComponent();

      this.roleId = roleId;
      this.staffs = staffs;
    }

    private void Permission_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(staffSelect, staffs, new[] { "Username", "Name", "State" }, "Id", "Name");
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      Controller.Permission.Instance.Insert(staffSelect.EditValue.ToString(), roleId, commentInput.Text);
      Close();
    }
  }
}