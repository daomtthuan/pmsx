using MySql.Data.MySqlClient;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using PMSX.Utility;
using System;
using System.Collections.Generic;
using System.Data;

namespace PMSX.App.Controller {
  internal class SessionController : SingletonBase<SessionController> {
    private SessionController() { }

    public List<Session> Get(int state = -1) {
      string query = @"
        select *
        from view_session
        where
          (@state = -1 or session_state = @state)";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state));
      if (data == null) {
        return null;
      }

      List<Session> sessions = new List<Session>();
      foreach (DataRow row in data.Rows) {
        sessions.Add(new Session(row));
      }

      return sessions;
    }

    public List<Session> GetByDate(DateTime date) {
      string query = @"
        select *
        from view_session
        where session_date = convert(@date, date)";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@date", date));
      if (data == null) {
        return null;
      }

      List<Session> sessions = new List<Session>();
      foreach (DataRow row in data.Rows) {
        sessions.Add(new Session(row));
      }

      return sessions;
    }

    public int Add(DateTime date, long doctorId, long technicianId, string comment) {
      string query = @"
        insert into table_session(
          session_date,
          session_doctorId,
          session_technicianId,
          session_comment,
          session_createStaffId
        ) values(
          convert(@date, date),
          @doctorId,
          @technicianId,
          @comment,
          @createStaffId
        )";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@date", date),
        new MySqlParameter("@doctorId", doctorId),
        new MySqlParameter("@technicianId", technicianId),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@createStaffId", Authentication.Instance.Staff.Id));
    }

    public int Edit(long id, DateTime date, long doctorId, long technicianId, int state, string comment) {
      string query = @"
        update table_session
        set
          session_date = convert(@date, date),
          session_doctorId = @doctorId,
          session_technicianId = @technicianId,
          session_state = @state,
          session_comment = @comment,
          session_updateStaffId = @updateStaffId,
          session_updateDateTime = now()
        where session_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@date", date),
        new MySqlParameter("@doctorId", doctorId),
        new MySqlParameter("@technicianId", technicianId),
        new MySqlParameter("@state", state),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }

    public int Disable(long id) {
      string query = @"
        update table_session
        set
          session_state = 0,
          session_updateStaffId = @updateStaffId,
          session_updateDateTime = now()
        where session_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }
  }
}
