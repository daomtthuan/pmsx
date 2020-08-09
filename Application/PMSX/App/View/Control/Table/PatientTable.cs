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
      GridUtility.Instance.LoadData(grid, view, patients, new[] { "Id", "Code", "Name", "YearsOld", "Address", "CreateDateTime", "UpdateDateTime" });
    }

    protected override DialogResult EventAddButtonClick(object selected) {
      throw new System.NotImplementedException();
    }

    protected override DialogResult EventEditButtonClick(ModelBase modelSelected) {
      throw new System.NotImplementedException();
    }

    protected override bool EventDisableButtonClick(ModelBase modelSelected) {
      throw new System.NotImplementedException();
    }
  }
}
