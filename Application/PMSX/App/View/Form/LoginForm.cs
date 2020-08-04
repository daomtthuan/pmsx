﻿using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.App.View.Form.Add;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  public partial class LoginForm : DevExpress.XtraEditors.XtraForm {
    public LoginForm() {
      InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e) {
      usernameInput.Text = "daomtthuan";
      passwordInput.Text = "1";

      System.Collections.Generic.List<Session> sessions = SessionController.Instance.Get(1);
      if (sessions == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(sessionSelect, sessions, new[] { "Id", "Date", "DoctorName", "TechnicianName" }, "Id", "Date");
      DisplayUtility.Instance.Set(this, true);

      //LoginButton_Click(sender, e);
    }

    private bool IsLogin() {
      Authentication.State state = Authentication.State.None;
      OverlayUtility.Instance.StartProcess(this, () => {
        state = Authentication.Instance.Login(usernameInput.Text, passwordInput.Text);
      });

      switch (state) {
        case Authentication.State.LoggedIn:
          return true;
        case Authentication.State.Disabled:
          AlertUtility.Instance.ShowWarning("Tài khoản đã bị vô hiệu hoá");
          break;
        case Authentication.State.Failed:
          AlertUtility.Instance.ShowWarning("Tên đăng nhập hoặc mật khẩu không đúng");
          break;
        case Authentication.State.Error:
          Application.Exit();
          return false;
        case Authentication.State.None:
          AlertUtility.Instance.ShowWarning("Vui lòng điền tên đăng nhập và mật khẩu");
          break;
      }
      return false;
    }

    private void LoginButton_Click(object sender, EventArgs e) {
      Session session = (Session)GridUtility.Instance.GetSelected(sessionSelect);
      if (session == null) {
        AlertUtility.Instance.ShowWarning("Vui lòng chọn phiên làm việc");
        return;
      }

      if (IsLogin()) {
        Authentication.Instance.Session = (Session)GridUtility.Instance.GetSelected(sessionSelect);
        DialogResult = DialogResult.OK;
        Close();
      }
    }

    private void SessionButton_Click(object sender, EventArgs e) {
      if (IsLogin()) {
        if (!Authentication.Instance.HasOneRole(Authentication.Role.Admin, Authentication.Role.Doctor, Authentication.Role.Technician)) {
          AlertUtility.Instance.ShowWarning("Tài khoản không có quyền thêm phiên làm việc");
        } else {
          DisplayUtility.Instance.Set(this, false);
          if (FormFactory<AddSessionForm>.Instance.Create().ShowDialog() == DialogResult.OK) {
            System.Collections.Generic.List<Session> sessions = SessionController.Instance.Get(1);
            if (sessions == null) {
              Application.Exit();
              return;
            }
            GridUtility.Instance.LoadData(sessionSelect, sessions, new[] { "Id", "Date", "DoctorName", "TechnicianName" }, "Id", "Date");
          }
          DisplayUtility.Instance.Set(this, true);
        }
      }
    }
  }
}