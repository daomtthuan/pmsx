using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using System.Linq;

namespace PMSX.Utils.View {
  internal class Grid : Pattern.Class.Singleton<Grid>, Pattern.Interface.IUtil {
    private Grid() { }

    public void Load(GridControl gridControl, GridView gridView, IList models, string[] visibledFieldNames) {
      gridControl.DataSource = models;
      gridView.PopulateColumns();

      foreach (GridColumn column in gridView.Columns) {
        column.Caption = Locale.Instance.Caption[column.FieldName];
        column.Visible = visibledFieldNames.Contains(column.FieldName);
      }
    }

    public void Load(LookUpEdit select, IList models, string[] visibledFieldNames, string valueFieldName, string displayFieldNames, int selectIndex = 1) {
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

    public void Load(LookUpEdit select, IList models, string[] visibledFieldNames, string valueFieldName, string displayFieldNames, object selectValue) {
      select.Properties.DataSource = models;
      select.Properties.PopulateColumns();

      foreach (LookUpColumnInfo column in select.Properties.Columns) {
        column.Caption = Locale.Instance.Caption[column.FieldName];
        column.Visible = visibledFieldNames.Contains(column.FieldName);
      }

      select.Properties.ValueMember = valueFieldName;
      select.Properties.DisplayMember = displayFieldNames;

      select.EditValue = selectValue;
    }
  }
}
