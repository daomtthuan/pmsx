using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.Controller {   
    public class Staff {
        private static Staff instance;

        private Staff() {
            View = new View.UserControl.View.Staff() {
                Dock = DockStyle.Fill
            };
        }

        public View.UserControl.View.Staff View { get; set; }

        public static Staff Instance {
            get {
                if (instance == null)
                    instance = new Staff();
                return instance;
            }
            private set => instance = value;
        }

        public Model.Staff Auth(string username, string password) {
            List<Model.Staff> staffs = Access.Staff.Instance.SelectByUsername(username);
            if (staffs.Count != 1) {
                return null;
            }

            if (!BCrypt.Net.BCrypt.Verify(password, staffs[0].Password)) {
                return null;
            }

            return staffs[0];
        }

        public List<Model.Staff> GetList() {
            return Access.Staff.Instance.SelectAll();
        }

        public List<Model.Staff> GetListByRoleId(string roleId) {
            return Access.Staff.Instance.SelectByRoleId(roleId);
        }
    }
}
