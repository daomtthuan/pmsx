using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.App.View.Form.Add;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using PMSX.Utility.View.Control;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  public partial class LoginForm : DevExpress.XtraEditors.XtraForm {
    public LoginForm() {
      InitializeComponent();

      usernameInput.Text = "daomtthuan";
      passwordInput.Text = "1";
    }

    private void LoginForm_Load(object sender, EventArgs e) {
      GridUtility.Instance.LoadData(sessionSelect, SessionController.Instance.Get(1), new[] { "Id", "Date", "DoctorName", "TechnicianName" }, "Id", "Date");

      LoginButton_Click(sender, e);
    }

    private bool Login() {
      Authentication.State state = Authentication.Instance.Login(usernameInput.Text, passwordInput.Text);
      switch (state) {
        case Authentication.State.LoggedIn:
          return true;
        case Authentication.State.Disabled:
          AlertUtility.Instance.ShowWarning("Tài khoản đã bị vô hiệu hoá");
          break;
        case Authentication.State.Failed:
          AlertUtility.Instance.ShowWarning("Tên đăng nhập hoặc mật khẩu không đúng");
          break;
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

      if (Login()) {
        Authentication.Instance.Session = (Session)GridUtility.Instance.GetSelected(sessionSelect);
        DialogResult = DialogResult.OK;
        Close();
      }
    }

    private void SessionButton_Click(object sender, EventArgs e) {
      if (Login()) {
        if (!Authentication.Instance.HasOneRole(Authentication.Role.Admin, Authentication.Role.Doctor, Authentication.Role.Technician)) {
          AlertUtility.Instance.ShowWarning("Tài khoản không có quyền thêm phiên làm việc");
        } else {
          Hide();
          if (FormFactory<AddSessionForm>.Instance.Create().ShowDialog() == DialogResult.OK) {
            LoginForm_Load(sender, e);
          }
          Show();
        }
      }
    }
  }
}