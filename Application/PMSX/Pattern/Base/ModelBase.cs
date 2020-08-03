using System;
using System.Data;

namespace PMSX.Pattern.Base {
  internal abstract class ModelBase {
    private readonly int state;

    protected ModelBase(DataRow row, string prefix) {
      Id = (long)row[$"{prefix}_id"];

      if (row.Table.Columns.Contains($"{prefix}_comment")) {
        object value = row[$"{prefix}_comment"];
        if (value != DBNull.Value) {
          Comment = value.ToString();
        }
      }

      if (row.Table.Columns.Contains($"{prefix}_state")) {
        state = (int)row[$"{prefix}_state"];
        State = state == 1 ? "Kích hoạt" : "Vô hiệu hoá";
      } else {
        state = -1;
      }

      if (row.Table.Columns.Contains($"{prefix}_createStaffId")) {
        CreateStaffId = (long)row[$"{prefix}_createStaffId"];
        CreateStaffName = row[$"{prefix}_createStaffName"].ToString();
        CreateDateTime = row[$"{prefix}_createDateTime"].ToString();
      }

      if (row.Table.Columns.Contains($"{prefix}_updateStaffId")) {
        object value = row[$"{prefix}_updateStaffId"];
        if (value != DBNull.Value) {
          UpdateStaffId = (long)value;
          UpdateStaffName = row[$"{prefix}_updateStaffName"].ToString();
          UpdateDateTime = row[$"{prefix}_updateDateTime"].ToString();
        }
      }
    }

    public long Id { get; }
    public string Comment { get; }
    public string State { get; }
    public long CreateStaffId { get; }
    public string CreateStaffName { get; }
    public string CreateDateTime { get; }
    public long UpdateStaffId { get; }
    public string UpdateStaffName { get; }
    public string UpdateDateTime { get; }

    public int GetStateNumber() {
      return state;
    }
  }
}
