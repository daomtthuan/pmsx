using System.Data;

namespace PMSX.Model {
  public class Role {
    private readonly int state;

    public Role(DataRow row) {
      Id = row["role_id"].ToString();
      Name = row["role_name"].ToString();

      Comment = row["role_comment"].ToString();
      state = (int)row["role_state"];

      CreateStaffId = row["role_createStaffId"].ToString();
      CreateDatetime = row["role_createDatetime"].ToString();

      UpdateStaffId = row["role_updateStaffId"].ToString();
      UpdateDatetime = row["role_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Name { get; private set; }

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