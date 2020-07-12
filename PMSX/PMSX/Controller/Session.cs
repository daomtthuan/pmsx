using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Session {
    private static Session instance;

    private Session() { }

    public static Session Instance {
      get {
        if (instance == null)
          instance = new Session();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.Session> SelectAll(int state = -1) {
      List<Model.Session> sessions = new List<Model.Session>();

      string query = @"
        select *
        from pmsx_session
        where
          (@state = -1 or session_state = @state)
        order by session_name desc
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        sessions.Add(new Model.Session(row));
      }

      return sessions;
    }

    public List<Model.Session> SelectById(string id, int state = -1) {
      List<Model.Session> sessions = new List<Model.Session>();

      string query = @"
        select *
        from pmsx_session
        where                    
          (@state = -1 or session_state = @state) and
          session_id = @id
        order by session_name desc
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        sessions.Add(new Model.Session(row));
      }

      return sessions;
    }

    public List<Model.Session> SelectByName(DateTime name, int state = -1) {
      List<Model.Session> sessions = new List<Model.Session>();

      string query = @"
        select *
        from pmsx_session
        where                    
          (@state = -1 or session_state = @state) and
          convert(date, session_name) = convert(date, @name)
        order by session_name desc
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@name", name),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        sessions.Add(new Model.Session(row));
      }

      return sessions;
    }

    public bool Insert(DateTime name, string technicianId, string doctorId, string comment) {
      if (SelectByName(name).Count > 0) {
        return false;
      }

      string query = @"
        insert into pmsx_session(
          session_name,
          session_technicianId,
          session_doctorId,
          session_comment,
          session_createStaffId
        ) values(
          convert(date, @name),
          @technicianId,
          @doctorId,
          @comment,
          @createStaffId
        )
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@name", name),
        new SqlParameter("@technicianId", technicianId),
        new SqlParameter("@doctorId", doctorId),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }
  }
}
