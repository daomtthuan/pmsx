using System.Data;

namespace PMSX.Model {
    public class Staff {
        public Staff(DataRow row) {
            Id = row["staff_id"].ToString();
            Username = row["staff_username"].ToString();
            Password = row["staff_password"].ToString();
            Name = row["staff_name"].ToString();
            State = (int)row["staff_state"];
            CreateDatetime = row["staff_createDatetime"].ToString();
            UpdateDatetime = row["staff_updateDatetime"].ToString();
        }

        public string Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public int State { get; private set; }
        public string CreateDatetime { get; private set; }
        public string UpdateDatetime { get; private set; }
    }
}