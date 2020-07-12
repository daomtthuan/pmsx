using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Staff : XtraForm {
    public Staff() {
      InitializeComponent();

      Icon = Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (usernameInput.Text.Length == 0 || nameInput.Text.Length == 0) {
        XtraMessageBox.Show("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else if (!Regex.IsMatch(usernameInput.Text, Utils.RegexPattern.username) || usernameInput.Text.Length < 4) {
        XtraMessageBox.Show("Thêm không thành công.\nTên đăng nhập không hợp lệ.\nChỉ gồm chữ, số và dấu gạch dưới, tối thiểu 4 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else if (!Regex.IsMatch(nameInput.Text, Utils.RegexPattern.name)) {
        XtraMessageBox.Show("Thêm không thành công.\nTên nhân viên không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else if (!Controller.Staff.Instance.InsertWithDefaultPassword(usernameInput.Text, nameInput.Text, commentInput.Text)) {
        XtraMessageBox.Show("Thêm không thành công.\nTên đăng nhập đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else {
        Close();
      }
    }
  }
}