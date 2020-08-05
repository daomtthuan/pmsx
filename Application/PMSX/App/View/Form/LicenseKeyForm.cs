using DevExpress.XtraEditors;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  internal partial class LicenseKeyForm : XtraForm {
    public LicenseKeyForm() {
      InitializeComponent();
    }

    private void LicenseKeyForm_Load(object sender, System.EventArgs e) {
      DisplayUtility.Instance.Set(this, true);
    }

    private void ActiveButton_Click(object sender, System.EventArgs e) {
      OverlayUtility.Instance.StartProcess(this, () => {
        Config.Instance.LicenseKey = keyInput.Text;
        DialogResult = DialogResult.OK;
        Close();
      });
    }
  }
}