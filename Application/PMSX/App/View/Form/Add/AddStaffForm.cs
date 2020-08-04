using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.Utility;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
  public partial class AddStaffForm : XtraForm {
    public AddStaffForm() {
      InitializeComponent();
    }

    private void AddStaffForm_Load(object sender, EventArgs e) {
      passwordInput.Text = StringUtility.Instance.Random(10);

      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      OverlayUtility.Instance.StartProcess(this, () => {
        string username = usernameInput.Text;
        string password = passwordInput.Text;
        string name = nameInput.Text;
        string comment = commentInput.Text;

        if (StaffController.Instance.Add(username, password, name, comment) < 0) {
          Application.Exit();
          return;
        };

        DialogResult = DialogResult.OK;
        Close();
      });
    }
  }
}