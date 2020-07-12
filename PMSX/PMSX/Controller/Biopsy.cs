using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Biopsy {
    private static Biopsy instance;

    private Biopsy() { }

    public static Biopsy Instance {
      get {
        if (instance == null)
          instance = new Biopsy();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.Biopsy> SelectByGroupId(string id, int state = -1) {
      List<Model.Biopsy> biopsies = new List<Model.Biopsy>();

      string query = @"
        select *
        from pmsx_biopsy
        where
          (@state = -1 or biopsy_state = @state) and
          biopsy_groupId = @id
        order by biopsy_code 
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        biopsies.Add(new Model.Biopsy(row));
      }

      return biopsies;
    }
  }
}
