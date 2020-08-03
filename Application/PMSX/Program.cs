using PMSX.App;
using PMSX.App.View.Form;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using System;
using System.Globalization;
using System.Threading;
#if !DEBUG
using System.Threading.Tasks;
#endif
using System.Windows.Forms;

namespace PMSX {
  public static class Program {
    [STAThread]
#if DEBUG
    private static void Main() {
#else
    private static async Task Main() {
      await Loading.Instance.Show("Chuẩn bị thiết lập...");
      await Loading.Instance.UpdateStatus("Thiết lập giao diện...");
#endif
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

#if !DEBUG
      await Loading.Instance.UpdateStatus("Thiết lập ngôn ngữ...");
#endif
      CultureInfo culture = CultureInfo.CreateSpecificCulture("vi-VN");
      Thread.CurrentThread.CurrentUICulture = culture;
      Thread.CurrentThread.CurrentCulture = culture;
      CultureInfo.DefaultThreadCurrentCulture = culture;
      CultureInfo.DefaultThreadCurrentUICulture = culture;

      bool loop = true;
#if !DEBUG
      await Loading.Instance.UpdateStatus("Kiểm tra khoá kích hoạt bản quyền...");
#endif
      while (loop) {
        bool activated = Config.Instance.Activated;

        if (!activated) {
#if !DEBUG
          await Loading.Instance.Close();
#endif
          AlertUtility.Instance.ShowWarning("Khoá kích hoạt bản quyền đã hết hạn");
          if (FormFactory<LicenseKeyForm>.Instance.Create().ShowDialog() != DialogResult.OK) {
            loop = false;
          } else {
#if !DEBUG
            await Loading.Instance.Show("Kiểm tra khoá kích hoạt bản quyền...");
#endif
          }
        } else {
          loop = false;
#if !DEBUG
          await Loading.Instance.UpdateStatus("Đang khởi động...");
#endif
          Application.Run(RibbonFormFactory<MainRibbonForm>.Instance.Create());
        }
      }
    }
  }
}
