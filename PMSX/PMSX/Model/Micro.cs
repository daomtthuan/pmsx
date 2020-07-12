using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class Micro {
    public Micro(DataRow row) {
      Id = row["micro_id"].ToString();
      Code = row["micro_code"].ToString();
      Description = row["micro_description"].ToString();
      Conclusion = row["micro_conclusion"].ToString();
      GroupId = row["micro_groupId"].ToString();

      Comment = row["micro_comment"].ToString();
      State = (int)row["micro_state"];

      CreateStaffId = row["micro_createStaffId"].ToString();
      CreateDatetime = row["micro_createDatetime"].ToString();

      UpdateStaffId = row["micro_updateStaffId"].ToString();
      UpdateDatetime = row["micro_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
    public string Description { get; private set; }
    public string Conclusion { get; private set; }
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

    public MicroGroup GetGroup() {
      return Controller.MicroGroup.Instance.SelectById(GroupId)[0];
    }
  }
}