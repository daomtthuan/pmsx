using DevExpress.XtraEditors;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Utility;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Form.Add {
  internal partial class AddMicroGroupForm : XtraForm {
    public AddMicroGroupForm() {
      InitializeComponent();
    }

    private void AddMicroGroupForm_Load(object sender, EventArgs e) {
      DisplayUtility.Instance.Set(this, true);
    }

    private void addButton_Click(object sender, EventArgs e) {
      string code = codeInput.Text;
      string name = nameInput.Text;
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
        AlertUtility.Instance.ShowWarning("Mã số nhóm vi thể này đã tồn tại");
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        if (MicroGroupController.Instance.Add(code, name, comment) < 0) {
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