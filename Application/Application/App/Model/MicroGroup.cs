using PMSXApplication.Pattern.Base;
using System.Data;

namespace PMSXApplication.App.Model {
  internal class MicroGroup : ModelBase {
    public MicroGroup(DataRow row) : base(row, "microGroup") {
      Code = row["microGroup_code"].ToString();
      Name = row["microGroup_name"].ToString();
    }

    public string Code { get; }
    public string Name { get; }
  }
}