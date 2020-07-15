﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Biopsy : XtraForm {
    private readonly string groupId;
    private readonly List<Model.Patient> patients;
    private readonly List<Model.Staff> grossDoctors;
    private readonly List<Model.Session> sessions;

    public Biopsy(string groupId, List<Model.Patient> patients, List<Model.Staff> grossDoctors, List<Model.Session> sessions) {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      grossDatetimeSelect.Properties.MaxValue = DateTime.Now;
      grossDatetimeSelect.Properties.MaxValue = DateTime.Now;

      this.groupId = groupId;
      this.patients = patients;
      this.grossDoctors = grossDoctors;
      this.sessions = sessions;
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Util.View.Grid.Instance.Load(patientSelect, patients, new[] { "Name", "YearsOld", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Name");
      Util.View.Grid.Instance.Load(grossDoctorSelect, grossDoctors, new[] { "Username", "Name", "State" }, "Id", "Name");
      Util.View.Grid.Instance.Load(sessionSelect, sessions, new[] { "Name", "TechnicianName", "DoctorName" }, "Id", "Name", -1);
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (grossDatetimeSelect.Text.Length == 0 || collectDatetimeSelect.Text.Length == 0 || segmentInput.Text.Length == 0) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (int.Parse(segmentInput.Text) == 0) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nSố mảnh không hợp lệ.\nSố mảnh tối thiểu là 1.");
      } else if (!Controller.Biopsy.Instance.Insert(groupId, patientSelect.EditValue.ToString(), sessionSelect.EditValue.ToString(), grossDoctorSelect.EditValue.ToString(), int.Parse(segmentInput.Text), grossDatetimeSelect.DateTime, collectDatetimeSelect.DateTime, commentInput.Text)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nThao tác thêm bị huỷ trong quá trình thực thi.");
      } else {
        Close();
      }
    }

    private void PatientSelect_EditValueChanged(object sender, EventArgs e) {
      grossDatetimeSelect.Properties.MinValue = ((Model.Patient)patientSelect.GetSelectedDataRow()).GetBirthday();
    }

    private void GrossDatetimeSelect_EditValueChanged(object sender, EventArgs e) {
      collectDatetimeSelect.Properties.MinValue = grossDatetimeSelect.DateTime;
    }

    private void sessionSelect_EditValueChanged(object sender, EventArgs e) {
      grossDoctorSelect.EditValue = ((Model.Session)sessionSelect.GetSelectedDataRow()).DoctorId;
    }
  }
}