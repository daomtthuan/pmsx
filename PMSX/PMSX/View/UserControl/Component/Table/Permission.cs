using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Permission : DevExpress.XtraEditors.XtraUserControl {
    private class PermissionTable : Layout.Table {
      private List<Model.Permission> permissions;
      private string roleId;
      private string roleName;

      protected override void OnInsert() {
        List<Model.Staff> staffs = Controller.Staff.Instance.SelectByNotRoleId(roleId, 1);
        if (staffs.Count == 0) {
          Util.MessageBox.Instance.Warning("Không thể thêm.\nTất cả nhân viên đã có quyền này.");    
        } else {
          new Form.Insert.Permission(roleId, staffs).ShowDialog();
          LoadData(roleId, roleName);
        }        
      }

      protected override void OnUpdate() {
        new Form.Update.Permission(permissions.Where(item => item.Id == SelectedId).First()).ShowDialog();
        LoadData(roleId, roleName);
      }

      protected override void OnDisabled() {
        Controller.Permission.Instance.Disabled(SelectedId);
        LoadData(roleId, roleName);
      }

      public void LoadData(string roleId, string roleName) {
        this.roleId = roleId;
        this.roleName = roleName;
        permissions = Controller.Permission.Instance.SelectByRoleId(roleId);

        TitleLabel.Text = "Danh sách nhân viên có quyền " + roleName;
        GridControl.DataSource = permissions.Select(item => {
          Model.Staff staff = Controller.Staff.Instance.SelectById(item.StaffId)[0];
          return new {
            item.Id,
            StaffUsername = staff.Username,
            StaffName = staff.Name,
            item.CreateDatetime,
            item.UpdateDatetime,
            State = item.State == 0 ? "Vô hiệu hoá" : "Kích hoạt"
          };
        });
        GridView.PopulateColumns();
        GridView.Columns["Id"].Visible = false;
        GridView.Columns["StaffUsername"].Caption = "Tên đăng nhập";
        GridView.Columns["StaffName"].Caption = "Tên";
        GridView.Columns["CreateDatetime"].Caption = "Ngày tạo";
        GridView.Columns["UpdateDatetime"].Caption = "Ngày sửa";
        GridView.Columns["State"].Caption = "Trạng thái";
      }

      protected override void RowStyle(RowStyleEventArgs e) {
        if (e.RowHandle >= 0) {
          if (GridView.GetRowCellValue(e.RowHandle, "State").ToString() == "Vô hiệu hoá") {
            e.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
          }
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
        roleSelect.Properties.DataSource = roles.Select(item => new {
          item.Id,
          item.Name,
          item.CreateDatetime,
          item.UpdateDatetime,
          State = item.State == 0 ? "Vô hiệu hoá" : "Kích hoạt"
        });
        roleSelect.Properties.PopulateColumns();
        roleSelect.Properties.DisplayMember = "Name";
        roleSelect.Properties.ValueMember = "Id";
        roleSelect.Properties.Columns["Id"].Caption = "Mã định danh";
        roleSelect.Properties.Columns["Id"].Visible = false;
        roleSelect.Properties.Columns["Name"].Caption = "Tên";
        roleSelect.Properties.Columns["CreateDatetime"].Caption = "Ngày tạo";
        roleSelect.Properties.Columns["UpdateDatetime"].Caption = "Ngày sửa";
        roleSelect.Properties.Columns["State"].Caption = "Trạng thái";

        roleSelect.EditValue = roles[0].Id;
      }
    }

    private void RoleSelect_EditValueChanged(object sender, EventArgs e) {
      ((PermissionTable)permissionPanel.Controls[0]).LoadData(roleSelect.EditValue.ToString(), roleSelect.Text);
    }
  }
}
