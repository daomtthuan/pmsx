using System;
using System.Data;

namespace PMSX.Model {
  internal class Biopsy : Pattern.Interface.IModel {
    private readonly int state;

    public Biopsy(DataRow row) {
      Id = row["biopsy_id"].ToString();
      Code = row["biopsy_code"].ToString();
      FullCode = row["biopsy_fullCode"].ToString();
      BiopsyGroupId = row["biopsy_groupId"].ToString();
      PatientId = row["biopsy_patientId"].ToString();
      PatientName = row["biopsy_patientName"].ToString();
      GrossDoctorId = row["biopsy_grossDoctorId"].ToString();
      GrossDoctorName = row["biopsy_grossDoctorName"].ToString();
      Segment = (int)row["biopsy_segment"];
      GrossDatetime = ((DateTime)row["biopsy_grossDatetime"]).ToShortDateString();
      CollectDatetime = ((DateTime)row["biopsy_collectDatetime"]).ToShortDateString();

      if (row["biopsy_sessionId"] != DBNull.Value) {
        SessionId = row["biopsy_sessionId"].ToString();
        SessionName = ((DateTime)row["biopsy_sessionName"]).ToShortDateString();
      }

      Comment = row["biopsy_comment"].ToString();
      state = (int)row["biopsy_state"];

      CreateDatetime = row["biopsy_createDatetime"].ToString();
      UpdateDatetime = row["biopsy_updateDatetime"].ToString();

      UpdateStaffId = row["biopsy_updateStaffId"].ToString();
      UpdateDatetime = row["biopsy_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
    public string FullCode { get; private set; }
    public string BiopsyGroupId { get; private set; }
    public string PatientId { get; private set; }
    public string PatientName { get; private set; }
    public string SessionName { get; private set; }
    public string SessionId { get; private set; }
    public string GrossDoctorId { get; private set; }
    public string GrossDoctorName { get; private set; }
    public int Segment { get; private set; }
    public string GrossDatetime { get; private set; }
    public string CollectDatetime { get; private set; }

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