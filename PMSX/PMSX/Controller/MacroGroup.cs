using System;
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
    public List<Model.MacroGroup> SelectByCode(string code, int state = -1) {
      List<Model.MacroGroup> macroGroups = new List<Model.MacroGroup>();

      string query = @"
        select *
        from pmsx_macroGroup
        where
          (@state = -1 or macroGroup_state = @state) and
          macroGroup_code = @code
        order by macroGroup_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        macroGroups.Add(new Model.MacroGroup(row));
      }

      return macroGroups;
    }

    public bool Insert(string code, string name, string comment, string createStaffId) {
      if (SelectByCode(code).Count > 0) {
        return false;
      }

      string query = @"
        insert into pmsx_macroGroup(
          macroGroup_code,
          macroGroup_name,
          macroGroup_comment,
          macroGroup_createStaffId
        ) values(
          @code,
          @name,
          @comment,
          @createStaffId
        )
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@name", name),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public void Update(string code, string name, string comment, int state) {
      string query = @"
        update pmsx_macroGroup
        set 
	        macroGroup_name = @name,
	        macroGroup_comment = @comment,
          macroGroup_state = @state,
          macroGroup_updateStaffId = @updateStaffId,
	        macroGroup_updateDatetime = getdate()                    
        where macroGroup_code = @code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@name", name),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_macroGroup
        set
          macroGroup_state = 0,
          macroGroup_updateStaffId = @updateStaffId,
          macroGroup_updateDatetime = getdate()  
        where macroGroup_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Util.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
