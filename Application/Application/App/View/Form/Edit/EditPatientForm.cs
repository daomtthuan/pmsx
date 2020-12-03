using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.Utility;
using PMSXApplication.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Edit {
  internal partial class EditPatientForm : XtraForm {
    public EditPatientForm() {
      InitializeComponent();
    }

    private void EditPatientForm_Load(object sender, EventArgs e) {
      int yearNow = DateTime.Now.Year;
      for (int year = yearNow; year >= yearNow - 150; year--) {
        yearSelect.Properties.Items.Add(year);
        yearsOldSelect.Properties.Items.Add(yearNow - year);
      }

      Patient patient = (Patient)Tag;
      nameInput.Text = patient.Name;
      yearsOldSelect.EditValue = patient.YearsOld;
      addressInput.Text = patient.Address;
      stateRadio.EditValue = patient.GetStateNumber();
      commentInput.Text = patient.Comment;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      if (AlertUtility.Instance.ShowConfirm("Chỉnh sửa thông tin bệnh nhân này?") == DialogResult.No) {
        return;
      }

      string name = nameInput.Text;
      object year = yearSelect.SelectedItem;
      string address = addressInput.Text;
      int state = (int)stateRadio.EditValue;
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
        if (PatientController.Instance.Edit(((Patient)Tag).Id, name, (int)year, address, state, comment) < 0) {
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