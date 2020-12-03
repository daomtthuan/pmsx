using DevExpress.XtraEditors;
using PMSXApplication.App;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Pattern.Interface;
using System.Windows.Forms;

namespace PMSXApplication.Pattern.Factory {
  internal class ControlFactory<Control> : SingletonBase<ControlFactory<Control>>, IFactory<Control> where Control : XtraUserControl, new() {
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
