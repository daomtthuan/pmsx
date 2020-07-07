using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Access {
    public class Staff {
        private static Staff instance;

        private Staff() { }

        public static Staff Instance {
            get {
                if (instance == null)
                    instance = new Staff();
                return instance;
            }
            private set => instance = value;
        }

        public List<Model.Staff> SelectAll() {
            List<Model.Staff> data = new List<Model.Staff>();

            string query = @"
                select *
                from pmsx_staff
				order by staff_name
            ";

            foreach (DataRow row in Database.Instance.Excute(query).Rows) {
                data.Add(new Model.Staff(row));
            }

            return data;
        }

        public List<Model.Staff> SelectByUsername(string username) {
            List<Model.Staff> data = new List<Model.Staff>();

            string query = @"
                select *
                from pmsx_staff
                where staff_username = @username
				order by staff_name
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };


            foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
                data.Add(new Model.Staff(row));
            }

            return data;
        }

        public List<Model.Staff> SelectByRoleId(string roleId) {
            List<Model.Staff> data = new List<Model.Staff>();

            string query = @"
                select pmsx_staff.*
                from pmsx_staff
	                join pmsx_staffRole on staff_id = staffRole_staffId
                where staffRole_roleId = @roleId
				order by staff_name
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@roleId", roleId)
            };


            foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
                data.Add(new Model.Staff(row));
            }

            return data;
        }
    }
}
