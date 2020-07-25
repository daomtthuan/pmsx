using System;
using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Biopsy
  /// </summary>
  internal class Biopsy : Util.Pattern.Model {

    /// <summary>
    /// Create Biopsy
    /// </summary>
    /// <param name="row">Data row</param>
    public Biopsy(DataRow row) {
      Id = (long)row["biopsy_id"];
      PatientId = (long)row["biopsy_patientId"];
      SessionId = (long)row["biopsy_sessionId"];
      Segment = row["biopsy_segment"].ToString();
      GrossDate = (DateTime)row["biopsy_grossDate"];
      CollectDate = (DateTime)row["biopsy_collectDate"];
      MacroId = (long)row["biopsy_macroId"];
      MacroDescription = row["biopsy_macroDescription"].ToString();
      ProvisionalDiagnosy = row["biopsy_provisionalDiagnosy"].ToString();

      Comment = row["biopsy_comment"].ToString();
      state = (int)row["biopsy_state"];

      CreateStaffId = (long)row["biopsy_createStaffId"];
      CreateDatetime = row["biopsy_createDatetime"].ToString();

      UpdateStaffId = (long)row["biopsy_updateStaffId"];
      UpdateDatetime = row["biopsy_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Patient Id
    /// </summary>
    public long PatientId { get; private set; }

    /// <summary>
    /// Get and set Session Id
    /// </summary>
    public long SessionId { get; private set; }

    /// <summary>
    /// Get and set Segment
    /// </summary>
    public string Segment { get; private set; }

    /// <summary>
    /// Get and set Gross Date
    /// </summary>
    public DateTime GrossDate { get; private set; }

    /// <summary>
    /// Get and set Collect Date
    /// </summary>
    public DateTime CollectDate { get; private set; }

    /// <summary>
    /// Get and set Macro Id
    /// </summary>
    public long MacroId { get; private set; }

    /// <summary>
    /// Get and set Macro Description
    /// </summary>
    public string MacroDescription { get; private set; }

    /// <summary>
    /// Get and set Provisional Diagnosy
    /// </summary>
    public string ProvisionalDiagnosy { get; private set; }
  }
}