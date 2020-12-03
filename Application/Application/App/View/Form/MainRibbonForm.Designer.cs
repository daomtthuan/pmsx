namespace PMSXApplication.App.View.Form {
  internal partial class MainRibbonForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRibbonForm));
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.backstage = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
      this.aboutTab = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
      this.aboutTabLayout = new DevExpress.XtraLayout.LayoutControl();
      this.brand = new PMSXApplication.App.View.Control.BrandControl();
      this.updateVersionButton = new DevExpress.XtraEditors.SimpleButton();
      this.licenseKeyButton = new DevExpress.XtraEditors.SimpleButton();
      this.feedbackButton = new DevExpress.XtraEditors.SimpleButton();
      this.aboutTabRoot = new DevExpress.XtraLayout.LayoutControlGroup();
      this.brandLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.aboutInformationLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.feedbackButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.aboutButton = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
      this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
      this.logoutButton = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
      this.exitButton = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
      this.accountButton = new DevExpress.XtraBars.BarButtonItem();
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.homeBrand = new PMSXApplication.App.View.Control.BrandControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.homeLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.backstage)).BeginInit();
      this.backstage.SuspendLayout();
      this.aboutTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.aboutTabLayout)).BeginInit();
      this.aboutTabLayout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.aboutTabRoot)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aboutInformationLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.feedbackButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.homeLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.ApplicationButtonDropDownControl = this.backstage;
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.accountButton,
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
      // backstage
      // 
      this.backstage.Controls.Add(this.aboutTab);
      this.backstage.Items.Add(this.aboutButton);
      this.backstage.Items.Add(this.backstageViewItemSeparator1);
      this.backstage.Items.Add(this.logoutButton);
      this.backstage.Items.Add(this.exitButton);
      this.backstage.Location = new System.Drawing.Point(24, 186);
      this.backstage.Name = "backstage";
      this.backstage.OwnerControl = this.ribbon;
      this.backstage.SelectedTab = this.aboutButton;
      this.backstage.SelectedTabIndex = 0;
      this.backstage.Size = new System.Drawing.Size(683, 447);
      this.backstage.TabIndex = 6;
      this.backstage.VisibleInDesignTime = true;
      // 
      // aboutTab
      // 
      this.aboutTab.Controls.Add(this.aboutTabLayout);
      this.aboutTab.Location = new System.Drawing.Point(134, 63);
      this.aboutTab.Name = "aboutTab";
      this.aboutTab.Size = new System.Drawing.Size(548, 383);
      this.aboutTab.TabIndex = 2;
      // 
      // aboutTabLayout
      // 
      this.aboutTabLayout.Controls.Add(this.brand);
      this.aboutTabLayout.Controls.Add(this.updateVersionButton);
      this.aboutTabLayout.Controls.Add(this.licenseKeyButton);
      this.aboutTabLayout.Controls.Add(this.feedbackButton);
      this.aboutTabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.aboutTabLayout.Location = new System.Drawing.Point(0, 0);
      this.aboutTabLayout.Name = "aboutTabLayout";
      this.aboutTabLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1172, 370, 650, 400);
      this.aboutTabLayout.Root = this.aboutTabRoot;
      this.aboutTabLayout.Size = new System.Drawing.Size(548, 383);
      this.aboutTabLayout.TabIndex = 2;
      this.aboutTabLayout.Text = "layoutControl1";
      // 
      // brand
      // 
      this.brand.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.brand.Appearance.Options.UseBackColor = true;
      this.brand.Location = new System.Drawing.Point(14, 14);
      this.brand.Margin = new System.Windows.Forms.Padding(2);
      this.brand.Name = "brand";
      this.brand.Size = new System.Drawing.Size(520, 183);
      this.brand.TabIndex = 4;
      this.brand.TabStop = false;
      // 
      // updateVersionButton
      // 
      this.updateVersionButton.AutoWidthInLayoutControl = true;
      this.updateVersionButton.Location = new System.Drawing.Point(184, 296);
      this.updateVersionButton.MaximumSize = new System.Drawing.Size(180, 26);
      this.updateVersionButton.MinimumSize = new System.Drawing.Size(180, 26);
      this.updateVersionButton.Name = "updateVersionButton";
      this.updateVersionButton.Padding = new System.Windows.Forms.Padding(2);
      this.updateVersionButton.Size = new System.Drawing.Size(180, 26);
      this.updateVersionButton.StyleController = this.aboutTabLayout;
      this.updateVersionButton.TabIndex = 5;
      this.updateVersionButton.Text = "Kiểm tra cập nhật";
      this.updateVersionButton.Click += new System.EventHandler(this.UpdateVersionButton_Click);
      // 
      // licenseKeyButton
      // 
      this.licenseKeyButton.AutoWidthInLayoutControl = true;
      this.licenseKeyButton.Location = new System.Drawing.Point(184, 228);
      this.licenseKeyButton.MaximumSize = new System.Drawing.Size(180, 26);
      this.licenseKeyButton.MinimumSize = new System.Drawing.Size(180, 26);
      this.licenseKeyButton.Name = "licenseKeyButton";
      this.licenseKeyButton.Padding = new System.Windows.Forms.Padding(2);
      this.licenseKeyButton.Size = new System.Drawing.Size(180, 26);
      this.licenseKeyButton.StyleController = this.aboutTabLayout;
      this.licenseKeyButton.TabIndex = 6;
      this.licenseKeyButton.Text = "Đổi khoá kích hoạt bản quyền";
      this.licenseKeyButton.Click += new System.EventHandler(this.LicenseKeyButton_Click);
      // 
      // feedbackButton
      // 
      this.feedbackButton.AutoWidthInLayoutControl = true;
      this.feedbackButton.Location = new System.Drawing.Point(184, 262);
      this.feedbackButton.MaximumSize = new System.Drawing.Size(180, 26);
      this.feedbackButton.MinimumSize = new System.Drawing.Size(180, 26);
      this.feedbackButton.Name = "feedbackButton";
      this.feedbackButton.Padding = new System.Windows.Forms.Padding(2);
      this.feedbackButton.Size = new System.Drawing.Size(180, 26);
      this.feedbackButton.StyleController = this.aboutTabLayout;
      this.feedbackButton.TabIndex = 7;
      this.feedbackButton.Text = "Ý kiến phản hồi";
      this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click);
      // 
      // aboutTabRoot
      // 
      this.aboutTabRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.aboutTabRoot.GroupBordersVisible = false;
      this.aboutTabRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.brandLayout,
            this.aboutInformationLabel,
            this.feedbackButtonLayout,
            this.layoutControlItem1,
            this.layoutControlItem2});
      this.aboutTabRoot.Name = "Root";
      this.aboutTabRoot.Size = new System.Drawing.Size(548, 383);
      this.aboutTabRoot.TextVisible = false;
      // 
      // brandLayout
      // 
      this.brandLayout.Control = this.brand;
      this.brandLayout.Location = new System.Drawing.Point(0, 0);
      this.brandLayout.MaxSize = new System.Drawing.Size(0, 191);
      this.brandLayout.MinSize = new System.Drawing.Size(334, 191);
      this.brandLayout.Name = "brandLayout";
      this.brandLayout.Size = new System.Drawing.Size(528, 191);
      this.brandLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.brandLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.brandLayout.TextSize = new System.Drawing.Size(0, 0);
      this.brandLayout.TextVisible = false;
      // 
      // aboutInformationLabel
      // 
      this.aboutInformationLabel.AllowHotTrack = false;
      this.aboutInformationLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.aboutInformationLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.aboutInformationLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.aboutInformationLabel.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.aboutInformationLabel.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
      this.aboutInformationLabel.Location = new System.Drawing.Point(0, 191);
      this.aboutInformationLabel.Name = "aboutInformationLabel";
      this.aboutInformationLabel.Size = new System.Drawing.Size(528, 23);
      this.aboutInformationLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.aboutInformationLabel.TextSize = new System.Drawing.Size(149, 15);
      // 
      // feedbackButtonLayout
      // 
      this.feedbackButtonLayout.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.feedbackButtonLayout.Control = this.feedbackButton;
      this.feedbackButtonLayout.Location = new System.Drawing.Point(0, 248);
      this.feedbackButtonLayout.Name = "feedbackButtonLayout";
      this.feedbackButtonLayout.Size = new System.Drawing.Size(528, 34);
      this.feedbackButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
      this.feedbackButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.feedbackButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.feedbackButtonLayout.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.layoutControlItem1.Control = this.updateVersionButton;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 282);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(528, 81);
      this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.layoutControlItem2.Control = this.licenseKeyButton;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 214);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(528, 34);
      this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // aboutButton
      // 
      this.aboutButton.Caption = "Giới thiệu";
      this.aboutButton.ContentControl = this.aboutTab;
      this.aboutButton.Name = "aboutButton";
      this.aboutButton.Selected = true;
      // 
      // backstageViewItemSeparator1
      // 
      this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
      // 
      // logoutButton
      // 
      this.logoutButton.Caption = "Đăng xuất";
      this.logoutButton.Name = "logoutButton";
      this.logoutButton.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.LogoutButton_ItemClick);
      // 
      // exitButton
      // 
      this.exitButton.Caption = "Thoát";
      this.exitButton.Name = "exitButton";
      this.exitButton.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.ExitButton_ItemClick);
      // 
      // accountButton
      // 
      this.accountButton.Caption = "Tài khoản";
      this.accountButton.Id = 2;
      this.accountButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.accountButton.ImageOptions.AllowStubGlyph = DevExpress.Utils.DefaultBoolean.True;
      this.accountButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accountButton.ImageOptions.SvgImage")));
      this.accountButton.ItemAppearance.Disabled.Options.UseTextOptions = true;
      this.accountButton.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.accountButton.ItemAppearance.Hovered.Options.UseTextOptions = true;
      this.accountButton.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.accountButton.ItemAppearance.Normal.Options.UseTextOptions = true;
      this.accountButton.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.accountButton.ItemAppearance.Pressed.Options.UseTextOptions = true;
      this.accountButton.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.accountButton.Name = "accountButton";
      this.accountButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AccountButton_ItemClick);
      // 
      // passwordButton
      // 
      this.passwordButton.Caption = "Mật khẩu";
      this.passwordButton.Id = 3;
      this.passwordButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.passwordButton.ImageOptions.AllowStubGlyph = DevExpress.Utils.DefaultBoolean.True;
      this.passwordButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("passwordButton.ImageOptions.SvgImage")));
      this.passwordButton.ItemAppearance.Disabled.Options.UseTextOptions = true;
      this.passwordButton.ItemAppearance.Disabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.passwordButton.ItemAppearance.Hovered.Options.UseTextOptions = true;
      this.passwordButton.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.passwordButton.ItemAppearance.Normal.Options.UseTextOptions = true;
      this.passwordButton.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.passwordButton.ItemAppearance.Pressed.Options.UseTextOptions = true;
      this.passwordButton.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
      this.passwordButton.Name = "passwordButton";
      this.passwordButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PasswordButton_ItemClick);
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
      this.themeSelect.ImageOptions.AllowStubGlyph = DevExpress.Utils.DefaultBoolean.True;
      this.themeSelect.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("themeSelect.ImageOptions.SvgImage")));
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
      this.accountGroup.ItemLinks.Add(this.accountButton);
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
      this.layout.Controls.Add(this.layoutControl1);
      this.layout.Location = new System.Drawing.Point(744, 216);
      this.layout.Name = "layout";
      this.layout.Size = new System.Drawing.Size(489, 416);
      this.layout.TabIndex = 2;
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.homeBrand);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1172, 370, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(489, 416);
      this.layoutControl1.TabIndex = 3;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // homeBrand
      // 
      this.homeBrand.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.homeBrand.Appearance.Options.UseBackColor = true;
      this.homeBrand.Location = new System.Drawing.Point(14, 84);
      this.homeBrand.Margin = new System.Windows.Forms.Padding(2);
      this.homeBrand.Name = "homeBrand";
      this.homeBrand.Size = new System.Drawing.Size(461, 183);
      this.homeBrand.TabIndex = 4;
      this.homeBrand.TabStop = false;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.homeLabel,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(489, 416);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.homeBrand;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 70);
      this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 191);
      this.layoutControlItem3.MinSize = new System.Drawing.Size(334, 191);
      this.layoutControlItem3.Name = "brandLayout";
      this.layoutControlItem3.Size = new System.Drawing.Size(469, 191);
      this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // homeLabel
      // 
      this.homeLabel.AllowHotTrack = false;
      this.homeLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.homeLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.homeLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.homeLabel.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.homeLabel.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
      this.homeLabel.Location = new System.Drawing.Point(0, 261);
      this.homeLabel.Name = "homeLabel";
      this.homeLabel.Size = new System.Drawing.Size(469, 23);
      this.homeLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.homeLabel.TextSize = new System.Drawing.Size(86, 15);
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(469, 70);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new System.Drawing.Point(0, 284);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(469, 112);
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // MainRibbonForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1280, 720);
      this.Controls.Add(this.backstage);
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
      ((System.ComponentModel.ISupportInitialize)(this.backstage)).EndInit();
      this.backstage.ResumeLayout(false);
      this.aboutTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.aboutTabLayout)).EndInit();
      this.aboutTabLayout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.aboutTabRoot)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aboutInformationLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.feedbackButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.homeLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar statusBar;
    private DevExpress.XtraBars.BarButtonItem accountButton;
    private DevExpress.XtraBars.Ribbon.RibbonPage settingPage;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup accountGroup;
    private DevExpress.XtraBars.BarButtonItem passwordButton;
    private DevExpress.XtraBars.BarStaticItem statusLabel;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup systemGroup;
    private DevExpress.XtraBars.BarSubItem themeSelect;
    private DevExpress.XtraBars.BarButtonItem lightThemeButton;
    private DevExpress.XtraBars.BarButtonItem darkThemeButton;
    private DevExpress.XtraEditors.PanelControl layout;
    private DevExpress.XtraBars.Ribbon.BackstageViewControl backstage;
    private DevExpress.XtraBars.Ribbon.BackstageViewClientControl aboutTab;
    private DevExpress.XtraBars.Ribbon.BackstageViewTabItem aboutButton;
    private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
    private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem logoutButton;
    private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem exitButton;
    private DevExpress.XtraLayout.LayoutControl aboutTabLayout;
    private Control.BrandControl brand;
    private DevExpress.XtraEditors.SimpleButton updateVersionButton;
    private DevExpress.XtraEditors.SimpleButton licenseKeyButton;
    private DevExpress.XtraEditors.SimpleButton feedbackButton;
    private DevExpress.XtraLayout.LayoutControlGroup aboutTabRoot;
    private DevExpress.XtraLayout.LayoutControlItem brandLayout;
    private DevExpress.XtraLayout.SimpleLabelItem aboutInformationLabel;
    private DevExpress.XtraLayout.LayoutControlItem feedbackButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private Control.BrandControl homeBrand;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.SimpleLabelItem homeLabel;
    private DevExpress.XtraBars.Ribbon.RibbonPage homePage;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
  }
}