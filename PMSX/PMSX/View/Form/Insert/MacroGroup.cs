using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class MacroGroup : XtraForm {
    public MacroGroup() {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0 || nameInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Controller.MacroGroup.Instance.Insert(codeInput.Text, nameInput.Text, commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên mã đã tồn tại.");
      } else {
        Controller.MacroGroup.Instance.Insert(codeInput.Text, nameInput.Text, commentInput.Text);
        Close();
      }
    }
  }
}