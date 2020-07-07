using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.View {
    public partial class Patient : XtraUserControl {

        private class PatientTable : TableView {
            protected override void Init() {
                titleLabel.Text = "Danh sách bệnh nhân";
            }

            protected override void View_Load(object sender, EventArgs e) {
                gridControl.DataSource = Controller.Patient.Instance.Get();
                gridView.PopulateColumns();
                gridView.Columns["Id"].Visible = false;
                gridView.Columns["Name"].Caption = "Tên";
                gridView.Columns["Year"].Caption = "Năm sinh";
                gridView.Columns["Address"].Caption = "Địa chỉ";
                gridView.Columns["Comment"].Caption = "Ghi chú";
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

        public Patient() {
            InitializeComponent();
            Controls.Add(new PatientTable() {
                Dock = DockStyle.Fill
            });
        }
    }
}
