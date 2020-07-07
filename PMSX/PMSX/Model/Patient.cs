﻿using System.Data;

namespace PMSX.Model {
    public class Patient {
        public Patient(DataRow row) {
            Id = row["patient_id"].ToString();
            Name = row["patient_name"].ToString();
            Year = (int)row["patient_year"];
            Address = row["patient_address"].ToString();
            Comment = row["patient_comment"].ToString();
            State = (int)row["patient_state"];
            CreateDatetime = row["patient_createDatetime"].ToString();
            UpdateDatetime = row["patient_updateDatetime"].ToString();
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Year { get; private set; }
        public string Address { get; private set; }
        public string Comment { get; private set; }
        public int State { get; private set; }
        public string CreateDatetime { get; private set; }
        public string UpdateDatetime { get; private set; }
    }
}