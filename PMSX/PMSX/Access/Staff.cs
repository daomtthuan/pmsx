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

        public List<Model.Staff> Select() {
            List<Model.Staff> staffs = new List<Model.Staff>();

            string query = @"
                select *
                from pmsx_staff
            ";

            SqlParameter[] parameters = {};


            foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
                staffs.Add(new Model.Staff(row));
            }

            return staffs;
        }

        public List<Model.Staff> Select(string username) {
            List<Model.Staff> staffs = new List<Model.Staff>();

            string query = @"
                select *
                from pmsx_staff
                where staff_username = @username
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@username", username)
            };


            foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
                staffs.Add(new Model.Staff(row));
            }

            return staffs;
        }
    }
}
