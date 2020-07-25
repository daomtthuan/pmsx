using System.Data;

namespace PMSX.Model {

  /// <summary>
  /// Patient
  /// </summary>
  internal class Patient : Util.Pattern.Model {

    /// <summary>
    /// Create Patient
    /// </summary>
    /// <param name="row">Data row</param>
    public Patient(DataRow row) {
      Id = (long)row["patient_id"];
      GroupId = (long)row["patient_groupId"];
      Code = (long)row["patient_code"];
      Name = row["patient_name"].ToString();
      Year = (int)row["patient_year"];
      Address = row["patient_address"].ToString();

      Comment = row["patient_comment"].ToString();
      state = (int)row["patient_state"];

      CreateStaffId = (long)row["patient_createStaffId"];
      CreateDatetime = row["patient_createDatetime"].ToString();

      UpdateStaffId = (long)row["patient_updateStaffId"];
      UpdateDatetime = row["patient_updateDatetime"].ToString();
    }

    /// <summary>
    /// Get and set Group Id
    /// </summary>
    public long GroupId { get; private set; }

    /// <summary>
    /// Get and set Code
    /// </summary>
    public long Code { get; private set; }

    /// <summary>
    /// Get and set Name
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Get and set Birth Year
    /// </summary>
    public int Year { get; private set; }

    /// <summary>
    /// Get and set Address
    /// </summary>
    public string Address { get; private set; }
  }
}