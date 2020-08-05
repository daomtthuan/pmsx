using DevExpress.UserSkins;
using PMSX.App;
using PMSX.App.View.Form;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSX {
  public static class Program {
    [STAThread]

    private static async Task Main() {
      await LoadingUtility.Instance.Show("Chuẩn bị thiết lập...");

      await LoadingUtility.Instance.UpdateStatus("Thiết lập giao diện...");
      Config.Instance.SetupTheme();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      BonusSkins.Register();

      await LoadingUtility.Instance.UpdateStatus("Thiết lập ngôn ngữ...");
      CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
      Thread.CurrentThread.CurrentUICulture = culture;
      Thread.CurrentThread.CurrentCulture = culture;
      CultureInfo.DefaultThreadCurrentCulture = culture;
      CultureInfo.DefaultThreadCurrentUICulture = culture;

      await LoadingUtility.Instance.UpdateStatus("Kiểm tra khoá kích hoạt bản quyền...");
      bool loop = true;
      while (loop) {
        bool activated = Config.Instance.Activated;
        if (!activated) {
          await LoadingUtility.Instance.Close();

          AlertUtility.Instance.ShowWarning("Khoá kích hoạt bản quyền đã hết hạn");
          if (FormFactory<LicenseKeyForm>.Instance.Create().ShowDialog() != DialogResult.OK) {
            loop = false;
          } else {
            await LoadingUtility.Instance.Show("Kiểm tra khoá kích hoạt bản quyền...");
          }
        } else {
          loop = false;
          await LoadingUtility.Instance.UpdateStatus("Đang khởi động...");
          Application.Run(RibbonFormFactory<MainRibbonForm>.Instance.Create());
        }
      }
    }
  }
}
