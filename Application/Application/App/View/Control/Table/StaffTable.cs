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
  internal class StaffTable : TableControl {
    public StaffTable() { }

    protected override void EventLoad(GridControl grid, GridView view) {
      Name = "StaffTable";

      List<Staff> staffs = StaffController.Instance.Get();
      if (staffs == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, staffs, new[] { "Id", "Username", "Name", "Comment", "State", "Comment", "CreateDateTime", "UpdateDateTime" });
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

      bool isFalse = false;
      OverlayUtility.Instance.StartProcess(this, () => {
        isFalse = StaffController.Instance.Disable(modelSelected.Id) < 0;
        if (isFalse) {
          Application.Exit();
        }
      });
      return !isFalse;
    }
  }
}
