using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  internal class Biopsy : Pattern.Class.Singleton<Biopsy>, Pattern.Interface.IController {
    private Biopsy() { }

    public List<Model.Biopsy> SelectByGroupId(string id, int state = -1) {
      List<Model.Biopsy> biopsies = new List<Model.Biopsy>();

      string query = @"
        select
          pmsx_biopsy.*,
          concat(biopsy_code,' - ', biopsyGroup_code) as biopsy_fullCode,
          patient_name as biopsy_patientName,
          staff_name as biopsy_grossDoctorName,
          session_name as biopsy_sessionName
        from pmsx_biopsy
          join pmsx_biopsyGroup on biopsy_groupId = biopsyGroup_id
          join pmsx_patient on biopsy_patientId = patient_id
          join pmsx_staff on biopsy_grossDoctorId = staff_id
          left outer join pmsx_session on biopsy_sessionId = session_id
        where
          (@state = -1 or biopsy_state = @state) and
          biopsy_groupId = @id
        order by biopsy_code 
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        biopsies.Add(new Model.Biopsy(row));
      }

      return biopsies;
    }

    public List<Model.Biopsy> SelectByGroupIdAndPatientId(string groupId, string patientId, int state = -1) {
      List<Model.Biopsy> biopsies = new List<Model.Biopsy>();

      string query = @"
        select
          pmsx_biopsy.*,
          concat(biopsy_code,' - ', biopsyGroup_code) as biopsy_fullCode,
          patient_name as biopsy_patientName,
          staff_name as biopsy_grossDoctorName,
          session_name as biopsy_sessionName
        from pmsx_biopsy
          join pmsx_biopsyGroup on biopsy_groupId = biopsyGroup_id
          join pmsx_patient on biopsy_patientId = patient_id
          join pmsx_staff on biopsy_grossDoctorId = staff_id
          left outer join pmsx_session on biopsy_sessionId = session_id
        where
          (@state = -1 or biopsy_state = @state) and
          biopsy_groupId = @groupId and
          biopsy_patientId = @patientId
        order by biopsy_code 
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@groupId", groupId),
        new SqlParameter("@patientId", patientId),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        biopsies.Add(new Model.Biopsy(row));
      }

      return biopsies;
    }

    public bool Insert(string groupId, string patientId, string sessionId, string grossStaffId, int segment, DateTime grossDatetime, DateTime collectDatetime, string comment) {
      string query = @"
        set xact_abort on
        begin tran
          begin try
            declare @numberBiopsy bigint = (
              select biopsyGroup_numberBiopsy
              from pmsx_biopsyGroup
              where biopsyGroup_id = @groupId
            )

            insert into pmsx_biopsy (
              biopsy_code,
              biopsy_groupId,
              biopsy_patientId,
              biopsy_sessionId,
              biopsy_grossDoctorId,
              biopsy_segment,
              biopsy_grossDatetime,
              biopsy_collectDatetime,
              biopsy_comment,
              biopsy_createStaffId
            ) values (
              @numberBiopsy + 1,
              @groupId,
              @patientId,
              @sessionId,
              @grossStaffId,
              @segment,
              @grossDatetime,
              @collectDatetime,
              @comment,
              @createStaffId
            )

            update pmsx_biopsyGroup
            set
              biopsyGroup_numberBiopsy = @numberBiopsy + 1
            where biopsyGroup_id = @groupId

            select 1
            commit
          end try
          begin catch
            rollback
            select 0
          end catch
        set xact_abort off
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@groupId", groupId),
        new SqlParameter("@patientId", patientId),
        new SqlParameter("@sessionId", sessionId),
        new SqlParameter("@grossStaffId", grossStaffId),
        new SqlParameter("@segment", segment),
        new SqlParameter("@grossDatetime", grossDatetime),
        new SqlParameter("@collectDatetime", collectDatetime),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      return (int)Utils.Database.Instance.ExecuteScalar(query, parameters) == 1;
    }

    public void Update(string id, string patientId, string sessionId, string grossStaffId, int segment, DateTime grossDatetime, DateTime collectDatetime, string comment, int state) {
      string query = @"
        update pmsx_biopsy
        set
          biopsy_patientId = @patientId,
          biopsy_sessionId = @sessionId,
          biopsy_grossDoctorId = @grossStaffId,
          biopsy_segment = @segment,
          biopsy_grossDatetime = @grossDatetime,
          biopsy_collectDatetime = @collectDatetime,
	        biopsy_comment = @comment,
          biopsy_state = @state,
          biopsy_updateStaffId = @updateStaffId,
	        biopsy_updateDatetime = getdate()
        where biopsy_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@patientId", patientId),
        new SqlParameter("@sessionId", sessionId),
        new SqlParameter("@grossStaffId", grossStaffId),
        new SqlParameter("@segment", segment),
        new SqlParameter("@grossDatetime", grossDatetime),
        new SqlParameter("@collectDatetime", collectDatetime),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.Excute(query, parameters);
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_biopsy
        set
          biopsy_state = 0,
          biopsy_updateStaffId = @updateStaffId,
	        biopsy_updateDatetime = getdate()
        where biopsy_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.Excute(query, parameters);
    }
  }
}
