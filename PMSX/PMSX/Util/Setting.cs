using System.Configuration;

namespace PMSX.Util {
  public class Setting {
    private static Setting instance;

    private Setting() {
      ConnectionString = ConfigurationManager.AppSettings["connectionString"];
    }

    public static Setting Instance {
      get {
        if (instance == null)
          instance = new Setting();
        return instance;
      }
      private set => instance = value;
    }

    public string ConnectionString { get; private set; }
  }
}
