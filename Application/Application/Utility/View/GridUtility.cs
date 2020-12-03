using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using PMSXApplication.Pattern.Base;
using System;
using System.Collections.Generic;

namespace PMSXApplication.Utility.View {
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
        { "YearsOld", "Tuổi" },
        { "Total", "Tổng số" },
        { "GroupId", "ID nhóm" },
        { "Code", "Mã số" },
        { "Address", "Địa chỉ" },
        { "Year", "Năm" },
        { "Description", "Mô tả" },
        { "MacroGroupId", "ID nhóm đại thể" },
        { "MicroGroupId", "ID nhóm vi thể" },
        { "Conclusion", "Kết luận" },
      };
    }

    public void LoadData<Model>(GridControl grid, GridView view, List<Model> data, string[] visibledColumns) where Model : ModelBase {
      grid.DataSource = data;
      view.PopulateColumns();

      foreach (GridColumn column in view.Columns) {
        column.Caption = caption[column.FieldName];
        column.VisibleIndex = Array.IndexOf(visibledColumns, column.FieldName);
      }

      view.BestFitColumns();
    }

    public void LoadData(LookUpEdit select, string[] data, int selectedIndex = 0) {
      select.Properties.DataSource = data;
      select.ItemIndex = selectedIndex;
    }

    private void LoadData<Model>(LookUpEdit select, List<Model> data, string[] visibledColumns, string valueColumn, string displayColumn) where Model : ModelBase {
      select.Properties.Columns.Clear();
      visibledColumns.ForEach(visibledColumn => {
        select.Properties.Columns.Add(new LookUpColumnInfo(visibledColumn, caption[visibledColumn]));
      });

      select.Properties.DataSource = data;
      select.Properties.ValueMember = valueColumn;
      select.Properties.DisplayMember = displayColumn;
      select.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

      select.Properties.BestFit();
    }

    public void LoadData<Model>(LookUpEdit select, List<Model> data, string[] visibledColumns, string valueColumn, string displayColumn, int selectedIndex = 0) where Model : ModelBase {
      LoadData(select, data, visibledColumns, valueColumn, displayColumn);
      select.ItemIndex = selectedIndex;
    }

    public void LoadData<Model>(LookUpEdit select, List<Model> data, string[] visibledColumns, string valueColumn, string displayColumn, object selectedValue) where Model : ModelBase {
      LoadData(select, data, visibledColumns, valueColumn, displayColumn);
      select.EditValue = selectedValue;
    }

    public ModelBase GetSelected(GridView view) {
      int[] selectedIndex = view.GetSelectedRows();
      return selectedIndex.Length == 0 ? null : (ModelBase)view.GetRow(view.GetSelectedRows()[0]);
    }

    public object GetSelected(LookUpEdit select) {
      return select.GetSelectedDataRow();
    }
  }
}
