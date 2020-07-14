using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class MacroGroup {
    private static MacroGroup instance;

    private MacroGroup() { }

    public static MacroGroup Instance {
      get {
        if (instance == null)
          instance = new MacroGroup();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.MacroGroup> SelectAll(int state = -1) {
      List<Model.MacroGroup> macroGroups = new List<Model.MacroGroup>();

      string query = @"
        select *
        from pmsx_macroGroup
        where
          (@state = -1 or macroGroup_state = @state)
        order by macroGroup_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        macroGroups.Add(new Model.MacroGroup(row));
      }

      return macroGroups;
    }

    public List<Model.MacroGroup> SelectById(string id, int state = -1) {
      List<Model.MacroGroup> macroGroups = new List<Model.MacroGroup>();

      string query = @"
        select *
        from pmsx_macroGroup
        where
          (@state = -1 or macroGroup_state = @state) and
          macroGroup_id = @id
        order by macroGroup_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        macroGroups.Add(new Model.MacroGroup(row));
      }

      return macroGroups;
    }
  }
}
