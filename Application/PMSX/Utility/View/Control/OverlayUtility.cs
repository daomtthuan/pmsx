using DevExpress.XtraBars;
#if !DEBUG
using DevExpress.XtraSplashScreen;
using PMSX.Exception;
#endif
using PMSX.Pattern.Base;
using System;
#if !DEBUG
using System.Threading.Tasks;
#endif

namespace PMSX.Utility.View.Control {
  internal class OverlayUtility : SingletonBase<OverlayUtility> {
    private OverlayUtility() { }

#if !DEBUG
    public async void StartProcess(System.Windows.Forms.Control control, BarStaticItem statusLabel, Action process) {
      statusLabel.Caption = "Đảng tải dữ liệu...";
      try {
        using (IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(control)) {
#endif
    public void StartProcess(System.Windows.Forms.Control control, BarStaticItem statusLabel, Action process) {
      process.Invoke();
#if !DEBUG
          await Task.Delay(1000);
          handle.Close();
          statusLabel.Caption = "Sẳn sàng!";
        }
      } catch {
        statusLabel.Caption = "Đã xảy ra lỗi!";
        throw AppException.Instance.Error;
      }
#endif
    }
  }
}
