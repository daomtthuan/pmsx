using MySql.Data.MySqlClient;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using PMSX.Utility;
using System.Collections.Generic;
using System.Data;

namespace PMSX.App.Controller {
  internal class PatientController : SingletonBase<PatientController> {
    private PatientController() { }

    public List<Patient> Get(long groupId, int state = -1) {
      string query = @"
        select *
        from view_patient
        where
          (@state = -1 or patient_state = @state) and
          patient_groupId = @groupId";

      DataTable data = DatabaseUtility.Instance.ExecuteReader(query,
        new MySqlParameter("@state", state),
        new MySqlParameter("@groupId", groupId));
      if (data == null) {
        return null;
      }

      List<Patient> patients = new List<Patient>();
      foreach (DataRow row in data.Rows) {
        patients.Add(new Patient(row));
      }

      return patients;
    }
  }
}
