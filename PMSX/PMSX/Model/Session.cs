using System;
using System.Data;

namespace PMSX.Model {
  public class Session : Pattern.IModel {
    private readonly int state;

    public Session(DataRow row) {
      Id = row["session_id"].ToString();
      Name = ((DateTime)row["session_name"]).ToShortDateString();
      TechnicianId = row["session_technicianId"].ToString();
      TechnicianName = row["session_technicianName"].ToString();
      DoctorId = row["session_doctorId"].ToString();
      DoctorName = row["session_doctorName"].ToString();

      Comment = row["session_comment"].ToString();
      state = (int)row["session_state"];

      CreateStaffId = row["session_createStaffId"].ToString();
      CreateDatetime = row["session_createDatetime"].ToString();

      UpdateStaffId = row["session_updateStaffId"].ToString();
      UpdateDatetime = row["session_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    public string TechnicianId { get; private set; }
    public string TechnicianName { get; private set; }
    public string DoctorId { get; private set; }
    public string DoctorName { get; private set; }
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