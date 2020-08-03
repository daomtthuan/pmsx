using PMSX.Pattern.Base;
using System.Data;

namespace PMSX.App.Model {
  internal class Patient : ModelBase {
    public Patient(DataRow row) : base(row, "patient") {
      GroupId = (long)row["patient_groupId"];
      Code = (long)row["patient_code"];
      Name = row["patient_name"].ToString();
      Year = (int)row["patient_year"];
      Address = row["patient_address"].ToString();
    }

    public long GroupId { get; }
    public long Code { get; }
    public string Name { get; }
    public int Year { get; }
    public string Address { get; }
  }
}