
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.View {
    public partial class Staff : DevExpress.XtraEditors.XtraUserControl {

        private class StaffTable : TableView {
            protected override void OnInit() {
                titleLabel.Text = "Danh sách nhân viên";
            }

            protected override void OnLoad() {
                gridControl.DataSource = Controller.Staff.Instance.GetList();
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

            protected override void OnInsert() {
                throw new NotImplementedException();
            }

            protected override void OnUpdate() {
                throw new NotImplementedException();
            }

            protected override void OnDelete() {
                throw new NotImplementedException();
            }
        }

        public Staff() {
            InitializeComponent();
            Controls.Add(new StaffTable() {
                Dock = DockStyle.Fill
            });
        }
    }
}
