using DevExpress.XtraEditors;
using PMSX.Pattern.Base;
using PMSX.Utility.View.Form;
using System.Windows.Forms;

namespace PMSX.Pattern.Factory {
  internal class RibbonFormFactory<RibbonForm> : SingletonBase<RibbonFormFactory<RibbonForm>>, IFactoryBase<RibbonForm> where RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm, new() {
    private RibbonFormFactory() { }

    public RibbonForm Create() {
      WindowsFormsSettings.LoadApplicationSettings();
      RibbonForm ribbonForm = new RibbonForm() {
        Icon = Properties.Resources.Icon,
        StartPosition = FormStartPosition.CenterScreen,
        DialogResult = DialogResult.None
      };
      DisplayUtility.Instance.Set(ribbonForm, false);

      return ribbonForm;
    }
  }
}
