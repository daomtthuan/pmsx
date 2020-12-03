using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.Utility;
using PMSXApplication.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Add {
  internal partial class AddPatientForm : XtraForm {
    public AddPatientForm() {
      InitializeComponent();
    }

    private void AddPatientForm_Load(object sender, EventArgs e) {
      int yearNow = DateTime.Now.Year;
      for (int year = yearNow; year >= yearNow - 150; year--) {
        yearSelect.Properties.Items.Add(year);
        yearsOldSelect.Properties.Items.Add(yearNow - year);
      }

      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      Group group = (Group)Tag;
      string name = nameInput.Text;
      object year = yearSelect.SelectedItem;
      string address = addressInput.Text;
      string comment = commentInput.Text;

      if (name.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên bệnh nhân");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Name, name)) {
        AlertUtility.Instance.ShowWarning("Tên bệnh nhân không hợp lệ");
        return;
      }

      if (year == null) {
        AlertUtility.Instance.ShowWarning("Vui lòng chọn năm sinh (tuổi) bệnh nhân");
        return;
      }

      if (address.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập địa chỉ bệnh nhân");
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (PatientController.Instance.Add(group, name, (int)year, address, comment) < 0) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else {
          DialogResult = DialogResult.OK;
          Close();
        }
      });
    }

    private void YearsOldSelect_SelectedIndexChanged(object sender, EventArgs e) {
      yearSelect.SelectedIndex = yearsOldSelect.SelectedIndex;
    }

    private void YearSelect_SelectedIndexChanged(object sender, EventArgs e) {
      yearsOldSelect.SelectedIndex = yearSelect.SelectedIndex;
    }
  }
}