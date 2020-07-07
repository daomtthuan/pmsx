namespace PMSX.Controller {
    public class Main {
        private static Main instance;

        private Main() { }

        public Model.Staff Staff { get; set; }
        public Model.Session Session { get; set; }

        public static Main Instance {
            get {
                if (instance == null)
                    instance = new Main();
                return instance;
            }
            private set => instance = value;
        }
    }
}
