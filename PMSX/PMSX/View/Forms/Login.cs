using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form {
    public partial class Login : XtraForm {
        public Login() {
            InitializeComponent();

            Icon = Resources.icon;

            Button closeButton = new Button();
            closeButton.Click += new EventHandler((sender, e) => Close());
            CancelButton = closeButton;
        }

        private void LoginButton_Click(object sender, EventArgs e) {            
            if (usernameTextEdit.Text.Length * passwordTextEdit.Text.Length == 0) {
                XtraMessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                Model.Staff staff = Controller.Staff.Instance.Auth(usernameTextEdit.Text, passwordTextEdit.Text);
                if (staff == null) {
                    XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    Controller.Main.Instance.Staff = staff;
                    Close();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e) {
            usernameTextEdit.Text = "daomtthuan";
            passwordTextEdit.Text = "1";
            Controller.Main.Instance.Staff = Controller.Staff.Instance.Auth(usernameTextEdit.Text, passwordTextEdit.Text);
            Close();
        }
    }
}