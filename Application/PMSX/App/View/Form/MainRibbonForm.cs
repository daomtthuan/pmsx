using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMSX.App.View.Control.Table;
using PMSX.Pattern.Factory;
using PMSX.Properties;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  internal partial class MainRibbonForm : RibbonForm {
    public MainRibbonForm() {
      InitializeComponent();
    }

    private BarButtonItem CreaetButton<Control>(string caption, SvgImage image) where Control : XtraUserControl, new() {
      BarButtonItem button = new BarButtonItem() {
        Caption = caption
      };
      button.ImageOptions.SvgImage = image;
      button.ImageOptions.AllowGlyphSkinning = DefaultBoolean.True;
      button.ImageOptions.AllowStubGlyph = DefaultBoolean.True;
      button.ItemAppearance.Normal.Options.UseTextOptions = true;
      button.ItemAppearance.Hovered.Options.UseTextOptions = true;
      button.ItemAppearance.Disabled.Options.UseTextOptions = true;
      button.ItemAppearance.Pressed.Options.UseTextOptions = true;
      button.ItemAppearance.Normal.TextOptions.WordWrap = WordWrap.NoWrap;
      button.ItemAppearance.Hovered.TextOptions.WordWrap = WordWrap.NoWrap;
      button.ItemAppearance.Disabled.TextOptions.WordWrap = WordWrap.NoWrap;
      button.ItemAppearance.Pressed.TextOptions.WordWrap = WordWrap.NoWrap;
      button.ItemClick += (sender, e) => {
        OverlayUtility.Instance.StartProcess(this, () => {
          if (layout.Controls.Count > 0) {
            layout.Controls[0].Dispose();
            layout.Controls.Clear();
          }
          layout.Controls.Add(ControlFactory<Control>.Instance.Create());
        }, statusLabel);
      };
      ribbon.Items.Add(button);
      return button;
    }

    private RibbonPageGroup CreateGroup(string text, params BarItem[] items) {
      RibbonPageGroup group = new RibbonPageGroup(text) {
        AllowTextClipping = false
      };
      group.ItemLinks.AddRange(items);
      return group;
    }

    private RibbonPage CreatePage(string text, params RibbonPageGroup[] groups) {
      RibbonPage page = new RibbonPage(text);
      page.Groups.AddRange(groups);
      return page;
    }

    private RibbonPageCategory CreateCategory(string text, params RibbonPage[] pages) {
      RibbonPageCategory category = new RibbonPageCategory() {
        Text = text
      };
      category.Pages.AddRange(pages);
      return category;
    }

    private async void MainRibbonForm_Load(object sender, EventArgs e) {
      await LoadingUtility.Instance.Close("Sẳn sàng!");

      if (FormFactory<LoginForm>.Instance.Create().ShowDialog() == DialogResult.OK) {
        OverlayUtility.Instance.StartProcess(this, () => {
          if (Authentication.Instance.HasOneRole(Authentication.Role.Admin, Authentication.Role.Doctor, Authentication.Role.Technician)) {
            ribbon.PageCategories.AddRange(new[] {
              CreateCategory("Quản lý",
                CreatePage("Nhân sự",
                CreateGroup("Tài khoản",
                  CreaetButton<StaffTable>("Nhân viên", Resources.User),
                  CreaetButton<PermissionTable>("Phân quyền", Resources.Key)),
                CreateGroup("Công việc",
                  CreaetButton<SessionTable>("Phiên làm việc", Resources.Calendar))))
            });
          }
        }, statusLabel, "Khởi tạo chức năng...");
        DisplayUtility.Instance.Set(this, true);
      } else {
        Application.Exit();
      }
    }

    private void LightThemeButton_ItemClick(object sender, ItemClickEventArgs e) {
      if (Config.Instance.Theme == "Light") {
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        Config.Instance.Theme = "Light";
      }, statusLabel, "Thay đổi giao diện...");
    }

    private void DarkThemeButton_ItemClick(object sender, ItemClickEventArgs e) {
      if (Config.Instance.Theme == "Dark") {
        return;
      }

      OverlayUtility.Instance.StartProcess(this, () => {
        Config.Instance.Theme = "Dark";
      }, statusLabel, "Thay đổi giao diện...");
    }
  }
}