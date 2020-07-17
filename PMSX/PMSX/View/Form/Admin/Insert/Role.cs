﻿using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class Role : XtraForm, Pattern.Interface.IView {
    public Role() {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(nameInput.Text, Utils.RegexPattern.Instance.Name)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên quyền không hợp lệ.");
      } else if (!Controller.Role.Instance.Insert(nameInput.Text, commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên quyền đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}