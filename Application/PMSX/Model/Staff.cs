using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Staff
  /// </summary>
  internal class Staff : Util.Pattern.Model {

    /// <summary>
    /// Create Staff
    /// </summary>
    /// <param name="row">Data row</param>
    public Staff(DataRow row) {
      Id = (long)row["staff_id"];
      Username = row["staff_username"].ToString();
      Password = row["staff_password"].ToString();
      Name = row["staff_name"].ToString();

      Comment = row["staff_comment"].ToString();
      state = (int)row["staff_state"];

      CreateStaffId = (long)row["staff_createStaffId"];
      CreateDatetime = row["staff_createDatetime"].ToString();

      UpdateStaffId = (long)row["staff_updateStaffId"];
      UpdateDatetime = row["staff_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Username
    /// </summary>
    public string Username { get; private set; }

    /// <summary>
    /// Get and set Password
    /// </summary>
    public string Password { get; private set; }

    /// <summary>
    /// Get and set Name
    /// </summary>
    public string Name { get; private set; }
  }
}