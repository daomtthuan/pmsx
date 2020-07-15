using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace PMSX.Utils.View {
  public class Grid {
    private static Grid instance;

    private Grid() { }

    public static Grid Instance {
      get {
        if (instance == null)
          instance = new Grid();
        return instance;
      }
      private set => instance = value;
    }

    public void Load(GridControl gridControl, GridView gridView, object models, string[] visibledFieldNames) {
      gridControl.DataSource = models;
      gridView.PopulateColumns();

      foreach (GridColumn column in gridView.Columns) {
        column.Caption = Locale.Instance.Caption[column.FieldName];
        column.Visible = visibledFieldNames.Contains(column.FieldName);
      }
    }

    public void Load(LookUpEdit select, object models, string[] visibledFieldNames, string valueFieldName, string displayFieldNames, int selectIndex = 0) {
      select.Properties.DataSource = models;
      select.Properties.PopulateColumns();

      foreach (LookUpColumnInfo column in select.Properties.Columns) {
        column.Caption = Locale.Instance.Caption[column.FieldName];
        column.Visible = visibledFieldNames.Contains(column.FieldName);
      }

      select.Properties.ValueMember = valueFieldName;
      select.Properties.DisplayMember = displayFieldNames;

      select.ItemIndex = selectIndex;
    }

    public void Load(LookUpEdit select, object models, string[] visibledFieldNames, string valueFieldName, string displayFieldNames, object editValue) {
      select.Properties.DataSource = models;
      select.Properties.PopulateColumns();

      foreach (LookUpColumnInfo column in select.Properties.Columns) {
        column.Caption = Locale.Instance.Caption[column.FieldName];
        column.Visible = visibledFieldNames.Contains(column.FieldName);
      }

      select.Properties.ValueMember = valueFieldName;
      select.Properties.DisplayMember = displayFieldNames;

      select.EditValue = editValue;
    }
  }
}
