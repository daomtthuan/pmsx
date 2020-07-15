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

    protected virtual void OnInit() { }

    protected virtual void OnLoad() { }

    protected abstract void OnInsert();

    protected abstract void OnUpdate();

    protected abstract void OnDisabled();

    protected object GetSelectedRow() {
      return GridView.GetRow(GridView.GetSelectedRows()[0]);
    }

    private void View_Load(object sender, EventArgs e) {
      OnLoad();
    }

    private void DetailsButton_Click(object sender, EventArgs e) {
      Utils.View.MessageBox.Instance.Information("Sẽ có vào phiên bản kế tiếp");
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
  }
}
