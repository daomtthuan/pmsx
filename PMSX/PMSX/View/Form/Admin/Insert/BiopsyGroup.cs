using System;
using System.Text.RegularExpressions;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class BiopsyGroup : Pattern.Class.EscCloseForm {
    public BiopsyGroup() {
      InitializeComponent();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(codeInput.Text, Utils.RegexPattern.Instance.Code)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã số không hợp lệ.");
      } else if (!Controller.BiopsyGroup.Instance.Insert(codeInput.Text, commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã số đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}