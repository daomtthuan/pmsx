using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Permission : DevExpress.XtraEditors.XtraUserControl {
    private class PermissionTable : Layout.Table {
      private List<Model.Permission> permissions;
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
        Controller.Permission.Instance.Disabled(((Model.Permission)GetSelectedRow()).Id);
        LoadData(roleId, roleName);
      }

      public void LoadData(string roleId, string roleName) {
        this.roleId = roleId;
        this.roleName = roleName;
        permissions = Controller.Permission.Instance.SelectByRoleId(roleId);

        TitleLabel.Text = "Danh sách nhân viên có quyền " + roleName;
        GridControl.DataSource = permissions;
        GridView.PopulateColumns();

        foreach (GridColumn column in GridView.Columns) {
          column.Caption = Util.Locale.Instance.Caption[column.FieldName];
          column.Visible =
            column.FieldName == "StaffUsername" ||
            column.FieldName == "StaffName" ||
            column.FieldName == "CreateDatetime" ||
            column.FieldName == "UpdateDatetime";
        }
      }
    }

    private List<Model.Role> roles;

    public Permission() {
      InitializeComponent();
      permissionPanel.Controls.Add(new PermissionTable() {
        Dock = DockStyle.Fill
      });
    }

    private void Permission_Load(object sender, EventArgs e) {
      roles = Controller.Role.Instance.SelectAll();

      if (roles.Count > 0) {
        roleSelect.Properties.DataSource = roles;
        roleSelect.Properties.PopulateColumns();

        foreach (LookUpColumnInfo column in roleSelect.Properties.Columns) {
          column.Caption = Util.Locale.Instance.Caption[column.FieldName];
          column.Visible =
            column.FieldName == "Name" ||
            column.FieldName == "CreateDatetime" ||
            column.FieldName == "UpdateDatetime" ||
            column.FieldName == "State";
        }

        roleSelect.Properties.ValueMember = "Id";
        roleSelect.Properties.DisplayMember = "Name";
        roleSelect.EditValue = roles[0].Id;
      }
    }

    private void RoleSelect_EditValueChanged(object sender, EventArgs e) {
      ((PermissionTable)permissionPanel.Controls[0]).LoadData(roleSelect.EditValue.ToString(), roleSelect.Text);
    }
  }
}
