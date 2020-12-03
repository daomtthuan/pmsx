using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.Utility.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Add {
  public partial class AddMacroForm : XtraForm {
    public AddMacroForm() {
      InitializeComponent();
    }

    private void AddMacroForm_Load(object sender, EventArgs e) {
      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      MacroGroup macroGroup = (MacroGroup)Tag;
      string code = codeInput.Text;
      string description = descriptionInput.Text;
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
        macros = MacroController.Instance.GetByCode(macroGroup.Id, code);
        if (macros == null) {
          Application.Exit();
          return;
        }
      });

      if (macros.Count > 0) {
        AlertUtility.Instance.ShowWarning("Mã số đại thể này đã tồn tại");
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (MacroController.Instance.Add(code, description, macroGroup.Id, comment) < 0) {
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