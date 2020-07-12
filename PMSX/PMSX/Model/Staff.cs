using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class Staff {
    public Staff(DataRow row) {
      Id = row["staff_id"].ToString();
      Username = row["staff_username"].ToString();
      Password = row["staff_password"].ToString();
      Name = row["staff_name"].ToString();

      Comment = row["staff_comment"].ToString();
      State = (int)row["staff_state"];

      CreateStaffId = row["staff_createStaffId"].ToString();
      CreateDatetime = row["staff_createDatetime"].ToString();

      UpdateStaffId = row["staff_updateStaffId"].ToString();
      UpdateDatetime = row["staff_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Username { get; private set; }
    public string Password { get; private set; }
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

    public List<Role> GetRoles() {
      return Controller.Role.Instance.SelectByStaffId(Id);
    }
  }
}