using MySql.Data.MySqlClient;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using PMSX.Utility;
using System;
using System.Collections.Generic;
using System.Data;

namespace PMSX.App.Controller {
  internal class MacroGroupController : SingletonBase<MacroGroupController> {
    private MacroGroupController() { }

    public List<MacroGroup> Get(int state = -1) {
      string query = @"
        select *
        from view_macroGroup
        where
          (@state = -1 or macroGroup_state = @state)";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state));
      if (data == null) {
        return null;
      }

      List<MacroGroup> macroGroups = new List<MacroGroup>();
      foreach (DataRow row in data.Rows) {
        macroGroups.Add(new MacroGroup(row));
      }

      return macroGroups;
    }

    public List<MacroGroup> GetByCode(string code, int state = -1) {
      string query = @"
        select *
        from view_macroGroup
        where
          (@state = -1 or macroGroup_state = @state) and
          macroGroup_code = @code";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@code", code),
        new MySqlParameter("@state", state));
      if (data == null) {
        return null;
      }

      List<MacroGroup> macroGroups = new List<MacroGroup>();
      foreach (DataRow row in data.Rows) {
        macroGroups.Add(new MacroGroup(row));
      }

      return macroGroups;
    }

    public int Add(string code, string name, string comment) {
      string query = @"
        insert into table_macroGroup(
          macroGroup_code,
          macroGroup_name,
          macroGroup_comment,
          macroGroup_createStaffId
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
        update table_macroGroup
        set
          macroGroup_code = @code,
          macroGroup_name = @name,
          macroGroup_state = @state,
          macroGroup_comment = @comment,
          macroGroup_updateStaffId = @updateStaffId,
          macroGroup_updateDateTime = now()
        where macroGroup_id = @id";

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
        update table_macroGroup
        set
          macroGroup_state = 0,
          macroGroup_updateStaffId = @updateStaffId,
          macroGroup_updateDateTime = now()
        where macroGroup_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }
  }
}
