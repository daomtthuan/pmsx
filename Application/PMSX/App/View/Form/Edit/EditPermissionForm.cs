using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Edit {
  public partial class EditPermissionForm : XtraForm {
    public EditPermissionForm() {
      InitializeComponent();
    }

    private void EditPermissionForm_Load(object sender, EventArgs e) {
      Permission permission = (Permission)Tag;
      stateRadio.EditValue = permission.GetStateNumber();
      commentInput.Text = permission.Comment;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      if (AlertUtility.Instance.ShowConfirm("Chỉnh sửa phân quyền nhân viên này?") == DialogResult.No) {
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        int state = (int)stateRadio.EditValue;
        string comment = commentInput.Text;

        if (PermissionController.Instance.Edit(((Permission)Tag).Id, state, comment) < 0) {
          Application.Exit();
          return;
        }

        DialogResult = DialogResult.OK;
        Close();
      });
    }
  }
}