using System.Configuration;

namespace PMSX.Utils {
  public class Setting : Pattern.Singleton<Setting> {
    private Setting() {
      ConnectionString = ConfigurationManager.AppSettings["connectionString"];
    }

    public string ConnectionString { get; private set; }
  }
}
