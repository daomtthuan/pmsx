using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Access {
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

        public List<Model.Patient> Select() {
            List<Model.Patient> patients = new List<Model.Patient>();

            string query = @"
                select *
                from pmsx_patient
            ";

            SqlParameter[] parameters = { };


            foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
                patients.Add(new Model.Patient(row));
            }

            return patients;
        }
    }
}
