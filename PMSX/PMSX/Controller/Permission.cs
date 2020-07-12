using PMSX.Utils;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Permission {
    private static Permission instance;

    private Permission() { }

    public static Permission Instance {
      get {
        if (instance == null)
          instance = new Permission();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.Permission> SelectByRoleId(string id, int state = -1) {
      List<Model.Permission> data = new List<Model.Permission>();

      string query = @"
			    select pmsx_permission.* 
			    from pmsx_permission
			        join pmsx_staff on permission_staffId = staff_id
			    where
                    (@state = -1 or permission_state = @state) and
                    permission_roleId = @id
			    order by staff_name
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@state", state)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Permission(row));
      }

      return data;
    }

    public List<Model.Permission> Insert(string staffId, string roleId, string comment) {
      List<Model.Permission> data = new List<Model.Permission>();

      string query = @"
			    insert into pmsx_permission(
                    permission_staffId,
                    permission_roleId,
                    permission_comment,
                    permission_createStaffId
                ) values(
                    @staffId,
                    @roleId,
                    @comment,
                    @createStaffId
                )
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@staffId", staffId),
                new SqlParameter("@roleId", roleId),
                new SqlParameter("@comment", comment),
                new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
            };

      foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
        data.Add(new Model.Permission(row));
      }

      return data;
    }

    public void Update(string id, string comment, int state) {
      string query = @"
			    update pmsx_permission
                set
                    permission_comment = @comment,
                    permission_state = @state,
                    permission_updateStaffId = @updateStaffId,
	                permission_updateDatetime = getdate()
                where permission_id = @id
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@comment", comment),
                new SqlParameter("@state", state),
                new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
            };

      Database.Instance.ExcuteNon(query, parameters);
    }

    public void Disabled(string id) {
      string query = @"
                update pmsx_permission
                set
                    permission_state = 0,
                    permission_updateStaffId = @updateStaffId,
	                permission_updateDatetime = getdate()  
                where permission_id = @id
            ";

      SqlParameter[] parameters = {
                new SqlParameter("@id", id),
                new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
            };

      Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
