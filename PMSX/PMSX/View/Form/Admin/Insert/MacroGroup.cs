using System;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class MacroGroup : Pattern.Class.EscCloseForm {
    public MacroGroup() {
      InitializeComponent();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0 || nameInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Controller.MacroGroup.Instance.Insert(codeInput.Text, nameInput.Text, commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã đã tồn tại.");
      } else {
        Controller.MacroGroup.Instance.Insert(codeInput.Text, nameInput.Text, commentInput.Text);
        Close();
      }
    }
  }
}