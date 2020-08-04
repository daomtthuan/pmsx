using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using PMSX.Pattern.Base;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSX.Utility.View {
  internal class OverlayUtility : SingletonBase<OverlayUtility> {
    private OverlayUtility() { }

    public async void StartProcess(System.Windows.Forms.Control control, BarStaticItem statusLabel, Action process) {
      try {
        statusLabel.Caption = "Đảng tải dữ liệu...";
        using (IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(control, false, false)) {
          process.Invoke();
          await Task.Delay(500);
          handle.Close();
        }
        statusLabel.Caption = "Sẳn sàng!";
      } catch (ExceptionBase exception) {
        statusLabel.Caption = "Đã xảy ra lỗi!";
        AlertUtility.Instance.ShowError(exception);
        Application.Exit();
      } catch (System.Exception exception) {
        statusLabel.Caption = "Đã xảy ra lỗi!";
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Error(exception));
        Application.Exit();
      }
    }

    public async void StartProcess(System.Windows.Forms.Control control, Action process) {
      try {
        using (IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(control, false, false)) {
          process.Invoke();
          await Task.Delay(500);
          handle.Close();
        }
      } catch (ExceptionBase exception) {
        AlertUtility.Instance.ShowError(exception);
        Application.Exit();
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Error(exception));
        Application.Exit();
      }
    }
  }
}
