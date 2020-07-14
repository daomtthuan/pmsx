using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class BiopsyGroup : XtraForm {
    public BiopsyGroup() {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(codeInput.Text, Util.RegexPattern.Instance.Code)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã số không hợp lệ.");
      } else if (!Controller.BiopsyGroup.Instance.Insert(codeInput.Text, commentInput.Text)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã số đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}