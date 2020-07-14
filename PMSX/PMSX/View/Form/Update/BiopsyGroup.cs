using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class BiopsyGroup : XtraForm {
    private readonly Model.BiopsyGroup biopsyGroup;

    public BiopsyGroup(Model.BiopsyGroup biopsyGroup) {
      InitializeComponent();
      this.biopsyGroup = biopsyGroup;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      codeInput.Text = biopsyGroup.Code;
      stateRadio.EditValue = biopsyGroup.GetStateNumber();
      commentInput.Text = biopsyGroup.Comment;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0) {
        Util.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(codeInput.Text, Util.RegexPattern.Instance.Code)) {
        Util.View.MessageBox.Instance.Warning("Sửa không thành công.\nMã số không hợp lệ.");
      } else if (!Controller.BiopsyGroup.Instance.Update(biopsyGroup.Id, codeInput.Text, commentInput.Text, (int)stateRadio.EditValue) {
        Util.View.MessageBox.Instance.Warning("Sửa không thành công.\nMã số đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}