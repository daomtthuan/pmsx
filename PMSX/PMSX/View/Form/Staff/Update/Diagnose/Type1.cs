using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Staff.Update.Diagnose {
  internal partial class Type1 : Pattern.Class.EscCloseForm {
    private readonly Model.Biopsy biopsy;
    private readonly Model.Diagnose.Type1 diagnose;
    private readonly List<Model.MacroGroup> macroGroups;
    private readonly List<Model.MicroGroup> microGroups;

    public Type1(Model.Diagnose.Type1 diagnose, List<Model.MacroGroup> macroGroups, List<Model.MicroGroup> microGroups, Model.Biopsy biopsy) {
      InitializeComponent();

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      readDateSelect.Properties.MinValue = DateTime.Now;

      this.diagnose = diagnose;
      this.macroGroups = macroGroups;
      this.microGroups = microGroups;
      this.biopsy = biopsy;
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(macroGroupSelect, macroGroups, new[] { "Code", "Name", "State" }, "Id", "Code", diagnose.MacroGroupId.Length == 0 ? null : diagnose.MacroGroupId);
      Utils.View.Grid.Instance.Load(microGroupSelect, microGroups, new[] { "Code", "Name", "State" }, "Id", "Code", diagnose.MicroGroupId.Length == 0 ? null : diagnose.MicroGroupId);

      macroSelect.EditValue = diagnose.MacroId.Length == 0 ? null : diagnose.MacroId;
      microSelect.EditValue = diagnose.MicroId.Length == 0 ? null : diagnose.MicroId;

      codeInput.Text = diagnose.Code;
      macroDescriptionInput.Text = diagnose.MacroDescription;
      microDescriptionInput.Text = diagnose.MicroDescription;
      conclusionInput.Text = diagnose.Conclusion;
      readDateSelect.DateTime = DateTime.Parse(diagnose.ReadDate);
      commentInput.Text = diagnose.Comment;
    }

    private void MacroGroupSelect_EditValueChanged(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(macroSelect, Controller.Macro.Instance.SelectByGroupId(macroGroupSelect.EditValue.ToString()), new[] { "Code", "Description", "State" }, "Id", "Code");
    }

    private void MicroGroupSelect_EditValueChanged(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(microSelect, Controller.Micro.Instance.SelectByGroupId(microGroupSelect.EditValue.ToString()), new[] { "Code", "Description", "State" }, "Id", "Code", null);
    }

    private void MacroSelect_EditValueChanged(object sender, EventArgs e) {
      macroDescriptionInput.Text = ((Model.Macro)macroSelect.GetSelectedDataRow()).Description;
    }

    private void MicroSelect_EditValueChanged(object sender, EventArgs e) {
      Model.Micro micro = (Model.Micro)microSelect.GetSelectedDataRow();
      microDescriptionInput.Text = micro.Description;
      conclusionInput.Text = micro.Conclusion;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0 || macroDescriptionInput.Text.Length == 0 || microDescriptionInput.Text.Length == 0 || conclusionInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(codeInput.Text, Utils.RegexPattern.Instance.Code)) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nMã số không hợp lệ.");
      } else if (!Controller.Diagnose.Type1.Instance.Update(diagnose.Id, codeInput.Text, biopsy.Id, macroSelect.EditValue == null ? "" : macroSelect.EditValue.ToString(), macroDescriptionInput.Text, microSelect.EditValue == null ? "" : microSelect.EditValue.ToString(), microDescriptionInput.Text, conclusionInput.Text, readDateSelect.EditValue == null ? "" : readDateSelect.DateTime.ToString(), commentInput.Text, diagnose.GetStateNumber())) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã số đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}