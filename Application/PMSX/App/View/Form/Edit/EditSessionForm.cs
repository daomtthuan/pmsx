using PMSX.Utility.View.Form;

namespace PMSX.App.View.Form.Edit {
  public partial class EditSessionForm : DevExpress.XtraEditors.XtraForm {
    public EditSessionForm() {
      InitializeComponent();
    }

    private void EditSessionForm_Load(object sender, System.EventArgs e) {
      DisplayUtility.Instance.Set(this, true);
    }
  }
}