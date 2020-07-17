using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update {
  internal partial class MicroGroup : XtraForm, Pattern.Interface.IView {
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
      if (nameInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } /*else if (!Regex.IsMatch(nameInput.Text, Util.RegexPattern.Instance.Name)) {
        Util.View.MessageBox.Instance.Warning("Sửa không thành công.\nTên nhân viên không hợp lệ.");
      }*/ else {
        Controller.MicroGroup.Instance.Update(microGroups.Code, nameInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      }
    }
  }
}