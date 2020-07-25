namespace PMSX.View.Form.Admin.Update {
  partial class Macro {
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
      this.updateButton = new DevExpress.XtraEditors.SimpleButton();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.stateRadio = new DevExpress.XtraEditors.RadioGroup();
      this.descriptionInput = new DevExpress.XtraEditors.MemoEdit();
      this.codeInput = new DevExpress.XtraEditors.TextEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.updateButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.requiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.notRequiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.stateRadioLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.descriptionInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.codeInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInputLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.updateButton);
      this.layoutControl.Controls.Add(this.commentInput);
      this.layoutControl.Controls.Add(this.stateRadio);
      this.layoutControl.Controls.Add(this.descriptionInput);
      this.layoutControl.Controls.Add(this.codeInput);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(997, 232, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(500, 518);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl";
      // 
      // updateButton
      // 
      this.updateButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.updateButton.Appearance.Options.UseBackColor = true;
      this.updateButton.Location = new System.Drawing.Point(8, 472);
      this.updateButton.Name = "updateButton";
      this.updateButton.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.updateButton.Size = new System.Drawing.Size(484, 36);
      this.updateButton.StyleController = this.layoutControl;
      this.updateButton.TabIndex = 6;
      this.updateButton.Text = "Sửa";
      this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(8, 317);
      this.commentInput.Name = "commentInput";
      this.commentInput.Size = new System.Drawing.Size(484, 141);
      this.commentInput.StyleController = this.layoutControl;
      this.commentInput.TabIndex = 7;
      // 
      // stateRadio
      // 
      this.stateRadio.Location = new System.Drawing.Point(8, 215);
      this.stateRadio.Name = "stateRadio";
      this.stateRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.stateRadio.Properties.Appearance.Options.UseBackColor = true;
      this.stateRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.stateRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Kích hoạt"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Vô hiệu hoá")});
      this.stateRadio.Size = new System.Drawing.Size(478, 30);
      this.stateRadio.StyleController = this.layoutControl;
      this.stateRadio.TabIndex = 8;
      // 
      // descriptionInput
      // 
      this.descriptionInput.Location = new System.Drawing.Point(8, 123);
      this.descriptionInput.Name = "descriptionInput";
      this.descriptionInput.Size = new System.Drawing.Size(484, 65);
      this.descriptionInput.StyleController = this.layoutControl;
      this.descriptionInput.TabIndex = 7;
      // 
      // codeInput
      // 
      this.codeInput.Location = new System.Drawing.Point(8, 68);
      this.codeInput.Name = "codeInput";
      this.codeInput.Properties.MaxLength = 100;
      this.codeInput.Size = new System.Drawing.Size(484, 28);
      this.codeInput.StyleController = this.layoutControl;
      this.codeInput.TabIndex = 5;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.updateButtonLayout,
            this.requiredLabel,
            this.commentInputLayout,
            this.stateRadioLayout,
            this.descriptionInputLayout,
            this.codeInputLayout,
            this.notRequiredLabel});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(500, 518);
      this.Root.TextVisible = false;
      // 
      // updateButtonLayout
      // 
      this.updateButtonLayout.Control = this.updateButton;
      this.updateButtonLayout.Location = new System.Drawing.Point(0, 452);
      this.updateButtonLayout.Name = "updateButtonLayout";
      this.updateButtonLayout.Size = new System.Drawing.Size(486, 50);
      this.updateButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.updateButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.updateButtonLayout.TextVisible = false;
      // 
      // requiredLabel
      // 
      this.requiredLabel.AllowHotTrack = false;
      this.requiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
      this.requiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.requiredLabel.Location = new System.Drawing.Point(0, 0);
      this.requiredLabel.Name = "requiredLabel";
      this.requiredLabel.Size = new System.Drawing.Size(486, 35);
      this.requiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
      this.requiredLabel.Text = "Thông tin bắt buộc";
      this.requiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // notRequiredLabel
      // 
      this.notRequiredLabel.AllowHotTrack = false;
      this.notRequiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
      this.notRequiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.notRequiredLabel.Location = new System.Drawing.Point(0, 239);
      this.notRequiredLabel.Name = "notRequiredLabel";
      this.notRequiredLabel.Size = new System.Drawing.Size(486, 45);
      this.notRequiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
      this.notRequiredLabel.Text = "Thông tin không bắt buộc";
      this.notRequiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 284);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(486, 168);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.commentInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // stateRadioLayout
      // 
      this.stateRadioLayout.Control = this.stateRadio;
      this.stateRadioLayout.Location = new System.Drawing.Point(0, 182);
      this.stateRadioLayout.MaxSize = new System.Drawing.Size(480, 57);
      this.stateRadioLayout.MinSize = new System.Drawing.Size(480, 57);
      this.stateRadioLayout.Name = "stateRadioLayout";
      this.stateRadioLayout.Size = new System.Drawing.Size(486, 57);
      this.stateRadioLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.stateRadioLayout.Text = "Trạng thái";
      this.stateRadioLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.stateRadioLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // descriptionInputLayout
      // 
      this.descriptionInputLayout.Control = this.descriptionInput;
      this.descriptionInputLayout.CustomizationFormText = "Mô tả";
      this.descriptionInputLayout.Location = new System.Drawing.Point(0, 90);
      this.descriptionInputLayout.Name = "descriptionInputLayout";
      this.descriptionInputLayout.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.descriptionInputLayout.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
      this.descriptionInputLayout.Size = new System.Drawing.Size(486, 92);
      this.descriptionInputLayout.Text = "Mô tả";
      this.descriptionInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.descriptionInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // codeInputLayout
      // 
      this.codeInputLayout.Control = this.codeInput;
      this.codeInputLayout.CustomizationFormText = "Mã đại thể";
      this.codeInputLayout.Location = new System.Drawing.Point(0, 35);
      this.codeInputLayout.Name = "codeInputLayout";
      this.codeInputLayout.OptionsPrint.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.codeInputLayout.OptionsPrint.AppearanceItemCaption.Options.UseFont = true;
      this.codeInputLayout.Size = new System.Drawing.Size(486, 55);
      this.codeInputLayout.Text = "Mã đại thể";
      this.codeInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.codeInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // Macro
      // 
      this.AcceptButton = this.updateButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(500, 518);
      this.Controls.Add(this.layoutControl);
      this.MaximizeBox = false;
      this.Name = "Macro";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Sửa đại thể";
      this.Load += new System.EventHandler(this.Macro_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInputLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraEditors.SimpleButton updateButton;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem updateButtonLayout;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraLayout.SimpleLabelItem requiredLabel;
    private DevExpress.XtraLayout.SimpleLabelItem notRequiredLabel;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraEditors.RadioGroup stateRadio;
    private DevExpress.XtraLayout.LayoutControlItem stateRadioLayout;
    private DevExpress.XtraEditors.MemoEdit descriptionInput;
    private DevExpress.XtraLayout.LayoutControlItem descriptionInputLayout;
    private DevExpress.XtraEditors.TextEdit codeInput;
    private DevExpress.XtraLayout.LayoutControlItem codeInputLayout;
  }
}