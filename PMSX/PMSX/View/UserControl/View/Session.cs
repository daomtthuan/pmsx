using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.View {
    public partial class Session : XtraUserControl {
        private class SessionTable : TableView {
            protected override void OnInit() {
                titleLabel.Text = "Danh sách phiên làm việc";
            }

            protected override void OnLoad() {
                gridControl.DataSource = Controller.Session.Instance.GetList();
                gridView.PopulateColumns();
                gridView.Columns["Id"].Visible = false;
                gridView.Columns["Name"].Caption = "Tên";
                gridView.Columns["TechnicianName"].Caption = "Kỹ thuật viên";
                gridView.Columns["DoctorName"].Caption = "Bác sĩ";
                gridView.Columns["Comment"].Caption = "Ghi chú";
                gridView.Columns["State"].Visible = true;
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

        public Session() {
            InitializeComponent();
            Controls.Add(new SessionTable() {
                Dock = DockStyle.Fill
            });
        }
    }
}
