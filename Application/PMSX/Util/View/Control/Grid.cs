using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.Util.Pattern;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PMSX.Util.View.Control {

  /// <summary>
  /// Util Grid
  /// </summary>
  internal class Grid : Singleton<Grid> {

    /// <summary>
    /// Caption columns
    /// </summary>
    private readonly Dictionary<string, string> caption;

    /// <summary>
    /// Create Grid Util
    /// </summary>
    private Grid() {
      caption = new Dictionary<string, string>() {
      };
    }

    /// <summary>
    /// Load data into GridView (GridControl wrapper)
    /// </summary>
    /// <param name="gridControl">Grid control</param>
    /// <param name="gridView">Grid view</param>
    /// <param name="dataSource">Data source</param>
    /// <param name="visibledColumns">Visibled columns FieldName</param>
    public void Load(GridControl gridControl, GridView gridView, IList dataSource, string[] visibledColumns) {
      gridControl.DataSource = dataSource;
      gridView.PopulateColumns();

      foreach (GridColumn column in gridView.Columns) {
        column.Caption = caption[column.FieldName];
        column.Visible = visibledColumns.Contains(column.FieldName);
      }
    }

    /// <summary>
    /// Load data into LookUpEdit
    /// </summary>
    /// <param name="lookUpEdit">LookUpEdit control</param>
    /// <param name="dataSource">Data source</param>
    /// <param name="visibledColumns">Visibled columns FieldName</param>
    /// <param name="valueColumn">Value member column FieldName</param>
    /// <param name="displayColumn">Display member column FieldName</param>
    /// <param name="selectedIndex">Selected index</param>
    public void Load(LookUpEdit lookUpEdit, IList dataSource, string[] visibledColumns, string valueColumn, string displayColumn, int selectedIndex = 0) {
      lookUpEdit.Properties.DataSource = dataSource;
      lookUpEdit.Properties.PopulateColumns();

      foreach (LookUpColumnInfo column in lookUpEdit.Properties.Columns) {
        column.Caption = caption[column.FieldName];
        column.Visible = visibledColumns.Contains(column.FieldName);
      }

      lookUpEdit.Properties.ValueMember = valueColumn;
      lookUpEdit.Properties.DisplayMember = displayColumn;

      lookUpEdit.ItemIndex = selectedIndex;
    }

    /// <summary>
    /// Load data into LookUpEdit
    /// </summary>
    /// <param name="lookUpEdit">LookUpEdit control</param>
    /// <param name="dataSource">Data source</param>
    /// <param name="visibledColumns">Visibled columns FieldName</param>
    /// <param name="valueColumn">Value member column FieldName</param>
    /// <param name="displayColumn">Display member column FieldName</param>
    /// <param name="selectedValue">Selected value</param>
    public void Load(LookUpEdit lookUpEdit, IList dataSource, string[] visibledColumns, string valueColumn, string displayColumn, object selectedValue) {
      lookUpEdit.Properties.DataSource = dataSource;
      lookUpEdit.Properties.PopulateColumns();

      foreach (LookUpColumnInfo column in lookUpEdit.Properties.Columns) {
        column.Caption = caption[column.FieldName];
        column.Visible = visibledColumns.Contains(column.FieldName);
      }

      lookUpEdit.Properties.ValueMember = valueColumn;
      lookUpEdit.Properties.DisplayMember = displayColumn;

      lookUpEdit.EditValue = selectedValue;
    }

    /// <summary>
    /// Get Selected Row of Grid view
    /// </summary>
    /// <param name="gridView">Grid view</param>
    /// <returns>Selected data</returns>
    public Pattern.Model GetSelected(GridView gridView) {
      int[] selectedIndex = gridView.GetSelectedRows();
      return selectedIndex.Length == 0 ? null : (Pattern.Model)gridView.GetRow(gridView.GetSelectedRows()[0]);
    }

    /// <summary>
    /// Get Selected Row of LookUpEdit control
    /// </summary>
    /// <param name="lookUpEdit">LookUpEdit control</param>
    /// <returns>Selected data</returns>
    public Pattern.Model GetSelected(LookUpEdit lookUpEdit) {
      object selected = lookUpEdit.GetSelectedDataRow();
      return selected == null ? null : (Pattern.Model)selected;
    }
  }
}
