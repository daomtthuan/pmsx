using DevExpress.XtraEditors;
using PMSX.Pattern.Base;
using System.Windows.Forms;

namespace PMSX.Pattern.Factory {
  internal class RibbonFormFactory<RibbonForm> : SingletonBase<RibbonFormFactory<RibbonForm>>, IFactoryBase<RibbonForm> where RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm, new() {
    private RibbonFormFactory() { }

    public RibbonForm Create() {
      WindowsFormsSettings.LoadApplicationSettings();
      return new RibbonForm() {
        Icon = Properties.Resources.Icon,
        StartPosition = FormStartPosition.CenterScreen,
        DialogResult = DialogResult.None
      };
    }
  }
}
