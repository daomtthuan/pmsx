﻿using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.App.View.Form.Add;
using PMSX.App.View.Form.Edit;
using PMSX.Pattern.Base;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Control.Table {
  [System.ComponentModel.DesignerCategory("")]
  internal class MacroGroupTable : TableControl {
    public MacroGroupTable() { }

    protected override void EventLoad(GridControl grid, GridView view) {
      Name = "MacroGroupTable";

      List<MacroGroup> macroGroups = MacroGroupController.Instance.Get();
      if (macroGroups == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, macroGroups, new[] { "Id", "Code", "Name", "Comment", "State", "CreateDateTime", "UpdateDateTime" });
    }

    protected override DialogResult EventAddButtonClick() {
      return FormFactory<AddMacroGroupForm>.Instance.Create().ShowDialog();
    }

    protected override DialogResult EventEditButtonClick(object modelSelected) {
      EditMacroGroupForm editForm = FormFactory<EditMacroGroupForm>.Instance.Create();
      editForm.Tag = modelSelected;
      return editForm.ShowDialog();
    }

    protected override bool EventDisableButtonClick(ModelBase modelSelected) {
      if (AlertUtility.Instance.ShowConfirm("Vô hiệu hoá nhóm đại thể này này?") == DialogResult.No) {
        return false;
      }

      if (MacroGroupController.Instance.Disable(modelSelected.Id) < 0) {
        Application.Exit();
        return false;
      }
      return true;
    }
  }
}
