using PMSX.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Role {
    private static Role instance;

    private Role() { }

    public static Role Instance {
      get {
        if (instance == null)
          instance = new Role();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.Role> SelectAll(int state = -1) {
      List<Model.Role> data = new List<Model.Role>();

      string query = @"
                select *
                from pmsx_role
                where
                    (@state = -1 or role_state = @state)
				order by role_name
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@state", state)
            };


      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Role(row));
      }

      return data;
    }

    public List<Model.Role> SelectById(string id, int state = -1) {
      List<Model.Role> data = new List<Model.Role>();

      string query = @"
                select *
                from pmsx_role
                where
                    (@state = -1 or role_state = @state) and
                    role_id = @id
				order by role_name
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@state", state)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Role(row));
      }

      return data;
    }

    public List<Model.Role> SelectByName(string name, int state = -1) {
      List<Model.Role> data = new List<Model.Role>();

      string query = @"
                select *
                from pmsx_role
                where
                    (@state = -1 or role_state = @state) and
                    role_name = @name
				order by role_name
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@name", name),
                new SqlParameter("@state", state)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Role(row));
      }

      return data;
    }

    public List<Model.Role> SelectByStaffId(string id, int state = -1) {
      List<Model.Role> data = new List<Model.Role>();

      string query = @"
                select pmsx_role.*
                from pmsx_role
					join pmsx_permission on role_id = permission_roleId
				where
                    (@state = -1 or role_state = @state) and
                    permission_staffId = @id
				order by role_name
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@state", state)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Role(row));
      }

      return data;
    }

    public bool Insert(string name, string comment) {
      if (SelectByName(name).Count > 0) {
        return false;
      }

      string query = @"
                insert into pmsx_role(
                    role_name,
                    role_comment,
                    role_createStaffId
                ) values(
                    @name,
                    @comment,
                    @createStaffId
                )
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@name", name),
                comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
                new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
            };

      Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public bool Update(string id, string name, string comment, int state) {
      List<Model.Role> role = SelectByName(name);
      if (role.Count > 0) {
        if (role[0].Id != id) {
          return false;
        }
      }

      string query = @"
                update pmsx_role
                set 
	                role_name = @name,
	                role_comment = @comment,
                    role_state = @state,
                    role_updateStaffId = @updateStaffId,
	                role_updateDatetime = getdate()                   
                where role_id = @id
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name),
                comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
                new SqlParameter("@state", state),
                new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
            };

      Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public void Disabled(string id) {
      string query = @"
                update pmsx_role
                set
                    role_state = 0,
                    role_updateStaffId = @updateStaffId,
	                role_updateDatetime = getdate()  
                where role_id = @id
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
            };

      Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
