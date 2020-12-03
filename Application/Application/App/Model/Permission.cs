using PMSXApplication.Pattern.Base;
using System.Data;

namespace PMSXApplication.App.Model {
  internal class Permission : ModelBase {
    public Permission(DataRow row) : base(row, "permission") {
      StaffId = (long)row["permission_staffId"];
      StaffName = row["permission_staffName"].ToString();
      RoleId = (long)row["permission_roleId"];
      RoleName = row["permission_roleName"].ToString();
    }

    public long StaffId { get; }
    public string StaffName { get; }
    public long RoleId { get; }
    public string RoleName { get; }
  }
}