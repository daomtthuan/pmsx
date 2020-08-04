namespace PMSX.App.View {
  partial class LoadingSplashScreen {
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
      this.layout = new DevExpress.XtraLayout.LayoutControl();
      this.progressBar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
      this.brandControl1 = new PMSX.App.View.Control.BrandControl();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.statusLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.versionLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.copyrightLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.progressBarLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.versionLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.progressBarLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.Appearance.Control.BackColor = System.Drawing.Color.Transparent;
      this.layout.Appearance.Control.Options.UseBackColor = true;
      this.layout.BackColor = System.Drawing.Color.Transparent;
      this.layout.Controls.Add(this.progressBar);
      this.layout.Controls.Add(this.brandControl1);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(1, 1);
      this.layout.Name = "layout";
      this.layout.Root = this.Root;
      this.layout.Size = new System.Drawing.Size(485, 294);
      this.layout.TabIndex = 9;
      this.layout.Text = "layoutControl1";
      // 
      // progressBar
      // 
      this.progressBar.EditValue = 0;
      this.progressBar.Location = new System.Drawing.Point(14, 236);
      this.progressBar.Name = "progressBar";
      this.progressBar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.progressBar.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(186)))), ((int)(((byte)(155)))));
      this.progressBar.Properties.ProgressPadding = new System.Windows.Forms.Padding(1);
      this.progressBar.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(186)))), ((int)(((byte)(155)))));
      this.progressBar.Size = new System.Drawing.Size(457, 10);
      this.progressBar.StyleController = this.layout;
      this.progressBar.TabIndex = 9;
      // 
      // brandControl1
      // 
      this.brandControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.brandControl1.Appearance.Options.UseBackColor = true;
      this.brandControl1.Location = new System.Drawing.Point(14, 14);
      this.brandControl1.Margin = new System.Windows.Forms.Padding(2);
      this.brandControl1.Name = "brandControl1";
      this.brandControl1.Size = new System.Drawing.Size(457, 183);
      this.brandControl1.TabIndex = 8;
      this.brandControl1.TabStop = false;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.statusLabel,
            this.versionLabel,
            this.copyrightLabel,
            this.progressBarLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(485, 294);
      this.Root.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.brandControl1;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 191);
      this.layoutControlItem4.MinSize = new System.Drawing.Size(334, 191);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(465, 191);
      this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // statusLabel
      // 
      this.statusLabel.AllowHotTrack = false;
      this.statusLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.statusLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.statusLabel.Location = new System.Drawing.Point(0, 191);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(465, 31);
      this.statusLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
      this.statusLabel.Text = "Trạng thái";
      this.statusLabel.TextSize = new System.Drawing.Size(56, 15);
      // 
      // versionLabel
      // 
      this.versionLabel.AllowHotTrack = false;
      this.versionLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.versionLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
      this.versionLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
      this.versionLabel.Location = new System.Drawing.Point(0, 240);
      this.versionLabel.Name = "versionLabel";
      this.versionLabel.Size = new System.Drawing.Size(185, 34);
      this.versionLabel.Text = "Phiên bản";
      this.versionLabel.TextSize = new System.Drawing.Size(56, 15);
      // 
      // copyrightLabel
      // 
      this.copyrightLabel.AllowHotTrack = false;
      this.copyrightLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.copyrightLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.copyrightLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
      this.copyrightLabel.Location = new System.Drawing.Point(185, 240);
      this.copyrightLabel.MinSize = new System.Drawing.Size(102, 23);
      this.copyrightLabel.Name = "copyrightLabel";
      this.copyrightLabel.Size = new System.Drawing.Size(280, 34);
      this.copyrightLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.copyrightLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.copyrightLabel.Text = "Bản quyền";
      this.copyrightLabel.TextSize = new System.Drawing.Size(56, 15);
      // 
      // progressBarLayout
      // 
      this.progressBarLayout.Control = this.progressBar;
      this.progressBarLayout.Location = new System.Drawing.Point(0, 222);
      this.progressBarLayout.MaxSize = new System.Drawing.Size(0, 18);
      this.progressBarLayout.MinSize = new System.Drawing.Size(58, 18);
      this.progressBarLayout.Name = "progressBarLayout";
      this.progressBarLayout.Size = new System.Drawing.Size(465, 18);
      this.progressBarLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.progressBarLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.progressBarLayout.TextSize = new System.Drawing.Size(0, 0);
      this.progressBarLayout.TextVisible = false;
      // 
      // LoadingSplashScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(487, 296);
      this.Controls.Add(this.layout);
      this.Name = "LoadingSplashScreen";
      this.Padding = new System.Windows.Forms.Padding(1);
      this.Text = "SplashScreen1";
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.statusLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.versionLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.progressBarLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private Control.BrandControl brandControl1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.SimpleLabelItem statusLabel;
    private DevExpress.XtraLayout.SimpleLabelItem copyrightLabel;
    private DevExpress.XtraLayout.SimpleLabelItem versionLabel;
    private DevExpress.XtraEditors.MarqueeProgressBarControl progressBar;
    private DevExpress.XtraLayout.LayoutControlItem progressBarLayout;
  }
}
