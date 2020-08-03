using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.App.Controller;
using PMSX.Pattern.Base;
using PMSX.Utility.View.Control;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Control {
  internal abstract partial class TableWithGroupControl : XtraUserControl {
    protected TableWithGroupControl() {
      InitializeComponent();
    }

    protected abstract void EventLoad(GridControl grid, GridView view);
    protected abstract DialogResult EventAddButtonClick();
    protected abstract DialogResult EventEditButtonClick(ModelBase modelSelected);
    protected abstract bool EventDisableButtonClick(ModelBase modelSelected);
    protected abstract void EventGroupSelectChanged(ModelBase selectedModel);

    protected void TableWithGroupControl_Load(object sender, EventArgs e) {
      GridUtility.Instance.LoadData(groupSelect, GroupController.Instance.Get(), new[] { "Name", "Year", "Total" }, "Id", "Name", Authentication.Instance.Group.Id);
      EventLoad(tableGrid, tableView);
    }

    protected void AddButton_Click(object sender, EventArgs e) {
      if (EventAddButtonClick() == DialogResult.OK) {
        EventLoad(tableGrid, tableView);
      }
    }

    protected void EditButton_Click(object sender, EventArgs e) {
      if (EventEditButtonClick(GridUtility.Instance.GetSelected(tableView)) == DialogResult.OK) {
        EventLoad(tableGrid, tableView);
      }
    }

    protected void DisableButton_Click(object sender, EventArgs e) {
      if (EventDisableButtonClick(GridUtility.Instance.GetSelected(tableView))) {
        EventLoad(tableGrid, tableView);
      }
    }

    private void GroupSelect_EditValueChanged(object sender, EventArgs e) {
      EventGroupSelectChanged(GridUtility.Instance.GetSelected(groupSelect));
    }
  }
}
