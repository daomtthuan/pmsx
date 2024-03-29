﻿using DevExpress.XtraGrid;
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
  internal class SessionTable : TableControl {
    public SessionTable() { }

    protected override void EventLoad(GridControl grid, GridView view) {
      Name = "SessionTable";

      List<Session> sessions = SessionController.Instance.Get();
      if (sessions == null) {
        Application.Exit();
        return;
      }
      GridUtility.Instance.LoadData(grid, view, sessions, new[] { "Id", "Date", "DoctorName", "TechnicianName", "State", "Comment", "CreateDateTime", "UpdateDateTime" });
    }

    protected override DialogResult EventAddButtonClick() {
      return FormFactory<AddSessionForm>.Instance.Create().ShowDialog();
    }

    protected override DialogResult EventEditButtonClick(object modelSelected) {
      EditSessionForm editForm = FormFactory<EditSessionForm>.Instance.Create();
      editForm.Tag = modelSelected;
      return editForm.ShowDialog();
    }

    protected override bool EventDisableButtonClick(ModelBase modelSelected) {
      if (AlertUtility.Instance.ShowConfirm("Vô hiệu hoá phiên làm việc này?") == DialogResult.No) {
        return false;
      }

      bool isFalse = false;
      OverlayUtility.Instance.StartProcess(this, () => {
        isFalse = SessionController.Instance.Disable(modelSelected.Id) < 0;
        if (isFalse) {
          Application.Exit();
        }
      });
      return !isFalse;
    }
  }
}
