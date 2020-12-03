using PMSXApplication.App.Model;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Utility;
using System.Collections.Generic;
using System.Data;

namespace PMSXApplication.App.Controller {
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
