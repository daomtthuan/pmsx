using DevExpress.XtraEditors;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.Utility;
using PMSXApplication.Utility.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Form.Add {
  internal partial class AddMacroGroupForm : XtraForm {
    public AddMacroGroupForm() {
      InitializeComponent();
    }

    private void AddMacroGroupForm_Load(object sender, EventArgs e) {
      DisplayUtility.Instance.Set(this, true);
    }

    private void AddButton_Click(object sender, EventArgs e) {
      string code = codeInput.Text;
      string name = nameInput.Text;
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
        AlertUtility.Instance.ShowWarning("Mã số nhóm đại thể này đã tồn tại");
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (MacroGroupController.Instance.Add(code, name, comment) < 0) {
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