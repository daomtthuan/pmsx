using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using PMSX.App.View.Control.Table;
using PMSX.Pattern.Factory;
using PMSX.Properties;
using PMSX.Utility.View;
using PMSX.Utility.View.Form;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace PMSX.App.View.Form {
  internal partial class MainRibbonForm : RibbonForm {
    public MainRibbonForm() {
      InitializeComponent();
    }

    private BarButtonItem CreateButton<Control>(string caption, SvgImage image) where Control : XtraUserControl, new() {
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
      layout.Dock = DockStyle.Fill;

      string year = DateTime.Now.Year == 2020 ? "2020" : $"2020 - {DateTime.Now.Year}";
      aboutInformationLabel.Text =
        $"Phiên bản {Assembly.GetExecutingAssembly().GetName().Version}\r\n" +
        $"Bản quyền © {year} Daomtthuan\r\n" +
        $"__________________________________________________\r\n\r\n" +
        $"Thông tin Nhà phát triển:\r\n" +
        $"Website: daomtthuan.com\r\n" +
        $"Email: dao.mt.thuan@gmail.com\r\n" +
        $"Điện thoại: +84 939 908 568\r\n" +
        $"Facebook: facebook.com/dao.mt.thuan\r\n" +
        $"__________________________________________________\r\n\r\n" +
        $"Thời hạn khoá kích hoạt bản quyền:\r\n" +
        $"{Config.Instance.LicenseExpiry.Date}\r\n\r\n";

      await LoadingUtility.Instance.Close("Sẳn sàng!");

      if (FormFactory<LoginForm>.Instance.Create().ShowDialog() == DialogResult.OK) {
        OverlayUtility.Instance.StartProcess(this, () => {
          if (Authentication.Instance.HasOneRole(Authentication.Role.Admin, Authentication.Role.Doctor, Authentication.Role.Technician)) {
            RibbonPageCategory manageCategory = CreateCategory("Quản lý",
              CreatePage("Xét nghiệm",
                CreateGroup("Phòng khám",
                  CreateButton<PatientTable>("Bệnh nhân", Resources.Bed),
                  CreateButton<StaffTable>("Sinh thiết", Resources.Biopsy)),
                CreateGroup("Chẩn đoán",
                  CreateButton<StaffTable>("Loại 1", Resources.Diagnosy)),
                CreateGroup("Giải phẫu bệnh",
                  CreateButton<MacroGroupTable>("Nhóm đại thể", Resources.Microscope),
                  CreateButton<StaffTable>("Đại thể", Resources.Microscope),
                  CreateButton<MicroGroupTable>("Nhóm vi thể", Resources.Microscope),
                  CreateButton<StaffTable>("Vi thể", Resources.Microscope))));

            if (Authentication.Instance.HasRole(Authentication.Role.Admin)) {
              manageCategory.Pages.Add(
                CreatePage("Nhân sự",
                  CreateGroup("Tài khoản",
                    CreateButton<StaffTable>("Nhân viên", Resources.Users),
                    CreateButton<PermissionTable>("Phân quyền", Resources.Key)),
                  CreateGroup("Công việc",
                    CreateButton<SessionTable>("Phiên làm việc", Resources.Calendar))));
            }

            ribbon.PageCategories.Add(manageCategory);
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

    private void LogoutButton_ItemClick(object sender, BackstageViewItemEventArgs e) {
      Application.Restart();
    }

    private void ExitButton_ItemClick(object sender, BackstageViewItemEventArgs e) {
      Application.Exit();
    }

    private void AccountButton_ItemClick(object sender, ItemClickEventArgs e) {
      if (FormFactory<AccountForm>.Instance.Create().ShowDialog() == DialogResult.OK && layout.Controls.Count > 0) {
        if (layout.Controls[0].Name == "StaffTable") {
          OverlayUtility.Instance.StartProcess(this, () => {
            layout.Controls[0].Dispose();
            layout.Controls.Clear();
            layout.Controls.Add(ControlFactory<StaffTable>.Instance.Create());
          }, statusLabel);
        }
      }
    }

    private void PasswordButton_ItemClick(object sender, ItemClickEventArgs e) {
      FormFactory<PasswordForm>.Instance.Create().ShowDialog();
    }

    private void LicenseKeyButton_Click(object sender, EventArgs e) {
      if (FormFactory<LicenseKeyForm>.Instance.Create().ShowDialog() == DialogResult.OK) {
        AlertUtility.Instance.ShowInformation("Đổi thành công\r\nHệ thống sẽ khởi động lại");
        Application.Restart();
      }
    }

    private void UpdateVersionButton_Click(object sender, EventArgs e) {
      AlertUtility.Instance.ShowInformation("Phiên bản hiện tại là phiên bản mới nhất");
    }

    private void feedbackButton_Click(object sender, EventArgs e) {
      Process.Start("https://daomtthuan.com");
    }
  }
}