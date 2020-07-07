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

        public List<Model.Session> Select(int state) {
            List<Model.Session> sessions = new List<Model.Session>();

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
	                join pmsx_staff as technician on pmsx_session.session_technicianId = technician.staff_id
	                join pmsx_staff as doctor on pmsx_session.session_doctorId = doctor.staff_id
                where session_state = @state
            ";

            SqlParameter[] parameters = {
                new SqlParameter("@state", state)
            };


            foreach (DataRow row in Database.Instance.Excute(query, parameters).Rows) {
                sessions.Add(new Model.Session(row));
            }

            return sessions;
        }
    }
}
