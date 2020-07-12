namespace PMSX.View.Form {
    partial class Login {
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
            this.usernameInput = new DevExpress.XtraEditors.TextEdit();
            this.passwordInput = new DevExpress.XtraEditors.TextEdit();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.enSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.usernameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.passwordInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.loginButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.titleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.viSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.logoImageLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.logoImage);
            this.layoutControl.Controls.Add(this.usernameInput);
            this.layoutControl.Controls.Add(this.passwordInput);
            this.layoutControl.Controls.Add(this.loginButton);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.root;
            this.layoutControl.Size = new System.Drawing.Size(500, 403);
            this.layoutControl.TabIndex = 0;
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
            this.logoImage.TabIndex = 10;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(12, 253);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Properties.MaxLength = 100;
            this.usernameInput.Size = new System.Drawing.Size(476, 28);
            this.usernameInput.StyleController = this.layoutControl;
            this.usernameInput.TabIndex = 4;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(12, 309);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Properties.MaxLength = 100;
            this.passwordInput.Properties.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(476, 28);
            this.passwordInput.StyleController = this.layoutControl;
            this.passwordInput.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.loginButton.Appearance.Options.UseBackColor = true;
            this.loginButton.Location = new System.Drawing.Point(12, 351);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(5);
            this.loginButton.Size = new System.Drawing.Size(476, 40);
            this.loginButton.StyleController = this.layoutControl;
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // root
            // 
            this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.root.GroupBordersVisible = false;
            this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.enSubTitleLabel,
            this.usernameInputLayout,
            this.passwordInputLayout,
            this.loginButtonLayout,
            this.titleLabel,
            this.viSubTitleLabel,
            this.logoImageLayout});
            this.root.Name = "Root";
            this.root.Size = new System.Drawing.Size(500, 403);
            this.root.TextVisible = false;
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
            // usernameInputLayout
            // 
            this.usernameInputLayout.Control = this.usernameInput;
            this.usernameInputLayout.Location = new System.Drawing.Point(0, 217);
            this.usernameInputLayout.MaxSize = new System.Drawing.Size(0, 56);
            this.usernameInputLayout.MinSize = new System.Drawing.Size(419, 56);
            this.usernameInputLayout.Name = "usernameInputLayout";
            this.usernameInputLayout.Size = new System.Drawing.Size(480, 56);
            this.usernameInputLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.usernameInputLayout.Text = "Tên đăng nhập";
            this.usernameInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.usernameInputLayout.TextSize = new System.Drawing.Size(359, 21);
            // 
            // passwordInputLayout
            // 
            this.passwordInputLayout.Control = this.passwordInput;
            this.passwordInputLayout.Location = new System.Drawing.Point(0, 273);
            this.passwordInputLayout.MaxSize = new System.Drawing.Size(0, 56);
            this.passwordInputLayout.MinSize = new System.Drawing.Size(419, 56);
            this.passwordInputLayout.Name = "passwordInputLayout";
            this.passwordInputLayout.Size = new System.Drawing.Size(480, 56);
            this.passwordInputLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.passwordInputLayout.Text = "Mật khẩu";
            this.passwordInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.passwordInputLayout.TextSize = new System.Drawing.Size(359, 21);
            // 
            // loginButtonLayout
            // 
            this.loginButtonLayout.Control = this.loginButton;
            this.loginButtonLayout.Location = new System.Drawing.Point(0, 329);
            this.loginButtonLayout.MaxSize = new System.Drawing.Size(0, 54);
            this.loginButtonLayout.MinSize = new System.Drawing.Size(97, 54);
            this.loginButtonLayout.Name = "loginButtonLayout";
            this.loginButtonLayout.Size = new System.Drawing.Size(480, 54);
            this.loginButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.loginButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.loginButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.loginButtonLayout.TextVisible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AllowHotTrack = false;
            this.titleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // viSubTitleLabel
            // 
            this.viSubTitleLabel.AllowHotTrack = false;
            this.viSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
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
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 403);
            this.Controls.Add(this.layoutControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMSX - Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup root;
        private DevExpress.XtraLayout.SimpleLabelItem titleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem enSubTitleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem viSubTitleLabel;
        private DevExpress.XtraEditors.TextEdit usernameInput;
        private DevExpress.XtraLayout.LayoutControlItem usernameInputLayout;
        private DevExpress.XtraEditors.TextEdit passwordInput;
        private DevExpress.XtraLayout.LayoutControlItem passwordInputLayout;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraLayout.LayoutControlItem loginButtonLayout;
        private DevExpress.XtraEditors.PictureEdit logoImage;
        private DevExpress.XtraLayout.LayoutControlItem logoImageLayout;
    }
}