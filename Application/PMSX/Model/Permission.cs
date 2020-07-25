using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Permission
  /// </summary>
  internal class Permission : Util.Pattern.Model {

    /// <summary>
    /// Create Permission
    /// </summary>
    /// <param name="row">Data row</param>
    public Permission(DataRow row) {
      Id = (long)row["permission_id"];
      StaffId = (long)row["permission_staffId"];
      RoleId = (long)row["permission_roleId"];

      Comment = row["permission_comment"].ToString();
      state = (int)row["permission_state"];

      CreateStaffId = (long)row["permission_createStaffId"];
      CreateDatetime = row["permission_createDatetime"].ToString();

      UpdateStaffId = (long)row["permission_updateStaffId"];
      UpdateDatetime = row["permission_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Staff Id
    /// </summary>
    public long StaffId { get; private set; }

    /// <summary>
    /// Get and set Role Id
    /// </summary>
    public long RoleId { get; private set; }
  }
}