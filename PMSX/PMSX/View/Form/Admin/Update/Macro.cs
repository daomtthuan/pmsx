using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update {
  internal partial class Macro : XtraForm, Pattern.Interface.IView {
    private readonly Model.Macro macros;

    public Macro(Model.Macro macros) {
      InitializeComponent();
      this.macros = macros;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void Macro_Load(object sender, EventArgs e) {
      descriptionInput.Text = macros.Description;
      stateRadio.EditValue = macros.GetStateNumber();
      commentInput.Text = macros.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (descriptionInput.Text.Length == 0 || codeInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (codeInput.Text == macros.Code) {
        Controller.Macro.Instance.Update(macros.Id, codeInput.Text, descriptionInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      } else if ((codeInput.Text != macros.Code) && (Controller.Macro.Instance.SelectByCodeAndId(codeInput.Text,macros.MacroGroupId).Count == 0)) {
        Controller.Macro.Instance.Update(macros.Id, codeInput.Text, descriptionInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      } else {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nMã nhóm đã tồn tại.");
      }
    }
  }
}