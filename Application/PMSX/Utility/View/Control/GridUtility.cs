using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMSX.Pattern.Base;
using System;
using System.Collections.Generic;

namespace PMSX.Utility.View.Control {
  internal class GridUtility : SingletonBase<GridUtility> {
    private readonly Dictionary<string, string> caption;

    private GridUtility() {
      caption = new Dictionary<string, string>() {
        //{ "", "" },
        { "Id", "ID" },
        { "Comment", "Chú thích" },
        { "State", "Trạng thái" },
        { "CreateStaffId", "ID nhân viên tạo" },
        { "CreateStaffName", "Tên nhân viên tạo" },
        { "CreateDateTime", "Ngày tạo" },
        { "UpdateStaffId", "ID nhân viên sửa" },
        { "UpdateStaffName", "Tên nhân viên sửa" },
        { "UpdateDateTime", "Ngày sửa" },
        { "Username", "Tên đăng nhập" },
        { "Password", "Mật khẩu" },
        { "Name", "Tên" },
        { "Date", "Ngày" },
        { "DoctorId", "ID bác sĩ" },
        { "DoctorName", "Tên bác sĩ" },
        { "TechnicianId", "ID Kỹ thuật viên" },
        { "TechnicianName", "Tên Kỹ thuật viên" },
        { "StaffId", "Id nhân viên" },
        { "StaffName", "Tên nhân viên" },
        { "RoleId", "ID quyền" },
        { "RoleName", "Tên quyền" },
        { "Year", "Năm" },
        { "Total", "Tổng số" },
      };
    }

    public void LoadData<Model>(GridControl gridControl, GridView gridView, List<Model> dataSource, string[] visibledColumns) where Model : ModelBase {
      gridControl.DataSource = dataSource;
      gridView.PopulateColumns();

      foreach (GridColumn column in gridView.Columns) {
        column.Caption = caption[column.FieldName];
        column.VisibleIndex = Array.IndexOf(visibledColumns, column.FieldName);
      }

      gridView.BestFitColumns();
    }

    private void LoadData<Model>(LookUpEdit lookUpEdit, List<Model> dataSource, string[] visibledColumns, string valueColumn, string displayColumn) where Model : ModelBase {
      visibledColumns.ForEach(visibledColumn => {
        lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo(visibledColumn, caption[visibledColumn]));
      });

      lookUpEdit.Properties.DataSource = dataSource;
      lookUpEdit.Properties.ValueMember = valueColumn;
      lookUpEdit.Properties.DisplayMember = displayColumn;
      lookUpEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

      lookUpEdit.Properties.BestFit();
    }

    public void LoadData<Model>(LookUpEdit lookUpEdit, List<Model> dataSource, string[] visibledColumns, string valueColumn, string displayColumn, int selectedIndex = 0) where Model : ModelBase {
      LoadData(lookUpEdit, dataSource, visibledColumns, valueColumn, displayColumn);
      lookUpEdit.ItemIndex = selectedIndex;
    }

    public void LoadData<Model>(LookUpEdit lookUpEdit, List<Model> dataSource, string[] visibledColumns, string valueColumn, string displayColumn, object selectedValue) where Model : ModelBase {
      LoadData(lookUpEdit, dataSource, visibledColumns, valueColumn, displayColumn);
      lookUpEdit.EditValue = selectedValue;
    }

    public ModelBase GetSelected(GridView gridView) {
      int[] selectedIndex = gridView.GetSelectedRows();
      return selectedIndex.Length == 0 ? null : (ModelBase)gridView.GetRow(gridView.GetSelectedRows()[0]);
    }

    public ModelBase GetSelected(LookUpEdit lookUpEdit) {
      object selected = lookUpEdit.GetSelectedDataRow();
      return selected == null ? null : (ModelBase)selected;
    }
  }
}
