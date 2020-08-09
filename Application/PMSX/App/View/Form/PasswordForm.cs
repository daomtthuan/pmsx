using PMSX.App.Controller;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  public partial class PasswordForm : DevExpress.XtraEditors.XtraForm {
    public PasswordForm() {
      InitializeComponent();
    }

    private void PasswordForm_Load(object sender, EventArgs e) {
      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      if (oldInput.Text.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập mật khẩu cũ");
        return;
      }

      if (newInput.Text.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập mật khẩu mới");
        return;
      }

      if (reInput.Text.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập lại mật khẩu Mới");
        return;
      }

      if (newInput.Text != reInput.Text) {
        AlertUtility.Instance.ShowWarning("Mật khẩu nhập lại không trùng khớp");
        return;
      }

      int result = -1;
      OverlayUtility.Instance.StartProcess(this, () => {
        result = StaffController.Instance.Edit(newInput.Text);
      });
      if (result < 0) {
        Application.Exit();
        return;
      } else if (result == 0) {
        AlertUtility.Instance.ShowWarning("Mật khẩu không đúng");
        return;
      } else {
        DialogResult = DialogResult.OK;
        Close();
      }
    }
  }
}