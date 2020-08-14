using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using PMSX.Utility.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Control.Table {
  [System.ComponentModel.DesignerCategory("")]
  internal class MicroTable : TableWithSelectControl {
    public MicroTable() { }

    protected override void EventLoad(LookUpEdit selectControl) {
      Name = "MicroTable";

      List<MicroGroup> microGroups = MicroGroupController.Instance.Get();
      if (microGroups == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(selectControl, microGroups, new[] { "Code", "Name" }, "Id", "Name");
    }

    protected override void EventSelectChanged(GridControl grid, GridView view, object selected) {
      List<Micro> micros = MicroController.Instance.Get(((MicroGroup)selected).Id);
      if (micros == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, micros, new[] { "Id", "Code", "Description", "Conclusion", "State", "Comment", "CreateDateTime", "UpdateDateTime" });
    }

    protected override DialogResult EventAddButtonClick(object selected) {
      throw new System.NotImplementedException();
    }

    protected override DialogResult EventEditButtonClick(object selected, ModelBase modelSelected) {
      throw new System.NotImplementedException();
    }

    protected override bool EventDisableButtonClick(object selected, ModelBase modelSelected) {
      throw new System.NotImplementedException();
    }
  }
}
