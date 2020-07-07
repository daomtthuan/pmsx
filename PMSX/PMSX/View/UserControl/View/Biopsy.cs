using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.View {
    public partial class Biopsy : XtraUserControl {
        private class BiopsyTable : TableView {
            protected override void OnInit() {
                titleLabel.Text = "Danh sách mẫu sinh thiết";
            }

            protected override void OnLoad() {
                gridControl.DataSource = Controller.Biopsy.Instance.GetList();
                gridView.PopulateColumns();
                gridView.Columns["Id"].Visible = false;
                gridView.Columns["FullCode"].Caption = "Mã số";
                gridView.Columns["PatientName"].Caption = "Bệnh nhân";
                gridView.Columns["TechnicianName"].Caption = "Kỹ thuật viên";
                gridView.Columns["DoctorName"].Caption = "Bác sĩ";
                gridView.Columns["GrossStaffName"].Caption = "Nhân viên gọt";
                gridView.Columns["NumberSegment"].Caption = "Số phân thùy";
                gridView.Columns["GrossDatetime"].Caption = "Ngày cắt";
                gridView.Columns["CollectDatetime"].Caption = "Ngày thu thập";
                gridView.Columns["Comment"].Caption = "Ghi chú";
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

        public Biopsy() {
            InitializeComponent();
            Controls.Add(new BiopsyTable() {
                Dock = DockStyle.Fill
            });
        }
    }
}
