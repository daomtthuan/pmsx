using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class MicroGroup {
    public MicroGroup(DataRow row) {
      Id = row["macroGroup_id"].ToString();
      Code = row["macroGroup_code"].ToString();
      Name = row["macroGroup_name"].ToString();

      Comment = row["macroGroup_comment"].ToString();
      State = (int)row["macroGroup_state"];

      CreateStaffId = row["macroGroup_createStaffId"].ToString();
      CreateDatetime = row["macroGroup_createDatetime"].ToString();

      UpdateStaffId = row["macroGroup_updateStaffId"].ToString();
      UpdateDatetime = row["macroGroup_updateDatetime"].ToString();
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

    public List<Macro> GetMacros() {
      return Controller.Macro.Instance.SelectByGroupId(Id);
    }
  }
}