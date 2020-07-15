using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Macro : XtraForm {
    private readonly string groupId;
    public Macro(string groupId) {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      this.groupId = groupId;
    }
    /*   private void Macro_Load(object sender, System.EventArgs e) {
        //  Util.View.Grid.Instance.Load(, macros, new[] { "Code", "Name", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Name");
        }*/

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0 || nameInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } /*else if (!Regex.IsMatch(idInput.Text, Util.RegexPattern.Instance.Username) || idInput.Text.Length < 4) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên đăng nhập không hợp lệ.\nChỉ gồm chữ, số và dấu gạch dưới, tối thiểu 4 ký tự.");
      } else if (!Regex.IsMatch(codeInput.Text, Util.RegexPattern.Instance.Name)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên nhân viên không hợp lệ.");
      } else if (!Controller.Staff.Instance.InsertWithDefaultPassword(idInput.Text, codeInput.Text, commentInput.Text)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên đăng nhập đã tồn tại.");
      }*/ else {
        Controller.Macro.Instance.Insert(codeInput.Text, nameInput.Text, groupId, commentInput.Text);
        Close();
      }
    }
  }
}