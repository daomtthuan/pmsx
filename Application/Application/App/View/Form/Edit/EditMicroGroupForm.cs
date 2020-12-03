using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.Utility;
using PMSXApplication.Utility.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Edit {
  internal partial class EditMicroGroupForm : XtraForm {
    public EditMicroGroupForm() {
      InitializeComponent();
    }

    private void EditMicroGroupForm_Load(object sender, EventArgs e) {
      MicroGroup microGroup = (MicroGroup)Tag;
      codeInput.Text = microGroup.Code;
      nameInput.Text = microGroup.Name;
      stateRadio.EditValue = microGroup.GetStateNumber();
      commentInput.Text = microGroup.Comment;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      if (AlertUtility.Instance.ShowConfirm("Chỉnh sửa nhóm vi thể này?") == DialogResult.No) {
        return;
      }

      long id = ((MicroGroup)Tag).Id;
      string code = codeInput.Text;
      string name = nameInput.Text;
      int state = (int)stateRadio.EditValue;
      string comment = commentInput.Text;

      if (code.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập mã số nhóm vi thể");
        return;
      }

      if (name.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên nhóm vi thể");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Name, name)) {
        AlertUtility.Instance.ShowWarning("Tên nhóm vi thể không hợp lệ");
        return;
      }

      List<MicroGroup> microGroups = null;
      OverlayUtility.Instance.StartProcess(this, () => {
        microGroups = MicroGroupController.Instance.GetByCode(code);
        if (microGroups == null) {
          Application.Exit();
          return;
        }
      });

      if (microGroups.Count > 0) {
        if (microGroups[0].Id != id) {
          AlertUtility.Instance.ShowWarning("Mã số nhóm vi thể này đã tồn tại");
          return;
        }
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (MicroGroupController.Instance.Edit(id, code, name, state, comment) < 0) {
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