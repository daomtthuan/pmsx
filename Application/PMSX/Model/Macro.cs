using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Macro
  /// </summary>
  internal class Macro : Util.Pattern.Model {

    /// <summary>
    /// Create Macro
    /// </summary>
    /// <param name="row">Data row</param>
    public Macro(DataRow row) {
      Id = (long)row["macro_id"];
      Code = row["macro_code"].ToString();
      Description = row["macro_description"].ToString();
      MacroGroupId = (long)row["macro_macroGroupId"];

      Comment = row["macro_comment"].ToString();
      state = (int)row["macro_state"];

      CreateStaffId = (long)row["macro_createStaffId"];
      CreateDatetime = row["macro_createDatetime"].ToString();

      UpdateStaffId = (long)row["macro_updateStaffId"];
      UpdateDatetime = row["macro_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Code
    /// </summary>
    public string Code { get; private set; }

    /// <summary>
    /// Get and set Description
    /// </summary>
    public string Description { get; private set; }

    /// <summary>
    /// Get and set MacroGroupId
    /// </summary>
    public long MacroGroupId { get; private set; }
  }
}