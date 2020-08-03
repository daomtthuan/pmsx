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
      this.backstage = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
      this.accountLabel = new DevExpress.XtraBars.BarHeaderItem();
      this.profileButton = new DevExpress.XtraBars.BarButtonItem();
      this.passwordButton = new DevExpress.XtraBars.BarButtonItem();
      this.statusLabel = new DevExpress.XtraBars.BarStaticItem();
      this.homePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.settingPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.accountGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.statusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.backstage)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.ApplicationButtonDropDownControl = this.backstage;
      this.ribbon.CaptionBarItemLinks.Add(this.accountLabel);
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.accountLabel,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.profileButton,
            this.passwordButton,
            this.statusLabel});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.Margin = new System.Windows.Forms.Padding(2);
      this.ribbon.MaxItemId = 12;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homePage,
            this.settingPage});
      this.ribbon.Size = new System.Drawing.Size(1280, 170);
      this.ribbon.StatusBar = this.statusBar;
      // 
      // backstage
      // 
      this.backstage.Location = new System.Drawing.Point(42, 192);
      this.backstage.Name = "backstage";
      this.backstage.OwnerControl = this.ribbon;
      this.backstage.Size = new System.Drawing.Size(485, 270);
      this.backstage.TabIndex = 2;
      this.backstage.VisibleInDesignTime = true;
      // 
      // accountLabel
      // 
      this.accountLabel.Id = 11;
      this.accountLabel.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.accountLabel.ImageOptions.SvgImage = global::PMSX.Properties.Resources.User;
      this.accountLabel.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
      this.accountLabel.Name = "accountLabel";
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
      // homePage
      // 
      this.homePage.Name = "homePage";
      this.homePage.Text = "Trang chủ";
      // 
      // settingPage
      // 
      this.settingPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.accountGroup});
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
      // statusBar
      // 
      this.statusBar.ItemLinks.Add(this.statusLabel);
      this.statusBar.Location = new System.Drawing.Point(0, 694);
      this.statusBar.Name = "statusBar";
      this.statusBar.Ribbon = this.ribbon;
      this.statusBar.Size = new System.Drawing.Size(1280, 26);
      // 
      // MainRibbonForm
      // 
      this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1280, 720);
      this.Controls.Add(this.backstage);
      this.Controls.Add(this.statusBar);
      this.Controls.Add(this.ribbon);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(1280, 720);
      this.Name = "MainRibbonForm";
      this.Ribbon = this.ribbon;
      this.StatusBar = this.statusBar;
      this.Text = "PMSX";
      this.Load += new System.EventHandler(this.FormMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.backstage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar statusBar;
    private DevExpress.XtraBars.Ribbon.BackstageViewControl backstage;
    private DevExpress.XtraBars.BarButtonItem profileButton;
    private DevExpress.XtraBars.Ribbon.RibbonPage settingPage;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup accountGroup;
    private DevExpress.XtraBars.BarButtonItem passwordButton;
    private DevExpress.XtraBars.BarHeaderItem accountLabel;
    private DevExpress.XtraBars.BarStaticItem statusLabel;
    private DevExpress.XtraBars.Ribbon.RibbonPage homePage;
  }
}