using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// MacroGroup
  /// </summary>
  internal class MacroGroup : Util.Pattern.Model {

    /// <summary>
    /// Create MacroGroup
    /// </summary>
    /// <param name="row">Data row</param>
    public MacroGroup(DataRow row) {
      Id = (long)row["macroGroup_id"];
      Code = row["macroGroup_code"].ToString();
      Name = row["macroGroup_name"].ToString();

      Comment = row["macroGroup_comment"].ToString();
      state = (int)row["macroGroup_state"];

      CreateStaffId = (long)row["macroGroup_createStaffId"];
      CreateDatetime = row["macroGroup_createDatetime"].ToString();

      UpdateStaffId = (long)row["macroGroup_updateStaffId"];
      UpdateDatetime = row["macroGroup_updateDatetime"].ToString();
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