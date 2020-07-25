using System;
using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Diagnosy Type1
  /// </summary>
  internal class DiagnosyType1 : Util.Pattern.Model {

    /// <summary>
    /// Create Diagnosy Type1
    /// </summary>
    /// <param name="row">Data row</param>
    public DiagnosyType1(DataRow row) {
      Id = (long)row["diagnosy_id"];
      BiopsyId = (long)row["diagnosy_biopsyId"];
      MicroId = (long)row["diagnosy_microId"];
      MicroDescription = row["diagnosy_microDescription"].ToString();
      Conclusion = row["diagnosy_conclusion"].ToString();
      ReadDate = (DateTime)row["diagnosy_readDate"];
      Image1 = row["diagnosy_image1"].ToString();
      Image2 = row["diagnosy_image2"].ToString();

      Comment = row["diagnosy_comment"].ToString();
      state = (int)row["diagnosy_state"];

      CreateStaffId = (long)row["diagnosy_createStaffId"];
      CreateDatetime = row["diagnosy_createDatetime"].ToString();

      UpdateStaffId = (long)row["diagnosy_updateStaffId"];
      UpdateDatetime = row["diagnosy_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Biopsy Id
    /// </summary>
    public long BiopsyId { get; private set; }

    /// <summary>
    /// Get and set Micro Id
    /// </summary>
    public long MicroId { get; private set; }

    /// <summary>
    /// Get and set Micro Description
    /// </summary>
    public string MicroDescription { get; private set; }

    /// <summary>
    /// Get and set Conclusion
    /// </summary>
    public string Conclusion { get; private set; }

    /// <summary>
    /// Get and set Conclusion
    /// </summary>
    public DateTime ReadDate { get; private set; }

    /// <summary>
    /// Get and set Conclusion
    /// </summary>
    public string Image1 { get; private set; }

    /// <summary>
    /// Get and set Conclusion
    /// </summary>
    public string Image2 { get; private set; }
  }
}