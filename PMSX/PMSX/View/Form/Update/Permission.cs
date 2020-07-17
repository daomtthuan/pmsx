using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class Permission : XtraForm {
    private readonly Model.Permission permissions;

    public Permission(Model.Permission permissions) {
      InitializeComponent();
      this.permissions = permissions;

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void Permission_Load(object sender, EventArgs e) {
      stateRadio.EditValue = permissions.GetStateNumber();
      commentInput.Text = permissions.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      Controller.Permission.Instance.Update(permissions.Id, commentInput.Text, (int)stateRadio.EditValue);
      Close();
    }
  }
}