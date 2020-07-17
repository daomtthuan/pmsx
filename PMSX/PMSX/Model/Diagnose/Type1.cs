﻿using System;
using System.Data;

namespace PMSX.Model.Diagnose {
  public class Type1 : Pattern.IModel {
    private readonly int state;

    public Type1(DataRow row) {
      Id = row["diagnose_id"].ToString();
      Code = row["diagnose_code"].ToString();
      MacroId = row["diagnose_macroId"].ToString();
      MacroCode = row["diagnose_macroCode"].ToString();
      MacroDescription = row["diagnose_macroDescription"].ToString();
      MicroId = row["diagnose_microId"].ToString();
      MicroCode = row["diagnose_microCode"].ToString();
      MicroDescription = row["diagnose_microDescription"].ToString();
      Conclusion = row["diagnose_conclusion"].ToString();
      ReadDate = row["diagnose_readDate"].ToString();
      BiopsyId = row["diagnose_biopsyId"].ToString();
      BiopsyCode = row["diagnose_biopsyCode"].ToString();
      PatientName = row["diagnose_patientName"].ToString();

      Comment = row["diagnose_comment"].ToString();
      state = (int)row["diagnose_state"];

      CreateDatetime = row["diagnose_createDatetime"].ToString();
      UpdateDatetime = row["diagnose_updateDatetime"].ToString();

      UpdateStaffId = row["diagnose_updateStaffId"].ToString();
      UpdateDatetime = row["diagnose_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Code { get; private set; }
    public string PatientName { get; private set; }
    public string BiopsyId { get; private set; }
    public string BiopsyCode { get; private set; }
    public string MacroId { get; private set; }
    public string MacroCode { get; private set; }
    public string MacroDescription { get; private set; }
    public string MicroId { get; private set; }
    public string MicroCode { get; private set; }
    public string MicroDescription { get; private set; }
    public string Conclusion { get; private set; }
    public string ReadDate { get; private set; } 

    public string Comment { get; private set; }
    public string State { get => state == 0 ? "Vô hiệu hoá" : "Kích hoạt"; }

    public string CreateStaffId { get; private set; }
    public string CreateDatetime { get; private set; }

    public string UpdateStaffId { get; private set; }
    public string UpdateDatetime { get; private set; }

    public int GetStateNumber() {
      return state;
    }
  }
}
