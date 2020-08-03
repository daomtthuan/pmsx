using BCrypt.Net;
using PMSX.Exception;
using PMSX.Pattern.Base;
using System;
using System.Configuration;

namespace PMSX.App {
  internal class Config : SingletonBase<Config> {
    private struct License {
      public bool Active;
      public DateTime Expire;
    }

    public struct DatabaseSetting {
      public string Host;
      public string Port;
      public string Username;
      public string Password;
      public string Name;
    }

    private License license;

    private Config() {
      try {
        System.Collections.Specialized.NameValueCollection appSettings = ConfigurationManager.AppSettings;
        if (appSettings.Count == 0) {
          throw SettingException.Instance.NotFound;
        } else {
          license = new License();
          Database = new DatabaseSetting() {
            Host = appSettings["DatabaseHost"],
            Port = appSettings["DatabasePort"],
            Username = appSettings["DatabaseUsername"],
            Password = appSettings["DatabasePassword"],
            Name = appSettings["DatabaseName"]
          };
        }
      } catch (ConfigurationErrorsException) {
        throw SettingException.Instance.ErrorReading;
      }
    }

    public void AddLicenseKey(string key) {
      Properties.Settings.Default.LicenseKey = key;
      Properties.Settings.Default.Save();
    }

    public bool Activated {
      get {
        string key = Properties.Settings.Default.LicenseKey;
        if (BCrypt.Net.BCrypt.Verify("daomtthuan", key)) {
          license.Active = true;
          license.Expire = DateTime.Now;
        }

        return license.Active;
      }
    }

    public DatabaseSetting Database { get; }
  }
}
