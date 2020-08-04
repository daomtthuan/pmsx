namespace PMSX.App.View.Control {
  partial class BrandControl {
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
      this.layout = new DevExpress.XtraLayout.LayoutControl();
      this.pictureLogo = new DevExpress.XtraEditors.PictureEdit();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.labelNameApp = new DevExpress.XtraLayout.SimpleLabelItem();
      this.labelSubNameApp = new DevExpress.XtraLayout.SimpleLabelItem();
      this.labelAltSubNameApp = new DevExpress.XtraLayout.SimpleLabelItem();
      this.pictureLogoLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureLogo.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.labelNameApp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.labelSubNameApp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.labelAltSubNameApp)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureLogoLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.pictureLogo);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(372, 183);
      this.layout.TabIndex = 0;
      this.layout.Text = "layoutControl1";
      // 
      // pictureLogo
      // 
      this.pictureLogo.EditValue = global::PMSX.Properties.Resources.Logo;
      this.pictureLogo.Location = new System.Drawing.Point(2, 2);
      this.pictureLogo.Name = "pictureLogo";
      this.pictureLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.pictureLogo.Properties.Appearance.Options.UseBackColor = true;
      this.pictureLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.pictureLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
      this.pictureLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
      this.pictureLogo.Size = new System.Drawing.Size(368, 90);
      this.pictureLogo.StyleController = this.layout;
      this.pictureLogo.TabIndex = 4;
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.labelNameApp,
            this.labelSubNameApp,
            this.labelAltSubNameApp,
            this.pictureLogoLayout});
      this.root.Name = "root";
      this.root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.root.Size = new System.Drawing.Size(372, 183);
      this.root.TextVisible = false;
      // 
      // labelNameApp
      // 
      this.labelNameApp.AllowHotTrack = false;
      this.labelNameApp.AppearanceItemCaption.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNameApp.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.labelNameApp.AppearanceItemCaption.Options.UseFont = true;
      this.labelNameApp.AppearanceItemCaption.Options.UseForeColor = true;
      this.labelNameApp.AppearanceItemCaption.Options.UseTextOptions = true;
      this.labelNameApp.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.labelNameApp.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.labelNameApp.Location = new System.Drawing.Point(0, 94);
      this.labelNameApp.Name = "labelNameApp";
      this.labelNameApp.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.labelNameApp.Size = new System.Drawing.Size(372, 37);
      this.labelNameApp.Text = "PMSX";
      this.labelNameApp.TextSize = new System.Drawing.Size(322, 37);
      // 
      // labelSubNameApp
      // 
      this.labelSubNameApp.AllowHotTrack = false;
      this.labelSubNameApp.AppearanceItemCaption.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSubNameApp.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.labelSubNameApp.AppearanceItemCaption.Options.UseFont = true;
      this.labelSubNameApp.AppearanceItemCaption.Options.UseForeColor = true;
      this.labelSubNameApp.AppearanceItemCaption.Options.UseTextOptions = true;
      this.labelSubNameApp.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.labelSubNameApp.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.labelSubNameApp.Location = new System.Drawing.Point(0, 131);
      this.labelSubNameApp.Name = "labelSubNameApp";
      this.labelSubNameApp.Size = new System.Drawing.Size(372, 26);
      this.labelSubNameApp.Text = "Pathology Management System";
      this.labelSubNameApp.TextSize = new System.Drawing.Size(322, 22);
      // 
      // labelAltSubNameApp
      // 
      this.labelAltSubNameApp.AllowHotTrack = false;
      this.labelAltSubNameApp.AppearanceItemCaption.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelAltSubNameApp.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
      this.labelAltSubNameApp.AppearanceItemCaption.Options.UseFont = true;
      this.labelAltSubNameApp.AppearanceItemCaption.Options.UseForeColor = true;
      this.labelAltSubNameApp.AppearanceItemCaption.Options.UseTextOptions = true;
      this.labelAltSubNameApp.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.labelAltSubNameApp.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.labelAltSubNameApp.Location = new System.Drawing.Point(0, 157);
      this.labelAltSubNameApp.Name = "labelAltSubNameApp";
      this.labelAltSubNameApp.Size = new System.Drawing.Size(372, 26);
      this.labelAltSubNameApp.Text = "Hệ Thống Quản Lý Kết Quả Giải Phẫu Bệnh";
      this.labelAltSubNameApp.TextSize = new System.Drawing.Size(322, 22);
      // 
      // pictureLogoLayout
      // 
      this.pictureLogoLayout.Control = this.pictureLogo;
      this.pictureLogoLayout.Location = new System.Drawing.Point(0, 0);
      this.pictureLogoLayout.MaxSize = new System.Drawing.Size(0, 94);
      this.pictureLogoLayout.MinSize = new System.Drawing.Size(24, 94);
      this.pictureLogoLayout.Name = "pictureLogoLayout";
      this.pictureLogoLayout.Size = new System.Drawing.Size(372, 94);
      this.pictureLogoLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.pictureLogoLayout.TextSize = new System.Drawing.Size(0, 0);
      this.pictureLogoLayout.TextVisible = false;
      // 
      // BrandControl
      // 
      this.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.Appearance.Options.UseBackColor = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.layout);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "BrandControl";
      this.Size = new System.Drawing.Size(372, 183);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureLogo.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.labelNameApp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.labelSubNameApp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.labelAltSubNameApp)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureLogoLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.SimpleLabelItem labelNameApp;
    private DevExpress.XtraLayout.SimpleLabelItem labelSubNameApp;
    private DevExpress.XtraLayout.SimpleLabelItem labelAltSubNameApp;
    private DevExpress.XtraEditors.PictureEdit pictureLogo;
    private DevExpress.XtraLayout.LayoutControlItem pictureLogoLayout;
  }
}
