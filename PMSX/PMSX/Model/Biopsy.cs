using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class Biopsy {
    public Biopsy(DataRow row) {
      Id = row["biopsy_id"].ToString();
      Code = row["biopsy_code"].ToString();
      GroupId = row["biopsy_groupId"].ToString();
      DiagnoseType = row["biopsy_diagnoseType"].ToString();
      PatientId = row["biopsy_patientId"].ToString();
      SessionId = row["biopsy_sessionId"].ToString();
      GrossStaffId = row["biopsy_grossStaffId"].ToString();
      Segment = (int)row["biopsy_segment"];
      GrossDatetime = row["biopsy_grossDatetime"].ToString();
      CollectDatetime = row["biopsy_collectDatetime"].ToString();

      Comment = row["biopsy_comment"].ToString();
      State = (int)row["biopsy_state"];

      CreateDatetime = row["biopsy_createDatetime"].ToString();
      UpdateDatetime = row["biopsy_updateDatetime"].ToString();

      UpdateStaffId = row["biopsy_updateStaffId"].ToString();
      UpdateDatetime = row["biopsy_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
    public string GroupId { get; private set; }
    public string DiagnoseType { get; private set; }
    public string PatientId { get; private set; }
    public string SessionId { get; private set; }
    public string GrossStaffId { get; private set; }
    public int Segment { get; private set; }
    public string GrossDatetime { get; private set; }
    public string CollectDatetime { get; private set; }


    public string Comment { get; private set; }
    public int State { get; private set; }

    public string CreateStaffId { get; private set; }
    public string CreateDatetime { get; private set; }

    public string UpdateStaffId { get; private set; }
    public string UpdateDatetime { get; private set; }

    public Staff GetCreateStaff() {
      return Controller.Staff.Instance.SelectById(CreateStaffId)[0];
    }

    public Staff GetUpdateStaff() {
      List<Staff> staffs = Controller.Staff.Instance.SelectById(UpdateStaffId);
      if (staffs.Count != 1) {
        return null;
      }
      return staffs[0];
    }

    public BiopsyGroup GetGroup() {
      return Controller.BiopsyGroup.Instance.SelectById(GroupId)[0];
    }

    public Patient GetPatient() {
      return Controller.Patient.Instance.SelectById(GroupId)[0];
    }

    public Session GetSession() {
      return Controller.Session.Instance.SelectById(SessionId)[0];
    }

    public Staff GetGrossStaff() {
      return Controller.Staff.Instance.SelectById(GrossStaffId)[0];
    }
  }
}