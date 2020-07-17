using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update {
  internal partial class MacroGroup : XtraForm, Pattern.Interface.IView {
    private readonly Model.MacroGroup macroGroups;

    public MacroGroup(Model.MacroGroup macroGroups) {
      InitializeComponent();
      this.macroGroups = macroGroups;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void MacroGroup_Load(object sender, EventArgs e) {
      nameInput.Text = macroGroups.Name;
      stateRadio.EditValue = macroGroups.GetStateNumber();
      commentInput.Text = macroGroups.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else {
        Controller.MacroGroup.Instance.Update(macroGroups.Code, nameInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      }
    }
  }
}