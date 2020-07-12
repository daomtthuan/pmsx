using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class Permission {
    public Permission(DataRow row) {
      Id = row["permission_id"].ToString();
      StaffId = row["permission_staffId"].ToString();
      RoleId = row["permission_roleId"].ToString();

      Comment = row["permission_comment"].ToString();
      State = (int)row["permission_state"];

      CreateStaffId = row["permission_createStaffId"].ToString();
      CreateDatetime = row["permission_createDatetime"].ToString();

      UpdateStaffId = row["permission_updateStaffId"].ToString();
      UpdateDatetime = row["permission_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string StaffId { get; private set; }
    public string RoleId { get; private set; }

    public string Comment { get; private set; }
    public int State { get; private set; }

    public string CreateStaffId { get; private set; }
    public string CreateDatetime { get; private set; }

    public string UpdateStaffId { get; private set; }
    public string UpdateDatetime { get; private set; }

    public Staff GetCreateStaff() {
      return Controller.Staff.Instance.SelectById(CreateStaffId)[0];
    }

    public Staff GetUpdateStaff() {
      List<Staff> staffs = Controller.Staff.Instance.SelectById(UpdateStaffId);
      if (staffs.Count != 1) {
        return null;
      }
      return staffs[0];
    }

    public Staff GetStaff() {
      return Controller.Staff.Instance.SelectById(StaffId)[0];
    }

    public Role GetRole() {
      return Controller.Role.Instance.SelectById(RoleId)[0];
    }
  }
}
