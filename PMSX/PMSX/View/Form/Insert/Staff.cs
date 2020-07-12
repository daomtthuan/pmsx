using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Staff : XtraForm {
    public Staff() {
      InitializeComponent();

      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (usernameInput.Text.Length == 0 || nameInput.Text.Length == 0) {
        Util.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(usernameInput.Text, Util.RegexPattern.username) || usernameInput.Text.Length < 4) {
        Util.MessageBox.Instance.Warning("Thêm không thành công.\nTên đăng nhập không hợp lệ.\nChỉ gồm chữ, số và dấu gạch dưới, tối thiểu 4 ký tự.");
      } else if (!Regex.IsMatch(nameInput.Text, Util.RegexPattern.name)) {
        Util.MessageBox.Instance.Warning("Thêm không thành công.\nTên nhân viên không hợp lệ.");
      } else if (!Controller.Staff.Instance.InsertWithDefaultPassword(usernameInput.Text, nameInput.Text, commentInput.Text)) {
        Util.MessageBox.Instance.Warning("Thêm không thành công.\nTên đăng nhập đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}