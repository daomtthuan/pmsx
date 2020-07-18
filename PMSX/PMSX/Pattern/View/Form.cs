using DevExpress.XtraEditors;

namespace PMSX.Pattern.View {
  class Form : XtraForm, Interface.IPattern, Interface.IView {
    public Form() {
      Icon = Properties.Resources.icon;
    }
  }
}
