using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  internal class Patient : Pattern.Class.Singleton<Patient>, Pattern.Interface.IController {
    private Patient() { }

    public List<Model.Patient> SelectAll(int state = -1) {
      List<Model.Patient> patients = new List<Model.Patient>();

      string query = @"
        select *
        from pmsx_patient
        where
          (@state = -1 or patient_state = @state)
        order by patient_name
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        patients.Add(new Model.Patient(row));
      }

      return patients;
    }

    public List<Model.Patient> SelectById(string id, int state = -1) {
      List<Model.Patient> patients = new List<Model.Patient>();
      string query = @"
        select *
        from pmsx_patient
        where
          (@state = -1 or patient_state = @state) and
          patient_id = @id
        order by patient_name
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };


      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        patients.Add(new Model.Patient(row));
      }

      return patients;
    }

    public void Insert(string name, int year, string address, string comment) {
      string query = @"
        insert into pmsx_patient(
          patient_name,
          patient_year,
          patient_address,
          patient_comment,
          patient_createStaffId
        ) values(
          @name,
          @year,
          @address,
          @comment,
          @createStaffId
        )
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@name", name),
        new SqlParameter("@year", year),
        new SqlParameter("@address", address),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }

    public void Update(string id, string name, int year, string address, string comment, int state) {
      string query = @"
        update pmsx_patient
        set 
	        patient_name = @name,
	        patient_year = @year,
	        patient_address = @address,
	        patient_comment = @comment,
          patient_state = @state,
          patient_updateStaffId = @updateStaffId,
	        patient_updateDatetime = getdate()                    
        where patient_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@name", name),
        new SqlParameter("@year", year),
        new SqlParameter("@address", address),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_patient
        set
          patient_state = 0,
          patient_updateStaffId = @updateStaffId,
          patient_updateDatetime = getdate()  
        where patient_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
