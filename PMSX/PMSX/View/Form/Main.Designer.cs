namespace PMSX.View.Form {
    partial class Main {
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
      DevExpress.XtraSplashScreen.SplashScreenManager splashScreen = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PMSX.View.Form.Loading), true, true, true);
      DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
      DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
      DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
      DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
      DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
      DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
      DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.backstageView = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
      this.aboutBackstage = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
      this.aboutButtonBackstage = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
      this.separatorBackstage = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
      this.logoutButton = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
      this.exitButton = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
      this.staffButton = new DevExpress.XtraBars.BarButtonItem();
      this.patientButton = new DevExpress.XtraBars.BarButtonItem();
      this.roleButton = new DevExpress.XtraBars.BarButtonItem();
      this.sessionButton = new DevExpress.XtraBars.BarButtonItem();
      this.biopsyButton = new DevExpress.XtraBars.BarButtonItem();
      this.resultButton = new DevExpress.XtraBars.BarButtonItem();
      this.permissionButton = new DevExpress.XtraBars.BarButtonItem();
      this.adminPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
      this.personnelPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.accountGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.workGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.clinicPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.clinicGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.pathologyGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.backstageView)).BeginInit();
      this.backstageView.SuspendLayout();
      this.SuspendLayout();
      // 
      // splashScreen
      // 
      splashScreen.ClosingDelay = 1000;
      // 
      // ribbon
      // 
      this.ribbon.ApplicationButtonDropDownControl = this.backstageView;
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.staffButton,
            this.patientButton,
            this.roleButton,
            this.sessionButton,
            this.biopsyButton,
            this.resultButton,
            this.permissionButton});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.MaxItemId = 9;
      this.ribbon.Name = "ribbon";
      this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.adminPageGroup});
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbon.Size = new System.Drawing.Size(1600, 195);
      // 
      // backstageView
      // 
      this.backstageView.Controls.Add(this.aboutBackstage);
      this.backstageView.Items.Add(this.aboutButtonBackstage);
      this.backstageView.Items.Add(this.separatorBackstage);
      this.backstageView.Items.Add(this.logoutButton);
      this.backstageView.Items.Add(this.exitButton);
      this.backstageView.Location = new System.Drawing.Point(75, 259);
      this.backstageView.Name = "backstageView";
      this.backstageView.OwnerControl = this.ribbon;
      this.backstageView.SelectedTab = this.aboutButtonBackstage;
      this.backstageView.SelectedTabIndex = 0;
      this.backstageView.Size = new System.Drawing.Size(565, 364);
      this.backstageView.TabIndex = 5;
      // 
      // aboutBackstage
      // 
      this.aboutBackstage.Location = new System.Drawing.Point(151, 63);
      this.aboutBackstage.Name = "aboutBackstage";
      this.aboutBackstage.Size = new System.Drawing.Size(413, 300);
      this.aboutBackstage.TabIndex = 1;
      // 
      // aboutButtonBackstage
      // 
      this.aboutButtonBackstage.Caption = "Giới thiệu";
      this.aboutButtonBackstage.ContentControl = this.aboutBackstage;
      this.aboutButtonBackstage.Name = "aboutButtonBackstage";
      this.aboutButtonBackstage.Selected = true;
      // 
      // separatorBackstage
      // 
      this.separatorBackstage.Name = "separatorBackstage";
      // 
      // logoutButton
      // 
      this.logoutButton.Caption = "Đăng xuất";
      this.logoutButton.Name = "logoutButton";
      this.logoutButton.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.LogoutButton_Click);
      // 
      // exitButton
      // 
      this.exitButton.Caption = "Thoát";
      this.exitButton.Name = "exitButton";
      this.exitButton.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.ExitButton_Click);
      // 
      // staffButton
      // 
      this.staffButton.Caption = "Nhân viên";
      this.staffButton.Id = 1;
      this.staffButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.staffButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.bo_lead;
      this.staffButton.Name = "staffButton";
      this.staffButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
      toolTipItem1.Text = "Quản lý nhân viên";
      superToolTip1.Items.Add(toolTipItem1);
      this.staffButton.SuperTip = superToolTip1;
      this.staffButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.StaffButton_Click);
      // 
      // patientButton
      // 
      this.patientButton.Caption = "Bệnh nhân";
      this.patientButton.Id = 2;
      this.patientButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.patientButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.travel_rest;
      this.patientButton.Name = "patientButton";
      toolTipItem2.Text = "Quản lý bệnh nhân";
      superToolTip2.Items.Add(toolTipItem2);
      this.patientButton.SuperTip = superToolTip2;
      this.patientButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PatientButton_Click);
      // 
      // roleButton
      // 
      this.roleButton.Caption = "Quyền truy cập";
      this.roleButton.Id = 3;
      this.roleButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.roleButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.security_key;
      this.roleButton.Name = "roleButton";
      this.roleButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
      toolTipItem3.Text = "Quản lý quyền truy cập nhân viên";
      superToolTip3.Items.Add(toolTipItem3);
      this.roleButton.SuperTip = superToolTip3;
      this.roleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RoleButton_Click);
      // 
      // sessionButton
      // 
      this.sessionButton.Caption = "Phiên làm việc";
      this.sessionButton.Id = 5;
      this.sessionButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.sessionButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.bo_audit_changehistory;
      this.sessionButton.Name = "sessionButton";
      this.sessionButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
      toolTipItem4.Text = "Quản lý phiên làm việc";
      superToolTip4.Items.Add(toolTipItem4);
      this.sessionButton.SuperTip = superToolTip4;
      this.sessionButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SessionButton_Click);
      // 
      // biopsyButton
      // 
      this.biopsyButton.Caption = "Sinh thiết";
      this.biopsyButton.Id = 6;
      this.biopsyButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.biopsyButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.charttype_bubble3d;
      this.biopsyButton.Name = "biopsyButton";
      toolTipItem5.Text = "Quản lý mẫu sinh thiết";
      superToolTip5.Items.Add(toolTipItem5);
      this.biopsyButton.SuperTip = superToolTip5;
      this.biopsyButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BiopsyButton_Click);
      // 
      // resultButton
      // 
      this.resultButton.Caption = "Kết quả";
      this.resultButton.Id = 7;
      this.resultButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.resultButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.showallfieldresults;
      this.resultButton.Name = "resultButton";
      toolTipItem6.Text = "Quản lý kết quả chuẩn đoán xét nghiệm";
      superToolTip6.Items.Add(toolTipItem6);
      this.resultButton.SuperTip = superToolTip6;
      // 
      // permissionButton
      // 
      this.permissionButton.Caption = "Phân quyền";
      this.permissionButton.Id = 8;
      this.permissionButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.permissionButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.bo_user;
      this.permissionButton.Name = "permissionButton";
      toolTipItem7.Text = "Phân quyền truy cập cho nhân viên";
      superToolTip7.Items.Add(toolTipItem7);
      this.permissionButton.SuperTip = superToolTip7;
      this.permissionButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PermissionButton_ItemClick);
      // 
      // adminPageGroup
      // 
      this.adminPageGroup.Name = "adminPageGroup";
      this.adminPageGroup.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.personnelPage,
            this.clinicPage});
      this.adminPageGroup.Text = "Quản trị viên";
      // 
      // personnelPage
      // 
      this.personnelPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.accountGroup,
            this.workGroup});
      this.personnelPage.Name = "personnelPage";
      this.personnelPage.Text = "Nhân sự";
      // 
      // accountGroup
      // 
      this.accountGroup.ItemLinks.Add(this.staffButton);
      this.accountGroup.ItemLinks.Add(this.roleButton);
      this.accountGroup.ItemLinks.Add(this.permissionButton);
      this.accountGroup.Name = "accountGroup";
      this.accountGroup.Text = "Tài khoản";
      // 
      // workGroup
      // 
      this.workGroup.ItemLinks.Add(this.sessionButton);
      this.workGroup.Name = "workGroup";
      this.workGroup.Text = "Công việc";
      // 
      // clinicPage
      // 
      this.clinicPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.clinicGroup,
            this.pathologyGroup});
      this.clinicPage.Name = "clinicPage";
      this.clinicPage.Text = "Phòng khám";
      // 
      // clinicGroup
      // 
      this.clinicGroup.ItemLinks.Add(this.patientButton);
      this.clinicGroup.Name = "clinicGroup";
      this.clinicGroup.Text = "Phòng khám";
      // 
      // pathologyGroup
      // 
      this.pathologyGroup.ItemLinks.Add(this.biopsyButton);
      this.pathologyGroup.ItemLinks.Add(this.resultButton);
      this.pathologyGroup.Name = "pathologyGroup";
      this.pathologyGroup.Text = "Giải phẫu bệnh";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "ribbonPageGroup1";
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1600, 900);
      this.Controls.Add(this.backstageView);
      this.Controls.Add(this.ribbon);
      this.Name = "Main";
      this.Ribbon = this.ribbon;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX";
      this.Load += new System.EventHandler(this.Main_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.backstageView)).EndInit();
      this.backstageView.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage personnelPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup accountGroup;
        private DevExpress.XtraBars.BarButtonItem staffButton;
        private DevExpress.XtraBars.BarButtonItem patientButton;
        private DevExpress.XtraBars.BarButtonItem roleButton;
        private DevExpress.XtraBars.BarButtonItem sessionButton;
        private DevExpress.XtraBars.BarButtonItem biopsyButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup clinicGroup;
        private DevExpress.XtraBars.BarButtonItem resultButton;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageView;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl aboutBackstage;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem aboutButtonBackstage;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator separatorBackstage;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem logoutButton;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem exitButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory adminPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage clinicPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pathologyGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup workGroup;
        private DevExpress.XtraBars.BarButtonItem permissionButton;
    }
}