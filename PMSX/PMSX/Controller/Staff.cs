using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  using BCrypt.Net;

  public class Staff {
    private static Staff instance;

    private Staff() { }

    public static Staff Instance {
      get {
        if (instance == null)
          instance = new Staff();
        return instance;
      }
      private set => instance = value;
    }

    public Model.Staff Auth(string username, string password) {
      List<Model.Staff> staffs = SelectByUsername(username);
      if (staffs.Count != 1) {
        return null;
      }

      if (!BCrypt.Verify(password, staffs[0].Password)) {
        return null;
      }

      return staffs[0];
    }

    public List<Model.Staff> SelectAll(int state = -1) {
      List<Model.Staff> staffs = new List<Model.Staff>();

      string query = @"
        select *
        from pmsx_staff
        where
          (@state = -1 or staff_state = @state)
        order by staff_name
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        staffs.Add(new Model.Staff(row));
      }

      return staffs;
    }

    public List<Model.Staff> SelectById(string id, int state = -1) {
      List<Model.Staff> staffs = new List<Model.Staff>();
      string query = @"
        select *
        from pmsx_staff
        where
          (@state = -1 or staff_state = @state) and
          staff_id = @id
        order by staff_name
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        staffs.Add(new Model.Staff(row));
      }

      return staffs;
    }

    public List<Model.Staff> SelectByUsername(string username, int state = -1) {
      List<Model.Staff> staffs = new List<Model.Staff>();

      string query = @"
        select *
        from pmsx_staff
        where
          (@state = -1 or staff_state = @state) and
          staff_username = @username
        order by staff_name
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@username", username),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        staffs.Add(new Model.Staff(row));
      }

      return staffs;
    }

    public List<Model.Staff> SelectByRoleId(string id, int state = -1) {
      List<Model.Staff> staffs = new List<Model.Staff>();

      string query = @"
        select pmsx_staff.*
        from pmsx_staff
          join pmsx_permission on staff_id = permission_staffId
        where
          (@state = -1 or staff_state = @state) and  
          permission_roleId = @id
        order by staff_name
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        staffs.Add(new Model.Staff(row));
      }

      return staffs;
    }

    public List<Model.Staff> SelectByNotRoleId(string id, int state = -1) {
      List<Model.Staff> staffs = new List<Model.Staff>();

      string query = @"
        select *
        from pmsx_staff
        where
          (@state = -1 or staff_state = @state) and
          staff_id not in (
	          select staff_id
	          from pmsx_staff
		          join pmsx_permission on staff_id = permission_staffId
	          where permission_roleId = @id				
          )
        order by staff_name
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        staffs.Add(new Model.Staff(row));
      }

      return staffs;
    }

    public bool Insert(string username, string password, string name, string comment) {
      if (SelectByUsername(username).Count > 0) {
        return false;
      }

      string query = @"
        insert into pmsx_staff(
          staff_username,
          staff_password,
          staff_name,
          staff_comment,
          staff_createStaffId
        ) values(
          @username,
          @password,
          @name,
          @comment,
          @createStaffId
        )
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@username", username),
        new SqlParameter("@password", BCrypt.HashPassword(password)),
        new SqlParameter("@name", name),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public bool InsertWithDefaultPassword(string username, string name, string comment) {
      return Insert(username, BCrypt.HashPassword("staff@pmxs"), name, comment);
    }

    public void Update(string id, string name, string comment, int state) {
      string query = @"
        update pmsx_staff
        set 
	        staff_name = @name,
	        staff_comment = @comment,
          staff_state = @state,
          staff_updateStaffId = @updateStaffId,
	        staff_updateDatetime = getdate()                    
        where staff_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@name", name),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_staff
        set
          staff_state = 0,
          staff_updateStaffId = @updateStaffId,
          staff_updateDatetime = getdate()  
        where staff_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
