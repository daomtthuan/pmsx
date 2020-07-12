using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Role : XtraForm {
    public Role() {
      InitializeComponent();

      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        Util.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(nameInput.Text, Util.RegexPattern.name)) {
        Util.MessageBox.Instance.Warning("Thêm không thành công.\nTên quyền không hợp lệ.");
      } else if (!Controller.Role.Instance.Insert(nameInput.Text, commentInput.Text)) {
        Util.MessageBox.Instance.Warning("Thêm không thành công.\nTên quyền đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}