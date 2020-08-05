namespace PMSX.App.View.Form {
  partial class MainRibbonForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.profileButton = new DevExpress.XtraBars.BarButtonItem();
      this.passwordButton = new DevExpress.XtraBars.BarButtonItem();
      this.statusLabel = new DevExpress.XtraBars.BarStaticItem();
      this.themeSelect = new DevExpress.XtraBars.BarSubItem();
      this.lightThemeButton = new DevExpress.XtraBars.BarButtonItem();
      this.darkThemeButton = new DevExpress.XtraBars.BarButtonItem();
      this.homePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.settingPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.accountGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.systemGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.statusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.layout = new DevExpress.XtraEditors.PanelControl();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.profileButton,
            this.passwordButton,
            this.statusLabel,
            this.themeSelect,
            this.lightThemeButton,
            this.darkThemeButton});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.Margin = new System.Windows.Forms.Padding(2);
      this.ribbon.MaxItemId = 28;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homePage,
            this.settingPage});
      this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
      this.ribbon.Size = new System.Drawing.Size(1280, 170);
      this.ribbon.StatusBar = this.statusBar;
      // 
      // profileButton
      // 
      this.profileButton.Caption = "Thông tin cá nhân";
      this.profileButton.Id = 2;
      this.profileButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.profileButton.ImageOptions.AllowStubGlyph = DevExpress.Utils.DefaultBoolean.True;
      this.profileButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.Profile;
      this.profileButton.ItemAppearance.Disabled.Options.UseTextOptions = true;
      this.profileButton.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.profileButton.ItemAppearance.Hovered.Options.UseTextOptions = true;
      this.profileButton.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.profileButton.ItemAppearance.Normal.Options.UseTextOptions = true;
      this.profileButton.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.profileButton.ItemAppearance.Pressed.Options.UseTextOptions = true;
      this.profileButton.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.profileButton.Name = "profileButton";
      // 
      // passwordButton
      // 
      this.passwordButton.Caption = "Mật khẩu";
      this.passwordButton.Id = 3;
      this.passwordButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.passwordButton.ImageOptions.AllowStubGlyph = DevExpress.Utils.DefaultBoolean.True;
      this.passwordButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.Password;
      this.passwordButton.ItemAppearance.Disabled.Options.UseTextOptions = true;
      this.passwordButton.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.passwordButton.ItemAppearance.Hovered.Options.UseTextOptions = true;
      this.passwordButton.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.passwordButton.ItemAppearance.Normal.Options.UseTextOptions = true;
      this.passwordButton.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.passwordButton.ItemAppearance.Pressed.Options.UseTextOptions = true;
      this.passwordButton.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.passwordButton.Name = "passwordButton";
      // 
      // statusLabel
      // 
      this.statusLabel.Caption = "Đảng tải dữ liệu...";
      this.statusLabel.Id = 4;
      this.statusLabel.Name = "statusLabel";
      // 
      // themeSelect
      // 
      this.themeSelect.Caption = "Giao diện";
      this.themeSelect.Id = 25;
      this.themeSelect.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.themeSelect.ImageOptions.SvgImage = global::PMSX.Properties.Resources.Paint;
      this.themeSelect.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lightThemeButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.darkThemeButton)});
      this.themeSelect.Name = "themeSelect";
      // 
      // lightThemeButton
      // 
      this.lightThemeButton.Caption = "Nền sáng";
      this.lightThemeButton.Id = 26;
      this.lightThemeButton.Name = "lightThemeButton";
      this.lightThemeButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LightThemeButton_ItemClick);
      // 
      // darkThemeButton
      // 
      this.darkThemeButton.Caption = "Nền tối";
      this.darkThemeButton.Id = 27;
      this.darkThemeButton.Name = "darkThemeButton";
      this.darkThemeButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DarkThemeButton_ItemClick);
      // 
      // homePage
      // 
      this.homePage.Name = "homePage";
      this.homePage.Text = "Trang chủ";
      // 
      // settingPage
      // 
      this.settingPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.accountGroup,
            this.systemGroup});
      this.settingPage.Name = "settingPage";
      this.settingPage.Text = "Cài đặt";
      // 
      // accountGroup
      // 
      this.accountGroup.ItemLinks.Add(this.profileButton);
      this.accountGroup.ItemLinks.Add(this.passwordButton);
      this.accountGroup.Name = "accountGroup";
      this.accountGroup.Text = "Tài khoản";
      // 
      // systemGroup
      // 
      this.systemGroup.ItemLinks.Add(this.themeSelect);
      this.systemGroup.Name = "systemGroup";
      this.systemGroup.Text = "Hệ thống";
      // 
      // statusBar
      // 
      this.statusBar.ItemLinks.Add(this.statusLabel);
      this.statusBar.Location = new System.Drawing.Point(0, 694);
      this.statusBar.Name = "statusBar";
      this.statusBar.Ribbon = this.ribbon;
      this.statusBar.Size = new System.Drawing.Size(1280, 26);
      // 
      // layout
      // 
      this.layout.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 170);
      this.layout.Name = "layout";
      this.layout.Size = new System.Drawing.Size(1280, 524);
      this.layout.TabIndex = 2;
      // 
      // MainRibbonForm
      // 
      this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1280, 720);
      this.Controls.Add(this.layout);
      this.Controls.Add(this.statusBar);
      this.Controls.Add(this.ribbon);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(1280, 720);
      this.Name = "MainRibbonForm";
      this.Ribbon = this.ribbon;
      this.StatusBar = this.statusBar;
      this.Text = "PMSX";
      this.Load += new System.EventHandler(this.MainRibbonForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar statusBar;
    private DevExpress.XtraBars.BarButtonItem profileButton;
    private DevExpress.XtraBars.Ribbon.RibbonPage settingPage;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup accountGroup;
    private DevExpress.XtraBars.BarButtonItem passwordButton;
    private DevExpress.XtraBars.BarStaticItem statusLabel;
    private DevExpress.XtraBars.Ribbon.RibbonPage homePage;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup systemGroup;
    private DevExpress.XtraBars.BarSubItem themeSelect;
    private DevExpress.XtraBars.BarButtonItem lightThemeButton;
    private DevExpress.XtraBars.BarButtonItem darkThemeButton;
    private DevExpress.XtraEditors.PanelControl layout;
  }
}