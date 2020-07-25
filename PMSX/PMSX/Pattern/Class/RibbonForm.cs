namespace PMSX.Pattern.Class {
  class RibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm, Interface.IPattern, Interface.IView {
    public RibbonForm() {
      Icon = Properties.Resources.icon;
      AutoSize = true;
    }
  }
}
