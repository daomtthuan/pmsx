using MySqlConnector;
using PMSXApplication.App.Model;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Utility;
using System;
using System.Collections.Generic;
using System.Data;

namespace PMSXApplication.App.Controller {
  internal class PermissionController : SingletonBase<PermissionController> {
    private PermissionController() { }

    public List<Permission> GetByStaff(long staffId, int state = -1) {
      string query = @"
        select *
        from view_permission
        where
          (@state = -1 or permission_state = @state) and
          permission_staffId = @staffId";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@staffId", staffId));
      if (data == null) {
        return null;
      }

      List<Permission> permissions = new List<Permission>();
      foreach (DataRow row in data.Rows) {
        permissions.Add(new Permission(row));
      }

      return permissions;
    }

    public List<Permission> GetByRoleName(string name, int state = -1) {
      string query = @"
        select *
        from view_permission
        where
          (@state = -1 or permission_state = @state) and
          permission_roleName = @roleName";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@roleName", name));
      if (data == null) {
        return null;
      }

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

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@roleName", Authentication.Instance.GetRoleName(role)));
      if (data == null) {
        return null;
      }

      List<Permission> permissions = new List<Permission>();
      foreach (DataRow row in data.Rows) {
        permissions.Add(new Permission(row));
      }

      return permissions;
    }

    public int Add(long staffId, long roleId, string comment) {
      string query = @"
        insert into table_permission(
          permission_staffId,
          permission_roleId,
          permission_comment,
          permission_createStaffId
        ) values(
          @staffId,
          @roleId,
          @comment,
          @createStaffId
        )";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@staffId", staffId),
        new MySqlParameter("@roleId", roleId),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@createStaffId", Authentication.Instance.Staff.Id));
    }

    public int Edit(long id, int state, string comment) {
      string query = @"
        update table_permission
        set
          permission_state = @state,
          permission_comment = @comment,
          permission_updateStaffId = @updateStaffId,
          permission_updateDateTime = now()
        where permission_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@state", state),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }

    public int Disable(long id) {
      string query = @"
        update table_permission
        set
          permission_state = 0,
          permission_updateStaffId = @updateStaffId,
          permission_updateDateTime = now()
        where permission_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }
  }
}
