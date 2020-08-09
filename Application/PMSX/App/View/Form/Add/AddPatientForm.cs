using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
  public partial class AddPatientForm : DevExpress.XtraEditors.XtraForm {
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
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Name, name)) {
        AlertUtility.Instance.ShowWarning("Tên không hợp lệ");
        return;
      }

      if (year == null) {
        AlertUtility.Instance.ShowWarning("Vui lòng chọn năm sinh (tuổi)");
        return;
      }

      if (address.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập địa chỉ");
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