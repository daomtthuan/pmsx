using PMSX.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class BiopsyGroup {
    private static BiopsyGroup instance;

    private BiopsyGroup() { }

    public static BiopsyGroup Instance {
      get {
        if (instance == null)
          instance = new BiopsyGroup();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.BiopsyGroup> SelectAll(int state = -1) {
      List<Model.BiopsyGroup> data = new List<Model.BiopsyGroup>();
      string query = @"
                select *
                from pmsx_biopsyGroup
                where
                    (@state = -1 or biopsyGroup_state = @state)
                order by biopsyGroup_code
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@state", state)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.BiopsyGroup(row));
      }

      return data;
    }

    public List<Model.BiopsyGroup> SelectById(string id, int state = -1) {
      List<Model.BiopsyGroup> data = new List<Model.BiopsyGroup>();
      string query = @"
                select *
                from pmsx_biopsyGroup
                where
                    (@state = -1 or biopsyGroup_state = @state) and
                    biopsyGroup_id = @id
                order by biopsyGroup_code
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@state", state)
            };


      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.BiopsyGroup(row));
      }

      return data;
    }
  }
}
