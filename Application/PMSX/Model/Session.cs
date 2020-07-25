using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Session
  /// </summary>
  internal class Session : Util.Pattern.Model {

    /// <summary>
    /// Create Session
    /// </summary>
    /// <param name="row">Data row</param>
    public Session(DataRow row) {
      Id = (long)row["session_id"];
      Date = row["session_date"].ToString();
      DoctorId = (long)row["session_doctorId"];
      TechnicianId = (long)row["session_technicianId"];

      Comment = row["session_comment"].ToString();
      state = (int)row["session_state"];

      CreateStaffId = (long)row["session_createStaffId"];
      CreateDatetime = row["session_createDatetime"].ToString();

      UpdateStaffId = (long)row["session_updateStaffId"];
      UpdateDatetime = row["session_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Date
    /// </summary>
    public string Date { get; private set; }

    /// <summary>
    /// Get and set Doctor Id
    /// </summary>
    public long DoctorId { get; private set; }

    /// <summary>
    /// Get and set Technician Id
    /// </summary>
    public long TechnicianId { get; private set; }
  }
}