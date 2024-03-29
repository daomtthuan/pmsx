﻿using MySqlConnector;
using PMSXApplication.App.Model;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Utility;
using PMSXApplication.Utility.View;
using System;
using System.Collections.Generic;
using System.Data;

namespace PMSXApplication.App.Controller {
  internal class StaffController : SingletonBase<StaffController> {
    private StaffController() { }

    public List<Staff> Get(int state = -1) {
      string query = @"
        select *
        from view_staff
        where
          (@state = -1 or staff_state = @state)
      ";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state));
      if (data == null) {
        return null;
      }

      List<Staff> staffs = new List<Staff>();
      foreach (DataRow row in data.Rows) {
        staffs.Add(new Staff(row));
      }

      return staffs;
    }

    public List<Staff> GetById(long id, int state = -1) {
      string query = @"
        select *
        from view_staff
        where
          (@state = -1 or staff_state = @state) and
          staff_id = @id
      ";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@id", id));
      if (data == null) {
        return null;
      }

      List<Staff> staffs = new List<Staff>();
      foreach (DataRow row in data.Rows) {
        staffs.Add(new Staff(row));
      }

      return staffs;
    }

    public List<Staff> GetByUsername(string username, int state = -1) {
      string query = @"
        select *
        from view_staff
        where
          (@state = -1 or staff_state = @state) and
          staff_username = @username
      ";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@username", username));
      if (data == null) {
        return null;
      }

      List<Staff> staffs = new List<Staff>();
      foreach (DataRow row in data.Rows) {
        staffs.Add(new Staff(row));
      }

      return staffs;
    }

    public List<Staff> GetByNoRoleName(string name, int state = -1) {
      string query = @"
        select *
        from view_staff
        where
          (@state = -1 or staff_state = @state) and
          staff_id not in (
            select permission_staffId
            from view_permission
            where permission_roleName = @name
          )";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@name", name));
      if (data == null) {
        return null;
      }

      List<Staff> permissions = new List<Staff>();
      foreach (DataRow row in data.Rows) {
        permissions.Add(new Staff(row));
      }

      return permissions;
    }

    public int Add(string username, string password, string name, string comment) {
      string query = @"
        insert into table_staff(
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
        )";

      try {
        password = BCrypt.Net.BCrypt.HashPassword(password);
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Encode(exception));
        return -1;
      }

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@username", username),
        new MySqlParameter("@password", password),
        new MySqlParameter("@name", name),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@createStaffId", Authentication.Instance.Staff.Id));
    }

    public int Edit(long id, string password, string name, int state, string comment) {
      if (password == string.Empty) {
        string query = @"
          update table_staff
          set
            staff_name = @name,
            staff_state = @state,
            staff_comment = @comment,
            staff_updateStaffId = @updateStaffId,
            staff_updateDateTime = now()
          where staff_id = @id";

        return DatabaseUtility.Instance.ExecuteNonQuery(query,
          new MySqlParameter("@id", id),
          new MySqlParameter("@name", name),
          new MySqlParameter("@state", state),
          comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
          new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
      } else {
        string query = @"
          update table_staff
          set
            staff_password = @password,
            staff_name = @name,
            staff_state = @state,
            staff_comment = @comment,
            staff_updateStaffId = @updateStaffId,
            staff_updateDateTime = now()
          where staff_id = @id";

        try {
          password = BCrypt.Net.BCrypt.HashPassword(password);
        } catch (System.Exception exception) {
          AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Encode(exception));
          return -1;
        }

        return DatabaseUtility.Instance.ExecuteNonQuery(query,
          new MySqlParameter("@id", id),
          new MySqlParameter("@password", password),
          new MySqlParameter("@name", name),
          new MySqlParameter("@state", state),
          comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
          new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
      }
    }

    public int Edit(string password) {
      try {
        if (!BCrypt.Net.BCrypt.Verify(password, Authentication.Instance.Staff.Password)) {
          return 0;
        }
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Decode(exception));
        return -1;
      }

      string query = @"
        update table_staff
        set
          staff_password = @password,
          staff_updateStaffId = @updateStaffId,
          staff_updateDateTime = now()
        where staff_id = @id";

      try {
        password = BCrypt.Net.BCrypt.HashPassword(password);
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Encode(exception));
        return -1;
      }

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", Authentication.Instance.Staff.Id),
        new MySqlParameter("@password", password),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }

    public int Disable(long id) {
      string query = @"
        update table_staff
        set
          staff_state = 0,
          staff_updateStaffId = @updateStaffId,
          staff_updateDateTime = now()
        where staff_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }
  }
}
