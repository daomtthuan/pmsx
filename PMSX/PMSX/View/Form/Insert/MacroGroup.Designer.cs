namespace PMSX.View.Form.Insert {
  partial class MacroGroup {
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
      this.codeInput = new DevExpress.XtraEditors.TextEdit();
      this.insertButton = new DevExpress.XtraEditors.SimpleButton();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.nameInput = new DevExpress.XtraEditors.TextEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.codeInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.insertButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.requiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.nameInputLayout1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.notrequiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.codeInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.notrequiredLabel)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.codeInput);
      this.layoutControl.Controls.Add(this.insertButton);
      this.layoutControl.Controls.Add(this.commentInput);
      this.layoutControl.Controls.Add(this.nameInput);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Margin = new System.Windows.Forms.Padding(4);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(997, 232, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(667, 507);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl";
      // 
      // codeInput
      // 
      this.codeInput.Location = new System.Drawing.Point(12, 81);
      this.codeInput.Margin = new System.Windows.Forms.Padding(4);
      this.codeInput.Name = "codeInput";
      this.codeInput.Properties.MaxLength = 100;
      this.codeInput.Size = new System.Drawing.Size(643, 32);
      this.codeInput.StyleController = this.layoutControl;
      this.codeInput.TabIndex = 5;
      // 
      // insertButton
      // 
      this.insertButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.insertButton.Appearance.Options.UseBackColor = true;
      this.insertButton.Location = new System.Drawing.Point(12, 453);
      this.insertButton.Margin = new System.Windows.Forms.Padding(4);
      this.insertButton.Name = "insertButton";
      this.insertButton.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.insertButton.Size = new System.Drawing.Size(643, 42);
      this.insertButton.StyleController = this.layoutControl;
      this.insertButton.TabIndex = 6;
      this.insertButton.Text = "Thêm";
      this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(12, 252);
      this.commentInput.Margin = new System.Windows.Forms.Padding(4);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 500;
      this.commentInput.Size = new System.Drawing.Size(643, 185);
      this.commentInput.StyleController = this.layoutControl;
      this.commentInput.TabIndex = 7;
      // 
      // nameInput
      // 
      this.nameInput.Location = new System.Drawing.Point(14, 145);
      this.nameInput.Margin = new System.Windows.Forms.Padding(4);
      this.nameInput.Name = "nameInput";
      this.nameInput.Properties.MaxLength = 100;
      this.nameInput.Size = new System.Drawing.Size(639, 32);
      this.nameInput.StyleController = this.layoutControl;
      this.nameInput.TabIndex = 5;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.codeInputLayout,
            this.insertButtonLayout,
            this.requiredLabel,
            this.commentInputLayout,
            this.nameInputLayout1,
            this.notrequiredLabel});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(667, 507);
      this.Root.TextVisible = false;
      // 
      // codeInputLayout
      // 
      this.codeInputLayout.Control = this.codeInput;
      this.codeInputLayout.Location = new System.Drawing.Point(0, 41);
      this.codeInputLayout.Name = "codeInputLayout";
      this.codeInputLayout.Size = new System.Drawing.Size(647, 64);
      this.codeInputLayout.Text = "Mã nhóm đại thể";
      this.codeInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.codeInputLayout.TextSize = new System.Drawing.Size(245, 25);
      // 
      // insertButtonLayout
      // 
      this.insertButtonLayout.Control = this.insertButton;
      this.insertButtonLayout.Location = new System.Drawing.Point(0, 429);
      this.insertButtonLayout.Name = "insertButtonLayout";
      this.insertButtonLayout.Size = new System.Drawing.Size(647, 58);
      this.insertButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 0);
      this.insertButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.insertButtonLayout.TextVisible = false;
      // 
      // requiredLabel
      // 
      this.requiredLabel.AllowHotTrack = false;
      this.requiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
      this.requiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.requiredLabel.Location = new System.Drawing.Point(0, 0);
      this.requiredLabel.Name = "requiredLabel";
      this.requiredLabel.Size = new System.Drawing.Size(647, 41);
      this.requiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 12);
      this.requiredLabel.Text = "Thông tin bắt buộc";
      this.requiredLabel.TextSize = new System.Drawing.Size(221, 25);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 212);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(647, 217);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.commentInputLayout.TextSize = new System.Drawing.Size(245, 25);
      // 
      // nameInputLayout1
      // 
      this.nameInputLayout1.Control = this.nameInput;
      this.nameInputLayout1.CustomizationFormText = "Tên";
      this.nameInputLayout1.Location = new System.Drawing.Point(0, 105);
      this.nameInputLayout1.Name = "nameInputLayout1";
      this.nameInputLayout1.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.nameInputLayout1.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
      this.nameInputLayout1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 2, 2);
      this.nameInputLayout1.Size = new System.Drawing.Size(647, 64);
      this.nameInputLayout1.Text = "Tên";
      this.nameInputLayout1.TextLocation = DevExpress.Utils.Locations.Top;
      this.nameInputLayout1.TextSize = new System.Drawing.Size(245, 25);
      // 
      // notrequiredLabel
      // 
      this.notrequiredLabel.AllowHotTrack = false;
      this.notrequiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
      this.notrequiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.notrequiredLabel.CustomizationFormText = "Thông tin không bắt buộc";
      this.notrequiredLabel.Location = new System.Drawing.Point(0, 169);
      this.notrequiredLabel.Name = "notrequiredLabel";
      this.notrequiredLabel.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.notrequiredLabel.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
      this.notrequiredLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 2, 2);
      this.notrequiredLabel.Size = new System.Drawing.Size(647, 43);
      this.notrequiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 14);
      this.notrequiredLabel.Text = "Thông tin không bắt buộc";
      this.notrequiredLabel.TextSize = new System.Drawing.Size(245, 25);
      // 
      // MacroGroup
      // 
      this.AcceptButton = this.insertButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(667, 507);
      this.Controls.Add(this.layoutControl);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "MacroGroup";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Thêm nhóm đại thể";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.codeInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.notrequiredLabel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraEditors.TextEdit codeInput;
    private DevExpress.XtraEditors.SimpleButton insertButton;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem codeInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem insertButtonLayout;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraLayout.SimpleLabelItem requiredLabel;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraEditors.TextEdit nameInput;
    private DevExpress.XtraLayout.LayoutControlItem nameInputLayout1;
    private DevExpress.XtraLayout.SimpleLabelItem notrequiredLabel;
  }
}