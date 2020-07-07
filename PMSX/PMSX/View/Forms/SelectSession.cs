using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form {
    public partial class SelectSession : XtraForm {
        public SelectSession() {
            InitializeComponent();

            Icon = Resources.icon;

            Button closeButton = new Button();
            closeButton.Click += new EventHandler((sender, e) => Close());
            CancelButton = closeButton;
        }

        private void SelectSession_Load(object sender, EventArgs e) {
            sessionLookUpEdit.Properties.DataSource = Controller.Session.Instance.GetListByState(1);
            sessionLookUpEdit.Properties.PopulateColumns();
            sessionLookUpEdit.Properties.DisplayMember = "Name";
            sessionLookUpEdit.Properties.ValueMember = "Id";
            sessionLookUpEdit.Properties.Columns["Id"].Visible = false;
            sessionLookUpEdit.Properties.Columns["State"].Visible = false;
            sessionLookUpEdit.Properties.Columns["Name"].Caption = "Tên";
            sessionLookUpEdit.Properties.Columns["TechnicianName"].Caption = "Kỹ thuật viên";
            sessionLookUpEdit.Properties.Columns["DoctorName"].Caption = "Bác sĩ";
            sessionLookUpEdit.Properties.Columns["Comment"].Caption = "Ghi chú";
            sessionLookUpEdit.Properties.Columns["CreateDatetime"].Caption = "Ngày tạo";
            sessionLookUpEdit.Properties.Columns["UpdateDatetime"].Caption = "Ngày sửa";
        }

        private void StartButton_Click(object sender, EventArgs e) {
            Controller.Main.Instance.Session = (Model.Session)sessionLookUpEdit.GetSelectedDataRow();
            Close();
        }
    }
}