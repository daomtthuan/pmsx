﻿using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form {
  public partial class Login : XtraForm {
    public Login() {
      InitializeComponent();

      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      brandPanel.Controls.Add(new UserControl.Component.Brand() {
        Dock = DockStyle.Fill
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

    private void Login_Load(object sender, EventArgs e) {
      usernameInput.Text = "daomtthuan";
      passwordInput.Text = "1";
      LoginButton_Click(sender, e);
    }
  }
}
