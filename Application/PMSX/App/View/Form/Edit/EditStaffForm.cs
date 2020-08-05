﻿using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Edit {
  internal partial class EditStaffForm : XtraForm {
    public EditStaffForm() {
      InitializeComponent();
    }

    private void EditStaffForm_Load(object sender, EventArgs e) {
      Staff staff = (Staff)Tag;
      usernameInput.Text = staff.Username;
      nameInput.Text = staff.Name;
      stateRadio.EditValue = staff.GetStateNumber();
      commentInput.Text = staff.Comment;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      if (AlertUtility.Instance.ShowConfirm("Chỉnh sửa nhân viên này?") == DialogResult.No) {
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        string password = passwordInput.Text;
        string name = nameInput.Text;
        int state = (int)stateRadio.EditValue;
        string comment = commentInput.Text;

        if (StaffController.Instance.Edit(((Staff)Tag).Id, password, name, state, comment) < 0) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else {
          DialogResult = DialogResult.OK;
          Close();
        }
      });
    }

    private void ResetPasswordButton_Click(object sender, EventArgs e) {
      OverlayUtility.Instance.StartProcess(this, () => {
        passwordInput.Text = StringUtility.Instance.Random(10);
      });
    }
  }
}