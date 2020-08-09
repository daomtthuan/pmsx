using DevExpress.Utils;
using DevExpress.XtraEditors;
using PMSX.App;
using PMSX.Pattern.Base;
using PMSX.Pattern.Interface;
using PMSX.Properties;
using PMSX.Utility.View.Form;
using System.Windows.Forms;

namespace PMSX.Pattern.Factory {
  internal class RibbonFormFactory<RibbonForm> : SingletonBase<RibbonFormFactory<RibbonForm>>, IFactory<RibbonForm> where RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm, new() {
    private RibbonFormFactory() { }

    public RibbonForm Create() {
      WindowsFormsSettings.LoadApplicationSettings();
      RibbonForm ribbonForm = new RibbonForm() {
        Icon = Resources.Icon,
        StartPosition = FormStartPosition.CenterScreen,
        DialogResult = DialogResult.None,
        FormBorderEffect = FormBorderEffect.Glow,
        AllowFormGlass = DefaultBoolean.True
      };
      DisplayUtility.Instance.Set(ribbonForm, false);
      Config.Instance.SetupTheme();

      return ribbonForm;
    }
  }
}
