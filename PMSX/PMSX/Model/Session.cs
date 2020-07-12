using System;
using System.Collections.Generic;
using System.Data;

namespace PMSX.Model {
  public class Session {
    public Session(DataRow row) {
      Id = row["session_id"].ToString();
      Name = ((DateTime)row["session_name"]).ToShortDateString();
      TechnicianId = row["session_technicianId"].ToString();
      DoctorId = row["session_doctorId"].ToString();

      Comment = row["session_comment"].ToString();
      State = (int)row["session_state"];

      CreateStaffId = row["session_createStaffId"].ToString();
      CreateDatetime = row["session_createDatetime"].ToString();

      UpdateStaffId = row["session_updateStaffId"].ToString();
      UpdateDatetime = row["session_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    public string TechnicianId { get; private set; }
    public string DoctorId { get; private set; }
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

    public Staff GetTechnician() {
      return Controller.Staff.Instance.SelectById(TechnicianId)[0];
    }

    public Staff GetDoctor() {
      return Controller.Staff.Instance.SelectById(DoctorId)[0];
    }
  }
}