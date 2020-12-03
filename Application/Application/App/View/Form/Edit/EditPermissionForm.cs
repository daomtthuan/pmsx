using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Edit {
  internal partial class EditPermissionForm : XtraForm {
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

      int state = (int)stateRadio.EditValue;
      string comment = commentInput.Text;

      OverlayUtility.Instance.StartProcess(this, () => {
        if (PermissionController.Instance.Edit(((Permission)Tag).Id, state, comment) < 0) {
          Application.Exit();
          DialogResult = DialogResult.No;
        } else {
          DialogResult = DialogResult.OK;
          Close();
        }
      });
    }
  }
}