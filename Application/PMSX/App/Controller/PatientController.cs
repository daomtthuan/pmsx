using MySql.Data.MySqlClient;
using PMSX.App.Model;
using PMSX.Pattern.Base;
using PMSX.Utility;
using System;
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

    public int Add(Group group, string name, int year, string address, string comment) {
      string query1 = @"
        insert into table_patient(
          patient_groupId,
          patient_code,
          patient_name,
          patient_year,
          patient_address,
          patient_comment,
          patient_createStaffId
        ) values(
          @groupId,
          @code,
          @name,
          @year,
          @address,
          @comment,
          @createStaffId
        )";
      MySqlParameter[] parameters1 = new[] {
        new MySqlParameter("@groupId", group.Id),
        new MySqlParameter("@code", group.Total + 1),
        new MySqlParameter("@name", name),
        new MySqlParameter("@year", year),
        new MySqlParameter("@address", address),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@createStaffId", Authentication.Instance.Staff.Id)
      };

      string query2 = @"
        update table_group
        set
          group_total = @total
        where group_id = @id";
      MySqlParameter[] parameters2 = new[] {
        new MySqlParameter("@id", group.Id),
        new MySqlParameter("@total", group.Total + 1)
      };

      return DatabaseUtility.Instance.ExecuteTransactionNonQuery(new[] { query1, query2 }, new[] { parameters1, parameters2 });
    }

    public int Edit(long id, string name, int year, string address, int state, string comment) {
      string query = @"
        update table_patient
        set
          patient_name = @name,
          patient_year = @year,
          patient_address = @address,
          patient_state = @state,
          patient_comment = @comment,
          patient_updateStaffId = @updateStaffId,
          patient_updateDateTime = now()
        where patient_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@name", name),
        new MySqlParameter("@year", year),
        new MySqlParameter("@address", address),
        new MySqlParameter("@state", state),
        comment.Length > 0 ? new MySqlParameter("@comment", comment) : new MySqlParameter("@comment", DBNull.Value),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }

    public int Disable(long id) {
      string query = @"
        update table_patient
        set
          patient_state = 0,
          patient_updateStaffId = @updateStaffId,
          patient_updateDateTime = now()
        where patient_id = @id";

      return DatabaseUtility.Instance.ExecuteNonQuery(query,
        new MySqlParameter("@id", id),
        new MySqlParameter("@updateStaffId", Authentication.Instance.Staff.Id));
    }
  }
}
