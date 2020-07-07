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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.aboutBackstageViewClientControl = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.aboutBackstageViewTabItem = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.logoutBackstageViewButtonItem = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.exitBackstageViewButtonItem = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.staffButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.patientButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.roleButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.resultButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.managerPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.personnelManagerPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.clinicPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.staffButtonItem,
            this.patientButtonItem,
            this.roleButtonItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.resultButtonItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.managerPage});
            this.ribbon.Size = new System.Drawing.Size(1406, 195);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.aboutBackstageViewClientControl);
            this.backstageViewControl1.Items.Add(this.aboutBackstageViewTabItem);
            this.backstageViewControl1.Items.Add(this.backstageViewItemSeparator1);
            this.backstageViewControl1.Items.Add(this.logoutBackstageViewButtonItem);
            this.backstageViewControl1.Items.Add(this.exitBackstageViewButtonItem);
            this.backstageViewControl1.Location = new System.Drawing.Point(75, 259);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbon;
            this.backstageViewControl1.SelectedTab = this.aboutBackstageViewTabItem;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Size = new System.Drawing.Size(565, 364);
            this.backstageViewControl1.TabIndex = 5;
            // 
            // aboutBackstageViewClientControl
            // 
            this.aboutBackstageViewClientControl.Location = new System.Drawing.Point(157, 63);
            this.aboutBackstageViewClientControl.Name = "aboutBackstageViewClientControl";
            this.aboutBackstageViewClientControl.Size = new System.Drawing.Size(407, 300);
            this.aboutBackstageViewClientControl.TabIndex = 1;
            // 
            // aboutBackstageViewTabItem
            // 
            this.aboutBackstageViewTabItem.Caption = "Giới thiệu";
            this.aboutBackstageViewTabItem.ContentControl = this.aboutBackstageViewClientControl;
            this.aboutBackstageViewTabItem.Name = "aboutBackstageViewTabItem";
            this.aboutBackstageViewTabItem.Selected = true;
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // logoutBackstageViewButtonItem
            // 
            this.logoutBackstageViewButtonItem.Caption = "Đăng xuất";
            this.logoutBackstageViewButtonItem.Name = "logoutBackstageViewButtonItem";
            this.logoutBackstageViewButtonItem.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.LogoutBackstageViewButtonItem_ItemClick);
            // 
            // exitBackstageViewButtonItem
            // 
            this.exitBackstageViewButtonItem.Caption = "Thoát";
            this.exitBackstageViewButtonItem.Name = "exitBackstageViewButtonItem";
            this.exitBackstageViewButtonItem.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.ExitBackstageViewButtonItem_ItemClick);
            // 
            // staffButtonItem
            // 
            this.staffButtonItem.Caption = "Nhân viên";
            this.staffButtonItem.Id = 1;
            this.staffButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.staffButtonItem.ImageOptions.SvgImage = global::PMSX.Properties.Resources.bo_lead;
            this.staffButtonItem.Name = "staffButtonItem";
            this.staffButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            toolTipTitleItem1.Text = "Nhân sự";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Quản lý nhân viên";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.staffButtonItem.SuperTip = superToolTip1;
            this.staffButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.StaffButtonItem_ItemClick);
            // 
            // patientButtonItem
            // 
            this.patientButtonItem.Caption = "Bệnh nhân";
            this.patientButtonItem.Id = 2;
            this.patientButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.patientButtonItem.ImageOptions.SvgImage = global::PMSX.Properties.Resources.travel_rest;
            this.patientButtonItem.Name = "patientButtonItem";
            toolTipTitleItem2.Text = "Phòng khám";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Quản lý bệnh nhân";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.patientButtonItem.SuperTip = superToolTip2;
            this.patientButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PatientButtonItem_ItemClick);
            // 
            // roleButtonItem
            // 
            this.roleButtonItem.Caption = "Phân quyền";
            this.roleButtonItem.Id = 3;
            this.roleButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.roleButtonItem.ImageOptions.SvgImage = global::PMSX.Properties.Resources.security_key;
            this.roleButtonItem.Name = "roleButtonItem";
            this.roleButtonItem.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            toolTipTitleItem3.Text = "Nhân sự";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Quản lý quyền truy cập nhân viên";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.roleButtonItem.SuperTip = superToolTip3;
            this.roleButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RoleButtonItem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Phiên làm việc";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItem1.ImageOptions.SvgImage = global::PMSX.Properties.Resources.bo_audit_changehistory;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            toolTipTitleItem4.Text = "Nhân sự";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Quản lý phiên làm việc";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.barButtonItem1.SuperTip = superToolTip4;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sinh khiết";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItem2.ImageOptions.SvgImage = global::PMSX.Properties.Resources.charttype_bubble3d;
            this.barButtonItem2.Name = "barButtonItem2";
            toolTipTitleItem5.Text = "Phòng khám";
            toolTipItem5.LeftIndent = 6;
            toolTipItem5.Text = "Quản lý mẫu sinh khiết";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.barButtonItem2.SuperTip = superToolTip5;
            // 
            // resultButtonItem
            // 
            this.resultButtonItem.Caption = "Kết quả";
            this.resultButtonItem.Id = 7;
            this.resultButtonItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.resultButtonItem.ImageOptions.SvgImage = global::PMSX.Properties.Resources.showallfieldresults;
            this.resultButtonItem.Name = "resultButtonItem";
            toolTipTitleItem6.Text = "Phòng khám";
            toolTipItem6.LeftIndent = 6;
            toolTipItem6.Text = "Quản lý kết quả chuẩn đoán xét nghiệm";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            this.resultButtonItem.SuperTip = superToolTip6;
            // 
            // managerPage
            // 
            this.managerPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.personnelManagerPageGroup,
            this.clinicPageGroup});
            this.managerPage.Name = "managerPage";
            this.managerPage.Text = "Quản lý";
            // 
            // personnelManagerPageGroup
            // 
            this.personnelManagerPageGroup.ItemLinks.Add(this.staffButtonItem);
            this.personnelManagerPageGroup.ItemLinks.Add(this.roleButtonItem);
            this.personnelManagerPageGroup.ItemLinks.Add(this.barButtonItem1);
            this.personnelManagerPageGroup.Name = "personnelManagerPageGroup";
            this.personnelManagerPageGroup.Text = "Nhân sự";
            // 
            // clinicPageGroup
            // 
            this.clinicPageGroup.ItemLinks.Add(this.patientButtonItem);
            this.clinicPageGroup.ItemLinks.Add(this.barButtonItem2);
            this.clinicPageGroup.ItemLinks.Add(this.resultButtonItem);
            this.clinicPageGroup.Name = "clinicPageGroup";
            this.clinicPageGroup.Text = "Phòng khám";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 835);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "Main";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMSX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage managerPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup personnelManagerPageGroup;
        private DevExpress.XtraBars.BarButtonItem staffButtonItem;
        private DevExpress.XtraBars.BarButtonItem patientButtonItem;
        private DevExpress.XtraBars.BarButtonItem roleButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup clinicPageGroup;
        private DevExpress.XtraBars.BarButtonItem resultButtonItem;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl aboutBackstageViewClientControl;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem aboutBackstageViewTabItem;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem logoutBackstageViewButtonItem;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem exitBackstageViewButtonItem;
    }
}