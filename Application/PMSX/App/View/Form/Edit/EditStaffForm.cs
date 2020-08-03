using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMSX.App.Model;
using PMSX.App.Controller;

namespace PMSX.App.View.Form.Edit {
  public partial class EditStaffForm : XtraForm {
    public EditStaffForm() {
      InitializeComponent();
    }

    private void EditStaffForm_Load(object sender, EventArgs e) {
      var staff = (Staff)Tag;
      usernameInput.Text = staff.Username;
      nameInput.Text = staff.Name;
      stateRadio.EditValue = staff.GetStateNumber();
      commentInput.Text = staff.Comment;
    }

    private void EditButton_Click(object sender, EventArgs e) {
      string password = passwordInput.Text;
      string name = nameInput.Text;
      int state = (int)stateRadio.EditValue;
      string comment = commentInput.Text;

      if (password == "") {
        StaffController.Instance.Edit(((Staff)Tag).Id, name, state, comment);
      } else {
        StaffController.Instance.Edit(((Staff)Tag).Id, password, name, state, comment);
      }

      DialogResult = DialogResult.OK;
      Close();
    }

    private void ResetPasswordButton_Click(object sender, EventArgs e) {

    }
  }
}