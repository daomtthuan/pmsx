using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.Pattern.Base;
using PMSX.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Control {
  internal abstract partial class TableWithSelectControl : XtraUserControl {
    private bool isFirstLoading;

    protected TableWithSelectControl() {
      InitializeComponent();
      isFirstLoading = true;
    }

    protected abstract void EventLoad(LookUpEdit select);
    protected abstract void EventSelectChanged(GridControl grid, GridView view, object selected);
    protected abstract DialogResult EventAddButtonClick(object selected);
    protected abstract DialogResult EventEditButtonClick(ModelBase modelSelected);
    protected abstract bool EventDisableButtonClick(ModelBase modelSelected);

    protected void TableWithGroupControl_Load(object sender, EventArgs e) {
      EventLoad(select);
    }

    private void GroupSelect_EditValueChanged(object sender, EventArgs e) {
      if (isFirstLoading) {
        EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(select));
        isFirstLoading = false;
      } else {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(select)));
      }
    }

    protected void AddButton_Click(object sender, EventArgs e) {
      if (EventAddButtonClick(GridUtility.Instance.GetSelected(select)) == DialogResult.OK) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(select)));
      }
    }

    protected void EditButton_Click(object sender, EventArgs e) {
      if (EventEditButtonClick(GridUtility.Instance.GetSelected(tableView)) == DialogResult.OK) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(select)));
      }
    }

    protected void DisableButton_Click(object sender, EventArgs e) {
      if (EventDisableButtonClick(GridUtility.Instance.GetSelected(tableView))) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventSelectChanged(tableGrid, tableView, GridUtility.Instance.GetSelected(select)));
      }
    }
  }
}
