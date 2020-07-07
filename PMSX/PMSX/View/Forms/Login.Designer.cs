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
            this.usernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.titleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.enSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.viSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.usernameLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.passwordLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.loginLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.pictureBox1);
            this.layoutControl.Controls.Add(this.usernameTextEdit);
            this.layoutControl.Controls.Add(this.passwordTextEdit);
            this.layoutControl.Controls.Add(this.loginButton);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(518, 402);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // usernameTextEdit
            // 
            this.usernameTextEdit.Location = new System.Drawing.Point(12, 257);
            this.usernameTextEdit.Name = "usernameTextEdit";
            this.usernameTextEdit.Size = new System.Drawing.Size(494, 28);
            this.usernameTextEdit.StyleController = this.layoutControl;
            this.usernameTextEdit.TabIndex = 4;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(12, 313);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(494, 28);
            this.passwordTextEdit.StyleController = this.layoutControl;
            this.passwordTextEdit.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.loginButton.Appearance.Options.UseBackColor = true;
            this.loginButton.Location = new System.Drawing.Point(12, 355);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(494, 35);
            this.loginButton.StyleController = this.layoutControl;
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.titleLabel,
            this.enSubTitleLabel,
            this.viSubTitleLabel,
            this.usernameLayout,
            this.passwordLayout,
            this.loginLayout,
            this.emptySpaceItem1,
            this.logoLayout,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(518, 402);
            this.Root.TextVisible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AllowHotTrack = false;
            this.titleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.titleLabel.Size = new System.Drawing.Size(498, 49);
            this.titleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.titleLabel.Text = "PMSX";
            this.titleLabel.TextSize = new System.Drawing.Size(415, 45);
            // 
            // enSubTitleLabel
            // 
            this.enSubTitleLabel.AllowHotTrack = false;
            this.enSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.enSubTitleLabel.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.enSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.enSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.enSubTitleLabel.Location = new System.Drawing.Point(0, 153);
            this.enSubTitleLabel.MaxSize = new System.Drawing.Size(0, 29);
            this.enSubTitleLabel.MinSize = new System.Drawing.Size(419, 29);
            this.enSubTitleLabel.Name = "enSubTitleLabel";
            this.enSubTitleLabel.Size = new System.Drawing.Size(498, 29);
            this.enSubTitleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.enSubTitleLabel.Text = "PATHOLOGY MANAGEMENT SYSTEM";
            this.enSubTitleLabel.TextSize = new System.Drawing.Size(415, 25);
            // 
            // viSubTitleLabel
            // 
            this.viSubTitleLabel.AllowHotTrack = false;
            this.viSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.viSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.viSubTitleLabel.Location = new System.Drawing.Point(0, 182);
            this.viSubTitleLabel.MaxSize = new System.Drawing.Size(0, 29);
            this.viSubTitleLabel.MinSize = new System.Drawing.Size(419, 29);
            this.viSubTitleLabel.Name = "viSubTitleLabel";
            this.viSubTitleLabel.Size = new System.Drawing.Size(498, 29);
            this.viSubTitleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.viSubTitleLabel.Text = "HỆ THỐNG QUẢN LÝ KẾT QUẢ GIẢI PHẪU BỆNH";
            this.viSubTitleLabel.TextSize = new System.Drawing.Size(415, 25);
            // 
            // usernameLayout
            // 
            this.usernameLayout.Control = this.usernameTextEdit;
            this.usernameLayout.Location = new System.Drawing.Point(0, 221);
            this.usernameLayout.MaxSize = new System.Drawing.Size(0, 56);
            this.usernameLayout.MinSize = new System.Drawing.Size(419, 56);
            this.usernameLayout.Name = "usernameLayout";
            this.usernameLayout.Size = new System.Drawing.Size(498, 56);
            this.usernameLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.usernameLayout.Text = "Tên đăng nhập";
            this.usernameLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.usernameLayout.TextSize = new System.Drawing.Size(415, 21);
            // 
            // passwordLayout
            // 
            this.passwordLayout.Control = this.passwordTextEdit;
            this.passwordLayout.Location = new System.Drawing.Point(0, 277);
            this.passwordLayout.MaxSize = new System.Drawing.Size(0, 56);
            this.passwordLayout.MinSize = new System.Drawing.Size(419, 56);
            this.passwordLayout.Name = "passwordLayout";
            this.passwordLayout.Size = new System.Drawing.Size(498, 56);
            this.passwordLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.passwordLayout.Text = "Mật khẩu";
            this.passwordLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.passwordLayout.TextSize = new System.Drawing.Size(415, 21);
            // 
            // loginLayout
            // 
            this.loginLayout.Control = this.loginButton;
            this.loginLayout.Location = new System.Drawing.Point(0, 343);
            this.loginLayout.MaxSize = new System.Drawing.Size(0, 39);
            this.loginLayout.MinSize = new System.Drawing.Size(87, 39);
            this.loginLayout.Name = "loginLayout";
            this.loginLayout.Size = new System.Drawing.Size(498, 39);
            this.loginLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.loginLayout.TextSize = new System.Drawing.Size(0, 0);
            this.loginLayout.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 211);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(498, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(498, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(498, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMSX.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // logoLayout
            // 
            this.logoLayout.Control = this.pictureBox1;
            this.logoLayout.Location = new System.Drawing.Point(0, 0);
            this.logoLayout.MinSize = new System.Drawing.Size(104, 24);
            this.logoLayout.Name = "logoLayout";
            this.logoLayout.Size = new System.Drawing.Size(498, 104);
            this.logoLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.logoLayout.TextSize = new System.Drawing.Size(0, 0);
            this.logoLayout.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 333);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(498, 10);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(498, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(498, 10);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.Text = "emptySpaceItem1";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 402);
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
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem titleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem enSubTitleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem viSubTitleLabel;
        private DevExpress.XtraEditors.TextEdit usernameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem usernameLayout;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem passwordLayout;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraLayout.LayoutControlItem loginLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraLayout.LayoutControlItem logoLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}