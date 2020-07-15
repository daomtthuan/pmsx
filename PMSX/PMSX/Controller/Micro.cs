using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Micro : Pattern.Singleton<Micro>, Pattern.IController {
    private Micro() { }

    public List<Model.Micro> SelectByGroupId(string id, int state = -1) {
      List<Model.Micro> micros = new List<Model.Micro>();

      string query = @"
        select *
        from pmsx_micro
        where
          (@state = -1 or micro_state = @state) and
          micro_groupId = @id
        order by micro_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        micros.Add(new Model.Micro(row));
      }

      return micros;
    }
  }
}
