using DevExpress.XtraEditors;
using PMSX.App;
using PMSX.Pattern.Base;
using System.Windows.Forms;

namespace PMSX.Pattern.Factory {
  internal class ControlFactory<Control> : SingletonBase<ControlFactory<Control>>, IFactoryBase<Control> where Control : XtraUserControl, new() {
    private ControlFactory() { }

    public Control Create() {
      Control control = new Control() {
        Dock = DockStyle.Fill
      };

      Config.Instance.SetupTheme();

      return control;
    }
  }
}
