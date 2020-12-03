using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Utility.View;
using System;
using System.Windows.Forms;

namespace PMSXApplication.App.View.Control {
  internal abstract partial class TableControl : XtraUserControl {
    public TableControl() {
      InitializeComponent();
    }

    protected abstract void EventLoad(GridControl grid, GridView view);
    protected abstract DialogResult EventAddButtonClick();
    protected abstract DialogResult EventEditButtonClick(object modelSelected);
    protected abstract bool EventDisableButtonClick(ModelBase modelSelected);

    protected void TableControl_Load(object sender, EventArgs e) {
      EventLoad(tableGrid, tableView);
    }

    protected void AddButton_Click(object sender, EventArgs e) {
      if (EventAddButtonClick() == DialogResult.OK) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventLoad(tableGrid, tableView));
      }
    }

    protected void EditButton_Click(object sender, EventArgs e) {
      if (EventEditButtonClick(GridUtility.Instance.GetSelected(tableView)) == DialogResult.OK) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventLoad(tableGrid, tableView));
      }
    }

    protected void DisableButton_Click(object sender, EventArgs e) {
      if (EventDisableButtonClick(GridUtility.Instance.GetSelected(tableView))) {
        OverlayUtility.Instance.StartProcess(Parent.Parent, () => EventLoad(tableGrid, tableView));
      }
    }
  }
}
