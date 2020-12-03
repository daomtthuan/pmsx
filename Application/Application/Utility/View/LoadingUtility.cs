using DevExpress.XtraSplashScreen;
using PMSXApplication.App.View;
using PMSXApplication.Pattern.Base;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSXApplication.Utility.View {
  internal class LoadingUtility : SingletonBase<LoadingUtility> {
    private LoadingUtility() { }

    public async Task Show(string text) {
      try {
        SplashScreenManager.ShowForm(typeof(LoadingSplashScreen), false, false);
        await Task.Delay(500);
        await UpdateStatus(text);
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Error(exception));
        Application.Exit();
      }
    }

    public async Task UpdateStatus(string status) {
      try {
        SplashScreenManager.Default.SendCommand(LoadingSplashScreen.SplashScreenCommand.UpdateStatus, status);
        await Task.Delay(500);
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Error(exception));
        Application.Exit();
      }
    }

    public async Task Close(string text = null) {
      try {
        if (text != null) {
          await UpdateStatus(text);
        } else {
          await Task.Delay(500);
        }
        SplashScreenManager.CloseForm();
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Error(exception));
        Application.Exit();
      }
    }
  }
}
