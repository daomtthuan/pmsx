using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Macro {
    private static Macro instance;

    private Macro() { }

    public static Macro Instance {
      get {
        if (instance == null)
          instance = new Macro();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.Macro> SelectByGroupId(string id, int state = -1) {
      List<Model.Macro> macros = new List<Model.Macro>();

      string query = @"
        select *
        from pmsx_macro
        where
          (@state = -1 or macro_state = @state) and
          macro_groupId = @id
        order by macro_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        macros.Add(new Model.Macro(row));
      }

      return macros;
    }
  }
}
