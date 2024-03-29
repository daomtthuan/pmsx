﻿using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.Utility.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Add {
  internal partial class AddPermissionForm : XtraForm {
    public AddPermissionForm() {
      InitializeComponent();
    }

    private void AddPermissionForm_Load(object sender, EventArgs e) {
      List<Staff> staffs = StaffController.Instance.GetByNoRoleName(Tag.ToString());
      if (staffs == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(staffSelect, staffs, new[] { "Id", "Username", "Name" }, "Id", "Name");
      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      object staff = GridUtility.Instance.GetSelected(staffSelect);
      if (staff == null) {
        AlertUtility.Instance.ShowWarning("Vui lòng chọn nhân viên cần phân quyền");
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        long staffId = ((Staff)staff).Id;
        int roleId = Array.IndexOf(Authentication.Instance.Roles, Tag.ToString()) + 1;
        string comment = commentInput.Text;

        if (PermissionController.Instance.Add(staffId, roleId, comment) < 0) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else {
          DialogResult = DialogResult.OK;
          Close();
        }
      });
    }
  }
}