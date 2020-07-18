﻿using System;
using System.Collections.Generic;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class Session : Pattern.Class.EscCloseForm {
    private readonly List<Model.Staff> technicians;
    private readonly List<Model.Staff> doctors;

    public Session(List<Model.Staff> technicians, List<Model.Staff> doctors) {
      InitializeComponent();

      this.technicians = technicians;
      this.doctors = doctors;
    }

    private void Session_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(technicianSelect, technicians, new[] { "Username", "Name", "State" }, "Id", "Name");
      Utils.View.Grid.Instance.Load(doctorSelect, doctors, new[] { "Username", "Name", "State" }, "Id", "Name");

      nameSelect.EditValue = DateTime.Now;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (!Controller.Session.Instance.Insert(nameSelect.DateTime, technicianSelect.EditValue.ToString(), doctorSelect.EditValue.ToString(), commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên phiên làm việc đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}