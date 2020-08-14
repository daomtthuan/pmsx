using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.App.View.Form.Add;
using PMSX.Pattern.Base;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Control.Table {
  [System.ComponentModel.DesignerCategory("")]
  internal class MacroTable : TableWithSelectControl {
    public MacroTable() { }

    protected override void EventLoad(LookUpEdit selectControl) {
      Name = "MacroTable";

      List<MacroGroup> macroGroups = MacroGroupController.Instance.Get();
      if (macroGroups == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(selectControl, macroGroups, new[] { "Code", "Name" }, "Id", "Name");
    }

    protected override void EventSelectChanged(GridControl grid, GridView view, object selected) {
      List<Macro> macros = MacroController.Instance.Get(((MacroGroup)selected).Id);
      if (macros == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, macros, new[] { "Id", "Code", "Description", "State", "Comment", "CreateDateTime", "UpdateDateTime" });
    }

    protected override DialogResult EventAddButtonClick(object selected) {
      AddMacroForm addForm = FormFactory<AddMacroForm>.Instance.Create();
      addForm.Tag = selected;
      return addForm.ShowDialog();
    }

    protected override DialogResult EventEditButtonClick(object selected, ModelBase modelSelected) {
      AddMacroForm addForm = FormFactory<AddMacroForm>.Instance.Create();
      addForm.Tag = modelSelected;
      return addForm.ShowDialog();
    }

    protected override bool EventDisableButtonClick(object selected, ModelBase modelSelected) {
      if (AlertUtility.Instance.ShowConfirm("Vô hiệu hoá đại thể này này?") == DialogResult.No) {
        return false;
      }

      bool isFalse = false;
      OverlayUtility.Instance.StartProcess(this, () => {
        isFalse = MacroController.Instance.Disable(modelSelected.Id) < 0;
        if (isFalse) {
          Application.Exit();
        }
      });
      return isFalse;
    }
  }
}
