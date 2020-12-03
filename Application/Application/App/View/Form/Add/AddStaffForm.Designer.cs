namespace PMSXApplication.App.View.Form.Add {
  internal partial class AddStaffForm {
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
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.addButton = new DevExpress.XtraEditors.SimpleButton();
      this.usernameInput = new DevExpress.XtraEditors.TextEdit();
      this.passwordInput = new DevExpress.XtraEditors.TextEdit();
      this.nameInput = new DevExpress.XtraEditors.TextEdit();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.usernameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.nameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.separator = new DevExpress.XtraLayout.SimpleSeparator();
      this.addButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.passwordInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.commentInput);
      this.layout.Controls.Add(this.addButton);
      this.layout.Controls.Add(this.usernameInput);
      this.layout.Controls.Add(this.passwordInput);
      this.layout.Controls.Add(this.nameInput);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 320);
      this.layout.TabIndex = 1;
      this.layout.Text = "layoutControl1";
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(95, 109);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 1000;
      this.commentInput.Size = new System.Drawing.Size(341, 163);
      this.commentInput.StyleController = this.layout;
      this.commentInput.TabIndex = 7;
      // 
      // addButton
      // 
      this.addButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.addButton.Appearance.Options.UseBackColor = true;
      this.addButton.Location = new System.Drawing.Point(14, 280);
      this.addButton.Name = "addButton";
      this.addButton.Padding = new System.Windows.Forms.Padding(2);
      this.addButton.Size = new System.Drawing.Size(422, 26);
      this.addButton.StyleController = this.layout;
      this.addButton.TabIndex = 8;
      this.addButton.Text = "Thêm";
      this.addButton.Click += new System.EventHandler(this.AddButton_Click);
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
      this.usernameInput.Size = new System.Drawing.Size(341, 22);
      this.usernameInput.StyleController = this.layout;
      this.usernameInput.TabIndex = 4;
      // 
      // passwordInput
      // 
      this.passwordInput.Location = new System.Drawing.Point(95, 74);
      this.passwordInput.Name = "passwordInput";
      this.passwordInput.Properties.MaxLength = 100;
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
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usernameInputLayout,
            this.nameInputLayout,
            this.commentInputLayout,
            this.separator,
            this.addButtonLayout,
            this.passwordInputLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(450, 320);
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
      // commentInputLayout
      // 
      this.commentInputLayout.AppearanceItemCaption.Options.UseTextOptions = true;
      this.commentInputLayout.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 95);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(430, 171);
      this.commentInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextSize = new System.Drawing.Size(78, 15);
      // 
      // separator
      // 
      this.separator.AllowHotTrack = false;
      this.separator.Location = new System.Drawing.Point(0, 90);
      this.separator.Name = "separator";
      this.separator.Size = new System.Drawing.Size(430, 5);
      this.separator.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      // 
      // addButtonLayout
      // 
      this.addButtonLayout.Control = this.addButton;
      this.addButtonLayout.Location = new System.Drawing.Point(0, 266);
      this.addButtonLayout.Name = "addButtonLayout";
      this.addButtonLayout.Size = new System.Drawing.Size(430, 34);
      this.addButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.addButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.addButtonLayout.TextVisible = false;
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
      // AddStaffForm
      // 
      this.AcceptButton = this.addButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 320);
      this.Controls.Add(this.layout);
      this.Name = "AddStaffForm";
      this.Text = "Thêm nhân viên";
      this.Load += new System.EventHandler(this.AddStaffForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usernameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.passwordInputLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraEditors.SimpleButton addButton;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem usernameInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem nameInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.SimpleSeparator separator;
    private DevExpress.XtraLayout.LayoutControlItem addButtonLayout;
    private DevExpress.XtraEditors.TextEdit usernameInput;
    private DevExpress.XtraEditors.TextEdit passwordInput;
    private DevExpress.XtraLayout.LayoutControlItem passwordInputLayout;
    private DevExpress.XtraEditors.TextEdit nameInput;
  }
}