using System.Configuration;

namespace PMSX.Utils {
  internal class Setting : Pattern.Class.Singleton<Setting> {
    private Setting() {
      ConnectionString = ConfigurationManager.AppSettings["connectionString"];
    }

    public string ConnectionString { get; private set; }
  }
}
