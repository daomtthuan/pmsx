using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Permission : XtraForm {
    private readonly string roleId;
    private readonly List<Model.Staff> staffs;

    public Permission(string roleId, List<Model.Staff> staffs) {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      this.roleId = roleId;
      this.staffs = staffs;
    }

    private void Permission_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(staffSelect, staffs, new[] { "Username", "Name", "State" }, "Id", "Name");
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      Controller.Permission.Instance.Insert(staffSelect.EditValue.ToString(), roleId, commentInput.Text);
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}