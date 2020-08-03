using DevExpress.XtraEditors;
using PMSX.Pattern.Base;
using System;
using System.Windows.Forms;

namespace PMSX.Pattern.Factory {
  internal class FormFactory<Form> : SingletonBase<FormFactory<Form>>, IFactoryBase<Form> where Form : XtraForm, new() {
    private FormFactory() { }

    public Form Create() {
      WindowsFormsSettings.LoadApplicationSettings();
      Form form = new Form() {
        Icon = Properties.Resources.Icon,
        StartPosition = FormStartPosition.CenterScreen,
        FormBorderStyle = FormBorderStyle.FixedSingle,
        MaximizeBox = false,
        DialogResult = DialogResult.None
      };

      SimpleButton closeButton = new SimpleButton();
      closeButton.Click += new EventHandler((sender, e) => form.Close());
      form.CancelButton = closeButton;

      return form;
    }
  }
}
