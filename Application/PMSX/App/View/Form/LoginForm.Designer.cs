namespace PMSX.App.View.Form {
  internal partial class LoginForm {
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
      this.brandControl = new PMSX.App.View.Control.BrandControl();
      this.usernameInput = new DevExpress.XtraEditors.TextEdit();
      this.passwordInput = new DevExpress.XtraEditors.TextEdit();
      this.loginButton = new DevExpress.XtraEditors.SimpleButton();
      this.sessionButton = new DevExpress.XtraEditors.SimpleButton();
      this.sessionSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.usernameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.passwordInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.separator = new DevExpress.XtraLayout.SimpleSeparator();
      this.sessionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.loginButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.sessionButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.brandControlLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.loginButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandControlLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.brandControl);
      this.layout.Controls.Add(this.usernameInput);
      this.layout.Controls.Add(this.passwordInput);
      this.layout.Controls.Add(this.loginButton);
      this.layout.Controls.Add(this.sessionButton);
      this.layout.Controls.Add(this.sessionSelect);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.layout.Name = "layout";
      this.layout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(910, 7, 650, 400);
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(408, 346);
      this.layout.TabIndex = 0;
      this.layout.Text = "layoutControl1";
      // 
      // brandControl
      // 
      this.brandControl.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.brandControl.Appearance.Options.UseBackColor = true;
      this.brandControl.Location = new System.Drawing.Point(14, 14);
      this.brandControl.Margin = new System.Windows.Forms.Padding(2);
      this.brandControl.Name = "brandControl";
      this.brandControl.Size = new System.Drawing.Size(380, 183);
      this.brandControl.TabIndex = 9;
      this.brandControl.TabStop = false;
      // 
      // usernameInput
      // 
      this.usernameInput.Location = new System.Drawing.Point(95, 205);
      this.usernameInput.Name = "usernameInput";
      this.usernameInput.Properties.MaxLength = 100;
      this.usernameInput.Properties.Padding = new System.Windows.Forms.Padding(1);
      this.usernameInput.Size = new System.Drawing.Size(299, 24);
      this.usernameInput.StyleController = this.layout;
      this.usernameInput.TabIndex = 4;
      // 
      // passwordInput
      // 
      this.passwordInput.Location = new System.Drawing.Point(95, 237);
      this.passwordInput.Name = "passwordInput";
      this.passwordInput.Properties.MaxLength = 100;
      this.passwordInput.Properties.Padding = new System.Windows.Forms.Padding(1);
      this.passwordInput.Properties.PasswordChar = '-';
      this.passwordInput.Size = new System.Drawing.Size(299, 24);
      this.passwordInput.StyleController = this.layout;
      this.passwordInput.TabIndex = 5;
      // 
      // loginButton
      // 
      this.loginButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.loginButton.Appearance.Options.UseBackColor = true;
      this.loginButton.Location = new System.Drawing.Point(206, 306);
      this.loginButton.Name = "loginButton";
      this.loginButton.Padding = new System.Windows.Forms.Padding(2);
      this.loginButton.Size = new System.Drawing.Size(188, 26);
      this.loginButton.StyleController = this.layout;
      this.loginButton.TabIndex = 7;
      this.loginButton.Text = "Đăng nhập";
      this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
      // 
      // sessionButton
      // 
      this.sessionButton.Location = new System.Drawing.Point(14, 306);
      this.sessionButton.Name = "sessionButton";
      this.sessionButton.Padding = new System.Windows.Forms.Padding(2);
      this.sessionButton.Size = new System.Drawing.Size(184, 26);
      this.sessionButton.StyleController = this.layout;
      this.sessionButton.TabIndex = 8;
      this.sessionButton.Text = "Thêm phiên làm việc";
      this.sessionButton.Click += new System.EventHandler(this.SessionButton_Click);
      // 
      // sessionSelect
      // 
      this.sessionSelect.Location = new System.Drawing.Point(95, 274);
      this.sessionSelect.Name = "sessionSelect";
      this.sessionSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.sessionSelect.Properties.NullText = "";
      this.sessionSelect.Properties.Padding = new System.Windows.Forms.Padding(1);
      this.sessionSelect.Size = new System.Drawing.Size(299, 24);
      this.sessionSelect.StyleController = this.layout;
      this.sessionSelect.TabIndex = 6;
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usernameInputLayout,
            this.passwordInputLayout,
            this.separator,
            this.sessionSelectLayout,
            this.loginButtonLayout,
            this.sessionButtonLayout,
            this.brandControlLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(408, 346);
      this.root.TextVisible = false;
      // 
      // usernameInputLayout
      // 
      this.usernameInputLayout.Control = this.usernameInput;
      this.usernameInputLayout.Location = new System.Drawing.Point(0, 191);
      this.usernameInputLayout.Name = "inputUsernameLayout";
      this.usernameInputLayout.Size = new System.Drawing.Size(388, 32);
      this.usernameInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.usernameInputLayout.Text = "Tên đăng nhập";
      this.usernameInputLayout.TextSize = new System.Drawing.Size(78, 15);
      // 
      // passwordInputLayout
      // 
      this.passwordInputLayout.Control = this.passwordInput;
      this.passwordInputLayout.Location = new System.Drawing.Point(0, 223);
      this.passwordInputLayout.Name = "inputPasswordLayout";
      this.passwordInputLayout.Size = new System.Drawing.Size(388, 32);
      this.passwordInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.passwordInputLayout.Text = "Mật khẩu";
      this.passwordInputLayout.TextSize = new System.Drawing.Size(78, 15);
      // 
      // separator
      // 
      this.separator.AllowHotTrack = false;
      this.separator.Location = new System.Drawing.Point(0, 255);
      this.separator.Name = "separator";
      this.separator.Size = new System.Drawing.Size(388, 5);
      this.separator.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      // 
      // sessionSelectLayout
      // 
      this.sessionSelectLayout.Control = this.sessionSelect;
      this.sessionSelectLayout.Location = new System.Drawing.Point(0, 260);
      this.sessionSelectLayout.Name = "selectSessionLayout";
      this.sessionSelectLayout.Size = new System.Drawing.Size(388, 32);
      this.sessionSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.sessionSelectLayout.Text = "Phiên làm việc";
      this.sessionSelectLayout.TextSize = new System.Drawing.Size(78, 15);
      // 
      // loginButtonLayout
      // 
      this.loginButtonLayout.Control = this.loginButton;
      this.loginButtonLayout.Location = new System.Drawing.Point(192, 292);
      this.loginButtonLayout.Name = "buttonLoginLayout";
      this.loginButtonLayout.Size = new System.Drawing.Size(196, 34);
      this.loginButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.loginButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.loginButtonLayout.TextVisible = false;
      // 
      // sessionButtonLayout
      // 
      this.sessionButtonLayout.Control = this.sessionButton;
      this.sessionButtonLayout.Location = new System.Drawing.Point(0, 292);
      this.sessionButtonLayout.Name = "buttonInsertSessionLayout";
      this.sessionButtonLayout.Size = new System.Drawing.Size(192, 34);
      this.sessionButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.sessionButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.sessionButtonLayout.TextVisible = false;
      // 
      // brandControlLayout
      // 
      this.brandControlLayout.Control = this.brandControl;
      this.brandControlLayout.Location = new System.Drawing.Point(0, 0);
      this.brandControlLayout.Name = "brandControlLayout";
      this.brandControlLayout.Size = new System.Drawing.Size(388, 191);
      this.brandControlLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.brandControlLayout.TextSize = new System.Drawing.Size(0, 0);
      this.brandControlLayout.TextVisible = false;
      // 
      // LoginForm
      // 
      this.AcceptButton = this.loginButton;
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(408, 346);
      this.Controls.Add(this.layout);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "LoginForm";
      this.Text = "Đăng nhập";
      this.Load += new System.EventHandler(this.LoginForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.loginButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandControlLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraEditors.TextEdit usernameInput;
    private DevExpress.XtraEditors.TextEdit passwordInput;
    private DevExpress.XtraLayout.LayoutControlItem usernameInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem passwordInputLayout;
    private DevExpress.XtraLayout.SimpleSeparator separator;
    private DevExpress.XtraLayout.LayoutControlItem sessionSelectLayout;
    private DevExpress.XtraEditors.SimpleButton loginButton;
    private DevExpress.XtraEditors.SimpleButton sessionButton;
    private DevExpress.XtraLayout.LayoutControlItem loginButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem sessionButtonLayout;
    private DevExpress.XtraEditors.LookUpEdit sessionSelect;
    private Control.BrandControl brandControl;
    private DevExpress.XtraLayout.LayoutControlItem brandControlLayout;
  }
}