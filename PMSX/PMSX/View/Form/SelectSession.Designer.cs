namespace PMSX.View.Form {
    partial class SelectSession {
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
            this.startButton = new DevExpress.XtraEditors.SimpleButton();
            this.sessionSelect = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sessionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.startButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.titleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.enSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.viSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.logoImageLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.logoImage);
            this.layoutControl.Controls.Add(this.startButton);
            this.layoutControl.Controls.Add(this.sessionSelect);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(500, 351);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
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
            // startButton
            // 
            this.startButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.startButton.Appearance.Options.UseBackColor = true;
            this.startButton.Location = new System.Drawing.Point(12, 299);
            this.startButton.Name = "startButton";
            this.startButton.Padding = new System.Windows.Forms.Padding(5);
            this.startButton.Size = new System.Drawing.Size(476, 40);
            this.startButton.StyleController = this.layoutControl;
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Bắt đầu";
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // sessionSelect
            // 
            this.sessionSelect.Location = new System.Drawing.Point(12, 257);
            this.sessionSelect.Name = "sessionSelect";
            this.sessionSelect.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.sessionSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sessionSelect.Properties.ImmediatePopup = true;
            this.sessionSelect.Properties.NullText = "";
            this.sessionSelect.Properties.PopupSizeable = false;
            this.sessionSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.sessionSelect.Size = new System.Drawing.Size(476, 28);
            this.sessionSelect.StyleController = this.layoutControl;
            this.sessionSelect.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sessionSelectLayout,
            this.startButtonLayout,
            this.titleLabel,
            this.enSubTitleLabel,
            this.viSubTitleLabel,
            this.logoImageLayout});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(500, 351);
            this.Root.TextVisible = false;
            // 
            // sessionSelectLayout
            // 
            this.sessionSelectLayout.Control = this.sessionSelect;
            this.sessionSelectLayout.Location = new System.Drawing.Point(0, 221);
            this.sessionSelectLayout.MaxSize = new System.Drawing.Size(0, 56);
            this.sessionSelectLayout.MinSize = new System.Drawing.Size(419, 56);
            this.sessionSelectLayout.Name = "sessionSelectLayout";
            this.sessionSelectLayout.Size = new System.Drawing.Size(480, 56);
            this.sessionSelectLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.sessionSelectLayout.Text = "Phiên làm việc";
            this.sessionSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.sessionSelectLayout.TextSize = new System.Drawing.Size(359, 21);
            // 
            // startButtonLayout
            // 
            this.startButtonLayout.Control = this.startButton;
            this.startButtonLayout.Location = new System.Drawing.Point(0, 277);
            this.startButtonLayout.MaxSize = new System.Drawing.Size(480, 54);
            this.startButtonLayout.MinSize = new System.Drawing.Size(480, 54);
            this.startButtonLayout.Name = "startButtonLayout";
            this.startButtonLayout.Size = new System.Drawing.Size(480, 54);
            this.startButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.startButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.startButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.startButtonLayout.TextVisible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AllowHotTrack = false;
            this.titleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.titleLabel.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
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
            this.titleLabel.TextSize = new System.Drawing.Size(359, 47);
            // 
            // enSubTitleLabel
            // 
            this.enSubTitleLabel.AllowHotTrack = false;
            this.enSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.enSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.enSubTitleLabel.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
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
            this.enSubTitleLabel.TextSize = new System.Drawing.Size(359, 25);
            // 
            // viSubTitleLabel
            // 
            this.viSubTitleLabel.AllowHotTrack = false;
            this.viSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.viSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.viSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.viSubTitleLabel.Location = new System.Drawing.Point(0, 182);
            this.viSubTitleLabel.MaxSize = new System.Drawing.Size(0, 39);
            this.viSubTitleLabel.MinSize = new System.Drawing.Size(419, 39);
            this.viSubTitleLabel.Name = "viSubTitleLabel";
            this.viSubTitleLabel.Size = new System.Drawing.Size(480, 39);
            this.viSubTitleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.viSubTitleLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
            this.viSubTitleLabel.Text = "HỆ THỐNG QUẢN LÝ KẾT QUẢ GIẢI PHẪU BỆNH";
            this.viSubTitleLabel.TextSize = new System.Drawing.Size(359, 21);
            // 
            // logoImageLayout
            // 
            this.logoImageLayout.Control = this.logoImage;
            this.logoImageLayout.Location = new System.Drawing.Point(0, 0);
            this.logoImageLayout.MaxSize = new System.Drawing.Size(480, 104);
            this.logoImageLayout.MinSize = new System.Drawing.Size(480, 104);
            this.logoImageLayout.Name = "logoImageLayout";
            this.logoImageLayout.Size = new System.Drawing.Size(480, 104);
            this.logoImageLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.logoImageLayout.TextSize = new System.Drawing.Size(0, 0);
            this.logoImageLayout.TextVisible = false;
            // 
            // SelectSession
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 351);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMSX - Chọn phiên làm việc";
            this.Load += new System.EventHandler(this.SelectSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem sessionSelectLayout;
        private DevExpress.XtraEditors.SimpleButton startButton;
        private DevExpress.XtraLayout.LayoutControlItem startButtonLayout;
        private DevExpress.XtraEditors.LookUpEdit sessionSelect;
        private DevExpress.XtraLayout.SimpleLabelItem titleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem enSubTitleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem viSubTitleLabel;
        private DevExpress.XtraEditors.PictureEdit logoImage;
        private DevExpress.XtraLayout.LayoutControlItem logoImageLayout;
    }
}