using System;
using System.Text.RegularExpressions;

namespace PMSX.View.Form.Admin.Insert {
  internal partial class Patient : Pattern.Class.EscCloseForm {
    public Patient() {
      InitializeComponent();

      yearSelect.Properties.MaxValue = DateTime.Now;
      yearSelect.Properties.MinValue = DateTime.Now.AddYears(-150);
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (nameInput.Text.Length == 0 || yearSelect.Text.Length == 0 || yearsOldInput.Text.Length == 0 || addressInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(nameInput.Text, Utils.RegexPattern.Instance.Name)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên bệnh nhân không hợp lệ.");
      } else {
        Controller.Patient.Instance.Insert(nameInput.Text, yearSelect.DateTime.Year, addressInput.Text, commentInput.Text);
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