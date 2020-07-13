﻿using System;
using System.Data;

namespace PMSX.Model {
  public class Patient {
    private readonly int state;

    public Patient(DataRow row) {
      Id = row["patient_id"].ToString();
      Name = row["patient_name"].ToString();
      Year = (int)row["patient_year"];
      Address = row["patient_address"].ToString();

      Comment = row["patient_comment"].ToString();
      state = (int)row["patient_state"];

      CreateStaffId = row["patient_createStaffId"].ToString();
      CreateDatetime = row["patient_createDatetime"].ToString();

      UpdateStaffId = row["patient_updateStaffId"].ToString();
      UpdateDatetime = row["patient_updateDatetime"].ToString();
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Year { get; private set; }
    public int YearOld { get => DateTime.Now.Year - Year; }
    public string Address { get; private set; }

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