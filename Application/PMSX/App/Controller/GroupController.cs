using PMSX.App.Model;
using PMSX.Pattern.Base;
using PMSX.Utility;
using System.Collections.Generic;
using System.Data;

namespace PMSX.App.Controller {
  internal class GroupController : SingletonBase<GroupController> {
    private GroupController() { }

    public List<Group> Current {
      get {
        DataTable data = DatabaseUtility.Instance.ExecuteReader("call procedure_select_group_now()");
        if (data == null) {
          return null;
        }

        List<Group> groups = new List<Group>();
        foreach (DataRow row in data.Rows) {
          groups.Add(new Group(row));
        }
        return groups;
      }
    }

    public List<Group> Get() {
      string query = "select * from view_group";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query);
      if (data == null) {
        return null;
      }

      List<Group> groups = new List<Group>();
      foreach (DataRow row in data.Rows) {
        groups.Add(new Group(row));
      }

      return groups;
    }
  }
}
