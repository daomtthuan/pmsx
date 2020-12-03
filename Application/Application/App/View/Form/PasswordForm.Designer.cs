namespace PMSXApplication.App.View.Form {
  internal partial class PasswordForm {
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
      this.oldInput = new DevExpress.XtraEditors.TextEdit();
      this.reInput = new DevExpress.XtraEditors.TextEdit();
      this.newInput = new DevExpress.XtraEditors.TextEdit();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.oldInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.newInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.editButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.reInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.oldInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.reInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.newInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.oldInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.newInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.reInputLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.editButton);
      this.layout.Controls.Add(this.oldInput);
      this.layout.Controls.Add(this.reInput);
      this.layout.Controls.Add(this.newInput);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 144);
      this.layout.TabIndex = 4;
      this.layout.Text = "layoutControl1";
      // 
      // editButton
      // 
      this.editButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.editButton.Appearance.Options.UseBackColor = true;
      this.editButton.Location = new System.Drawing.Point(14, 104);
      this.editButton.Name = "editButton";
      this.editButton.Padding = new System.Windows.Forms.Padding(2);
      this.editButton.Size = new System.Drawing.Size(422, 26);
      this.editButton.StyleController = this.layout;
      this.editButton.TabIndex = 8;
      this.editButton.Text = "Chỉnh sửa";
      this.editButton.Click += new System.EventHandler(this.EditButton_Click);
      // 
      // oldInput
      // 
      this.oldInput.Location = new System.Drawing.Point(135, 14);
      this.oldInput.Name = "oldInput";
      this.oldInput.Properties.DisplayFormat.FormatString = "d";
      this.oldInput.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.oldInput.Properties.EditFormat.FormatString = "d";
      this.oldInput.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.oldInput.Properties.MaxLength = 100;
      this.oldInput.Properties.PasswordChar = '-';
      this.oldInput.Size = new System.Drawing.Size(301, 22);
      this.oldInput.StyleController = this.layout;
      this.oldInput.TabIndex = 4;
      // 
      // reInput
      // 
      this.reInput.Location = new System.Drawing.Point(135, 74);
      this.reInput.Name = "reInput";
      this.reInput.Properties.MaxLength = 100;
      this.reInput.Properties.PasswordChar = '-';
      this.reInput.Size = new System.Drawing.Size(301, 22);
      this.reInput.StyleController = this.layout;
      this.reInput.TabIndex = 9;
      // 
      // newInput
      // 
      this.newInput.Location = new System.Drawing.Point(135, 44);
      this.newInput.Name = "newInput";
      this.newInput.Properties.MaxLength = 100;
      this.newInput.Properties.PasswordChar = '-';
      this.newInput.Size = new System.Drawing.Size(301, 22);
      this.newInput.StyleController = this.layout;
      this.newInput.TabIndex = 5;
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.oldInputLayout,
            this.newInputLayout,
            this.editButtonLayout,
            this.reInputLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(450, 144);
      this.root.TextVisible = false;
      // 
      // oldInputLayout
      // 
      this.oldInputLayout.Control = this.oldInput;
      this.oldInputLayout.Location = new System.Drawing.Point(0, 0);
      this.oldInputLayout.Name = "oldInputLayout";
      this.oldInputLayout.Size = new System.Drawing.Size(430, 30);
      this.oldInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.oldInputLayout.Text = "Mật khẩu cũ";
      this.oldInputLayout.TextSize = new System.Drawing.Size(118, 15);
      // 
      // newInputLayout
      // 
      this.newInputLayout.Control = this.newInput;
      this.newInputLayout.Location = new System.Drawing.Point(0, 30);
      this.newInputLayout.Name = "newInputLayout";
      this.newInputLayout.Size = new System.Drawing.Size(430, 30);
      this.newInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.newInputLayout.Text = "Mật khẩu mới";
      this.newInputLayout.TextSize = new System.Drawing.Size(118, 15);
      // 
      // editButtonLayout
      // 
      this.editButtonLayout.Control = this.editButton;
      this.editButtonLayout.Location = new System.Drawing.Point(0, 90);
      this.editButtonLayout.Name = "editButtonLayout";
      this.editButtonLayout.Size = new System.Drawing.Size(430, 34);
      this.editButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.editButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.editButtonLayout.TextVisible = false;
      // 
      // reInputLayout
      // 
      this.reInputLayout.Control = this.reInput;
      this.reInputLayout.Location = new System.Drawing.Point(0, 60);
      this.reInputLayout.Name = "reInputLayout";
      this.reInputLayout.Size = new System.Drawing.Size(430, 30);
      this.reInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.reInputLayout.Text = "Nhập lại mật khẩu mới";
      this.reInputLayout.TextSize = new System.Drawing.Size(118, 15);
      // 
      // PasswordForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 144);
      this.Controls.Add(this.layout);
      this.Name = "PasswordForm";
      this.Text = "Mật khẩu";
      this.Load += new System.EventHandler(this.PasswordForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.oldInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.reInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.newInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.oldInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.newInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.reInputLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.SimpleButton editButton;
    private DevExpress.XtraEditors.TextEdit oldInput;
    private DevExpress.XtraEditors.TextEdit reInput;
    private DevExpress.XtraEditors.TextEdit newInput;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem oldInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem newInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem editButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem reInputLayout;
  }
}