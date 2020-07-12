using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class Role : XtraForm {
    private readonly Model.Role data;

    public Role(Model.Role data) {
      InitializeComponent();
      this.data = data;

      Icon = Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      nameInput.Text = data.Name;
      stateRadio.EditValue = data.State;
      commentInput.Text = data.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        XtraMessageBox.Show("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else if (!Regex.IsMatch(nameInput.Text, Utils.RegexPattern.name)) {
        XtraMessageBox.Show("Sửa không thành công.\nTên quyền không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else if (!Controller.Role.Instance.Update(data.Id, nameInput.Text, commentInput.Text, (int)stateRadio.EditValue)) {
        XtraMessageBox.Show("Sửa không thành công.\nTên quyền đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      } else {
        Close();
      }
    }

    private void Role_Load(object sender, EventArgs e) {

    }
  }
}