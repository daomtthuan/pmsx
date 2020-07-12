namespace PMSX.View.Form {
    partial class Loading {
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.logoImage = new DevExpress.XtraEditors.PictureEdit();
            this.root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.logoImageLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.enSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.titleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.viSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.copyrightLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.logoImage);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.root;
            this.layoutControl.Size = new System.Drawing.Size(500, 287);
            this.layoutControl.TabIndex = 10;
            this.layoutControl.Text = "layoutControl1";
            // 
            // logoImage
            // 
            this.logoImage.EditValue = global::PMSX.Properties.Resources.logo;
            this.logoImage.Location = new System.Drawing.Point(12, 12);
            this.logoImage.Name = "logoImage";
            this.logoImage.Properties.AllowFocused = false;
            this.logoImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.logoImage.Properties.Appearance.Options.UseBackColor = true;
            this.logoImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.logoImage.Properties.ShowMenu = false;
            this.logoImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.logoImage.Size = new System.Drawing.Size(476, 100);
            this.logoImage.StyleController = this.layoutControl;
            this.logoImage.TabIndex = 11;
            // 
            // root
            // 
            this.root.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.root.AppearanceGroup.Options.UseBackColor = true;
            this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.root.GroupBordersVisible = false;
            this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.logoImageLayout,
            this.enSubTitleLabel,
            this.titleLabel,
            this.viSubTitleLabel,
            this.copyrightLabel});
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(500, 287);
            this.root.TextVisible = false;
            // 
            // logoImageLayout
            // 
            this.logoImageLayout.Control = this.logoImage;
            this.logoImageLayout.Location = new System.Drawing.Point(0, 0);
            this.logoImageLayout.MaxSize = new System.Drawing.Size(0, 104);
            this.logoImageLayout.MinSize = new System.Drawing.Size(24, 104);
            this.logoImageLayout.Name = "logoImageLayout";
            this.logoImageLayout.Size = new System.Drawing.Size(480, 104);
            this.logoImageLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.logoImageLayout.TextSize = new System.Drawing.Size(0, 0);
            this.logoImageLayout.TextVisible = false;
            // 
            // enSubTitleLabel
            // 
            this.enSubTitleLabel.AllowHotTrack = false;
            this.enSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.enSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.enSubTitleLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(181)))), ((int)(((byte)(150)))));
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.enSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.enSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.enSubTitleLabel.Location = new System.Drawing.Point(0, 153);
            this.enSubTitleLabel.MaxSize = new System.Drawing.Size(0, 29);
            this.enSubTitleLabel.MinSize = new System.Drawing.Size(419, 29);
            this.enSubTitleLabel.Name = "enSubTitleLabel";
            this.enSubTitleLabel.Size = new System.Drawing.Size(480, 29);
            this.enSubTitleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.enSubTitleLabel.Text = "PATHOLOGY MANAGEMENT SYSTEM";
            this.enSubTitleLabel.TextSize = new System.Drawing.Size(415, 25);
            // 
            // titleLabel
            // 
            this.titleLabel.AllowHotTrack = false;
            this.titleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.titleLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(181)))), ((int)(((byte)(150)))));
            this.titleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.titleLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.titleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.titleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.titleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.titleLabel.Location = new System.Drawing.Point(0, 104);
            this.titleLabel.MaxSize = new System.Drawing.Size(0, 49);
            this.titleLabel.MinSize = new System.Drawing.Size(419, 49);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(480, 49);
            this.titleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.titleLabel.Text = "PMSX";
            this.titleLabel.TextSize = new System.Drawing.Size(415, 47);
            // 
            // viSubTitleLabel
            // 
            this.viSubTitleLabel.AllowHotTrack = false;
            this.viSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.viSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.viSubTitleLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.viSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.viSubTitleLabel.Location = new System.Drawing.Point(0, 182);
            this.viSubTitleLabel.Name = "viSubTitleLabel";
            this.viSubTitleLabel.Size = new System.Drawing.Size(480, 35);
            this.viSubTitleLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
            this.viSubTitleLabel.Text = "HỆ THỐNG QUẢN LÝ KẾT QUẢ GIẢI PHẪU BỆNH";
            this.viSubTitleLabel.TextSize = new System.Drawing.Size(359, 21);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AllowHotTrack = false;
            this.copyrightLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.copyrightLabel.AppearanceItemCaption.Options.UseFont = true;
            this.copyrightLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.copyrightLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.copyrightLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.copyrightLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.copyrightLabel.Location = new System.Drawing.Point(0, 221);
            this.copyrightLabel.MinSize = new System.Drawing.Size(419, 21);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(480, 46);
            this.copyrightLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.copyrightLabel.Text = "Copyright";
            this.copyrightLabel.TextSize = new System.Drawing.Size(415, 17);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 287);
            this.Controls.Add(this.layoutControl);
            this.Name = "Loading";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup root;
        private DevExpress.XtraEditors.PictureEdit logoImage;
        private DevExpress.XtraLayout.LayoutControlItem logoImageLayout;
        private DevExpress.XtraLayout.SimpleLabelItem enSubTitleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem titleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem viSubTitleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem copyrightLabel;
    }
}
