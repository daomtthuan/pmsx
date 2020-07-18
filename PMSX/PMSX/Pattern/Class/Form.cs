using DevExpress.XtraEditors;

namespace PMSX.Pattern.Class {
  internal class Form : XtraForm, Interface.IPattern, Interface.IView {
    public Form() {
      Icon = Properties.Resources.icon;
      AutoSize = true;
    }
  }
}
