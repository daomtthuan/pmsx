using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class Permission : Pattern.Class.UserControl {
    private class PermissionTable : Layout.Table {
      private string roleId;
      private string roleName;

      protected override void OnInsert() {
        List<Model.Staff> staffs = Controller.Staff.Instance.SelectByNotRoleId(roleId);
        if (staffs.Count == 0) {
          Utils.View.MessageBox.Instance.Warning("Không thể thêm.\nTất cả nhân viên đã có quyền này.");
        } else {
          new Form.Admin.Insert.Permission(roleId, staffs).ShowDialog();
          LoadData(roleId, roleName);
        }
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.Permission((Model.Permission)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        LoadData(roleId, roleName);
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.Permission.Instance.Disable(((Model.Permission)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
        LoadData(roleId, roleName);
      }

      public void LoadData(string roleId, string roleName) {
        this.roleId = roleId;
        this.roleName = roleName;

        TitleLabel.Text = "Danh sách nhân viên có quyền " + roleName;

        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Permission.Instance.SelectByRoleId(roleId), new[] {
          "StaffUsername", "StaffName", "CreateDatetime", "UpdateDatetime"
        });
      }
    }

    public Permission() {
      InitializeComponent();
      permissionPanel.Controls.Add(new PermissionTable() {
        Dock = DockStyle.Fill
      });
    }

    private void Permission_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(roleSelect, Controller.Role.Instance.SelectAll(), new[] { "Name", "CreateDatetime", "UpdateDatetime", "State" }, "Id", "Name");
    }

    private void RoleSelect_EditValueChanged(object sender, EventArgs e) {
      ((PermissionTable)permissionPanel.Controls[0]).LoadData(roleSelect.EditValue.ToString(), roleSelect.Text);
    }
  }
}
