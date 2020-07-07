using System.Collections.Generic;

namespace PMSX.Controller {
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

        public List<Model.Session> Get(int state) {
            return Access.Session.Instance.Select(state);
        }
    }
}
