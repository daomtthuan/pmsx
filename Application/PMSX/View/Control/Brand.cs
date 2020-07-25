using DevExpress.XtraEditors;
using System.Reflection;

namespace PMSX.View.Control {

  /// <summary>
  /// Brand
  /// </summary>
  internal partial class Brand : XtraUserControl {

    /// <summary>
    /// Create Brand
    /// </summary>
    public Brand() {
      InitializeComponent();

      versionLabel.Text = $"Phiên bản {Assembly.GetExecutingAssembly().GetName().Version}";
    }
  }
}
