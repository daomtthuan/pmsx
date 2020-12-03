using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSXApplication.App.Controller;
using PMSXApplication.App.View.Form.Add;
using PMSXApplication.App.View.Form.Edit;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Pattern.Factory;
using PMSXApplication.Utility.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Control.Table {
  [System.ComponentModel.DesignerCategory("")]
  internal class PermissionTable : TableWithSelectControl {
    public PermissionTable() { }

    protected override void EventLoad(LookUpEdit selectControl) {
      Name = "PermissionTable";

      GridUtility.Instance.LoadData(selectControl, Authentication.Instance.Roles);
    }

    protected override void EventSelectChanged(GridControl grid, GridView view, object selected) {
      List<Model.Permission> permissions = PermissionController.Instance.GetByRoleName(selected.ToString());
      if (permissions == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, permissions, new[] { "StaffId", "StaffName", "State", "Comment", "CreateDateTime", "UpdateDateTime" });
    }

    protected override DialogResult EventAddButtonClick(object selected) {
      AddPermissionForm addForm = FormFactory<AddPermissionForm>.Instance.Create();
      addForm.Tag = selected;
      return addForm.ShowDialog();
    }

    protected override DialogResult EventEditButtonClick(object selected, ModelBase modelSelected) {
      EditPermissionForm editForm = FormFactory<EditPermissionForm>.Instance.Create();
      editForm.Tag = modelSelected;
      return editForm.ShowDialog();
    }

    protected override bool EventDisableButtonClick(object selected, ModelBase modelSelected) {
      if (AlertUtility.Instance.ShowConfirm("Vô hiệu hoá phân quyền của nhân viên này?") == DialogResult.No) {
        return false;
      }

      bool isFalse = false;
      OverlayUtility.Instance.StartProcess(this, () => {
        isFalse = PermissionController.Instance.Disable(modelSelected.Id) < 0;
        if (isFalse) {
          Application.Exit();
        }
      });
      return !isFalse;
    }
  }
}
