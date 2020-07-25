using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// MicroGroup
  /// </summary>
  internal class MicroGroup : Util.Pattern.Model {

    /// <summary>
    /// Create MicroGroup
    /// </summary>
    /// <param name="row">Data row</param>
    public MicroGroup(DataRow row) {
      Id = (long)row["microGroup_id"];
      Code = row["microGroup_code"].ToString();
      Name = row["microGroup_name"].ToString();

      Comment = row["microGroup_comment"].ToString();
      state = (int)row["microGroup_state"];

      CreateStaffId = (long)row["microGroup_createStaffId"];
      CreateDatetime = row["microGroup_createDatetime"].ToString();

      UpdateStaffId = (long)row["microGroup_updateStaffId"];
      UpdateDatetime = row["microGroup_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Code
    /// </summary>
    public string Code { get; private set; }

    /// <summary>
    /// Get and set Name
    /// </summary>
    public string Name { get; private set; }
  }
}