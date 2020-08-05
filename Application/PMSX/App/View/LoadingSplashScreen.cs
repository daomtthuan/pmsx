using System;
using System.Reflection;

namespace PMSX.App.View {
  internal partial class LoadingSplashScreen : DevExpress.XtraSplashScreen.SplashScreen {
    internal enum SplashScreenCommand {
      UpdateStatus
    }

    public LoadingSplashScreen() {
      InitializeComponent();
    }

    private void LoadingSplashScreen_Load(object sender, EventArgs e) {
      Config.Instance.SetupTheme();

      string year = DateTime.Now.Year == 2020 ? "2020" : $"2020 - {DateTime.Now.Year}";
      copyrightLabel.Text = $"Bản quyền © {year} Daomtthuan";
      versionLabel.Text = $"Phiên bản {Assembly.GetExecutingAssembly().GetName().Version}";
    }

    public override void ProcessCommand(Enum cmd, object arg) {
      base.ProcessCommand(cmd, arg);
      switch ((SplashScreenCommand)cmd) {
        case SplashScreenCommand.UpdateStatus:
          statusLabel.Text = arg.ToString();
          break;
      }
    }
  }
}