using DevExpress.XtraSplashScreen;
using System;

namespace PMSX.Util.View {

  /// <summary>
  /// Process
  /// </summary>
  class Process : Pattern.Singleton<Process> {

    /// <summary>
    /// Create Process
    /// </summary>
    private Process() { }

    /// <summary>
    /// Start process
    /// </summary>
    /// <param name="control">Base control</param>
    /// <param name="action">Action in process</param>
    public void Start(System.Windows.Forms.Control control, Action action) {
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
