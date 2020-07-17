using DevExpress.XtraSplashScreen;
using System;

namespace PMSX.View.Form {
  internal partial class Loading : SplashScreen {
    public Loading() {
      InitializeComponent();

      string year = DateTime.Now.Year.ToString();
      copyrightLabel.Text = "Copyright © " + (year == "2020" ? "2020" : ("2020-" + year)) + " Daomtthuan";
    }

    public override void ProcessCommand(Enum cmd, object arg) {
      base.ProcessCommand(cmd, arg);
    }

    public enum SplashScreenCommand { }
  }
}