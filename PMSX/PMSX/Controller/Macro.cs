using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Macro : Pattern.Singleton<Macro>, Pattern.IController {
    private Macro() { }

    public List<Model.Macro> SelectAll(int state = -1) {
      List<Model.Macro> macros = new List<Model.Macro>();

      string query = @"
        select *
        from pmsx_macro
        where
          (@state = -1 or macro_state = @state)
        order by macro_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        macros.Add(new Model.Macro(row));
      }

      return macros;
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

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        macros.Add(new Model.Macro(row));
      }

      return macros;
    }
    public List<Model.Macro> SelectByCode(string code, int state = -1) {
      List<Model.Macro> macros = new List<Model.Macro>();

      string query = @"
        select *
        from pmsx_macro
        where
          (@state = -1 or macro_state = @state) and
          macro_code = @code
        order by macro_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        macros.Add(new Model.Macro(row));
      }

      return macros;
    }
    public bool Insert(string code, string description, string groupId, string comment) {
      if (SelectByCode(code).Count > 0) {
        return false;
      }

      string query = @"
        insert into pmsx_macro(
          macro_code,
          macro_description,
          macro_groupId,
          macro_comment,
          macro_createStaffId
        ) values(
          @code,
          @description,
          @groupId,
          @comment,
          @createStaffId
        )
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@description", description),
        new SqlParameter("@groupId", groupId),
        new SqlParameter("@comment", comment),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public void Update(string code, string description, string comment, int state) {
      string query = @"
        update pmsx_macro
        set 
	        macro_description = @description,
	        macro_comment = @comment,
          macro_state = @state,
          macro_updateStaffId = @updateStaffId,
	        macro_updateDatetime = getdate()                    
        where macro_code = @code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@description", description),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_macro
        set
          macro_state = 0,
          macro_updateStaffId = @updateStaffId,
          macro_updateDatetime = getdate()  
        where macro_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
