using System.Data;

namespace PMSX.Model {
    public class Session {
        public Session(DataRow row) {
            Id = row["session_id"].ToString();
            Name = row["session_name"].ToString();
            TechnicianName = row["session_technicianName"].ToString();
            DoctorName = row["session_doctorName"].ToString();
            Comment = row["session_comment"].ToString();
            State = (int)row["session_state"];
            CreateDatetime = row["session_createDatetime"].ToString();
            UpdateDatetime = row["session_updateDatetime"].ToString();
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string TechnicianName { get; private set; }
        public string DoctorName { get; private set; }
        public string Comment { get; private set; }
        public int State { get; private set; }
        public string CreateDatetime { get; private set; }
        public string UpdateDatetime { get; private set; }
    }
}