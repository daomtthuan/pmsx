using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Edit {
  public partial class EditMacroForm : DevExpress.XtraEditors.XtraForm {
    public EditMacroForm() {
      InitializeComponent();
    }

    private void EditMacroForm_Load(object sender, EventArgs e) {
      Macro macro = (Macro)Tag;
      codeInput.Text = macro.Code;
      descriptionInput.Text = macro.Description;
      stateRadio.EditValue = macro.GetStateNumber();
      commentInput.Text = macro.Comment;

      DisplayUtility.Instance.Set(this, true);
    }

    private void EditButton_Click(object sender, EventArgs e) {
      if (AlertUtility.Instance.ShowConfirm("Chỉnh sửa đại thể này?") == DialogResult.No) {
        return;
      }

      Macro macro = (Macro)Tag;
      string code = codeInput.Text;
      string description = descriptionInput.Text;
      int state = (int)stateRadio.EditValue;
      string comment = commentInput.Text;


      if (code.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập mã số đại thể");
        return;
      }

      if (description.Length == 0) {
        AlertUtility.Instance.ShowWarning("Vui lòng nhập mô tả đại thể");
        return;
      }

      List<Macro> macros = null;
      OverlayUtility.Instance.StartProcess(this, () => {
        macros = MacroController.Instance.GetByCode(macro.MacroGroupId, code);
        if (macros == null) {
          Application.Exit();
          return;
        }
      });

      if (macros.Count > 0) {
        if (macros[0].Id != macro.Id) {
          AlertUtility.Instance.ShowWarning("Mã số đại thể này đã tồn tại");
          return;
        }
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (MacroController.Instance.Edit(macro.Id, code, description, state, comment) < 0) {
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