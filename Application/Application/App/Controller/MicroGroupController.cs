using MySqlConnector;
using PMSXApplication.App.Model;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Utility;
using System;
using System.Collections.Generic;
using System.Data;

namespace PMSXApplication.App.Controller {
  internal class MicroGroupController : SingletonBase<MicroGroupController> {
    private MicroGroupController() { }

    public List<MicroGroup> Get(int state = -1) {
      string query = @"
        select *
        from view_microGroup
        where
          (@state = -1 or microGroup_state = @state)";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state));
      if (data == null) {
        return null;
      }

      List<MicroGroup> microGroups = new List<MicroGroup>();
      foreach (DataRow row in data.Rows) {
        microGroups.Add(new MicroGroup(row));
      }

      return microGroups;
    }

    public List<MicroGroup> GetByCode(string code, int state = -1) {
      string query = @"
        select *
        from view_microGroup
        where
          (@state = -1 or microGroup_state = @state) and
          microGroup_code = @code";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@code", code),
        new MySqlParameter("@state", state));
      if (data == null) {
        return null;
      }

      List<MicroGroup> microGroups = new List<MicroGroup>();
      foreach (DataRow row in data.Rows) {
        microGroups.Add(new MicroGroup(row));
      }

      return microGroups;
    }

    public int Add(string code, string name, string comment) {
      string query = @"
        insert into table_microGroup(
          microGroup_code,
          microGroup_name,
          microGroup_comment,
          microGroup_createStaffId
        ) values(
          @code,
          @name,
          @comment,
          @createStaffId
        )";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@code", code),
        new MySqlParameter("@name", name),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@createStaffId", Authentication.Instance.Staff.Id));
    }

    public int Edit(long id, string code, string name, int state, string comment) {
      string query = @"
        update table_microGroup
        set
          microGroup_code = @code,
          microGroup_name = @name,
          microGroup_state = @state,
          microGroup_comment = @comment,
          microGroup_updateStaffId = @updateStaffId,
          microGroup_updateDateTime = now()
        where microGroup_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@code", code),
        new MySqlParameter("@name", name),
        new MySqlParameter("@state", state),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }

    public int Disable(long id) {
      string query = @"
        update table_microGroup
        set
          microGroup_state = 0,
          microGroup_updateStaffId = @updateStaffId,
          microGroup_updateDateTime = now()
        where microGroup_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }
  }
}
