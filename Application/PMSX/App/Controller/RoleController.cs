using MySql.Data.MySqlClient;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using System.Collections.Generic;
using System.Data;

namespace PMSX.App.Controller {
  internal class RoleController : SingletonBase<RoleController> {
    private RoleController() { }

    public List<Role> Get(int state = -1) {
      string query = @"
        select *
        from view_role
        where
          (@state = -1 or role_state = @state)";

      DataTable data = Database.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state));

      List<Role> roles = new List<Role>();
      foreach (DataRow row in data.Rows) {
        roles.Add(new Role(row));
      }

      return roles;
    }
  }
}
