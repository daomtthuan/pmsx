using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.App.Controller;
using PMSX.App.View.Form.Add;
using PMSX.App.View.Form.Edit;
using PMSX.Pattern.Base;
using PMSX.Pattern.Factory;
using PMSX.Utility.View;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.App.View.Control.Table {
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
      GridUtility.Instance.LoadData(grid, view, permissions, new[] { "StaffId", "StaffName", "Comment", "State", "CreateDateTime", "UpdateDateTime" });
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

      if (PermissionController.Instance.Disable(modelSelected.Id) < 0) {
        Application.Exit();
        return false;
      }
      return true;
    }
  }
}
