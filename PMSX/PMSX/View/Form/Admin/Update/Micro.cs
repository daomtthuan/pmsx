using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update {
  internal partial class Micro : XtraForm, Pattern.Interface.IView {
    private readonly Model.Micro micros;
    public Micro(Model.Micro micros) {
      InitializeComponent();
      this.micros = micros;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void Micro_Load(object sender, EventArgs e) {
      descriptionInput.Text = micros.Description;
      stateRadio.EditValue = micros.GetStateNumber();
      commentInput.Text = micros.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (descriptionInput.Text.Length == 0 || codeInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if ((codeInput.Text == micros.Code)) {
        Controller.Micro.Instance.Update(micros.MicroGroupId, micros.Id, codeInput.Text, descriptionInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      } else if ((codeInput.Text != micros.Code) && (Controller.Micro.Instance.SelectByCodeAndId(codeInput.Text,micros.MicroGroupId).Count == 0)) {
        Controller.Micro.Instance.Update(micros.MicroGroupId, micros.Id, codeInput.Text, descriptionInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      } else {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nMã nhóm đã tồn tại.");
      }
    }
  }
}