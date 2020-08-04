using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.App.Controller;
using PMSX.App.Model;
using PMSX.App.View.Form.Add;
using PMSX.App.View.Form.Edit;
using PMSX.Pattern.Base;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using System.Windows.Forms;

namespace PMSX.App.View.Control.Table {
  [System.ComponentModel.DesignerCategory("")]
  internal class StaffTable : TableControl {
    public StaffTable() { }

    protected override void EventLoad(GridControl grid, GridView view) {
      System.Collections.Generic.List<Staff> staffs = StaffController.Instance.Get();
      if (staffs == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, staffs, new[] { "Id", "Username", "Name", "Comment", "State", "CreateStaffName", "CreateDateTime" });
    }

    protected override DialogResult EventAddButtonClick() {
      return FormFactory<AddStaffForm>.Instance.Create().ShowDialog();
    }

    protected override DialogResult EventEditButtonClick(object modelSelected) {
      EditStaffForm editForm = FormFactory<EditStaffForm>.Instance.Create();
      editForm.Tag = modelSelected;
      return editForm.ShowDialog();
    }

    protected override bool EventDisableButtonClick(ModelBase modelSelected) {
      if (AlertUtility.Instance.ShowConfirm("Vô hiệu hoá nhân viên này?") == DialogResult.No) {
        return false;
      }

      if (StaffController.Instance.Disable(modelSelected.Id) < 0) {
        Application.Exit();
        return false;
      }
      return true;
    }
  }
}
