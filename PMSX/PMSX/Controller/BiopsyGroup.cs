using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class BiopsyGroup : Pattern.Singleton<BiopsyGroup>, Pattern.IController {
    private BiopsyGroup() { }

    public List<Model.BiopsyGroup> SelectAll(int state = -1) {
      List<Model.BiopsyGroup> biopsyGroups = new List<Model.BiopsyGroup>();
      string query = @"
        select *
        from pmsx_biopsyGroup
        where
          (@state = -1 or biopsyGroup_state = @state)
        order by biopsyGroup_code desc
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        biopsyGroups.Add(new Model.BiopsyGroup(row));
      }

      return biopsyGroups;
    }

    public List<Model.BiopsyGroup> SelectById(string id, int state = -1) {
      List<Model.BiopsyGroup> biopsyGroups = new List<Model.BiopsyGroup>();
      string query = @"
        select *
        from pmsx_biopsyGroup
        where
          (@state = -1 or biopsyGroup_state = @state) and
          biopsyGroup_id = @id
        order by biopsyGroup_code desc
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };


      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        biopsyGroups.Add(new Model.BiopsyGroup(row));
      }

      return biopsyGroups;
    }

    public List<Model.BiopsyGroup> SelectByCode(string code, int state = -1) {
      List<Model.BiopsyGroup> biopsyGroups = new List<Model.BiopsyGroup>();
      string query = @"
        select *
        from pmsx_biopsyGroup
        where
          (@state = -1 or biopsyGroup_state = @state) and
          biopsyGroup_code = @code
        order by biopsyGroup_code desc
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@state", state)
      };


      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        biopsyGroups.Add(new Model.BiopsyGroup(row));
      }

      return biopsyGroups;
    }

    public bool Insert(string code, string comment) {
      if (SelectByCode(code).Count > 0) {
        return false;
      }

      string query = @"
        insert into pmsx_biopsyGroup(
          biopsyGroup_code,
          biopsyGroup_comment,
          biopsyGroup_createStaffId
        ) values(
          @code,
          @comment,
          @createStaffId
        )
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public bool Update(string id, string code, string comment, int state) {
      List<Model.BiopsyGroup> biopsyGroups = SelectByCode(code);
      if (biopsyGroups.Count > 0) {
        if (biopsyGroups[0].Id != id) {
          return false;
        }
      }

      string query = @"
        update pmsx_biopsyGroup
        set 
	        biopsyGroup_code = @code,
	        biopsyGroup_comment = @comment,
          biopsyGroup_state = @state,
          biopsyGroup_updateStaffId = @updateStaffId,
	        biopsyGroup_updateDatetime = getdate()                    
        where biopsyGroup_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@code", code),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_biopsyGroup
        set
          biopsyGroup_state = 0,
          biopsyGroup_updateStaffId = @updateStaffId,
          biopsyGroup_updateDatetime = getdate()  
        where biopsyGroup_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
