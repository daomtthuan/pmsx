using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.Controller {
    public class Session {
        private static Session instance;

        private Session() {
            View = new View.UserControl.View.Session() {
                Dock = DockStyle.Fill
            };
        }

        public View.UserControl.View.Session View { get; set; }

        public static Session Instance {
            get {
                if (instance == null)
                    instance = new Session();
                return instance;
            }
            private set => instance = value;
        }

        public List<Model.Session> GetList() {
            return Access.Session.Instance.SelectAll();
        }

        public List<Model.Session> GetListByState(int state) {
            return Access.Session.Instance.SelectByState(state);
        }
    }
}
