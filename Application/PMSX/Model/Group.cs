using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Group
  /// </summary>
  internal class Group : Util.Pattern.Model {

    /// <summary>
    /// Create Group
    /// </summary>
    /// <param name="row">Data row</param>
    public Group(DataRow row) {
      Id = (long)row["group_id"];
      Year = (int)row["group_year"];
      Total = (long)row["group_total"];
    }

    /// <summary>
    /// Get and set Year
    /// </summary>
    public int Year { get; private set; }

    /// <summary>
    /// Get and set Total
    /// </summary>
    public long Total { get; private set; }
  }
}