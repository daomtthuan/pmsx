using PMSXApplication.Pattern.Base;
using System.Data;

namespace PMSXApplication.App.Model {
  internal class Micro : ModelBase {
    public Micro(DataRow row) : base(row, "micro") {
      Code = row["micro_code"].ToString();
      Description = row["micro_description"].ToString();
      Conclusion = row["micro_conclusion"].ToString();
      MicroGroupId = (long)row["micro_microGroupId"];
    }

    public string Code { get; }
    public string Description { get; }
    public string Conclusion { get; }
    public long MicroGroupId { get; }
  }
}