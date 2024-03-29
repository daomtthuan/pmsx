﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Control {
  internal abstract partial class TableWithSelectControl : XtraUserControl {
    private bool isFirstLoading;

    protected TableWithSelectControl() {
      InitializeComponent();
      isFirstLoading = true;
    }

    protected abstract void EventLoad(LookUpEdit selectControl);
    protected abstract void EventSelectChanged(GridControl grid, GridView view, object selected);
    protected abstract DialogResult EventAddButtonClick(object selected);
    protected abstract DialogResult EventEditButtonClick(object selected, ModelBase modelSelected);
    protected abstract bool EventDisableButtonClick(object selected, ModelBase modelSelected);

    protected void TableWithGroupControl_Load(object sender, EventArgs e) {
      EventLoad(selectControl);
    }

    private void GroupSelect_EditValueChanged(object sender, EventArgs e) {
      if (isFirstLoading) {
        EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(selectControl));
        isFirstLoading = false;
      } else {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(selectControl)));
      }
    }

    protected void AddButton_Click(object sender, EventArgs e) {
      if (EventAddButtonClick(GridUtility.Instance.GetSelected(selectControl)) == DialogResult.OK) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => {
          int index = selectControl.ItemIndex;
          EventLoad(selectControl);
          if (index == selectControl.ItemIndex) {
            EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(selectControl));
          } else {
            selectControl.ItemIndex = index;
          }
        });
      }
    }

    protected void EditButton_Click(object sender, EventArgs e) {
      if (EventEditButtonClick(GridUtility.Instance.GetSelected(selectControl), GridUtility.Instance.GetSelected(tableView)) == DialogResult.OK) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(selectControl)));
      }
    }

    protected void DisableButton_Click(object sender, EventArgs e) {
      if (EventDisableButtonClick(GridUtility.Instance.GetSelected(selectControl), GridUtility.Instance.GetSelected(tableView))) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(selectControl)));
      }
    }
  }
}
