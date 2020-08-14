using MySql.Data.MySqlClient;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using PMSX.Utility;
using System;
using System.Collections.Generic;
using System.Data;

namespace PMSX.App.Controller {
  internal class MacroController : SingletonBase<MacroController> {
    private MacroController() { }

    public List<Macro> Get(long macroGroupId, int state = -1) {
      string query = @"
        select *
        from view_macro
        where
          (@state = -1 or macro_state = @state) and
          macro_macroGroupId = @macroGroupId";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@macroGroupId", macroGroupId));
      if (data == null) {
        return null;
      }

      List<Macro> macros = new List<Macro>();
      foreach (DataRow row in data.Rows) {
        macros.Add(new Macro(row));
      }

      return macros;
    }

    public List<Macro> GetByCode(long macroGroupId, string code, int state = -1) {
      string query = @"
        select *
        from view_macro
        where
          (@state = -1 or macro_state = @state) and
          macro_macroGroupId = @macroGroupId and
          macro_code = @code";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@code", code),
        new MySqlParameter("@state", state),
        new MySqlParameter("@macroGroupId", macroGroupId));
      if (data == null) {
        return null;
      }

      List<Macro> macros = new List<Macro>();
      foreach (DataRow row in data.Rows) {
        macros.Add(new Macro(row));
      }

      return macros;
    }

    public int Add(string code, string description, long macroGroupId, string comment) {
      string query = @"
        insert into table_macro(
          macro_code,
          macro_description,
          macro_macroGroupId,
          macro_comment,
          macro_createStaffId
        ) values(
          @code,
          @description,
          @macroGroupId,
          @comment,
          @createStaffId
        )";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@code", code),
        new MySqlParameter("@description", description),
        new MySqlParameter("@macroGroupId", macroGroupId),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@createStaffId", Authentication.Instance.Staff.Id));
    }

    public int Edit(long id, string code, string description, int state, string comment) {
      string query = @"
        update table_macro
        set
          macro_code = @code,
          macro_description = @description,
          macro_state = @state,
          macro_comment = @comment,
          macro_updateStaffId = @updateStaffId,
          macro_updateDateTime = now()
        where macro_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@code", code),
        new MySqlParameter("@description", description),
        new MySqlParameter("@state", state),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }

    public int Disable(long id) {
      string query = @"
        update table_macro
        set
          macro_state = 0,
          macro_updateStaffId = @updateStaffId,
          macro_updateDateTime = now()
        where macro_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }
  }
}
