using PMSX.Pattern.Base;
using System;
using System.Data;

namespace PMSX.App.Model {
  internal class DiagnoseType1 : ModelBase {
    public DiagnoseType1(DataRow row) : base(row, "diagnose") {
      BiopsyId = (long)row["diagnose_biopsyId"];
      MicroId = (long)row["diagnose_microId"];
      MicroDescription = row["diagnose_microDescription"].ToString();
      Conclusion = row["diagnose_conclusion"].ToString();
      ReadDate = (DateTime)row["diagnose_readDate"];
      Image1 = row["diagnose_image1"].ToString();
      Image2 = row["diagnose_image2"].ToString();
    }

    public long BiopsyId { get; }
    public long MicroId { get; }
    public string MicroDescription { get; }
    public string Conclusion { get; }
    public DateTime ReadDate { get; }
    public string Image1 { get; }
    public string Image2 { get; }
  }
}