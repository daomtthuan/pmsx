using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;

namespace PMSX.View.Layout {
  internal abstract partial class Table : Pattern.Class.UserControl {
    public Table() {
      InitializeComponent();
      OnInit();
    }

    protected GridControl GridControl => gridControl;
    protected GridView GridView => gridView;
    protected SimpleLabelItem TitleLabel => titleLabel;

    protected virtual void OnInit() { }

    protected virtual void OnLoad() { }

    protected abstract void OnInsert();

    protected abstract void OnUpdate();

    protected abstract void OnDisabled();

    protected virtual void OnDetails() {
      Utils.View.MessageBox.Instance.Information("Sẽ có vào phiên bản kế tiếp");
    }

    private void View_Load(object sender, EventArgs e) {
      OnLoad();
    }

    private void DetailsButton_Click(object sender, EventArgs e) {
      OnDetails();
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
