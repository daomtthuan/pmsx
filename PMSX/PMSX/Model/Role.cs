using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class Role {
    public Role(DataRow row) {
      Id = row["role_id"].ToString();
      Name = row["role_name"].ToString();

      Comment = row["role_comment"].ToString();
      State = (int)row["role_state"];

      CreateStaffId = row["role_createStaffId"].ToString();
      CreateDatetime = row["role_createDatetime"].ToString();

      UpdateStaffId = row["role_updateStaffId"].ToString();
      UpdateDatetime = row["role_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Name { get; private set; }

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

    public List<Staff> GetStaff() {
      return Controller.Staff.Instance.SelectByRoleId(Id);
    }
  }
}