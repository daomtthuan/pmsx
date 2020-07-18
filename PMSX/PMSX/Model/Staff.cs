using System.Data;

namespace PMSX.Model {
  internal class Staff : Pattern.Interface.IModel {
    private readonly int state;

    public Staff(DataRow row) {
      Id = row["staff_id"].ToString();
      Username = row["staff_username"].ToString();
      Password = row["staff_password"].ToString();
      Name = row["staff_name"].ToString();

      Comment = row["staff_comment"].ToString();
      state = (int)row["staff_state"];

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
    public string State => state == 0 ? "Vô hiệu hoá" : "Kích hoạt";

    public string CreateStaffId { get; private set; }
    public string CreateDatetime { get; private set; }

    public string UpdateStaffId { get; private set; }
    public string UpdateDatetime { get; private set; }

    public int GetStateNumber() {
      return state;
    }
  }
}