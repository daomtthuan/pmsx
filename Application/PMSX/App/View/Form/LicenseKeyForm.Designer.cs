namespace PMSX.App.View.Form {
  partial class LicenseKeyForm {
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
      this.activeButton = new DevExpress.XtraEditors.SimpleButton();
      this.keyInput = new DevExpress.XtraEditors.TextEdit();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.keyInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.activeButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.keyInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.keyInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.activeButtonLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.activeButton);
      this.layout.Controls.Add(this.keyInput);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 86);
      this.layout.TabIndex = 1;
      this.layout.Text = "layoutControl1";
      // 
      // activeButton
      // 
      this.activeButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.activeButton.Appearance.Options.UseBackColor = true;
      this.activeButton.Location = new System.Drawing.Point(14, 46);
      this.activeButton.Name = "activeButton";
      this.activeButton.Padding = new System.Windows.Forms.Padding(2);
      this.activeButton.Size = new System.Drawing.Size(422, 26);
      this.activeButton.StyleController = this.layout;
      this.activeButton.TabIndex = 8;
      this.activeButton.Text = "Thêm";
      this.activeButton.Click += new System.EventHandler(this.ActiveButton_Click);
      // 
      // keyInput
      // 
      this.keyInput.Location = new System.Drawing.Point(95, 14);
      this.keyInput.Name = "keyInput";
      this.keyInput.Properties.DisplayFormat.FormatString = "d";
      this.keyInput.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.keyInput.Properties.EditFormat.FormatString = "d";
      this.keyInput.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.keyInput.Properties.Mask.EditMask = "d";
      this.keyInput.Properties.MaxLength = 36;
      this.keyInput.Properties.Padding = new System.Windows.Forms.Padding(1);
      this.keyInput.Properties.PasswordChar = 'o';
      this.keyInput.Size = new System.Drawing.Size(341, 24);
      this.keyInput.StyleController = this.layout;
      this.keyInput.TabIndex = 4;
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.keyInputLayout,
            this.activeButtonLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(450, 86);
      this.root.TextVisible = false;
      // 
      // keyInputLayout
      // 
      this.keyInputLayout.Control = this.keyInput;
      this.keyInputLayout.Location = new System.Drawing.Point(0, 0);
      this.keyInputLayout.Name = "keyInputLayout";
      this.keyInputLayout.Size = new System.Drawing.Size(430, 32);
      this.keyInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.keyInputLayout.Text = "Khoá kích hoạt";
      this.keyInputLayout.TextSize = new System.Drawing.Size(78, 15);
      // 
      // activeButtonLayout
      // 
      this.activeButtonLayout.Control = this.activeButton;
      this.activeButtonLayout.Location = new System.Drawing.Point(0, 32);
      this.activeButtonLayout.Name = "activeButtonLayout";
      this.activeButtonLayout.Size = new System.Drawing.Size(430, 34);
      this.activeButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.activeButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.activeButtonLayout.TextVisible = false;
      // 
      // LicenseKeyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 86);
      this.Controls.Add(this.layout);
      this.Name = "LicenseKeyForm";
      this.Text = "Kích hoạt bản quyền";
      this.Load += new System.EventHandler(this.LicenseKeyForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.keyInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.keyInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.activeButtonLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.SimpleButton activeButton;
    private DevExpress.XtraEditors.TextEdit keyInput;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem keyInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem activeButtonLayout;
  }
}