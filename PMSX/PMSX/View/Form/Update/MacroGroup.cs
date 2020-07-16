using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class MacroGroup : XtraForm {
    private readonly Model.MacroGroup macroGroups;

    public MacroGroup(Model.MacroGroup macroGroups) {
      InitializeComponent();
      this.macroGroups = macroGroups;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      nameInput.Text = macroGroups.Name;
      stateRadio.EditValue = macroGroups.GetStateNumber();
      commentInput.Text = macroGroups.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } /*else if (!Regex.IsMatch(nameInput.Text, Util.RegexPattern.Instance.Name)) {
        Util.View.MessageBox.Instance.Warning("Sửa không thành công.\nTên nhân viên không hợp lệ.");
      }*/ else {
          Controller.MacroGroup.Instance.Update(macroGroups.Code, nameInput.Text, commentInput.Text, (int)stateRadio.EditValue);
          Close();
      }
    }
  }
}