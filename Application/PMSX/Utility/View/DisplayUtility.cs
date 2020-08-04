using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using PMSX.Pattern.Base;

namespace PMSX.Utility.View.Form {
  internal class DisplayUtility : SingletonBase<DisplayUtility> {
    private DisplayUtility() { }

    public void Set(RibbonForm ribbonForm, bool value) {
      ribbonForm.Visible = value;
      ribbonForm.ShowInTaskbar = value;
      ribbonForm.Opacity = value ? 1 : 0;
      ribbonForm.FormBorderEffect = value ? FormBorderEffect.Default : FormBorderEffect.None;
    }

    public void Set(XtraForm form, bool value) {
      form.Visible = value;
      form.Opacity = value ? 1 : 0;
      form.FormBorderEffect = value ? FormBorderEffect.Default : FormBorderEffect.None;
    }
  }
}
