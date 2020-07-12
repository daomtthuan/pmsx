using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Permission : DevExpress.XtraEditors.XtraUserControl {
    private class PermissionTable : Layout.Table {
      private List<Model.Permission> data;

      public Model.Role SelectRole { get; set; }

      protected override void OnInsert() {
        new Form.Insert.Permission(SelectRole).ShowDialog();
        LoadData(SelectRole);
      }

      protected override void OnUpdate() {
        new Form.Update.Permission(data.Where(item => item.Id == SelectedId).First()).ShowDialog();
        LoadData(SelectRole);
      }

      protected override void OnDisabled() {
        Controller.Permission.Instance.Disabled(SelectedId);
        LoadData(SelectRole);
      }

      public void LoadData(Model.Role role) {
        SelectRole = role;
        data = Controller.Permission.Instance.SelectByRoleId(role.Id);

        TitleLabel.Text = "Danh sách nhân viên có quyền " + role.Name;
        GridControl.DataSource = data.Select(item => {
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

    private List<Model.Role> data;

    public Permission() {
      InitializeComponent();
      permissionPanel.Controls.Add(new PermissionTable() {
        Dock = DockStyle.Fill
      });
    }

    private void Permission_Load(object sender, EventArgs e) {
      data = Controller.Role.Instance.SelectAll();

      if (data.Count > 0) {
        roleSelect.Properties.DataSource = data.Select(item => new {
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

        roleSelect.EditValue = data[0].Id;
      }
    }

    private void RoleSelect_EditValueChanged(object sender, EventArgs e) {
      ((PermissionTable)permissionPanel.Controls[0]).LoadData(data.Where(item => item.Id == roleSelect.GetColumnValue("Id").ToString()).First());
    }
  }
}
