using System.Data;

namespace PMSX.Model {
    public class StaffRole {
        public StaffRole(DataRow row) {
            Id = row["staffRole_id"].ToString();
            StaffId = row["staffRole_staffId"].ToString();
            RoleId = row["staffRole_roleId"].ToString();
            CreateDatetime = row["staffRole_createDatetime"].ToString();
        }

        public string Id { get; private set; }
        public string StaffId { get; private set; }
        public string RoleId { get; private set; }
        public string CreateDatetime { get; private set; }
    }
}