using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.Pattern.Base;
using PMSX.Utility.View.Control;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Control {
  internal abstract partial class TableControl : XtraUserControl {
    public TableControl() {
      InitializeComponent();
    }

    protected abstract void EventLoad(GridControl grid, GridView view);
    protected abstract DialogResult EventAddButtonClick();
    protected abstract DialogResult EventEditButtonClick(ModelBase modelSelected);
    protected abstract bool EventDisableButtonClick(ModelBase modelSelected);

    protected void TableControl_Load(object sender, EventArgs e) {
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
  }
}
