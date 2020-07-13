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
        select
          pmsx_session.*,
          technician.staff_name as session_technicianName,
          doctor.staff_name as session_doctorName
        from pmsx_session
          join pmsx_staff as technician on session_technicianId = technician.staff_id
          join pmsx_staff as doctor on session_doctorId = doctor.staff_id
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
        select
          pmsx_session.*,
          technician.staff_name as session_technicianName,
          doctor.staff_name as session_doctorName
        from pmsx_session
          join pmsx_staff as technician on session_technicianId = technician.staff_id
          join pmsx_staff as doctor on session_doctorId = doctor.staff_id
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
        select
          pmsx_session.*,
          technician.staff_name as session_technicianName,
          doctor.staff_name as session_doctorName
        from pmsx_session
          join pmsx_staff as technician on session_technicianId = technician.staff_id
          join pmsx_staff as doctor on session_doctorId = doctor.staff_id
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

    public bool Update(string id, DateTime name, string technicianId, string doctorId, string comment, int state) {
      List<Model.Session> sessions = SelectByName(name);
      if (sessions.Count > 0) {
        if (sessions[0].Id != id) {
          return false;
        }
      }

      string query = @"
        update pmsx_session
        set 
          session_name = convert(date, @name),
          session_technicianId = @technicianId,
          session_doctorId = @doctorId,
          session_comment = @comment,
          session_state = @state,
          session_updateStaffId = @updateStaffId,
          session_updateDatetime = getdate()
        where session_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@name", name),
        new SqlParameter("@technicianId", technicianId),
        new SqlParameter("@doctorId", doctorId),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_session
        set
          session_state = 0,
          session_updateStaffId = @updateStaffId,
          session_updateDatetime = getdate()  
        where session_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
