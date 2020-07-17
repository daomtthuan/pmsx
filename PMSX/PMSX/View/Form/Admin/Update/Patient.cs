using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update {
  public partial class Patient : XtraForm {
    private readonly Model.Patient patient;

    public Patient(Model.Patient patient) {
      InitializeComponent();
      this.patient = patient;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      yearSelect.Properties.MaxValue = DateTime.Now;
      yearSelect.Properties.MinValue = DateTime.Now.AddYears(-150);
    }

    private void Patient_Load(object sender, EventArgs e) {
      nameInput.Text = patient.Name;
      yearsOldInput.EditValue = patient.YearsOld;
      addressInput.Text = patient.Address;
      stateRadio.EditValue = patient.GetStateNumber();
      commentInput.Text = patient.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0 || yearSelect.Text.Length == 0 || yearsOldInput.Text.Length == 0 || addressInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(nameInput.Text, Utils.RegexPattern.Instance.Name)) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nTên bệnh nhân không hợp lệ.");
      } else {
        Controller.Patient.Instance.Update(patient.Id, nameInput.Text, yearSelect.DateTime.Year, addressInput.Text, commentInput.Text, (int)stateRadio.EditValue);
        Close();
      }
    }

    private void YearSelect_EditValueChanged(object sender, EventArgs e) {
      yearsOldInput.EditValue = DateTime.Now.Year - yearSelect.DateTime.Year;
    }

    private void YearsOldInput_EditValueChanged(object sender, EventArgs e) {
      yearSelect.DateTime = new DateTime(DateTime.Now.Year - int.Parse(yearsOldInput.EditValue.ToString()), 1, 1);
    }
  }
}