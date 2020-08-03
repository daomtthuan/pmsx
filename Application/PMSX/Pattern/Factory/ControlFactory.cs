using DevExpress.XtraEditors;
using PMSX.Pattern.Base;
using System.Windows.Forms;

namespace PMSX.Pattern.Factory {
  internal class ControlFactory<Control> : SingletonBase<ControlFactory<Control>>, IFactoryBase<Control> where Control : XtraUserControl, new() {
    private ControlFactory() { }

    public Control Create() {
      WindowsFormsSettings.LoadApplicationSettings();
      return new Control() {
        Dock = DockStyle.Fill
      };
    }
  }
}
