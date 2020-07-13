using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class Biopsy {
    private readonly int state;

    public Biopsy(DataRow row) {
      Id = row["biopsy_id"].ToString();
      Code = row["biopsy_code"].ToString();
      GroupId = row["biopsy_groupId"].ToString();
      DiagnoseType = row["biopsy_diagnoseType"].ToString();
      PatientId = row["biopsy_patientId"].ToString();
      SessionId = row["biopsy_sessionId"].ToString();
      GrossStaffId = row["biopsy_grossStaffId"].ToString();
      Segment = (int)row["biopsy_segment"];
      GrossDatetime = row["biopsy_grossDatetime"].ToString();
      CollectDatetime = row["biopsy_collectDatetime"].ToString();

      Comment = row["biopsy_comment"].ToString();
      state = (int)row["biopsy_state"];

      CreateDatetime = row["biopsy_createDatetime"].ToString();
      UpdateDatetime = row["biopsy_updateDatetime"].ToString();

      UpdateStaffId = row["biopsy_updateStaffId"].ToString();
      UpdateDatetime = row["biopsy_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
    public string GroupId { get; private set; }
    public string DiagnoseType { get; private set; }
    public string PatientId { get; private set; }
    public string SessionId { get; private set; }
    public string GrossStaffId { get; private set; }
    public int Segment { get; private set; }
    public string GrossDatetime { get; private set; }
    public string CollectDatetime { get; private set; }

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