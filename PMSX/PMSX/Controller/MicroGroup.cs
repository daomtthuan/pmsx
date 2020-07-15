using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class MicroGroup {
    private static MicroGroup instance;

    private MicroGroup() { }

    public static MicroGroup Instance {
      get {
        if (instance == null)
          instance = new MicroGroup();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.MicroGroup> SelectAll(int state = -1) {
      List<Model.MicroGroup> microGroups = new List<Model.MicroGroup>();

      string query = @"
        select *
        from pmsx_microGroup
        where
          (@state = -1 or microGroup_state = @state)
        order by microGroup_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        microGroups.Add(new Model.MicroGroup(row));
      }

      return microGroups;
    }

    public List<Model.MicroGroup> SelectById(string id, int state = -1) {
      List<Model.MicroGroup> microGroups = new List<Model.MicroGroup>();

      string query = @"
        select *
        from pmsx_microGroup
        where
          (@state = -1 or microGroup_state = @state) and
          microGroup_id = @id
        order by microGroup_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        microGroups.Add(new Model.MicroGroup(row));
      }

      return microGroups;
    }

    public List<Model.MicroGroup> SelectByCode(string code, int state = -1) {
      List<Model.MicroGroup> microGroups = new List<Model.MicroGroup>();

      string query = @"
        select *
        from pmsx_microGroup
        where
          (@state = -1 or microGroup_state = @state) and
          microGroup_code = @code
        order by microGroup_code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        microGroups.Add(new Model.MicroGroup(row));
      }

      return microGroups;
    }

    public bool Insert(string code, string name, string comment) {
      if (SelectByCode(code).Count > 0) {
        return false;
      }

      string query = @"
        insert into pmsx_microGroup(
          microGroup_code,
          microGroup_name,
          microGroup_comment,
          microGroup_createStaffId
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

      Utils.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public void Update(string code, string name, string comment, int state) {
      string query = @"
        update pmsx_microGroup
        set 
	        microGroup_name = @name,
	        microGroup_comment = @comment,
          microGroup_state = @state,
          microGroup_updateStaffId = @updateStaffId,
	        microGroup_updateDatetime = getdate()                    
        where microGroup_code = @code
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@name", name),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_microGroup
        set
          microGroup_state = 0,
          microGroup_updateStaffId = @updateStaffId,
          microGroup_updateDatetime = getdate()  
        where microGroup_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
