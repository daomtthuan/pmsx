using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class MacroGroup {
    public MacroGroup(DataRow row) {
      Id = row["microGroup_id"].ToString();
      Code = row["microGroup_code"].ToString();
      Name = row["microGroup_name"].ToString();

      Comment = row["microGroup_comment"].ToString();
      State = (int)row["microGroup_state"];

      CreateStaffId = row["microGroup_createStaffId"].ToString();
      CreateDatetime = row["microGroup_createDatetime"].ToString();

      UpdateStaffId = row["microGroup_updateStaffId"].ToString();
      UpdateDatetime = row["microGroup_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
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

    public List<Micro> GetMicros() {
      return Controller.Micro.Instance.SelectByGroupId(Id);
    }
  }
}