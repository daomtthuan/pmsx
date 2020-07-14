using System.Data;

namespace PMSX.Model {
  public class MicroGroup : Interface.Model {
    private readonly int state;

    public MicroGroup(DataRow row) {
      Id = row["macroGroup_id"].ToString();
      Code = row["macroGroup_code"].ToString();
      Name = row["macroGroup_name"].ToString();

      Comment = row["macroGroup_comment"].ToString();
      state = (int)row["macroGroup_state"];

      CreateStaffId = row["macroGroup_createStaffId"].ToString();
      CreateDatetime = row["macroGroup_createDatetime"].ToString();

      UpdateStaffId = row["macroGroup_updateStaffId"].ToString();
      UpdateDatetime = row["macroGroup_updateDatetime"].ToString();
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