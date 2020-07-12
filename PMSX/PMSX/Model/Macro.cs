using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class Macro {
    public Macro(DataRow row) {
      Id = row["macro_id"].ToString();
      Code = row["macro_code"].ToString();
      Description = row["macro_description"].ToString();
      GroupId = row["macro_groupId"].ToString();

      Comment = row["macro_comment"].ToString();
      State = (int)row["macro_state"];

      CreateStaffId = row["macro_createStaffId"].ToString();
      CreateDatetime = row["macro_createDatetime"].ToString();

      UpdateStaffId = row["macro_updateStaffId"].ToString();
      UpdateDatetime = row["macro_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
    public string Description { get; private set; }
    public string GroupId { get; private set; }

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

    public MacroGroup GetGroup() {
      return Controller.MacroGroup.Instance.SelectById(GroupId)[0];
    }
  }
}