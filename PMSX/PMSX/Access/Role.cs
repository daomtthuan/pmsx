using System.Collections.Generic;
using System.Data;

namespace PMSX.Access {
    public class Role {
        private static Role instance;

        private Role() { }

        public static Role Instance {
            get {
                if (instance == null)
                    instance = new Role();
                return instance;
            }
            private set => instance = value;
        }

        public List<Model.Role> SelectAll() {
            List<Model.Role> data = new List<Model.Role>();

            string query = @"
                select *
                from pmsx_role
				order by role_name
            ";


            foreach (DataRow row in Database.Instance.Excute(query).Rows) {
                data.Add(new Model.Role(row));
            }

            return data;
        }
    }
}
