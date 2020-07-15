using System.Data;

namespace PMSX.Model {
  public class Permission : Utils.Pattern.Model {
    private readonly int state;

    public Permission(DataRow row) {
      Id = row["permission_id"].ToString();
      StaffId = row["permission_staffId"].ToString();
      StaffUsername = row["staff_username"].ToString();
      StaffName = row["staff_name"].ToString();
      RoleId = row["permission_roleId"].ToString();

      Comment = row["permission_comment"].ToString();
      state = (int)row["permission_state"];

      CreateStaffId = row["permission_createStaffId"].ToString();
      CreateDatetime = row["permission_createDatetime"].ToString();

      UpdateStaffId = row["permission_updateStaffId"].ToString();
      UpdateDatetime = row["permission_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string StaffId { get; private set; }
    public string StaffUsername { get; private set; }
    public string StaffName { get; private set; }
    public string RoleId { get; private set; }

    public string Comment { get; private set; }
    public string State { get => state == 0 ? "Vô hiệu hoá" : "Kích hoạt"; }

    public string CreateStaffId { get; private set; }
    public string CreateDatetime { get; private set; }

    public string UpdateStaffId { get; private set; }
    public string UpdateDatetime { get; private set; }

    public int GetStateNumber() {
      return state;
    }
  }
}
