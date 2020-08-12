using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using PMSX.Pattern.Base;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSX.Utility.View {
  internal class OverlayUtility : SingletonBase<OverlayUtility> {
    private OverlayUtility() { }

    public async void StartProcess(Control control, Action process, BarStaticItem statusLabel, string statusCaption = "Đảng tải dữ liệu...") {
      try {
        statusLabel.Caption = statusCaption;
        Skin skin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default);
        using (IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(control, false, false, skin.SvgPalettes["DefaultSkinPalette"].Colors[0].Value)) {
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

    public async void StartProcess(Control control, Action process) {
      try {
        Skin skin = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default);
        using (IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(control, false, false, skin.SvgPalettes["DefaultSkinPalette"].Colors[0].Value)) {
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
