using PMSXApplication.Pattern.Base;
using System.Data;

namespace PMSXApplication.App.Model {
  internal class MacroGroup : ModelBase {
    public MacroGroup(DataRow row) : base(row, "macroGroup") {
      Code = row["macroGroup_code"].ToString();
      Name = row["macroGroup_name"].ToString();
    }

    public string Code { get; }
    public string Name { get; }
  }
}