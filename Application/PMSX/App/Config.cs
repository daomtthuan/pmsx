using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using PMSX.Exception;
using PMSX.Pattern.Base;
using PMSX.Utility.View;
using System;
using System.Configuration;
using System.Windows.Forms;

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
          AlertUtility.Instance.ShowError(ConfigException.Instance.NotFound());
          Application.Exit();
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
      } catch (ConfigurationErrorsException e) {
        AlertUtility.Instance.ShowError(ConfigException.Instance.ErrorReading(e));
        Application.Exit();
      } catch (System.Exception e) {
        AlertUtility.Instance.ShowError(Exception.SystemException.Instance.Error(e));
        Application.Exit();
      }
    }

    public void SetupTheme() {
      Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
      skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(skin.CustomSvgPalettes[Config.Instance.Theme]);
      LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
      WindowsFormsSettings.LoadApplicationSettings();
    }

    public bool Activated {
      get {
        if (BCrypt.Net.BCrypt.Verify("daomtthuan", LicenseKey)) {
          license.Active = true;
          license.Expire = DateTime.Now;
        }

        return license.Active;
      }
    }

    public string LicenseKey {
      private get => Properties.Settings.Default.LicenseKey;
      set {
        Properties.Settings.Default.LicenseKey = value;
        Properties.Settings.Default.Save();
      }
    }

    public string Theme {
      get => Properties.Settings.Default.Theme;
      set {
        Properties.Settings.Default.Theme = value;
        Properties.Settings.Default.Save();

        Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
        skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(skin.CustomSvgPalettes[value]);
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
      }
    }

    public DatabaseSetting Database { get; }
  }
}
