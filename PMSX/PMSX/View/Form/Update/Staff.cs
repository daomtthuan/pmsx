using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class Staff : XtraForm {
    private readonly Model.Staff staffs;

    public Staff(Model.Staff staffs) {
      InitializeComponent();
      this.staffs = staffs;

      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      nameInput.Text = staffs.Name;
      stateRadio.EditValue = staffs.State;
      commentInput.Text = staffs.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        Util.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(nameInput.Text, Util.RegexPattern.name)) {
        Util.MessageBox.Instance.Warning("Sửa không thành công.\nTên nhân viên không hợp lệ.");
      } else {
        Controller.Staff.Instance.Update(staffs.Id, nameInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      }
    }
  }
}