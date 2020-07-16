using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class Macro : XtraForm {
    private readonly Model.Macro macros;

    public Macro(Model.Macro macros) {
      InitializeComponent();
      this.macros = macros;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      descriptionInput.Text = macros.Description;
      stateRadio.EditValue = macros.GetStateNumber();
      commentInput.Text = macros.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (descriptionInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } /*else if (!Regex.IsMatch(nameInput.Text, Util.RegexPattern.Instance.Name)) {
        Util.View.MessageBox.Instance.Warning("Sửa không thành công.\nTên nhân viên không hợp lệ.");
      }*/ else {
        Controller.Macro.Instance.Update(macros.Code, descriptionInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      }
    }
  }
}