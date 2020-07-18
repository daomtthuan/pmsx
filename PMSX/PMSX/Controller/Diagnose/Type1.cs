using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Controller.Diagnose {
  internal class Type1 : Pattern.Class.Singleton<Type1>, Pattern.Interface.IController {
    private Type1() { }

    public List<Model.Diagnose.Type1> SelectAll(int state = -1) {
      List<Model.Diagnose.Type1> diagnoses = new List<Model.Diagnose.Type1>();

      string query = @"
          select
            pmsx_diagnoseType1.*,
            biopsy_groupId as diagnose_biopsyGroupId,
            macro_groupId as diagnose_macroGroupId,
            macro_code as diagnose_macroCode,
            micro_groupId as diagnose_microGroupId,
            micro_code as diagnose_microCode,
            biopsy_code as diagnose_biopsyCode,
            patient_name as diagnose_patientName
          from pmsx_diagnoseType1
            left outer join pmsx_macro on macro_id = diagnose_macroId
            left outer join pmsx_micro on micro_id = diagnose_microId
            join pmsx_biopsy on biopsy_id = diagnose_biopsyId
            join pmsx_patient on biopsy_patientId = patient_id
          where
            (@state = -1 or diagnose_state = @state)
          order by diagnose_code
        ";

      SqlParameter[] parameters = {
          new SqlParameter("@state", state)
        };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        diagnoses.Add(new Model.Diagnose.Type1(row));
      }

      return diagnoses;
    }

    public List<Model.Diagnose.Type1> SelectByCode(string code, int state = -1) {
      List<Model.Diagnose.Type1> diagnoses = new List<Model.Diagnose.Type1>();

      string query = @"
          select
            pmsx_diagnoseType1.*,
            biopsy_groupId as diagnose_biopsyGroupId,
            macro_groupId as diagnose_macroGroupId,
            macro_code as diagnose_macroCode,
            micro_groupId as diagnose_microGroupId,
            micro_code as diagnose_microCode,
            biopsy_code as diagnose_biopsyCode,
            patient_name as diagnose_patientName
          from pmsx_diagnoseType1
            left outer join pmsx_macro on macro_id = diagnose_macroId
            left outer join pmsx_micro on micro_id = diagnose_microId
            join pmsx_biopsy on biopsy_id = diagnose_biopsyId
            join pmsx_patient on biopsy_patientId = patient_id
          where
            (@state = -1 or diagnose_state = @state) and
            diagnose_code = @code
          order by diagnose_code
        ";

      SqlParameter[] parameters = {
          new SqlParameter("@code", code),
          new SqlParameter("@state", state)
        };

      foreach (DataRow row in Utils.Database.Instance.Excute(query, parameters).Rows) {
        diagnoses.Add(new Model.Diagnose.Type1(row));
      }

      return diagnoses;
    }

    public bool Insert(string code, string biopsyId, string macroId, string macroDescription, string microId, string microDescription, string conclusion, DateTime readDate, string comment) {
      if (SelectByCode(code).Count > 0) {
        return false;
      }

      string query = @"
        insert into pmsx_diagnoseType1(
          diagnose_code,
          diagnose_biopsyId,
          diagnose_macroId,
          diagnose_macroDescription,
          diagnose_microId,
          diagnose_microDescription,
          diagnose_conclusion,
          diagnose_readDate,
          diagnose_comment,
          diagnose_createStaffId
        ) values(
          @code,
          @biopsyId,
          @macroId,
          @macroDescription,
          @microId,
          @microDescription,
          @conclusion,
          @readDate,
          @comment,
          @createStaffId
        )
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@code", code),
        new SqlParameter("@biopsyId", biopsyId),
        macroId.Length > 0 ? new SqlParameter("@macroId", macroId) : new SqlParameter("@macroId", DBNull.Value),
        new SqlParameter("@macroDescription", macroDescription),
        microId.Length > 0 ? new SqlParameter("@microId", microId) : new SqlParameter("@microId", DBNull.Value),
        new SqlParameter("@microDescription", microDescription),
        new SqlParameter("@conclusion", conclusion),
        new SqlParameter("@readDate", readDate),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@createStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public bool Update(string id, string code, string biopsyId, string macroId, string macroDescription, string microId, string microDescription, string conclusion, DateTime readDate, string comment, int state) {
      List<Model.Diagnose.Type1> diagnoses = SelectByCode(code);
      if (diagnoses.Count > 0) {
        if (diagnoses[0].Id != id) {
          return false;
        }
      }

      string query = @"
        update pmsx_diagnoseType1
        set 
	        diagnose_code = @code,
	        diagnose_biopsyId = @biopsyId,
          diagnose_macroId = @macroId,
          diagnose_macroDescription = @macroDescription,
          diagnose_microId = @microId,
          diagnose_microDescription = @microDescription,
          diagnose_conclusion = @conclusion,
          diagnose_readDate = @readDate,
          diagnose_comment = @comment,
          diagnose_state = @state,
          diagnose_updateStaffId = @updateStaffId,
	        diagnose_updateDatetime = getdate()                    
        where diagnose_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@code", code),
        new SqlParameter("@biopsyId", biopsyId),
        macroId.Length > 0 ? new SqlParameter("@macroId", macroId) : new SqlParameter("@macroId", DBNull.Value),
        new SqlParameter("@macroDescription", macroDescription),
        microId.Length > 0 ? new SqlParameter("@microId", microId) : new SqlParameter("@microId", DBNull.Value),
        new SqlParameter("@microDescription", microDescription),
        new SqlParameter("@conclusion", conclusion),
        new SqlParameter("@readDate", readDate),
        comment.Length > 0 ? new SqlParameter("@comment", comment) : new SqlParameter("@comment", DBNull.Value),
        new SqlParameter("@state", state),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
      return true;
    }

    public void Disable(string id) {
      string query = @"
        update pmsx_diagnoseType1
        set 
          diagnose_state = 0,
          diagnose_updateStaffId = @updateStaffId,
	        diagnose_updateDatetime = getdate()                    
        where diagnose_id = @id
      ";

      SqlParameter[] parameters = {
        new SqlParameter("@id", id),
        new SqlParameter("@updateStaffId", Main.Instance.Staff.Id)
      };

      Utils.Database.Instance.ExcuteNon(query, parameters);
    }
  }
}
