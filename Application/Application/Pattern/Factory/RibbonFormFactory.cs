using DevExpress.XtraEditors;
using PMSXApplication.App;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Pattern.Interface;
using PMSXApplication.Properties;
using PMSXApplication.Utility.View;
using System.Windows.Forms;

namespace PMSXApplication.Pattern.Factory {
  internal class RibbonFormFactory<RibbonForm> : SingletonBase<RibbonFormFactory<RibbonForm>>, IFactory<RibbonForm> where RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm, new() {
    private RibbonFormFactory() { }

    public RibbonForm Create() {
      WindowsFormsSettings.LoadApplicationSettings();
      RibbonForm ribbonForm = new RibbonForm() {
        Icon = Resources.Icon,
        StartPosition = FormStartPosition.CenterScreen,
        DialogResult = DialogResult.None
      };
      DisplayUtility.Instance.Set(ribbonForm, false);
      Config.Instance.SetupTheme();

      return ribbonForm;
    }
  }
}
