using System.Data;

namespace PMSX.Model {
    public class Role {
        public Role(DataRow row) {
            Id = row["role_id"].ToString();
            Name = row["role_name"].ToString();
            Comment = row["role_comment"].ToString();
            State = (int)row["role_state"];
            CreateDatetime = row["role_createDatetime"].ToString();
            UpdateDatetime = row["role_updateDatetime"].ToString();
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Comment { get; private set; }
        public int State { get; private set; }
        public string CreateDatetime { get; private set; }
        public string UpdateDatetime { get; private set; }
    }
}