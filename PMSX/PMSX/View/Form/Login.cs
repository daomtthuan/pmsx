using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Text.RegularExpressions;
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
      if (usernameInput.Text.Length == 0 || passwordInput.Text.Length == 0) {
        XtraMessageBox.Show("Đăng nhập không thành công.\nVui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else if (!Regex.IsMatch(usernameInput.Text, "^\\w+$")) {
        XtraMessageBox.Show("Đăng nhập không thành công.\nTên đăng nhập không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else {
        Model.Staff staff = Controller.Staff.Instance.Auth(usernameInput.Text, passwordInput.Text);
        if (staff == null) {
          XtraMessageBox.Show("Đăng nhập không thành công.\nTên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } else {
          if (staff.State == 0) {
            XtraMessageBox.Show("Không thể đăng nhập.\nTài khoản này đã bị vô hiệu hoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          } else {
            Controller.Main.Instance.Staff = staff;
            Controller.Main.Instance.Roles = staff.GetRoles();
            Close();
          }
        }
      }
    }

    private void Login_Load(object sender, EventArgs e) {
      usernameInput.Text = "daomtthuan";
      passwordInput.Text = "1";
      //LoginButton_Click(sender, e);
    }
  }
}
