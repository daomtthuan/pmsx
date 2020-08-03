using PMSX.Pattern.Base;
using System.Data;

namespace PMSX.App.Model {
  internal class Macro : ModelBase {
    public Macro(DataRow row) : base(row, "macro") {
      Code = row["macro_code"].ToString();
      Description = row["macro_description"].ToString();
      MacroGroupId = (long)row["macro_macroGroupId"];
    }

    public string Code { get; }
    public string Description { get; }
    public long MacroGroupId { get; }
  }
}