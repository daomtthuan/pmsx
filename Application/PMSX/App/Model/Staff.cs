using PMSX.Pattern.Base;
using System.Data;

namespace PMSX.App.Model {
  internal class Staff : ModelBase {
    public Staff(DataRow row) : base(row, "staff") {
      Username = row["staff_username"].ToString();
      Password = row["staff_password"].ToString();
      Name = row["staff_name"].ToString();
    }

    public string Username { get; }
    public string Password { get; }
    public string Name { get; }
  }
}