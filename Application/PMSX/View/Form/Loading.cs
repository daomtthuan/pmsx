using DevExpress.XtraSplashScreen;
using System;

namespace PMSX.View.Form {

  /// <summary>
  /// Loading
  /// </summary>
  public partial class Loading : SplashScreen {

    /// <summary>
    /// Create Loading
    /// </summary>
    public Loading() {
      InitializeComponent();

      string year = DateTime.Now.Year.ToString();
      copyrightLabel.Text = "Copyright © " + (year == "2020" ? "2020" : ("2020-" + year)) + " Daomtthuan";
    }

    /// <summary>
    /// Command Process
    /// </summary>
    /// <param name="cmd"></param>
    /// <param name="arg"></param>
    public override void ProcessCommand(Enum cmd, object arg) {
      base.ProcessCommand(cmd, arg);
    }

    /// <summary>
    /// Command
    /// </summary>
    public enum SplashScreenCommand {
    }
  }
}