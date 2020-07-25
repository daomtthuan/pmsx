using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;

namespace PMSX.Util.Pattern.Factory {

  /// <summary>
  /// RibbonForm Factory
  /// </summary>
  /// <typeparam name="Class">RibbonForm class</typeparam>
  internal class RibbonForm<Class> where Class : RibbonForm, new() {

    /// <summary>
    /// Create RibbonForm
    /// </summary>
    /// <returns>RibbonForm</returns>
    public static Class Create() {
      Class form = new Class() {
        Icon = Properties.Resources.icon,
        StartPosition = FormStartPosition.CenterScreen,
        WindowState = FormWindowState.Maximized
      };

      return form;
    }
  }
}
