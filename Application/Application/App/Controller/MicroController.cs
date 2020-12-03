using MySqlConnector;
using PMSXApplication.App.Model;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Utility;
using System.Collections.Generic;
using System.Data;

namespace PMSXApplication.App.Controller {
  internal class MicroController : SingletonBase<MicroController> {
    private MicroController() { }

    public List<Micro> Get(long microGroupId, int state = -1) {
      string query = @"
        select *
        from view_micro
        where
          (@state = -1 or micro_state = @state) and
          micro_microGroupId = @microGroupId";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@microGroupId", microGroupId));
      if (data == null) {
        return null;
      }

      List<Micro> micros = new List<Micro>();
      foreach (DataRow row in data.Rows) {
        micros.Add(new Micro(row));
      }

      return micros;
    }
  }
}
