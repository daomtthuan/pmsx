using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update {
  internal partial class Biopsy : XtraForm, Pattern.Interface.IView {
    private readonly Model.Biopsy biopsy;
    private readonly List<Model.Patient> patients;
    private readonly List<Model.Staff> grossDoctors;
    private readonly List<Model.Session> sessions;

    public Biopsy(Model.Biopsy biopsy, List<Model.Patient> patients, List<Model.Staff> grossDoctors, List<Model.Session> sessions) {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      grossDatetimeSelect.Properties.MaxValue = DateTime.Now;
      grossDatetimeSelect.Properties.MaxValue = DateTime.Now;

      this.biopsy = biopsy;
      this.patients = patients;
      this.grossDoctors = grossDoctors;
      this.sessions = sessions;
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(sessionSelect, sessions, new[] { "Name", "TechnicianName", "DoctorName" }, "Id", "Name", biopsy.SessionId);
      Utils.View.Grid.Instance.Load(patientSelect, patients, new[] { "Name", "YearsOld", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Name", biopsy.PatientId);
      Utils.View.Grid.Instance.Load(grossDoctorSelect, grossDoctors, new[] { "Username", "Name", "State" }, "Id", "Name", biopsy.GrossDoctorId);

      segmentInput.EditValue = biopsy.Segment;
      grossDatetimeSelect.DateTime = DateTime.Parse(biopsy.GrossDatetime);
      collectDatetimeSelect.DateTime = DateTime.Parse(biopsy.CollectDatetime);
      stateRadio.EditValue = biopsy.GetStateNumber();
      commentInput.Text = biopsy.Comment;
    }

    private void SessionSelect_EditValueChanged(object sender, EventArgs e) {
      grossDoctorSelect.EditValue = ((Model.Session)sessionSelect.GetSelectedDataRow()).DoctorId;
    }

    private void PatientSelect_EditValueChanged(object sender, EventArgs e) {
      grossDatetimeSelect.Properties.MinValue = DateTime.Now.AddYears(-((Model.Patient)patientSelect.GetSelectedDataRow()).YearsOld);
    }

    private void GrossDatetimeSelect_EditValueChanged(object sender, EventArgs e) {
      collectDatetimeSelect.Properties.MinValue = grossDatetimeSelect.DateTime;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (grossDatetimeSelect.Text.Length == 0 || collectDatetimeSelect.Text.Length == 0 || segmentInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (int.Parse(segmentInput.Text) == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nSố mảnh không hợp lệ.\nSố mảnh tối thiểu là 1.");
      } else {
        Controller.Biopsy.Instance.Update(
          biopsy.Id,
          patientSelect.EditValue.ToString(),
          sessionSelect.EditValue.ToString(),
          grossDoctorSelect.EditValue.ToString(),
          int.Parse(segmentInput.Text),
          grossDatetimeSelect.DateTime,
          collectDatetimeSelect.DateTime,
          commentInput.Text,
          (int)stateRadio.EditValue);
        Close();
      }
    }
  }
}