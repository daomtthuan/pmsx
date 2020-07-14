using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Micro : XtraUserControl {
    private class PermissionTable : Layout.Table {
      private string roleId;
      private string roleName;

      protected override void OnInsert() {
        List<Model.Staff> staffs = Controller.Staff.Instance.SelectByNotRoleId(roleId);
        if (staffs.Count == 0) {
          Util.View.MessageBox.Instance.Warning("Không thể thêm.\nTất cả nhân viên đã có quyền này.");
        } else {
          new Form.Insert.Permission(roleId, staffs).ShowDialog();
          LoadData(roleId, roleName);
        }
      }

      protected override void OnUpdate() {
        new Form.Update.Permission((Model.Permission)GetSelectedRow()).ShowDialog();
        LoadData(roleId, roleName);
      }

      protected override void OnDisabled() {
        Controller.Permission.Instance.Disable(((Model.Permission)GetSelectedRow()).Id);
        LoadData(roleId, roleName);
      }

      public void LoadData(string roleId, string roleName) {
        this.roleId = roleId;
        this.roleName = roleName;

        TitleLabel.Text = "Danh sách nhân viên có quyền " + roleName;

        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.Permission.Instance.SelectByRoleId(roleId), new[] {
          "StaffUsername", "StaffName", "CreateDatetime", "UpdateDatetime"
        });
      }
    }

    public Micro() {
      InitializeComponent();
      permissionPanel.Controls.Add(new PermissionTable() {
        Dock = DockStyle.Fill
      });
    }

    private void Permission_Load(object sender, EventArgs e) {
      Util.View.Grid.Instance.Load(roleSelect, Controller.Role.Instance.SelectAll(), new[] { "Name", "CreateDatetime", "UpdateDatetime", "State" }, "Id", "Name");
    }

    private void RoleSelect_EditValueChanged(object sender, EventArgs e) {
      ((PermissionTable)permissionPanel.Controls[0]).LoadData(roleSelect.EditValue.ToString(), roleSelect.Text);
    }
  }
}
