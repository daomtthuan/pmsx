using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Edit {
  internal partial class EditMacroGroupForm : XtraForm {
    public EditMacroGroupForm() {
      InitializeComponent();
    }

    private void EditMacroGroupForm_Load(object sender, EventArgs e) {
      MacroGroup macroGroup = (MacroGroup)Tag;
      codeInput.Text = macroGroup.Code;
      nameInput.Text = macroGroup.Name;
      stateRadio.EditValue = macroGroup.GetStateNumber();
      commentInput.Text = macroGroup.Comment;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      long id = ((MacroGroup)Tag).Id;
      string code = codeInput.Text;
      string name = nameInput.Text;
      int state = (int)stateRadio.EditValue;
      string comment = commentInput.Text;

      if (code.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập mã số nhóm đại thể");
        return;
      }

      if (name.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập tên nhóm đại thể");
        return;
      } else if (!StringUtility.Instance.IsValid(StringUtility.Regex.Name, name)) {
        AlertUtility.Instance.ShowWarning("Tên nhóm đại thể không hợp lệ");
        return;
      }

      List<MacroGroup> macroGroups = null;
      OverlayUtility.Instance.StartProcess(this, () => {
        macroGroups = MacroGroupController.Instance.GetByCode(code);
        if (macroGroups == null) {
          Application.Exit();
          return;
        }
      });

      if (macroGroups.Count > 0) {
        if (macroGroups[0].Id != id) {
          AlertUtility.Instance.ShowWarning("Mã số nhóm đại thể này đã tồn tại");
          return;
        }
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (MacroGroupController.Instance.Edit(id, code, name, state, comment) < 0) {
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