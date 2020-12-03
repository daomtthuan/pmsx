using PMSXApplication.Pattern.Base;
using System;
using System.Data;

namespace PMSXApplication.App.Model {
  internal class Session : ModelBase {
    public Session(DataRow row) : base(row, "session") {
      Date = (DateTime)row["session_date"];
      DoctorId = (long)row["session_doctorId"];
      DoctorName = row["session_doctorName"].ToString();
      TechnicianId = (long)row["session_technicianId"];
      TechnicianName = row["session_technicianName"].ToString();
    }

    public DateTime Date { get; }
    public long DoctorId { get; }
    public string DoctorName { get; }
    public long TechnicianId { get; }
    public string TechnicianName { get; }
  }
}