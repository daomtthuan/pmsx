using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.App.View.Form.Add;
using PMSX.Pattern.Factory;
using PMSX.Utility;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  internal partial class LoginForm : DevExpress.XtraEditors.XtraForm {
    public LoginForm() {
      InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e) {
      usernameInput.Text = "daomtthuan";
      passwordInput.Text = "1";

      List<Session> sessions = SessionController.Instance.Get(1);
      if (sessions == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(sessionSelect, sessions, new[] { "Id", "Date", "DoctorName", "TechnicianName" }, "Id", "Date");
      DisplayUtility.Instance.Set(this, true);

      LoginButton_Click(sender, e);
    }

    private bool IsLogin() {
      string username = usernameInput.Text;
      string password = passwordInput.Text;

      if (username.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên đăng nhập");
        return false;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Username, username)) {
        AlertUtility.Instance.ShowWarning("Tên đăng nhập không hợp lệ");
        return false;
      }

      if (password.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập mật khẩu");
        return false;
      }

      Authentication.State state = Authentication.State.Error;
      OverlayUtility.Instance.StartProcess(this, () => {
        state = Authentication.Instance.Login(username, password);
      });

      switch (state) {
        case Authentication.State.LoggedIn:
          return true;
        case Authentication.State.Disabled:
          AlertUtility.Instance.ShowWarning("Tài khoản này đã bị vô hiệu hoá");
          break;
        case Authentication.State.Failed:
          AlertUtility.Instance.ShowWarning("Tên đăng nhập hoặc mật khẩu không đúng");
          break;
        case Authentication.State.Error:
          Application.Exit();
          return false;
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
          DialogResult result = FormFactory<AddSessionForm>.Instance.Create().ShowDialog();
          if (result == DialogResult.No) {
            return;
          }

          if (result == DialogResult.OK) {
            List<Session> sessions = SessionController.Instance.Get(1);
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