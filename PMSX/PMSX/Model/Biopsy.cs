using System.Data;

namespace PMSX.Model {
    public class Biopsy {
        public Biopsy(DataRow row) {
            Id = row["biopsy_id"].ToString();
            FullCode = row["biopsy_fullCode"].ToString();
            PatientName = row["biopsy_patientName"].ToString();
            TechnicianName = row["biopsy_technicianName"].ToString();
            DoctorName = row["biopsy_doctorName"].ToString();
            GrossStaffName = row["biopsy_grossStaffName"].ToString();
            NumberSegment = (int)row["biopsy_numberSegment"];
            GrossDatetime = row["biopsy_grossDatetime"].ToString();
            CollectDatetime = row["biopsy_collectDatetime"].ToString();
            Comment = row["biopsy_comment"].ToString();
            State = (int)row["biopsy_state"];
            CreateDatetime = row["biopsy_createDatetime"].ToString();
            UpdateDatetime = row["biopsy_updateDatetime"].ToString();
        }

        public string Id { get; private set; }
        public string FullCode { get; private set; }
        public string PatientName { get; private set; }
        public string TechnicianName { get; private set; }
        public string DoctorName { get; private set; }
        public string GrossStaffName { get; private set; }
        public int NumberSegment { get; private set; }
        public string GrossDatetime { get; private set; }
        public string CollectDatetime { get; private set; }
        public string Comment { get; private set; }
        public int State { get; private set; }
        public string CreateDatetime { get; private set; }
        public string UpdateDatetime { get; private set; }
    }
}