using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.Util.Pattern.Factory {

  /// <summary>
  /// Control Factory
  /// </summary>
  /// <typeparam name="Class">Control class</typeparam>
  internal class Control<Class> where Class : XtraUserControl, new() {

    /// <summary>
    /// Create Control
    /// </summary>
    /// <returns>Control</returns>
    public static Class Create() {
      Class control = new Class() {
        Dock = DockStyle.Fill
      };

      return control;
    }
  }
}
