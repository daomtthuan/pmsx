using PMSX.Pattern.Base;
using System.Data;

namespace PMSX.App.Model {
  internal class Role : ModelBase {
    public Role(DataRow row) : base(row, "role") {
      Name = row["role_name"].ToString();
    }

    public string Name { get; }
  }
}