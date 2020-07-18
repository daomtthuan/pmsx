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
      this.brand1 = new PMSX.View.UserControl.Brand();
      this.usernameInput = new DevExpress.XtraEditors.TextEdit();
      this.passwordInput = new DevExpress.XtraEditors.TextEdit();
      this.loginButton = new DevExpress.XtraEditors.SimpleButton();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.usernameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.passwordInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.loginButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.loginButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.brand1);
      this.layoutControl.Controls.Add(this.usernameInput);
      this.layoutControl.Controls.Add(this.passwordInput);
      this.layoutControl.Controls.Add(this.loginButton);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.root;
      this.layoutControl.Size = new System.Drawing.Size(400, 430);
      this.layoutControl.TabIndex = 3;
      this.layoutControl.Text = "layoutControl1";
      // 
      // brand1
      // 
      this.brand1.Location = new System.Drawing.Point(12, 12);
      this.brand1.Name = "brand1";
      this.brand1.Size = new System.Drawing.Size(376, 244);
      this.brand1.TabIndex = 4;
      this.brand1.TabStop = false;
      // 
      // usernameInput
      // 
      this.usernameInput.Location = new System.Drawing.Point(12, 284);
      this.usernameInput.Name = "usernameInput";
      this.usernameInput.Properties.MaxLength = 100;
      this.usernameInput.Size = new System.Drawing.Size(376, 28);
      this.usernameInput.StyleController = this.layoutControl;
      this.usernameInput.TabIndex = 0;
      // 
      // passwordInput
      // 
      this.passwordInput.Location = new System.Drawing.Point(12, 340);
      this.passwordInput.Name = "passwordInput";
      this.passwordInput.Properties.MaxLength = 100;
      this.passwordInput.Properties.PasswordChar = '*';
      this.passwordInput.Size = new System.Drawing.Size(376, 28);
      this.passwordInput.StyleController = this.layoutControl;
      this.passwordInput.TabIndex = 1;
      // 
      // loginButton
      // 
      this.loginButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.loginButton.Appearance.Options.UseBackColor = true;
      this.loginButton.Location = new System.Drawing.Point(12, 382);
      this.loginButton.Name = "loginButton";
      this.loginButton.Padding = new System.Windows.Forms.Padding(5);
      this.loginButton.Size = new System.Drawing.Size(376, 36);
      this.loginButton.StyleController = this.layoutControl;
      this.loginButton.TabIndex = 2;
      this.loginButton.Text = "Đăng nhập";
      this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usernameInputLayout,
            this.passwordInputLayout,
            this.loginButtonLayout,
            this.layoutControlItem1});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(400, 430);
      this.root.TextVisible = false;
      // 
      // usernameInputLayout
      // 
      this.usernameInputLayout.Control = this.usernameInput;
      this.usernameInputLayout.Location = new System.Drawing.Point(0, 248);
      this.usernameInputLayout.Name = "usernameInputLayout";
      this.usernameInputLayout.Size = new System.Drawing.Size(380, 56);
      this.usernameInputLayout.Text = "Tên đăng nhập";
      this.usernameInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.usernameInputLayout.TextSize = new System.Drawing.Size(107, 21);
      // 
      // passwordInputLayout
      // 
      this.passwordInputLayout.Control = this.passwordInput;
      this.passwordInputLayout.Location = new System.Drawing.Point(0, 304);
      this.passwordInputLayout.Name = "passwordInputLayout";
      this.passwordInputLayout.Size = new System.Drawing.Size(380, 56);
      this.passwordInputLayout.Text = "Mật khẩu";
      this.passwordInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.passwordInputLayout.TextSize = new System.Drawing.Size(107, 21);
      // 
      // loginButtonLayout
      // 
      this.loginButtonLayout.Control = this.loginButton;
      this.loginButtonLayout.Location = new System.Drawing.Point(0, 360);
      this.loginButtonLayout.Name = "loginButtonLayout";
      this.loginButtonLayout.Size = new System.Drawing.Size(380, 50);
      this.loginButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.loginButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.loginButtonLayout.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.brand1;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(380, 248);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // Login
      // 
      this.AcceptButton = this.loginButton;
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(400, 430);
      this.Controls.Add(this.layoutControl);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Đăng nhập";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.loginButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup root;
        private DevExpress.XtraEditors.TextEdit usernameInput;
        private DevExpress.XtraLayout.LayoutControlItem usernameInputLayout;
        private DevExpress.XtraEditors.TextEdit passwordInput;
        private DevExpress.XtraLayout.LayoutControlItem passwordInputLayout;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraLayout.LayoutControlItem loginButtonLayout;
    private UserControl.Brand brand1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
  }
}