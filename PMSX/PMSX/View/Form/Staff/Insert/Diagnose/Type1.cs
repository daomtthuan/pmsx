﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PMSX.View.Form.Staff.Insert.Diagnose {
  internal partial class Type1 : Pattern.Class.EscCloseForm {
    private readonly Model.Biopsy biopsy;
    private readonly List<Model.MacroGroup> macroGroups;
    private readonly List<Model.MicroGroup> microGroups;

    public Type1(List<Model.MacroGroup> macroGroups, List<Model.MicroGroup> microGroups, Model.Biopsy biopsy) {
      InitializeComponent();

      readDateSelect.Properties.MinValue = DateTime.Now;

      this.macroGroups = macroGroups;
      this.microGroups = microGroups;
      this.biopsy = biopsy;
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(macroGroupSelect, macroGroups, new[] { "Code", "Name", "State" }, "Id", "Code", null);
      Utils.View.Grid.Instance.Load(microGroupSelect, microGroups, new[] { "Code", "Name", "State" }, "Id", "Code", null);
    }

    private void MacroGroupSelect_EditValueChanged(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(macroSelect, Controller.Macro.Instance.SelectByGroupId(macroGroupSelect.EditValue.ToString()), new[] { "Code", "Description", "State" }, "Id", "Code", null);
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

    private void InsertButton_Click(object sender, EventArgs e) {
      if (codeInput.Text.Length == 0 || macroDescriptionInput.Text.Length == 0 || microDescriptionInput.Text.Length == 0 || conclusionInput.Text.Length == 0) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
      } else if (!Regex.IsMatch(codeInput.Text, Utils.RegexPattern.Instance.Code)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã số không hợp lệ.");
      } else if (!Controller.Diagnose.Type1.Instance.Insert(codeInput.Text, biopsy.Id, macroSelect.EditValue == null ? "" : macroSelect.EditValue.ToString(), macroDescriptionInput.Text, microSelect.EditValue == null ? "" : microSelect.EditValue.ToString(), microDescriptionInput.Text, conclusionInput.Text, readDateSelect.EditValue == null ? "" : readDateSelect.DateTime.ToString(), commentInput.Text)) {
        Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nMã số đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}