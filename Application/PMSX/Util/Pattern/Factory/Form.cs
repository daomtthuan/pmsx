using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.Util.Pattern.Factory {

  /// <summary>
  /// Form Factory
  /// </summary>
  /// <typeparam name="Class">Form class</typeparam>
  internal class Form<Class> where Class : XtraForm, new() {

    /// <summary>
    /// Create Form
    /// </summary>
    /// <returns>Form</returns>
    public static Class Create() {
      Class form = new Class() {
        Icon = Properties.Resources.icon,
        StartPosition = FormStartPosition.CenterScreen,
        FormBorderStyle = FormBorderStyle.FixedSingle,
        MaximizeBox = false
      };

      SimpleButton closeButton = new SimpleButton();
      closeButton.Click += new EventHandler((sender, e) => form.Close());
      form.CancelButton = closeButton;

      return form;
    }
  }
}
