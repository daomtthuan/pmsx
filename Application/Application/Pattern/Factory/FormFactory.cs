using DevExpress.XtraEditors;
using PMSXApplication.App;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Pattern.Interface;
using PMSXApplication.Properties;
using PMSXApplication.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSXApplication.Pattern.Factory {
  internal class FormFactory<Form> : SingletonBase<FormFactory<Form>>, IFactory<Form> where Form : XtraForm, new() {
    private FormFactory() { }

    public Form Create() {
      Form form = new Form() {
        Icon = Resources.Icon,
        StartPosition = FormStartPosition.CenterScreen,
        FormBorderStyle = FormBorderStyle.FixedSingle,
        MaximizeBox = false,
        DialogResult = DialogResult.Cancel
      };
      DisplayUtility.Instance.Set(form, false);
      Config.Instance.SetupTheme();

      SimpleButton closeButton = new SimpleButton();
      closeButton.Click += new EventHandler((sender, e) => form.Close());
      form.CancelButton = closeButton;

      return form;
    }
  }
}
