using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class Biopsy : Pattern.View.EscCloseForm, Pattern.Interface.IView {
    private readonly string groupId;
    private readonly List<Model.Patient> patients;
    private readonly List<Model.Staff> grossDoctors;
    private readonly List<Model.Session> sessions;

    public Biopsy(string groupId, List<Model.Patient> patients, List<Model.Staff> grossDoctors, List<Model.Session> sessions) {
      InitializeComponent();

      Icon = Properties.Resources.icon;

      grossDatetimeSelect.Properties.MaxValue = DateTime.Now;
      grossDatetimeSelect.Properties.MaxValue = DateTime.Now;

      this.groupId = groupId;
      this.patients = patients;
      this.grossDoctors = grossDoctors;
      this.sessions = sessions;
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(sessionSelect, sessions, new[] { "Name", "TechnicianName", "DoctorName" }, "Id", "Name", null);
      Utils.View.Grid.Instance.Load(patientSelect, patients, new[] { "Name", "YearsOld", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Name");
      Utils.View.Grid.Instance.Load(grossDoctorSelect, grossDoctors, new[] { "Username", "Name", "State" }, "Id", "Name");
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

    private void InsertButton_Click(object sender, EventArgs e) {
      if (grossDatetimeSelect.Text.Length == 0 || collectDatetimeSelect.Text.Length == 0 || segmentInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (int.Parse(segmentInput.Text) == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nSố mảnh không hợp lệ.\nSố mảnh tối thiểu là 1.");
      } else if (!Controller.Biopsy.Instance.Insert(groupId, patientSelect.EditValue.ToString(), sessionSelect.EditValue.ToString(), grossDoctorSelect.EditValue.ToString(), int.Parse(segmentInput.Text), grossDatetimeSelect.DateTime, collectDatetimeSelect.DateTime, commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nThao tác thêm bị huỷ trong quá trình thực thi.");
      } else {
        Close();
      }
    }
  }
}