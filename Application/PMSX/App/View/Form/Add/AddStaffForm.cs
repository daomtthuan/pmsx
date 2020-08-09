using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.Utility;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
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
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên đăng nhập");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Username, username)) {
        AlertUtility.Instance.ShowWarning("Tên đăng nhập không hợp lệ");
        return;
      }

      if (name.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Name, name)) {
        AlertUtility.Instance.ShowWarning("Tên không hợp lệ");
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