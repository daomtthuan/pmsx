using PMSX.Pattern.Base;
using System.Data;

namespace PMSX.App.Model {
  internal class Group : ModelBase {
    public Group(DataRow row) : base(row, "group") {
      Year = (int)row["group_year"];
      Total = (long)row["group_total"];
      Name = $"YCT{Year.ToString().Substring(2)}";
    }

    public string Name { get; }
    public int Year { get; }
    public long Total { get; }
  }
}