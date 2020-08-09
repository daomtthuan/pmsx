namespace PMSX.App.View.Form {
  partial class AccountForm {
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
      this.editButton = new DevExpress.XtraEditors.SimpleButton();
      this.usernameInput = new DevExpress.XtraEditors.TextEdit();
      this.passwordInput = new DevExpress.XtraEditors.TextEdit();
      this.nameInput = new DevExpress.XtraEditors.TextEdit();
      this.resetPasswordButton = new DevExpress.XtraEditors.SimpleButton();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.usernameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.nameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.editButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.passwordInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.resetPasswordButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.resetPasswordButtonLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.editButton);
      this.layout.Controls.Add(this.usernameInput);
      this.layout.Controls.Add(this.passwordInput);
      this.layout.Controls.Add(this.nameInput);
      this.layout.Controls.Add(this.resetPasswordButton);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 144);
      this.layout.TabIndex = 3;
      this.layout.Text = "layoutControl1";
      // 
      // editButton
      // 
      this.editButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.editButton.Appearance.Options.UseBackColor = true;
      this.editButton.Location = new System.Drawing.Point(229, 104);
      this.editButton.Name = "editButton";
      this.editButton.Padding = new System.Windows.Forms.Padding(2);
      this.editButton.Size = new System.Drawing.Size(207, 26);
      this.editButton.StyleController = this.layout;
      this.editButton.TabIndex = 8;
      this.editButton.Text = "Chỉnh sửa";
      this.editButton.Click += new System.EventHandler(this.EditButton_Click);
      // 
      // usernameInput
      // 
      this.usernameInput.Location = new System.Drawing.Point(95, 14);
      this.usernameInput.Name = "usernameInput";
      this.usernameInput.Properties.DisplayFormat.FormatString = "d";
      this.usernameInput.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.usernameInput.Properties.EditFormat.FormatString = "d";
      this.usernameInput.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.usernameInput.Properties.MaxLength = 100;
      this.usernameInput.Properties.ReadOnly = true;
      this.usernameInput.Size = new System.Drawing.Size(341, 22);
      this.usernameInput.StyleController = this.layout;
      this.usernameInput.TabIndex = 4;
      // 
      // passwordInput
      // 
      this.passwordInput.Location = new System.Drawing.Point(95, 74);
      this.passwordInput.Name = "passwordInput";
      this.passwordInput.Properties.ReadOnly = true;
      this.passwordInput.Size = new System.Drawing.Size(341, 22);
      this.passwordInput.StyleController = this.layout;
      this.passwordInput.TabIndex = 9;
      // 
      // nameInput
      // 
      this.nameInput.Location = new System.Drawing.Point(95, 44);
      this.nameInput.Name = "nameInput";
      this.nameInput.Properties.MaxLength = 100;
      this.nameInput.Size = new System.Drawing.Size(341, 22);
      this.nameInput.StyleController = this.layout;
      this.nameInput.TabIndex = 5;
      // 
      // resetPasswordButton
      // 
      this.resetPasswordButton.Location = new System.Drawing.Point(14, 104);
      this.resetPasswordButton.Name = "resetPasswordButton";
      this.resetPasswordButton.Padding = new System.Windows.Forms.Padding(2);
      this.resetPasswordButton.Size = new System.Drawing.Size(207, 26);
      this.resetPasswordButton.StyleController = this.layout;
      this.resetPasswordButton.TabIndex = 10;
      this.resetPasswordButton.Text = "Tạo mới mật khẩu";
      this.resetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usernameInputLayout,
            this.nameInputLayout,
            this.editButtonLayout,
            this.passwordInputLayout,
            this.resetPasswordButtonLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(450, 144);
      this.root.TextVisible = false;
      // 
      // usernameInputLayout
      // 
      this.usernameInputLayout.Control = this.usernameInput;
      this.usernameInputLayout.Location = new System.Drawing.Point(0, 0);
      this.usernameInputLayout.Name = "usernameInputLayout";
      this.usernameInputLayout.Size = new System.Drawing.Size(430, 30);
      this.usernameInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.usernameInputLayout.Text = "Tên đăng nhập";
      this.usernameInputLayout.TextSize = new System.Drawing.Size(78, 15);
      // 
      // nameInputLayout
      // 
      this.nameInputLayout.Control = this.nameInput;
      this.nameInputLayout.Location = new System.Drawing.Point(0, 30);
      this.nameInputLayout.Name = "nameInputLayout";
      this.nameInputLayout.Size = new System.Drawing.Size(430, 30);
      this.nameInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.nameInputLayout.Text = "Tên";
      this.nameInputLayout.TextSize = new System.Drawing.Size(78, 15);
      // 
      // editButtonLayout
      // 
      this.editButtonLayout.Control = this.editButton;
      this.editButtonLayout.Location = new System.Drawing.Point(215, 90);
      this.editButtonLayout.Name = "editButtonLayout";
      this.editButtonLayout.Size = new System.Drawing.Size(215, 34);
      this.editButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.editButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.editButtonLayout.TextVisible = false;
      // 
      // passwordInputLayout
      // 
      this.passwordInputLayout.Control = this.passwordInput;
      this.passwordInputLayout.Location = new System.Drawing.Point(0, 60);
      this.passwordInputLayout.Name = "passwordInputLayout";
      this.passwordInputLayout.Size = new System.Drawing.Size(430, 30);
      this.passwordInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.passwordInputLayout.Text = "Mật khẩu";
      this.passwordInputLayout.TextSize = new System.Drawing.Size(78, 15);
      // 
      // resetPasswordButtonLayout
      // 
      this.resetPasswordButtonLayout.Control = this.resetPasswordButton;
      this.resetPasswordButtonLayout.Location = new System.Drawing.Point(0, 90);
      this.resetPasswordButtonLayout.Name = "resetPasswordButtonLayout";
      this.resetPasswordButtonLayout.Size = new System.Drawing.Size(215, 34);
      this.resetPasswordButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.resetPasswordButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.resetPasswordButtonLayout.TextVisible = false;
      // 
      // AccountForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 144);
      this.Controls.Add(this.layout);
      this.Name = "AccountForm";
      this.Text = "Tài khoản";
      this.Load += new System.EventHandler(this.ProfileForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.resetPasswordButtonLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.SimpleButton editButton;
    private DevExpress.XtraEditors.TextEdit usernameInput;
    private DevExpress.XtraEditors.TextEdit passwordInput;
    private DevExpress.XtraEditors.TextEdit nameInput;
    private DevExpress.XtraEditors.SimpleButton resetPasswordButton;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem usernameInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem nameInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem editButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem passwordInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem resetPasswordButtonLayout;
  }
}