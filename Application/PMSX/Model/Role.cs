using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Role
  /// </summary>
  internal class Role : Util.Pattern.Model {

    /// <summary>
    /// Create Role
    /// </summary>
    /// <param name="row">Data row</param>
    public Role(DataRow row) {
      Id = (long)row["role_id"];
      Name = row["role_name"].ToString();

      Comment = row["role_comment"].ToString();
      state = (int)row["role_state"];

      CreateStaffId = (long)row["role_createStaffId"];
      CreateDatetime = row["role_createDatetime"].ToString();

      UpdateStaffId = (long)row["role_updateStaffId"];
      UpdateDatetime = row["role_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Name
    /// </summary>
    public string Name { get; private set; }
  }
}