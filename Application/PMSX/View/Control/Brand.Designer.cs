namespace PMSX.View.Control {
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
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.logoImageLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.appNameLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.nameLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.subNameLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.versionLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.appNameLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.subNameLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.versionLabel)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.BackColor = System.Drawing.Color.Transparent;
      this.layoutControl.Controls.Add(this.logoImage);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Margin = new System.Windows.Forms.Padding(0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.root;
      this.layoutControl.Size = new System.Drawing.Size(392, 219);
      this.layoutControl.TabIndex = 0;
      this.layoutControl.Text = "layoutControl1";
      // 
      // logoImage
      // 
      this.logoImage.EditValue = global::PMSX.Properties.Resources.logo;
      this.logoImage.Location = new System.Drawing.Point(2, 2);
      this.logoImage.Name = "logoImage";
      this.logoImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.logoImage.Properties.Appearance.Options.UseBackColor = true;
      this.logoImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.logoImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
      this.logoImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
      this.logoImage.Size = new System.Drawing.Size(388, 90);
      this.logoImage.StyleController = this.layoutControl;
      this.logoImage.TabIndex = 4;
      // 
      // root
      // 
      this.root.AppearanceGroup.BackColor = System.Drawing.Color.Transparent;
      this.root.AppearanceGroup.Options.UseBackColor = true;
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.logoImageLayout,
            this.appNameLabel,
            this.nameLabel,
            this.subNameLabel,
            this.versionLabel});
      this.root.Name = "root";
      this.root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.root.Size = new System.Drawing.Size(392, 219);
      this.root.TextVisible = false;
      // 
      // logoImageLayout
      // 
      this.logoImageLayout.Control = this.logoImage;
      this.logoImageLayout.Location = new System.Drawing.Point(0, 0);
      this.logoImageLayout.MaxSize = new System.Drawing.Size(0, 94);
      this.logoImageLayout.MinSize = new System.Drawing.Size(24, 94);
      this.logoImageLayout.Name = "logoImageLayout";
      this.logoImageLayout.Size = new System.Drawing.Size(392, 94);
      this.logoImageLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.logoImageLayout.TextSize = new System.Drawing.Size(0, 0);
      this.logoImageLayout.TextVisible = false;
      // 
      // appNameLabel
      // 
      this.appNameLabel.AllowHotTrack = false;
      this.appNameLabel.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
      this.appNameLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.appNameLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(186)))), ((int)(((byte)(155)))));
      this.appNameLabel.AppearanceItemCaption.Options.UseBackColor = true;
      this.appNameLabel.AppearanceItemCaption.Options.UseFont = true;
      this.appNameLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.appNameLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.appNameLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.appNameLabel.Location = new System.Drawing.Point(0, 94);
      this.appNameLabel.MaxSize = new System.Drawing.Size(0, 48);
      this.appNameLabel.MinSize = new System.Drawing.Size(371, 48);
      this.appNameLabel.Name = "appNameLabel";
      this.appNameLabel.Size = new System.Drawing.Size(392, 48);
      this.appNameLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.appNameLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.appNameLabel.Text = "PMSX";
      this.appNameLabel.TextSize = new System.Drawing.Size(367, 44);
      // 
      // nameLabel
      // 
      this.nameLabel.AllowHotTrack = false;
      this.nameLabel.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
      this.nameLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(186)))), ((int)(((byte)(155)))));
      this.nameLabel.AppearanceItemCaption.Options.UseBackColor = true;
      this.nameLabel.AppearanceItemCaption.Options.UseFont = true;
      this.nameLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.nameLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.nameLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.nameLabel.CustomizationFormText = "PATHOLOGY MANAGEMENT SYSTEM";
      this.nameLabel.Location = new System.Drawing.Point(0, 142);
      this.nameLabel.MaxSize = new System.Drawing.Size(0, 25);
      this.nameLabel.MinSize = new System.Drawing.Size(371, 25);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(392, 25);
      this.nameLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.nameLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.nameLabel.Text = "PATHOLOGY MANAGEMENT SYSTEM";
      this.nameLabel.TextSize = new System.Drawing.Size(367, 21);
      // 
      // subNameLabel
      // 
      this.subNameLabel.AllowHotTrack = false;
      this.subNameLabel.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
      this.subNameLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.subNameLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
      this.subNameLabel.AppearanceItemCaption.Options.UseBackColor = true;
      this.subNameLabel.AppearanceItemCaption.Options.UseFont = true;
      this.subNameLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.subNameLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.subNameLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.subNameLabel.Location = new System.Drawing.Point(0, 167);
      this.subNameLabel.MaxSize = new System.Drawing.Size(0, 25);
      this.subNameLabel.MinSize = new System.Drawing.Size(371, 25);
      this.subNameLabel.Name = "subNameLabel";
      this.subNameLabel.Size = new System.Drawing.Size(392, 25);
      this.subNameLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.subNameLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.subNameLabel.Text = "HỆ THỐNG QUẢN LÝ KẾT QUẢ GIẢI PHẪU BỆNH";
      this.subNameLabel.TextSize = new System.Drawing.Size(367, 21);
      // 
      // versionLabel
      // 
      this.versionLabel.AllowHotTrack = false;
      this.versionLabel.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
      this.versionLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
      this.versionLabel.AppearanceItemCaption.Options.UseBackColor = true;
      this.versionLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.versionLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.versionLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.versionLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.versionLabel.Location = new System.Drawing.Point(0, 192);
      this.versionLabel.MaxSize = new System.Drawing.Size(0, 19);
      this.versionLabel.MinSize = new System.Drawing.Size(371, 19);
      this.versionLabel.Name = "versionLabel";
      this.versionLabel.Size = new System.Drawing.Size(392, 27);
      this.versionLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.versionLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.versionLabel.TextSize = new System.Drawing.Size(367, 15);
      // 
      // Brand
      // 
      this.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl);
      this.Name = "Brand";
      this.Size = new System.Drawing.Size(392, 219);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.appNameLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.subNameLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.versionLabel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraEditors.PictureEdit logoImage;
    private DevExpress.XtraLayout.SimpleLabelItem appNameLabel;
    private DevExpress.XtraLayout.LayoutControlItem logoImageLayout;
    private DevExpress.XtraLayout.SimpleLabelItem nameLabel;
    private DevExpress.XtraLayout.SimpleLabelItem subNameLabel;
    private DevExpress.XtraLayout.SimpleLabelItem versionLabel;
  }
}
