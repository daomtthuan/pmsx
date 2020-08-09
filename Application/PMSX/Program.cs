﻿using DevExpress.UserSkins;
using PMSX.App;
using PMSX.App.View.Form;
using PMSX.Exception;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSX {
  public static class Program {

    [System.STAThread]
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
      var state = Config.Instance.CheckLicense();
      if (state != Config.LicenseState.Accept) {
        await LoadingUtility.Instance.Close();
        if (FormFactory<LicenseKeyForm>.Instance.Create().ShowDialog() == DialogResult.OK) {
          await LoadingUtility.Instance.Show("Đang khởi động...");
          Application.Run(RibbonFormFactory<MainRibbonForm>.Instance.Create());
        }
      } else {
        await LoadingUtility.Instance.UpdateStatus("Đang khởi động...");
        Application.Run(RibbonFormFactory<MainRibbonForm>.Instance.Create());
      }
    }
  }
}
