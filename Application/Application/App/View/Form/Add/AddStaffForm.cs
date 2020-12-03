using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.Utility;
using PMSXApplication.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Add {
  internal partial class AddStaffForm : XtraForm {
    public AddStaffForm() {
      InitializeComponent();
    }

    private void AddStaffForm_Load(object sender, EventArgs e) {
      passwordInput.Text = StringUtility.Instance.Random(10);

      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      string username = usernameInput.Text;
      string password = passwordInput.Text;
      string name = nameInput.Text;
      string comment = commentInput.Text;

      if (username.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên đăng nhập nhân viên");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Username, username)) {
        AlertUtility.Instance.ShowWarning("Tên đăng nhập nhân viên không hợp lệ");
        return;
      }

      if (name.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên nhân viên");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Name, name)) {
        AlertUtility.Instance.ShowWarning("Tên nhân viên không hợp lệ");
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (StaffController.Instance.Add(username, password, name, comment) < 0) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else {
          DialogResult = DialogResult.OK;
          Close();
        }
      });
    }
  }
}