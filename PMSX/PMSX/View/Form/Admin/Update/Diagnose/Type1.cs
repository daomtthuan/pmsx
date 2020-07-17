using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update.Diagnose {
  public partial class Type1 : XtraForm {
    private readonly Model.Diagnose.Type1 diagnose;
    private readonly List<Model.MacroGroup> macroGroups;
    private readonly List<Model.MicroGroup> microGroups;
    private readonly List<Model.BiopsyGroup> biopsyGroups;

    public Type1(Model.Diagnose.Type1 diagnose, List<Model.MacroGroup> macroGroups, List<Model.MicroGroup> microGroups, List<Model.BiopsyGroup> biopsyGroups) {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      readDateSelect.Properties.MinValue = DateTime.Now;

      this.diagnose = diagnose;
      this.macroGroups = macroGroups;
      this.microGroups = microGroups;
      this.biopsyGroups = biopsyGroups;
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(macroGroupSelect, macroGroups, new[] { "Code", "Name", "State" }, "Id", "Code", diagnose.MacroGroupId.Length == 0 ? null : diagnose.MacroGroupId);
      Utils.View.Grid.Instance.Load(microGroupSelect, microGroups, new[] { "Code", "Name", "State" }, "Id", "Code", diagnose.MicroGroupId.Length == 0 ? null : diagnose.MicroGroupId);
      Utils.View.Grid.Instance.Load(biopsyGroupSelect, biopsyGroups, new[] { "Code", "State" }, "Id", "Code", diagnose.BiopsyGroupId.Length == 0 ? null : diagnose.BiopsyGroupId);

      macroSelect.EditValue = diagnose.MacroId.Length == 0 ? null : diagnose.MacroId;
      microSelect.EditValue = diagnose.MicroId.Length == 0 ? null : diagnose.MicroId;
      biopsySelect.EditValue = diagnose.BiopsyId.Length == 0 ? null : diagnose.BiopsyId;

      codeInput.Text = diagnose.Code;
      macroDescriptionInput.Text = diagnose.MacroDescription;
      microDescriptionInput.Text = diagnose.MicroDescription;
      conclusionInput.Text = diagnose.Conclusion;
      readDateSelect.DateTime = DateTime.Parse(diagnose.ReadDate);
      stateRadio.EditValue = diagnose.GetStateNumber();
      commentInput.Text = diagnose.Comment;
    }

    private void MacroGroupSelect_EditValueChanged(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(macroSelect, Controller.Macro.Instance.SelectByGroupId(macroGroupSelect.EditValue.ToString()), new[] { "Code", "Name", "State" }, "Id", "Code");
    }

    private void MicroGroupSelect_EditValueChanged(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(microSelect, Controller.Micro.Instance.SelectByGroupId(microGroupSelect.EditValue.ToString()), new[] { "Code", "Name", "State" }, "Id", "Code", null);
    }

    private void BiopsyGroupSelect_EditValueChanged(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(biopsySelect, Controller.Biopsy.Instance.SelectByGroupId(biopsyGroupSelect.EditValue.ToString()), new[] { "FullCode", "PatientName", "Segment", "State" }, "Id", "FullCode", null);
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
      if (biopsySelect.EditValue == null || codeInput.Text.Length == 0 || macroDescriptionInput.Text.Length == 0 || microDescriptionInput.Text.Length == 0 || conclusionInput.Text.Length == 0 || readDateSelect.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(codeInput.Text, Utils.RegexPattern.Instance.Code)) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nMã số không hợp lệ.");
      } else if (!Controller.Diagnose.Type1.Instance.Update(diagnose.Id, codeInput.Text, biopsySelect.EditValue.ToString(), macroSelect.EditValue == null ? "" : macroSelect.EditValue.ToString(), macroDescriptionInput.Text, microSelect.EditValue == null ? "" : microSelect.EditValue.ToString(), microDescriptionInput.Text, conclusionInput.Text, readDateSelect.DateTime, commentInput.Text, (int)stateRadio.EditValue)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã số đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}