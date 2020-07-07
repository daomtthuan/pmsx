
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.View {
    public partial class Staff : DevExpress.XtraEditors.XtraUserControl {

        private class StaffTable : TableView {
            protected override void Init() {
                titleLabel.Text = "Danh sách nhân viên";
            }

            protected override void View_Load(object sender, EventArgs e) {
                gridControl.DataSource = Controller.Staff.Instance.Get();
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

            protected override void InsertButton_Click(object sender, EventArgs e) {
                throw new NotImplementedException();
            }

            protected override void UpdateButton_Click(object sender, EventArgs e) {
                throw new NotImplementedException();
            }

            protected override void DeleteButton_Click(object sender, EventArgs e) {
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
