using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
  internal class PatientTable : TableWithSelectControl {
    public PatientTable() { }

    protected override void EventLoad(LookUpEdit selectControl) {
      Name = "PatientTable";

      List<Group> groups = GroupController.Instance.Get();
      if (groups == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(selectControl, groups, new[] { "Name", "Year" }, "Id", "Name");
    }

    protected override void EventSelectChanged(GridControl grid, GridView view, object selected) {
      List<Patient> patients = PatientController.Instance.Get(((Group)selected).Id);
      if (patients == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, patients, new[] { "Id", "Code", "Name", "YearsOld", "Address", "State", "CreateDateTime", "UpdateDateTime" });
    }

    protected override DialogResult EventAddButtonClick(object selected) {
      if (((Group)selected).Id != Authentication.Instance.Group.Id && !Authentication.Instance.HasRole(Authentication.Role.Admin)) {
        AlertUtility.Instance.ShowWarning("Tài khoản không có quyền thêm bệnh nhân ở nhóm này");
        return DialogResult.Cancel;
      } else {
        AddPatientForm addForm = FormFactory<AddPatientForm>.Instance.Create();
        addForm.Tag = selected;
        return addForm.ShowDialog();
      }
    }

    protected override DialogResult EventEditButtonClick(object selected, ModelBase modelSelected) {
      if (((Group)selected).Id != Authentication.Instance.Group.Id && !Authentication.Instance.HasRole(Authentication.Role.Admin)) {
        AlertUtility.Instance.ShowWarning("Tài khoản không có quyền thêm bệnh nhân ở nhóm này");
        return DialogResult.Cancel;
      } else {
        EditPatientForm editForm = FormFactory<EditPatientForm>.Instance.Create();
        editForm.Tag = modelSelected;
        return editForm.ShowDialog();
      }
    }

    protected override bool EventDisableButtonClick(object selected, ModelBase modelSelected) {
      if (((Group)selected).Id != Authentication.Instance.Group.Id && !Authentication.Instance.HasRole(Authentication.Role.Admin)) {
        AlertUtility.Instance.ShowWarning("Tài khoản không có quyền thêm bệnh nhân ở nhóm này");
        return false;
      } else {
        if (AlertUtility.Instance.ShowConfirm("Vô hiệu hoá bệnh nhân này?") == DialogResult.No) {
          return false;
        }

        if (PatientController.Instance.Disable(modelSelected.Id) < 0) {
          Application.Exit();
          return false;
        }
        return true;
      }
    }
  }
}
