using System.Collections.Generic;
using System.Data;

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

        public List<Model.Patient> SelectAll() {
            List<Model.Patient> data = new List<Model.Patient>();

            string query = @"
                select *
                from pmsx_patient
				order by patient_name
            ";

            foreach (DataRow row in Database.Instance.Excute(query).Rows) {
                data.Add(new Model.Patient(row));
            }

            return data;
        }
    }
}
