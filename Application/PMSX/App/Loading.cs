using DevExpress.XtraSplashScreen;
using PMSX.App.View;
using PMSX.Pattern.Base;
using System.Threading.Tasks;

namespace PMSX.App {
  internal class Loading : SingletonBase<Loading> {
    private Loading() { }

    public async Task Show(string text) {
      SplashScreenManager.ShowForm(typeof(LoadingSplashScreen));
      await Task.Delay(500);
      await UpdateStatus(text);
    }

    public async Task UpdateStatus(string status) {
      SplashScreenManager.Default.SendCommand(LoadingSplashScreen.SplashScreenCommand.UpdateStatus, status);
      await Task.Delay(1000);
    }

    public async Task Close(string text = null) {
      if (text != null) {
        await UpdateStatus(text);
      }
      SplashScreenManager.CloseForm();
      await Task.Delay(500);
    }
  }
}
