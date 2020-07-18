using System;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class MicroGroup : Pattern.Class.EscCloseForm {
    public MicroGroup() {
      InitializeComponent();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0 || nameInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Controller.MicroGroup.Instance.Insert(codeInput.Text, nameInput.Text, commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã đã tồn tại.");
      } else {
        Controller.MicroGroup.Instance.Insert(codeInput.Text, nameInput.Text, commentInput.Text);
        Close();
      }
    }
  }
}