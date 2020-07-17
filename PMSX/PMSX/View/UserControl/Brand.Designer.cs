namespace PMSX.View.UserControl {
  partial class Brand {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
      this.logoImage = new DevExpress.XtraEditors.PictureEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.titleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.enSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.viSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.versionLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.logoImageLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.versionLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.logoImage);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(500, 244);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl";
      // 
      // logoImage
      // 
      this.logoImage.EditValue = global::PMSX.Properties.Resources.logo;
      this.logoImage.Location = new System.Drawing.Point(2, 2);
      this.logoImage.Name = "logoImage";
      this.logoImage.Properties.AllowFocused = false;
      this.logoImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.logoImage.Properties.Appearance.Options.UseBackColor = true;
      this.logoImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.logoImage.Properties.ShowMenu = false;
      this.logoImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
      this.logoImage.Size = new System.Drawing.Size(496, 100);
      this.logoImage.StyleController = this.layoutControl;
      this.logoImage.TabIndex = 11;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.titleLabel,
            this.enSubTitleLabel,
            this.viSubTitleLabel,
            this.versionLabel,
            this.logoImageLayout});
      this.Root.Name = "Root";
      this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.Root.Size = new System.Drawing.Size(500, 244);
      this.Root.TextVisible = false;
      // 
      // titleLabel
      // 
      this.titleLabel.AllowHotTrack = false;
      this.titleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito ExtraBold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titleLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(186)))), ((int)(((byte)(155)))));
      this.titleLabel.AppearanceItemCaption.Options.UseFont = true;
      this.titleLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.titleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.titleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.titleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.titleLabel.Location = new System.Drawing.Point(0, 104);
      this.titleLabel.MaxSize = new System.Drawing.Size(0, 52);
      this.titleLabel.MinSize = new System.Drawing.Size(371, 52);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(500, 52);
      this.titleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.titleLabel.Text = "PMSX";
      this.titleLabel.TextSize = new System.Drawing.Size(367, 48);
      // 
      // enSubTitleLabel
      // 
      this.enSubTitleLabel.AllowHotTrack = false;
      this.enSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito ExtraBold", 14F, System.Drawing.FontStyle.Bold);
      this.enSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.enSubTitleLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(186)))), ((int)(((byte)(155)))));
      this.enSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
      this.enSubTitleLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.enSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.enSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.enSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.enSubTitleLabel.Location = new System.Drawing.Point(0, 156);
      this.enSubTitleLabel.MaxSize = new System.Drawing.Size(0, 30);
      this.enSubTitleLabel.MinSize = new System.Drawing.Size(371, 30);
      this.enSubTitleLabel.Name = "enSubTitleLabel";
      this.enSubTitleLabel.Size = new System.Drawing.Size(500, 30);
      this.enSubTitleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.enSubTitleLabel.Text = "PATHOLOGY MANAGEMENT SYSTEM";
      this.enSubTitleLabel.TextSize = new System.Drawing.Size(367, 26);
      // 
      // viSubTitleLabel
      // 
      this.viSubTitleLabel.AllowHotTrack = false;
      this.viSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.viSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.viSubTitleLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
      this.viSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
      this.viSubTitleLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.viSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.viSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.viSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.viSubTitleLabel.Location = new System.Drawing.Point(0, 186);
      this.viSubTitleLabel.MaxSize = new System.Drawing.Size(0, 25);
      this.viSubTitleLabel.MinSize = new System.Drawing.Size(371, 25);
      this.viSubTitleLabel.Name = "viSubTitleLabel";
      this.viSubTitleLabel.Size = new System.Drawing.Size(500, 25);
      this.viSubTitleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.viSubTitleLabel.Text = "HỆ THỐNG QUẢN LÝ KẾT QUẢ GIẢI PHẪU BỆNH";
      this.viSubTitleLabel.TextSize = new System.Drawing.Size(367, 21);
      // 
      // versionLabel
      // 
      this.versionLabel.AllowHotTrack = false;
      this.versionLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito SemiBold", 10F);
      this.versionLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
      this.versionLabel.AppearanceItemCaption.Options.UseFont = true;
      this.versionLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.versionLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.versionLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.versionLabel.Location = new System.Drawing.Point(0, 211);
      this.versionLabel.MaxSize = new System.Drawing.Size(0, 33);
      this.versionLabel.MinSize = new System.Drawing.Size(371, 33);
      this.versionLabel.Name = "versionLabel";
      this.versionLabel.Size = new System.Drawing.Size(500, 33);
      this.versionLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.versionLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
      this.versionLabel.Text = "Phiên bản 1.0.0";
      this.versionLabel.TextSize = new System.Drawing.Size(367, 19);
      // 
      // logoImageLayout
      // 
      this.logoImageLayout.Control = this.logoImage;
      this.logoImageLayout.Location = new System.Drawing.Point(0, 0);
      this.logoImageLayout.MaxSize = new System.Drawing.Size(0, 104);
      this.logoImageLayout.MinSize = new System.Drawing.Size(24, 104);
      this.logoImageLayout.Name = "logoImageLayout";
      this.logoImageLayout.Size = new System.Drawing.Size(500, 104);
      this.logoImageLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.logoImageLayout.TextSize = new System.Drawing.Size(0, 0);
      this.logoImageLayout.TextVisible = false;
      // 
      // Brand
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl);
      this.Name = "Brand";
      this.Size = new System.Drawing.Size(500, 244);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.versionLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraEditors.PictureEdit logoImage;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.SimpleLabelItem titleLabel;
    private DevExpress.XtraLayout.SimpleLabelItem enSubTitleLabel;
    private DevExpress.XtraLayout.SimpleLabelItem viSubTitleLabel;
    private DevExpress.XtraLayout.LayoutControlItem logoImageLayout;
    private DevExpress.XtraLayout.SimpleLabelItem versionLabel;
  }
}
