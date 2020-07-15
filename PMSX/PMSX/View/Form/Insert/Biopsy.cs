using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Biopsy : XtraForm {
    private readonly string groupId;
    private readonly List<Model.Patient> patients;
    private readonly List<Model.Staff> grossStaffs;
    private readonly List<Model.Session> sessions;

    public Biopsy(string groupId, List<Model.Patient> patients, List<Model.Staff> grossStaffs, List<Model.Session> sessions) {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;      

      this.groupId = groupId;
      this.patients = patients;
      this.grossStaffs = grossStaffs;
      this.sessions = sessions;
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Util.View.Grid.Instance.Load(patientSelect, patients, new[] { "Name", "YearsOld", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Name");
      Util.View.Grid.Instance.Load(sessionSelect, sessions, new[] { "Name", "TechnicianName", "DoctorName" }, "Id", "Name", -1);
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (patientSelect.Text.Length == 0 || nameInput.Text.Length == 0) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(patientSelect.Text, Util.RegexPattern.Instance.Username) || patientSelect.Text.Length < 4) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên đăng nhập không hợp lệ.\nChỉ gồm chữ, số và dấu gạch dưới, tối thiểu 4 ký tự.");
      } else if (!Regex.IsMatch(nameInput.Text, Util.RegexPattern.Instance.Name)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên nhân viên không hợp lệ.");
      } else if (!Controller.Staff.Instance.InsertWithDefaultPassword(patientSelect.Text, nameInput.Text, commentInput.Text)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên đăng nhập đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}