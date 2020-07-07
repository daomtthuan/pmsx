using System.Collections.Generic;
using System.Data;

namespace PMSX.Access {
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

        public List<Model.Biopsy> SelectAll() {
            List<Model.Biopsy> data = new List<Model.Biopsy>();

            string query = @"
                select
	                biopsy_id,
	                concat(biopsyGroup_name, '-', biopsy_code) as biopsy_fullCode,
	                patient_name as biopsy_patientName,
	                technician.staff_name as biopsy_technicianName,
	                doctor.staff_name as biopsy_doctorName,
	                gross.staff_name as biopsy_grossStaffName,
	                biopsy_numberSegment,
	                biopsy_grossDatetime,
	                biopsy_collectDatetime,
                    biopsy_comment,
	                biopsy_state,
	                biopsy_createDatetime,
	                biopsy_updateDatetime
                from pmsx_biopsy
	                join pmsx_biopsyGroup on biopsy_groupId = biopsyGroup_id
	                join pmsx_patient on biopsy_patientId = patient_id
	                left outer join pmsx_session on biopsy_sessionId = session_id
	                left outer join pmsx_staff as technician on session_technicianId = technician.staff_id
	                left outer join pmsx_staff as doctor on session_doctorId = doctor.staff_id
	                join pmsx_staff as gross on biopsy_grossStaffId = gross.staff_id
                order by biopsy_fullCode desc
            ";

            foreach (DataRow row in Database.Instance.Excute(query).Rows) {
                data.Add(new Model.Biopsy(row));
            }

            return data;
        }
    }
}
