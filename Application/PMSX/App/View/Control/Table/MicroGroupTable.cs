using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.App.View.Form.Add;
using PMSX.App.View.Form.Edit;
using PMSX.Pattern.Base;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Control.Table {
  [System.ComponentModel.DesignerCategory("")]
  internal class MicroGroupTable : TableControl {
    public MicroGroupTable() { }

    protected override void EventLoad(GridControl grid, GridView view) {
      Name = "MicroGroupTable";

      List<MicroGroup> microGroups = MicroGroupController.Instance.Get();
      if (microGroups == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, microGroups, new[] { "Id", "Code", "Name", "Comment", "State", "CreateDateTime", "UpdateDateTime" });
    }

    protected override DialogResult EventAddButtonClick() {
      return FormFactory<AddMicroGroupForm>.Instance.Create().ShowDialog();
    }

    protected override DialogResult EventEditButtonClick(object modelSelected) {
      EditMicroGroupForm editForm = FormFactory<EditMicroGroupForm>.Instance.Create();
      editForm.Tag = modelSelected;
      return editForm.ShowDialog();
    }

    protected override bool EventDisableButtonClick(ModelBase modelSelected) {
      if (AlertUtility.Instance.ShowConfirm("Vô hiệu hoá nhóm vi thể này này?") == DialogResult.No) {
        return false;
      }

      if (MicroGroupController.Instance.Disable(modelSelected.Id) < 0) {
        Application.Exit();
        return false;
      }
      return true;
    }
  }
}
