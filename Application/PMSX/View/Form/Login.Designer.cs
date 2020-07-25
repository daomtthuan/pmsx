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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.brandControl = new PMSX.View.Control.Brand();
      this.usernameInput = new DevExpress.XtraEditors.TextEdit();
      this.passwordInput = new DevExpress.XtraEditors.TextEdit();
      this.loginButton = new DevExpress.XtraEditors.SimpleButton();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.usernameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.passwordInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.loginButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.sessionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.sessionSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.insertSessionButton = new DevExpress.XtraEditors.SimpleButton();
      this.insertSessionButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.loginButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertSessionButtonLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.AllowCustomization = false;
      this.layoutControl1.Controls.Add(this.brandControl);
      this.layoutControl1.Controls.Add(this.usernameInput);
      this.layoutControl1.Controls.Add(this.passwordInput);
      this.layoutControl1.Controls.Add(this.loginButton);
      this.layoutControl1.Controls.Add(this.sessionSelect);
      this.layoutControl1.Controls.Add(this.insertSessionButton);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1040, 143, 650, 400);
      this.layoutControl1.Root = this.Root;
      this.layoutControl1.Size = new System.Drawing.Size(416, 363);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // brandControl
      // 
      this.brandControl.Location = new System.Drawing.Point(14, 14);
      this.brandControl.Name = "brandControl";
      this.brandControl.Size = new System.Drawing.Size(388, 215);
      this.brandControl.TabIndex = 4;
      // 
      // usernameInput
      // 
      this.usernameInput.Location = new System.Drawing.Point(89, 237);
      this.usernameInput.Name = "usernameInput";
      this.usernameInput.Size = new System.Drawing.Size(313, 22);
      this.usernameInput.StyleController = this.layoutControl1;
      this.usernameInput.TabIndex = 5;
      // 
      // passwordInput
      // 
      this.passwordInput.Location = new System.Drawing.Point(89, 267);
      this.passwordInput.Name = "passwordInput";
      this.passwordInput.Size = new System.Drawing.Size(313, 22);
      this.passwordInput.StyleController = this.layoutControl1;
      this.passwordInput.TabIndex = 6;
      // 
      // loginButton
      // 
      this.loginButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.loginButton.Appearance.Options.UseBackColor = true;
      this.loginButton.Location = new System.Drawing.Point(212, 327);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(190, 22);
      this.loginButton.StyleController = this.layoutControl1;
      this.loginButton.TabIndex = 7;
      this.loginButton.Text = "Đăng nhập";
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.usernameInputLayout,
            this.passwordInputLayout,
            this.loginButtonLayout,
            this.sessionSelectLayout,
            this.insertSessionButtonLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(416, 363);
      this.Root.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.brandControl;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(396, 223);
      this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // usernameInputLayout
      // 
      this.usernameInputLayout.Control = this.usernameInput;
      this.usernameInputLayout.Location = new System.Drawing.Point(0, 223);
      this.usernameInputLayout.Name = "usernameInputLayout";
      this.usernameInputLayout.Size = new System.Drawing.Size(396, 30);
      this.usernameInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.usernameInputLayout.Text = "Tên đăng nhập";
      this.usernameInputLayout.TextSize = new System.Drawing.Size(72, 15);
      // 
      // passwordInputLayout
      // 
      this.passwordInputLayout.Control = this.passwordInput;
      this.passwordInputLayout.Location = new System.Drawing.Point(0, 253);
      this.passwordInputLayout.Name = "passwordInputLayout";
      this.passwordInputLayout.Size = new System.Drawing.Size(396, 30);
      this.passwordInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.passwordInputLayout.Text = "Mật khẩu";
      this.passwordInputLayout.TextSize = new System.Drawing.Size(72, 15);
      // 
      // loginButtonLayout
      // 
      this.loginButtonLayout.Control = this.loginButton;
      this.loginButtonLayout.Location = new System.Drawing.Point(198, 313);
      this.loginButtonLayout.Name = "loginButtonLayout";
      this.loginButtonLayout.Size = new System.Drawing.Size(198, 30);
      this.loginButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.loginButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.loginButtonLayout.TextVisible = false;
      // 
      // sessionSelectLayout
      // 
      this.sessionSelectLayout.Control = this.sessionSelect;
      this.sessionSelectLayout.Location = new System.Drawing.Point(0, 283);
      this.sessionSelectLayout.Name = "sessionSelectLayout";
      this.sessionSelectLayout.Size = new System.Drawing.Size(396, 30);
      this.sessionSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.sessionSelectLayout.Text = "Phiên làm việc";
      this.sessionSelectLayout.TextSize = new System.Drawing.Size(72, 15);
      // 
      // sessionSelect
      // 
      this.sessionSelect.Location = new System.Drawing.Point(89, 297);
      this.sessionSelect.Name = "sessionSelect";
      this.sessionSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.sessionSelect.Properties.NullText = "";
      this.sessionSelect.Size = new System.Drawing.Size(313, 22);
      this.sessionSelect.StyleController = this.layoutControl1;
      this.sessionSelect.TabIndex = 8;
      // 
      // insertSessionButton
      // 
      this.insertSessionButton.Location = new System.Drawing.Point(14, 327);
      this.insertSessionButton.Name = "insertSessionButton";
      this.insertSessionButton.Size = new System.Drawing.Size(190, 22);
      this.insertSessionButton.StyleController = this.layoutControl1;
      this.insertSessionButton.TabIndex = 9;
      this.insertSessionButton.Text = "Thêm phiên làm việc";
      // 
      // insertSessionButtonLayout
      // 
      this.insertSessionButtonLayout.Control = this.insertSessionButton;
      this.insertSessionButtonLayout.Location = new System.Drawing.Point(0, 313);
      this.insertSessionButtonLayout.Name = "insertSessionButtonLayout";
      this.insertSessionButtonLayout.Size = new System.Drawing.Size(198, 30);
      this.insertSessionButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.insertSessionButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.insertSessionButtonLayout.TextVisible = false;
      // 
      // Login
      // 
      this.AcceptButton = this.loginButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(416, 363);
      this.Controls.Add(this.layoutControl1);
      this.Name = "Login";
      this.Text = "PMSX - Đăng nhập";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.loginButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertSessionButtonLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private Control.Brand brandControl;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.TextEdit usernameInput;
    private DevExpress.XtraEditors.TextEdit passwordInput;
    private DevExpress.XtraEditors.SimpleButton loginButton;
    private DevExpress.XtraLayout.LayoutControlItem usernameInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem passwordInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem loginButtonLayout;
    private DevExpress.XtraEditors.LookUpEdit sessionSelect;
    private DevExpress.XtraEditors.SimpleButton insertSessionButton;
    private DevExpress.XtraLayout.LayoutControlItem sessionSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem insertSessionButtonLayout;
  }
}