using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSX.View.Form {

  /// <summary>
  /// Main
  /// </summary>
  internal partial class Main : RibbonForm {

    /// <summary>
    /// Create Main
    /// </summary>
    public Main() {
      InitializeComponent();

      SetDisplay(false);
    }

    /// <summary>
    /// Set Display form
    /// </summary>
    /// <param name="isDisplay">Is display or not</param>
    private void SetDisplay(bool isDisplay) {
      Visible = isDisplay;
      ShowInTaskbar = isDisplay;
      Opacity = isDisplay ? 1 : 0;
      FormBorderEffect = isDisplay ? FormBorderEffect.Default : FormBorderEffect.None;
    }

    /// <summary>
    /// OnLoad Action after Logging in
    /// </summary>
    private void OnLoad() {
      //if (!Controller.Staff.Instance.HasRole(Controller.Role.RoleName.Admin)) {
      //  managePageGroup.Pages.Remove(personnelPage);
      //  personnelPage.Dispose();
      //}
    }

    /// <summary>
    /// Load Event
    /// </summary>
    /// <param name="sender">Object sender</param>
    /// <param name="e">Event args</param>
    private async void Main_LoadAsync(object sender, System.EventArgs e) {
      await Task.Delay(2000);

      Util.Pattern.Factory.Form<Login>.Create().ShowDialog();
      if (Util.Store.Instance.Staff == null) {
        Application.Exit();
      } else {
        Util.View.Process.Instance.Start(this, OnLoad);
      }
    }
  }
}