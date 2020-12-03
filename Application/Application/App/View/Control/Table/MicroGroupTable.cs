using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSXApplication.App.Controller;
using PMSXApplication.App.Model;
using PMSXApplication.App.View.Form.Add;
using PMSXApplication.App.View.Form.Edit;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Pattern.Factory;
using PMSXApplication.Utility.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Control.Table {
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

      bool isFalse = false;
      OverlayUtility.Instance.StartProcess(this, () => {
        isFalse = MicroGroupController.Instance.Disable(modelSelected.Id) < 0;
        if (isFalse) {
          Application.Exit();
        }
      });
      return !isFalse;
    }
  }
}
