using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update {
  public partial class MicroGroup : XtraForm {
    private readonly Model.MicroGroup microGroups;

    public MicroGroup(Model.MicroGroup microGroups) {
      InitializeComponent();
      this.microGroups = microGroups;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void MicroGroup_Load(object sender, EventArgs e) {
      nameInput.Text = microGroups.Name;
      stateRadio.EditValue = microGroups.GetStateNumber();
      commentInput.Text = microGroups.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0 || codeInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (codeInput.Text == microGroups.Code) {
        Controller.MicroGroup.Instance.Update(microGroups.Id, codeInput.Text, nameInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      } else if ((codeInput.Text != microGroups.Code) && (Controller.MicroGroup.Instance.SelectByCode(codeInput.Text).Count == 0)) {
        Controller.MicroGroup.Instance.Update(microGroups.Id, codeInput.Text, nameInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      } else {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nMã nhóm đã tồn tại.");
      }
    }
  }
}