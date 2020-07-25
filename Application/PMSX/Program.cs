using DevExpress.UserSkins;
using System;
using System.Windows.Forms;

namespace PMSX {

  /// <summary>
  /// Program
  /// </summary>
  internal static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      BonusSkins.Register();
      Application.Run(Util.Pattern.Factory.RibbonForm<View.Form.Main>.Create());
    }
  }
}
