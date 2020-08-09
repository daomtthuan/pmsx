using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  public partial class AccountForm : DevExpress.XtraEditors.XtraForm {
    public AccountForm() {
      InitializeComponent();
    }

    private void ProfileForm_Load(object sender, EventArgs e) {
      usernameInput.Text = Authentication.Instance.Staff.Username;
      nameInput.Text = Authentication.Instance.Staff.Name;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Name, nameInput.Text)) {
        AlertUtility.Instance.ShowWarning("Tên không hợp lệ");
        return;
      }

      if (AlertUtility.Instance.ShowConfirm("Chỉnh sửa thông tin tài khoản này?") == DialogResult.No) {
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        string password = passwordInput.Text;
        string name = nameInput.Text;

        if (StaffController.Instance.Edit(Authentication.Instance.Staff.Id, password, name, Authentication.Instance.Staff.GetStateNumber(), Authentication.Instance.Staff.Comment ?? "") < 0) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else {
          DialogResult = DialogResult.OK;
          List<Staff> staffs = StaffController.Instance.GetById(Authentication.Instance.Staff.Id);
          if (staffs.Count < 0) {
            Application.Exit();
          } else {
            Authentication.Instance.Staff = staffs[0];
            Close();
          }
        }
      });
    }

    private void ResetPasswordButton_Click(object sender, EventArgs e) {
      OverlayUtility.Instance.StartProcess(this, () => {
        passwordInput.Text = StringUtility.Instance.Random(10);
      });
    }
  }
}