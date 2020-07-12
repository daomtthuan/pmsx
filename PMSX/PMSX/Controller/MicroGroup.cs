using PMSX.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class MicroGroup {
    private static MicroGroup instance;

    private MicroGroup() { }

    public static MicroGroup Instance {
      get {
        if (instance == null)
          instance = new MicroGroup();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.MicroGroup> SelectAll(int state = -1) {
      List<Model.MicroGroup> data = new List<Model.MicroGroup>();

      string query = @"
			    select *
                from pmsx_microGroup
                where
                    (@state = -1 or microGroup_state = @state)
                order by microGroup_code
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@state", state)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.MicroGroup(row));
      }

      return data;
    }

    public List<Model.MicroGroup> SelectById(string id, int state = -1) {
      List<Model.MicroGroup> data = new List<Model.MicroGroup>();

      string query = @"
			    select *
                from pmsx_microGroup
				where
                    (@state = -1 or microGroup_state = @state) and
                    microGroup_id = @id
                order by microGroup_code
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@state", state)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.MicroGroup(row));
      }

      return data;
    }
  }
}
