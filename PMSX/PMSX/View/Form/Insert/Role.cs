using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Role : XtraForm {
    public Role() {
      InitializeComponent();

      Icon = Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        XtraMessageBox.Show("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else if (!Regex.IsMatch(nameInput.Text, Utils.RegexPattern.name)) {
        XtraMessageBox.Show("Thêm không thành công.\nTên quyền không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else if (!Controller.Role.Instance.Insert(nameInput.Text, commentInput.Text)) {
        XtraMessageBox.Show("Thêm không thành công.\nTên quyền đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else {
        Close();
      }
    }
  }
}