using PMSXApplication.Pattern.Base;
using System;
using System.Data;

namespace PMSXApplication.App.Model {
  internal class Biopsy : ModelBase {
    public Biopsy(DataRow row) : base(row, "biopsy") {
      PatientId = (long)row["biopsy_patientId"];
      SessionId = (long)row["biopsy_sessionId"];
      Segment = row["biopsy_segment"].ToString();
      GrossDate = (DateTime)row["biopsy_grossDate"];
      CollectDate = (DateTime)row["biopsy_collectDate"];
      MacroId = (long)row["biopsy_macroId"];
      MacroDescription = row["biopsy_macroDescription"].ToString();

      object value = row["biopsy_provisionalDiagnose"];
      if (value != DBNull.Value) {
        ProvisionalDiagnose = value.ToString();
      }
    }

    public long PatientId { get; }
    public long SessionId { get; }
    public string Segment { get; }
    public DateTime GrossDate { get; }
    public DateTime CollectDate { get; }
    public long MacroId { get; }
    public string MacroDescription { get; }
    public string ProvisionalDiagnose { get; }
  }
}