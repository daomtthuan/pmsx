using System.Data;

namespace PMSX.Model {
  public class Macro : Utils.Pattern.Model {
    private readonly int state;

    public Macro(DataRow row) {
      Id = row["macro_id"].ToString();
      Code = row["macro_code"].ToString();
      Description = row["macro_description"].ToString();
      MacroGroupId = row["macro_groupId"].ToString();

      Comment = row["macro_comment"].ToString();
      state = (int)row["macro_state"];

      CreateStaffId = row["macro_createStaffId"].ToString();
      CreateDatetime = row["macro_createDatetime"].ToString();

      UpdateStaffId = row["macro_updateStaffId"].ToString();
      UpdateDatetime = row["macro_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
    public string Description { get; private set; }
    public string MacroGroupId { get; private set; }

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