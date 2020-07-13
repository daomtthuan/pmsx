using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class BiopsyGroup {
    private readonly int state;

    public BiopsyGroup(DataRow row) {
      Id = row["biopsyGroup_id"].ToString();
      Code = row["biopsyGroup_code"].ToString();
      NumberBiopsy = (long)row["biopsyGroup_numberBiopsy"];

      Comment = row["biopsyGroup_comment"].ToString();
      state = (int)row["biopsyGroup_state"];

      CreateStaffId = row["biopsyGroup_createStaffId"].ToString();
      CreateDatetime = row["biopsyGroup_createDatetime"].ToString();

      UpdateStaffId = row["biopsyGroup_updateStaffId"].ToString();
      UpdateDatetime = row["biopsyGroup_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
    public long NumberBiopsy { get; private set; }

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