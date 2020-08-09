using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using PMSX.Exception;
using PMSX.Pattern.Base;
using PMSX.Properties;
using PMSX.Utility.View;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PMSX.App {
  internal class Config : SingletonBase<Config> {
    internal struct DatabaseSetting {
      public string Host;
      public string Port;
      public string Username;
      public string Password;
      public string Name;
    }

    internal enum LicenseState : int {
      Accept,
      Outdated,
      Invalid,
      Ignore,
      Error
    }

    private Config() {
      try {
        System.Collections.Specialized.NameValueCollection appSettings = ConfigurationManager.AppSettings;
        if (appSettings.Count == 0) {
          AlertUtility.Instance.ShowError(ConfigException.Instance.NotFound());
          Application.Exit();
        } else {
          Database = new DatabaseSetting() {
            Host = appSettings["DatabaseHost"],
            Port = appSettings["DatabasePort"],
            Username = appSettings["DatabaseUsername"],
            Password = appSettings["DatabasePassword"],
            Name = appSettings["DatabaseName"]
          };
        }
      } catch (ConfigurationErrorsException exception) {
        AlertUtility.Instance.ShowError(ConfigException.Instance.ErrorReading(exception));
        Application.Exit();
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Error(exception));
        Application.Exit();
      }
    }

    public void SetupTheme() {
      WindowsFormsSettings.LoadApplicationSettings();
      Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
      skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(skin.CustomSvgPalettes[Theme]);
      LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
    }

    public LicenseState CheckLicense(string key = "") {
      try {
        key = key == "" ? LicenseKey : BCrypt.Net.BCrypt.HashPassword(key);
      } catch (System.Exception exception) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Encode(exception));
        return LicenseState.Error;
      }

      if (key == "") {
        return LicenseState.Ignore;
      } else {
        try {
          if (BCrypt.Net.BCrypt.Verify("daomtthuan", key)) {
            if (key != LicenseKey) {
              LicenseKey = key;
            }
            LicenseExpiry = DateTime.Now.AddDays(1);
            return LicenseState.Accept;
          } else {
            return LicenseState.Ignore;
          }
        } catch (System.Exception exception) {
          AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Decode(exception));
          return LicenseState.Error;
        }
      }
    }

    private string LicenseKey {
      get => Settings.Default.LicenseKey;
      set {
        Settings.Default.LicenseKey = value;
        Settings.Default.Save();
      }
    }

    public DateTime LicenseExpiry { get; set; }

    public string Theme {
      get => Settings.Default.Theme;
      set {
        Settings.Default.Theme = value;
        Settings.Default.Save();

        Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
        skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(skin.CustomSvgPalettes[value]);
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
      }
    }

    public DatabaseSetting Database { get; }
  }
}
