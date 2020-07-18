﻿using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class Macro : Pattern.View.EscCloseForm, Pattern.Interface.IView {
    private readonly string groupId;
    public Macro(string groupId) {
      InitializeComponent();

      Icon = Properties.Resources.icon;

      this.groupId = groupId;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0 || descriptionInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Controller.Macro.Instance.Insert(codeInput.Text, descriptionInput.Text, groupId, commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã đã tồn tại.");
      } else {
        Controller.Macro.Instance.Insert(codeInput.Text, descriptionInput.Text, groupId, commentInput.Text);
        Close();
      }
    }
  }
}