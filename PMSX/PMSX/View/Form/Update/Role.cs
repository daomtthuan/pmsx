using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class Role : XtraForm {
    private readonly Model.Role roles;

    public Role(Model.Role roles) {
      InitializeComponent();
      this.roles = roles;

      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      nameInput.Text = roles.Name;
      stateRadio.EditValue = roles.State;
      commentInput.Text = roles.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        Util.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(nameInput.Text, Util.RegexPattern.name)) {
        Util.MessageBox.Instance.Warning("Sửa không thành công.\nTên quyền không hợp lệ.");
      } else if (!Controller.Role.Instance.Update(roles.Id, nameInput.Text, commentInput.Text, (int)stateRadio.EditValue)) {
        Util.MessageBox.Instance.Warning("Sửa không thành công.\nTên quyền đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}