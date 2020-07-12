using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Patient {
    private static Patient instance;

    private Patient() { }

    public static Patient Instance {
      get {
        if (instance == null)
          instance = new Patient();
        return instance;
      }
      private set => instance = value;
    }

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

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
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


      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
        patients.Add(new Model.Patient(row));
      }

      return patients;
    }
  }
}
