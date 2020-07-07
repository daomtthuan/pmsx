using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using PMSX.Properties;
using System.Windows.Forms;

namespace PMSX.View.Form {
    public partial class Main : RibbonForm {
        private readonly PanelControl panelControl;


        public Main() {
            InitializeComponent();
            SetDisplay(false);

            Icon = Resources.icon;

            panelControl = new PanelControl() {
                Dock = DockStyle.Fill
            };
            Controls.Add(panelControl);
        }

        private void SetDisplay(bool value) {
            Visible = value;
            ShowInTaskbar = value;
            Opacity = value ? 1 : 0;
            FormBorderEffect = value ? FormBorderEffect.Default : FormBorderEffect.None;
        }

        private void AddUserControl(XtraUserControl userControl) {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(userControl);
        }

        private void Main_Load(object sender, System.EventArgs e) {
            Login loginForm = new Login();
            loginForm.ShowDialog();

            if (Controller.Main.Instance.Staff == null) {
                Application.Exit();
            } else {
                SelectSession selectSessionForm = new SelectSession();
                selectSessionForm.ShowDialog();
            }

            SetDisplay(true);
        }

        private void ExitBackstageViewButtonItem_ItemClick(object sender, BackstageViewItemEventArgs e) {
            Application.Exit();
        }

        private void LogoutBackstageViewButtonItem_ItemClick(object sender, BackstageViewItemEventArgs e) {
            Application.Restart();
        }

        private void StaffButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddUserControl(Controller.Staff.Instance.View);
        }

        private void PatientButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            AddUserControl(Controller.Patient.Instance.View);
        }

        private void RoleButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
           
        }
    }
}