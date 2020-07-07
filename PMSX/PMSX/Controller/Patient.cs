using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.Controller {
    public class Patient {
        private static Patient instance;        

        private Patient() {
            View = new View.UserControl.View.Patient() {
                Dock = DockStyle.Fill
            };
        }

        public View.UserControl.View.Patient View { get; set; }

        public static Patient Instance {
            get {
                if (instance == null)
                    instance = new Patient();
                return instance;
            }
            private set => instance = value;
        }

        public List<Model.Patient> Get() {
            return Access.Patient.Instance.Select();
        }
    }
}
