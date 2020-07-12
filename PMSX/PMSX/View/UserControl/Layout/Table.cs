using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;

namespace PMSX.View.UserControl.Layout {
  public abstract partial class Table : XtraUserControl {
    public Table() {
      InitializeComponent();
      OnInit();
    }

    protected GridControl GridControl { get => gridControl; }
    protected GridView GridView { get => gridView; }
    protected SimpleLabelItem TitleLabel { get => titleLabel; }
    protected string SelectedId { get => GridView.GetRowCellValue(GridView.GetSelectedRows()[0], "Id").ToString(); }

    protected virtual void OnInit() { }

    protected virtual void OnLoad() { }

    protected abstract void OnInsert();

    protected abstract void OnUpdate();

    protected abstract void OnDisabled();

    protected virtual void RowStyle(RowStyleEventArgs e) { }

    private void DetailsButton_Click(object sender, EventArgs e) {
      Util.MessageBox.Instance.Info("Sẽ có vào phiên bản kế tiếp");
    }

    private void View_Load(object sender, EventArgs e) {
      OnLoad();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      OnInsert();
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      OnUpdate();
    }


    private void DisabledButton_Click(object sender, EventArgs e) {
      OnDisabled();
    }

    private void GridView_RowStyle(object sender, RowStyleEventArgs e) {
      RowStyle(e);
    }
  }
}
