using PMSX.Pattern.Base;
using System;
using System.Data;

namespace PMSX.App.Model {
  internal class Patient : ModelBase {
    public Patient(DataRow row) : base(row, "patient") {
      GroupId = (long)row["patient_groupId"];
      Code = $"{row["patient_code"]}-YCT{row["patient_groupYear"].ToString().Substring(2)}";
      Name = row["patient_name"].ToString();
      YearsOld = DateTime.Now.Year - (int)row["patient_year"];
      Address = row["patient_address"].ToString();
    }

    public long GroupId { get; }
    public string Code { get; }
    public string Name { get; }
    public int YearsOld { get; }
    public string Address { get; }
  }
}