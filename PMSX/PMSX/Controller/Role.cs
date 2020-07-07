using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.Controller {
    public class Role {
        private static Role instance;

        private Role() {
            View = new View.UserControl.View.Role() {
                Dock = DockStyle.Fill
            };
        }

        public View.UserControl.View.Role View { get; set; }

        public static Role Instance {
            get {
                if (instance == null)
                    instance = new Role();
                return instance;
            }
            private set => instance = value;
        }

        public List<Model.Role> GetList() {
            return Access.Role.Instance.SelectAll();
        }
    }
}
