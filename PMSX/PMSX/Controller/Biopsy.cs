using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller {
  public class Biopsy {
    private static Biopsy instance;

    private Biopsy() { }

    public static Biopsy Instance {
      get {
        if (instance == null)
          instance = new Biopsy();
        return instance;
      }
      private set => instance = value;
    }

    public List<Model.Biopsy> SelectByGroupId(string id, int state = -1) {
      List<Model.Biopsy> biopsies = new List<Model.Biopsy>();

      string query = @"
        select *
        from pmsx_biopsy
        where
          (@state = -1 or biopsy_state = @state) and
          biopsy_groupId = @id
        order by biopsy_code 
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@state", state)
      };

      foreach (DataRow row in Util.Database.Instance.Excute(query, parameters).Rows) {
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

      return (int)Util.Database.Instance.ExecuteScalar(query, parameters) == 1;
    }
  }
}
