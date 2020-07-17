using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form {
  public partial class Loading : SplashScreen {
    public Loading() {
      InitializeComponent();

      string year = DateTime.Now.Year.ToString();
      copyrightLabel.Text = "Copyright © " + (year == "2020" ? "2020" : ("2020-" + year)) + " Daomtthuan";

      brandPanel.Controls.Add(new UserControl.Brand() {
        Dock = DockStyle.Fill
      });
    }

    public override void ProcessCommand(Enum cmd, object arg) {
      base.ProcessCommand(cmd, arg);
    }

    public enum SplashScreenCommand { }
  }
}