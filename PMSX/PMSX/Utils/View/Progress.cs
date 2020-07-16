using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace PMSX.Utils.View {
  public class Progress : Pattern.Singleton<Progress> {
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
