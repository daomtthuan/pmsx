using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace PMSX.Utils.View {
  internal class Progress : Pattern.Class.Singleton<Progress>, Pattern.Interface.IUtil {
    private Progress() { }

    public void Start(Control control, Action action) {
      IOverlaySplashScreenHandle handle = null;
      try {
        handle = SplashScreenManager.ShowOverlayForm(control);
        action();
      } finally {
        if (handle != null) {
          SplashScreenManager.CloseOverlayForm(handle);
        }
      }
    }
  }
}
