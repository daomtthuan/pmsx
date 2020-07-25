using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// MIcro
  /// </summary>
  internal class MIcro : Util.Pattern.Model {

    /// <summary>
    /// Create MIcro
    /// </summary>
    /// <param name="row">Data row</param>
    public MIcro(DataRow row) {
      Id = (long)row["micro_id"];
      Code = row["micro_code"].ToString();
      Description = row["micro_description"].ToString();
      Conclusion = row["micro_conclusion"].ToString();
      MIcroGroupId = (long)row["micro_macroGroupId"];

      Comment = row["micro_comment"].ToString();
      state = (int)row["micro_state"];

      CreateStaffId = (long)row["micro_createStaffId"];
      CreateDatetime = row["micro_createDatetime"].ToString();

      UpdateStaffId = (long)row["micro_updateStaffId"];
      UpdateDatetime = row["micro_updateDatetime"].ToString();
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
    /// Get and set Conclusion
    /// </summary>
    public string Conclusion { get; private set; }

    /// <summary>
    /// Get and set MIcroGroupId
    /// </summary>
    public long MIcroGroupId { get; private set; }
  }
}