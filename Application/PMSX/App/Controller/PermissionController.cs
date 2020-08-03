using MySql.Data.MySqlClient;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using System.Collections.Generic;
using System.Data;

namespace PMSX.App.Controller {
  internal class PermissionController : SingletonBase<PermissionController> {
    private PermissionController() { }

    public List<Permission> GetByStaff(long staffId, int state = -1) {
      string query = @"
        select *
        from view_permission
        where
          (@state = -1 or permission_state = @state) and
          permission_staffId = @staffId";

      DataTable data = Database.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@staffId", staffId));

      List<Permission> permissions = new List<Permission>();
      foreach (DataRow row in data.Rows) {
        permissions.Add(new Permission(row));
      }

      return permissions;
    }

    public List<Permission> GetByRole(Authentication.Role role, int state = -1) {
      string query = @"
        select *
        from view_permission
        where
          (@state = -1 or permission_state = @state) and
          permission_roleName = @roleName";

      DataTable data = Database.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@roleName", Authentication.Instance.GetRoleName(role)));

      List<Permission> permissions = new List<Permission>();
      foreach (DataRow row in data.Rows) {
        permissions.Add(new Permission(row));
      }

      return permissions;
    }
  }
}
