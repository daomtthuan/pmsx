using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class Permission : XtraForm {
    private readonly Model.Permission data;

    public Permission(Model.Permission data) {
      InitializeComponent();
      this.data = data;

      Icon = Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      stateRadio.EditValue = data.State;
      commentInput.Text = data.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      Controller.Permission.Instance.Update(data.Id, commentInput.Text, (int)stateRadio.EditValue);
      Close();
    }
  }
}