using DevExpress.XtraEditors;
using System;

namespace PMSX.Pattern.View {
  class EscCloseForm : XtraForm, Interface.IPattern {
    public EscCloseForm() {
      SimpleButton closeButton = new SimpleButton();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }
  }
}
