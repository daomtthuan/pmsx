using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PMSX.Access {
    public class Session {
        private static Session instance;

        private Session() { }

        public static Session Instance {
            get {
                if (instance == null)
                    instance = new Session();
                return instance;
            }
            private set => instance = value;
        }

        public List<Model.Session> SelectAll() {
            List<Model.Session> data = new List<Model.Session>();

            string query = @"
                select
	                session_id,
	                session_name,
	                technician.staff_name as session_technicianName,
	                doctor.staff_name as session_doctorName,
	                session_comment,
	                session_state,
	                session_createDatetime,
	                session_updateDatetime
                from pmsx_session
	                join pmsx_staff as technician on session_technicianId = technician.staff_id
	                join pmsx_staff as doctor on session_doctorId = doctor.staff_id
				order by session_name
            ";

            foreach (DataRow row in Database.Instance.Excute(query).Rows) {
                data.Add(new Model.Session(row));
            }

            return data;
        }

        public List<Model.Session> SelectByState(int state) {
            List<Model.Session> data = new List<Model.Session>();

            string query = @"
                select
	                session_id,
	                session_name,
	                technician.staff_name as session_technicianName,
	                doctor.staff_name as session_doctorName,
	                session_comment,
	                session_state,
	                session_createDatetime,
	                session_updateDatetime
                from pmsx_session
	                join pmsx_staff as technician on session_technicianId = technician.staff_id
	                join pmsx_staff as doctor on session_doctorId = doctor.staff_id
                where session_state = @state
				order by session_name
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@state", state)
            };


            foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
                data.Add(new Model.Session(row));
            }

            return data;
        }
    }
}
