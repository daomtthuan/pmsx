using System.Data;

namespace PMSX.Model {
  public class Micro : Interface.Model {
    private readonly int state;

    public Micro(DataRow row) {
      Id = row["micro_id"].ToString();
      Code = row["micro_code"].ToString();
      Description = row["micro_description"].ToString();
      Conclusion = row["micro_conclusion"].ToString();
      GroupId = row["micro_groupId"].ToString();

      Comment = row["micro_comment"].ToString();
      state = (int)row["micro_state"];

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