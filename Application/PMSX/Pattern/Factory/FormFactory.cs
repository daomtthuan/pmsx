using DevExpress.XtraEditors;
using PMSX.App;
using PMSX.Pattern.Base;
using PMSX.Pattern.Interface;
using PMSX.Properties;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.Pattern.Factory {
  internal class FormFactory<Form> : SingletonBase<FormFactory<Form>>, IFactory<Form> where Form : XtraForm, new() {
    private FormFactory() { }

    public Form Create() {
      Form form = new Form() {
        Icon = Resources.Icon,
        StartPosition = FormStartPosition.CenterScreen,
        FormBorderStyle = FormBorderStyle.FixedSingle,
        MaximizeBox = false,
        DialogResult = DialogResult.Cancel,
        FormBorderEffect = FormBorderEffect.Glow
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
