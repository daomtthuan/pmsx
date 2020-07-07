using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.Controller {
    public class Biopsy {
        private static Biopsy instance;

        private Biopsy() {
            View = new View.UserControl.View.Biopsy() {
                Dock = DockStyle.Fill
            };
        }

        public View.UserControl.View.Biopsy View { get; set; }

        public static Biopsy Instance {
            get {
                if (instance == null)
                    instance = new Biopsy();
                return instance;
            }
            private set => instance = value;
        }

        public List<Model.Biopsy> GetList() {
            return Access.Biopsy.Instance.SelectAll();
        }
    }
}
