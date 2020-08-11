using DevExpress.XtraEditors;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  internal partial class LicenseKeyForm : XtraForm {
    public LicenseKeyForm() {
      InitializeComponent();
    }

    private void LicenseKeyForm_Load(object sender, EventArgs e) {
      DisplayUtility.Instance.Set(this, true);
    }

    private void ActiveButton_Click(object sender, EventArgs e) {
      string key = keyInput.Text;
      if (key.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui nhập khoá kích hoạt bản quyền sản phẩm");
        return;
      }

      Config.LicenseState licenseState = Config.LicenseState.Error;
      OverlayUtility.Instance.StartProcess(this, () => {
        licenseState = Config.Instance.CheckLicense(key);
      });
      switch (licenseState) {
        case Config.LicenseState.Accept:
          DialogResult = DialogResult.OK;
          Close();
          break;
        case Config.LicenseState.Outdated:
          AlertUtility.Instance.ShowWarning("Khoá kích hoạt bản quyền sản phẩm đã hết hạn");
          break;
        case Config.LicenseState.Invalid:
          AlertUtility.Instance.ShowWarning("Khoá kích hoạt bản quyền sản phẩm không hợp lệ");
          break;
        case Config.LicenseState.Ignore:
          AlertUtility.Instance.ShowWarning("Khoá kích hoạt bản quyền sản phẩm này không được chấp nhật");
          break;
        case Config.LicenseState.Error:
          Application.Exit();
          break;
      }
    }
  }
}