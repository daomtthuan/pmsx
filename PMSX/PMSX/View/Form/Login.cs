using System;
using System.Text.RegularExpressions;

namespace PMSX.View.Form {
  internal partial class Login : Pattern.View.EscCloseForm, Pattern.Interface.IView {
    public Login() : base() {
      InitializeComponent();

      Icon = Properties.Resources.icon;

      Load += new EventHandler((sender, e) => {
        usernameInput.Text = "doctor1";
        passwordInput.Text = "1";
        LoginButton_Click(sender, e);
      });
    }

    private void LoginButton_Click(object sender, EventArgs e) {
      if (usernameInput.Text.Length == 0 || passwordInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Đăng nhập không thành công.\nVui lòng nhập tên đăng nhập và mật khẩu.");
      } else if (!Regex.IsMatch(usernameInput.Text, "^\\w+$")) {
        Utils.View.MessageBox.Instance.Warning("Đăng nhập không thành công.\nTên đăng nhập không hợp lệ.");
      } else {
        Model.Staff staff = Controller.Staff.Instance.Auth(usernameInput.Text, passwordInput.Text);
        if (staff == null) {
          Utils.View.MessageBox.Instance.Warning("Đăng nhập không thành công.\nTên đăng nhập hoặc mật khẩu không đúng.");
          usernameInput.Focus();
          usernameInput.SelectAll();
        } else {
          if (staff.GetStateNumber() == 0) {
            Utils.View.MessageBox.Instance.Warning("Không thể đăng nhập.\nTài khoản này đã bị vô hiệu hoá.");
          } else {
            Controller.Main.Instance.Staff = staff;
            Controller.Main.Instance.Roles = Controller.Role.Instance.SelectByStaffId(staff.Id);
            Close();
          }
        }
      }
    }
  }
}
