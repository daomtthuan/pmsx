using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.App.Controller;
using PMSX.App.View.Form.Add;
using PMSX.App.View.Form.Edit;
using PMSX.Pattern.Base;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using PMSX.Utility.View.Control;
using System.Windows.Forms;

namespace PMSX.App.View.Control.Table {
  [System.ComponentModel.DesignerCategory("")]
  internal class StaffTable : TableControl {
    public StaffTable() { }

    protected override void EventLoad(GridControl grid, GridView view) {
      GridUtility.Instance.LoadData(grid, view, StaffController.Instance.Get(), new[] { "Id", "Username", "Name", "Comment", "State", "CreateStaffName", "CreateDateTime" });
    }

    protected override DialogResult EventAddButtonClick() {
      return FormFactory<AddStaffForm>.Instance.Create().ShowDialog();
    }

    protected override DialogResult EventEditButtonClick(ModelBase modelSelected) {
      var editForm = FormFactory<EditStaffForm>.Instance.Create();
      editForm.Tag = modelSelected;
      return editForm.ShowDialog();
    }

    protected override bool EventDisableButtonClick(ModelBase modelSelected) {      
      if (AlertUtility.Instance.ShowConfirm("Vô hiệu hoá nhân viên này?") == DialogResult.No) {
        return false;
      }

      return StaffController.Instance.Disable(modelSelected.Id) == 1;
    }
  }
}
