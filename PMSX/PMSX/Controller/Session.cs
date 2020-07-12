using PMSX.Utils;
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
      List<Model.Session> data = new List<Model.Session>();

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

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Session(row));
      }

      return data;
    }

    public List<Model.Session> SelectById(string id, int state = -1) {
      List<Model.Session> data = new List<Model.Session>();

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


      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Session(row));
      }

      return data;
    }

    //public List<Model.Session> Insert() {
    //  List<Model.Session> data = new List<Model.Session>();

    //  string query = @"
    //            select *
    //            from pmsx_session
    //            where                    
    //                (@state = -1 or session_state = @state) and
    //                session_id = @id
    //            order by session_name desc
    //        ";

    //  SqlParameter[] parameters = {
    //            new SqlParameter("@id", id),
    //            new SqlParameter("@state", state)
    //        };


    //  foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
    //    data.Add(new Model.Session(row));
    //  }

    //  return data;
    //}
  }
}
