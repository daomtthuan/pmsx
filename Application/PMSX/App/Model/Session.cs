using PMSX.Pattern.Base;
using System.Data;

namespace PMSX.App.Model {
  internal class Session : ModelBase {
    public Session(DataRow row) : base(row, "session") {
      Date = row["session_date"].ToString();
      DoctorId = (long)row["session_doctorId"];
      DoctorName = row["session_doctorName"].ToString();
      TechnicianId = (long)row["session_technicianId"];
      TechnicianName = row["session_technicianName"].ToString();
    }

    public string Date { get; }
    public long DoctorId { get; }
    public string DoctorName { get; }
    public long TechnicianId { get; }
    public string TechnicianName { get; }
  }
}