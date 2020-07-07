using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.View {
    public partial class Role : XtraUserControl {
        private class RoleTable : TableView {
            protected override void OnInit() {
                titleLabel.Text = "Danh sách nhóm quyền";
            }

            protected override void OnLoad() { }

            protected override void OnInsert() {
                throw new NotImplementedException();
            }

            protected override void OnUpdate() {
                throw new NotImplementedException();
            }

            protected override void OnDelete() {
                throw new NotImplementedException();
            }

            public void LoadData(List<Model.Role> data) {
                gridControl.DataSource = data;
                gridView.PopulateColumns();
                gridView.Columns["Id"].Visible = false;
                gridView.Columns["Name"].Caption = "Tên";
                gridView.Columns["Comment"].Caption = "Ghi chú";
                gridView.Columns["State"].Caption = "Trạng thái";
                gridView.Columns["CreateDatetime"].Caption = "Ngày tạo";
                gridView.Columns["UpdateDatetime"].Caption = "Ngày sửa";
            }
        }

        private class StaffRoleTable : TableView {
            protected override void OnInit() { }

            protected override void OnLoad() { }

            protected override void OnInsert() {
                throw new NotImplementedException();
            }

            protected override void OnUpdate() {
                throw new NotImplementedException();
            }

            protected override void OnDelete() {
                throw new NotImplementedException();
            }

            public void LoadData(string roleId, string roleName) {
                titleLabel.Text = "Danh sách nhân viên thuộc " + roleName;
                gridControl.DataSource = Controller.Staff.Instance.GetListByRoleId(roleId);
                gridView.PopulateColumns();
                gridView.Columns["Id"].Visible = false;
                gridView.Columns["Username"].Caption = "Tên";
                gridView.Columns["Password"].Caption = "Mật khẩu";
                gridView.Columns["Password"].Visible = false;
                gridView.Columns["Name"].Caption = "Tên";
                gridView.Columns["State"].Caption = "Trạng thái";
                gridView.Columns["CreateDatetime"].Caption = "Ngày tạo";
                gridView.Columns["UpdateDatetime"].Caption = "Ngày sửa";
            }
        }

        public Role() {
            InitializeComponent();

            rolePanel.Controls.Add(new RoleTable() {
                Dock = DockStyle.Fill
            });

            staffRolePanel.Controls.Add(new StaffRoleTable() {
                Dock = DockStyle.Fill
            });
        }

        private void Role_Load(object sender, EventArgs e) {
            List<Model.Role> data = Controller.Role.Instance.GetList();

            ((RoleTable)rolePanel.Controls[0]).LoadData(data);

            roleLookUpEdit.Properties.DataSource = data;
            roleLookUpEdit.Properties.PopulateColumns();
            roleLookUpEdit.Properties.DisplayMember = "Name";
            roleLookUpEdit.Properties.ValueMember = "Id";
            roleLookUpEdit.Properties.Columns["Id"].Visible = false;
            roleLookUpEdit.Properties.Columns["Name"].Caption = "Tên";
            roleLookUpEdit.Properties.Columns["Comment"].Caption = "Ghi chú";
            roleLookUpEdit.Properties.Columns["State"].Caption = "Trạng thái";
            roleLookUpEdit.Properties.Columns["CreateDatetime"].Caption = "Ngày tạo";
            roleLookUpEdit.Properties.Columns["UpdateDatetime"].Caption = "Ngày sửa";

            roleLookUpEdit.EditValue = data[0].Id;

        }

        private void RoleLookUpEdit_EditValueChanged(object sender, EventArgs e) {
            Model.Role role = (Model.Role)roleLookUpEdit.GetSelectedDataRow();
            ((StaffRoleTable)staffRolePanel.Controls[0]).LoadData(role.Id, role.Name);
        }
    }
}
