using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.Utility;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
  public partial class AddStaffForm : XtraForm {
    public AddStaffForm() {
      InitializeComponent();
    }

    private void AddStaffForm_Load(object sender, EventArgs e) {
      passwordInput.Text = StringUtility.Instance.Random(10);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      string username = usernameInput.Text;
      string password = passwordInput.Text;
      string name = nameInput.Text;
      string comment = commentInput.Text;

      StaffController.Instance.Add(username, password, name, comment);

      DialogResult = DialogResult.OK;
      Close();
    }
  }
}