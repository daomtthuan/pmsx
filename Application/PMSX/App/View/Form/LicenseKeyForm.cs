using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  public partial class LicenseKeyForm : XtraForm {
    public LicenseKeyForm() {
      InitializeComponent();
    }

    private void ActiveButton_Click(object sender, System.EventArgs e) {
      Config.Instance.AddLicenseKey(keyInput.Text);
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}