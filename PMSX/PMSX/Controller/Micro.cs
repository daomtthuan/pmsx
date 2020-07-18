using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  internal class Micro : Pattern.Class.Singleton<Micro>, Pattern.Interface.IController {
    private Micro() { }

    public List<Model.Micro> SelectAll(int state = -1) {
      List<Model.Micro> micros = new List<Model.Micro>();

      string query = @"
        select *
        from pmsx_micro
        where
          (@state = -1 or micro_state = @state)
        order by micro_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        micros.Add(new Model.Micro(row));
      }

      return micros;
    }
    public List<Model.Micro> SelectByGroupId(string id, int state = -1) {
      List<Model.Micro> micros = new List<Model.Micro>();

      string query = @"
        select *
        from pmsx_micro
        where
          (@state = -1 or micro_state = @state) and
          micro_groupId = @id
        order by micro_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        micros.Add(new Model.Micro(row));
      }

      return micros;
    }

    public List<Model.Micro> SelectByCodeAndId(string code, string groupId, int state = -1) {
      List<Model.Micro> micros = new List<Model.Micro>();

      string query = @"
        select *
        from pmsx_micro
        where
          (@state = -1 or micro_state = @state) and
          micro_code = @code and
          micro_groupId = @groupId
        order by micro_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@groupId", groupId),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        micros.Add(new Model.Micro(row));
      }

      return micros;
    }
    public bool Insert(string code, string description, string conclusion, string groupId, string comment) {
      if (SelectByCodeAndId(code, groupId).Count > 0) {
        return false;
      }

      string query = @"
        insert into pmsx_micro(
          micro_code,
          micro_description,
          micro_conclusion,
          micro_groupId,
          micro_comment,
          micro_createStaffId
        ) values(
          @code,
          @description,
          @conclusion,
          @groupId,
          @comment,
          @createStaffId
        )
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@description", description),
        new SqlParameter("@conclusion", conclusion),
        new SqlParameter("@groupId", groupId),
        new SqlParameter("@comment", comment),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public void Update(string groupId, string id, string code, string description, string comment, int state) {
      string query = @"
        update pmsx_micro
        set 
          micro_code = @code,
	        micro_description = @description,
	        micro_comment = @comment,
          micro_state = @state,
          micro_updateStaffId = @updateStaffId,
	        micro_updateDatetime = getdate()                    
        where micro_id = @id and
              micro_groupId = @groupId
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@groupId", groupId),
        new SqlParameter("@id", id),
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
        update pmsx_micro
        set
          micro_state = 0,
          micro_updateStaffId = @updateStaffId,
          micro_updateDatetime = getdate()  
        where micro_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
