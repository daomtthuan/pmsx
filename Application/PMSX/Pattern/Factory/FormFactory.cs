using DevExpress.XtraEditors;
using PMSX.Pattern.Base;
using PMSX.Utility.View.Form;
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
        DialogResult = DialogResult.Cancel
      };

      SimpleButton closeButton = new SimpleButton();
      closeButton.Click += new EventHandler((sender, e) => form.Close());
      form.CancelButton = closeButton;
      DisplayUtility.Instance.Set(form, false);

      return form;
    }
  }
}
