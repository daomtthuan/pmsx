using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.Utility;
using PMSXApplication.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Edit {
  internal partial class EditStaffForm : XtraForm {
    public EditStaffForm() {
      InitializeComponent();
    }

    private void EditStaffForm_Load(object sender, EventArgs e) {
      Staff staff = (Staff)Tag;
      usernameInput.Text = staff.Username;
      nameInput.Text = staff.Name;
      stateRadio.EditValue = staff.GetStateNumber();
      commentInput.Text = staff.Comment;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      if (AlertUtility.Instance.ShowConfirm("Chỉnh sửa nhân viên này?") == DialogResult.No) {
        return;
      }

      string password = passwordInput.Text;
      string name = nameInput.Text;
      int state = (int)stateRadio.EditValue;
      string comment = commentInput.Text;

      if (name.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên nhân viên");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Name, name)) {
        AlertUtility.Instance.ShowWarning("Tên nhân viên không hợp lệ");
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (StaffController.Instance.Edit(((Staff)Tag).Id, password, name, state, comment) < 0) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else {
          DialogResult = DialogResult.OK;
          Close();
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