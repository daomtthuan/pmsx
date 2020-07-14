using System.Data;

namespace PMSX.Model {
  public class MicroGroup : Interface.Model {
    private readonly int state;

    public MicroGroup(DataRow row) {
      Id = row["microGroup_id"].ToString();
      Code = row["microGroup_code"].ToString();
      Name = row["microGroup_name"].ToString();

      Comment = row["microGroup_comment"].ToString();
      state = (int)row["microGroup_state"];

      CreateStaffId = row["microGroup_createStaffId"].ToString();
      CreateDatetime = row["microGroup_createDatetime"].ToString();

      UpdateStaffId = row["microGroup_updateStaffId"].ToString();
      UpdateDatetime = row["microGroup_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
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