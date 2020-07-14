﻿using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Macro : XtraForm {
    public Macro() {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } /*else if (!Regex.IsMatch(idInput.Text, Util.RegexPattern.Instance.Username) || idInput.Text.Length < 4) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên đăng nhập không hợp lệ.\nChỉ gồm chữ, số và dấu gạch dưới, tối thiểu 4 ký tự.");
      } else if (!Regex.IsMatch(codeInput.Text, Util.RegexPattern.Instance.Name)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên nhân viên không hợp lệ.");
      } else if (!Controller.Staff.Instance.InsertWithDefaultPassword(idInput.Text, codeInput.Text, commentInput.Text)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên đăng nhập đã tồn tại.");
      }*/ else {
        Close();
      }
    }
  }
}