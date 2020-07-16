namespace PMSX.View.Form.Update {
  partial class MicroGroup {
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
      this.nameInput = new DevExpress.XtraEditors.TextEdit();
      this.updateButton = new DevExpress.XtraEditors.SimpleButton();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.stateRadio = new DevExpress.XtraEditors.RadioGroup();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.nameInputLayout1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.updateButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.requiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.notRequiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.stateRadioLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.nameInput);
      this.layoutControl.Controls.Add(this.updateButton);
      this.layoutControl.Controls.Add(this.commentInput);
      this.layoutControl.Controls.Add(this.stateRadio);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Margin = new System.Windows.Forms.Padding(4);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(997, 232, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(667, 515);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl";
      // 
      // nameInput
      // 
      this.nameInput.Location = new System.Drawing.Point(12, 81);
      this.nameInput.Margin = new System.Windows.Forms.Padding(4);
      this.nameInput.Name = "nameInput";
      this.nameInput.Properties.MaxLength = 100;
      this.nameInput.Size = new System.Drawing.Size(643, 32);
      this.nameInput.StyleController = this.layoutControl;
      this.nameInput.TabIndex = 5;
      // 
      // updateButton
      // 
      this.updateButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.updateButton.Appearance.Options.UseBackColor = true;
      this.updateButton.Location = new System.Drawing.Point(12, 461);
      this.updateButton.Margin = new System.Windows.Forms.Padding(4);
      this.updateButton.Name = "updateButton";
      this.updateButton.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.updateButton.Size = new System.Drawing.Size(643, 42);
      this.updateButton.StyleController = this.layoutControl;
      this.updateButton.TabIndex = 6;
      this.updateButton.Text = "Sửa";
      this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(12, 266);
      this.commentInput.Margin = new System.Windows.Forms.Padding(4);
      this.commentInput.Name = "commentInput";
      this.commentInput.Size = new System.Drawing.Size(643, 179);
      this.commentInput.StyleController = this.layoutControl;
      this.commentInput.TabIndex = 7;
      // 
      // stateRadio
      // 
      this.stateRadio.Location = new System.Drawing.Point(12, 145);
      this.stateRadio.Margin = new System.Windows.Forms.Padding(4);
      this.stateRadio.Name = "stateRadio";
      this.stateRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.stateRadio.Properties.Appearance.Options.UseBackColor = true;
      this.stateRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.stateRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Kích hoạt"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Vô hiệu hoá")});
      this.stateRadio.Size = new System.Drawing.Size(636, 36);
      this.stateRadio.StyleController = this.layoutControl;
      this.stateRadio.TabIndex = 8;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.nameInputLayout1,
            this.updateButtonLayout,
            this.requiredLabel,
            this.notRequiredLabel,
            this.commentInputLayout,
            this.stateRadioLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(667, 515);
      this.Root.TextVisible = false;
      // 
      // nameInputLayout1
      // 
      this.nameInputLayout1.Control = this.nameInput;
      this.nameInputLayout1.Location = new System.Drawing.Point(0, 41);
      this.nameInputLayout1.Name = "nameInputLayout1";
      this.nameInputLayout1.Size = new System.Drawing.Size(647, 64);
      this.nameInputLayout1.Text = "Tên";
      this.nameInputLayout1.TextLocation = DevExpress.Utils.Locations.Top;
      this.nameInputLayout1.TextSize = new System.Drawing.Size(245, 25);
      // 
      // updateButtonLayout
      // 
      this.updateButtonLayout.Control = this.updateButton;
      this.updateButtonLayout.Location = new System.Drawing.Point(0, 437);
      this.updateButtonLayout.Name = "updateButtonLayout";
      this.updateButtonLayout.Size = new System.Drawing.Size(647, 58);
      this.updateButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 0);
      this.updateButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.updateButtonLayout.TextVisible = false;
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
      this.requiredLabel.TextSize = new System.Drawing.Size(245, 25);
      // 
      // notRequiredLabel
      // 
      this.notRequiredLabel.AllowHotTrack = false;
      this.notRequiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
      this.notRequiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.notRequiredLabel.Location = new System.Drawing.Point(0, 173);
      this.notRequiredLabel.Name = "notRequiredLabel";
      this.notRequiredLabel.Size = new System.Drawing.Size(647, 53);
      this.notRequiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 12);
      this.notRequiredLabel.Text = "Thông tin không bắt buộc";
      this.notRequiredLabel.TextSize = new System.Drawing.Size(245, 25);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 226);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(647, 211);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.commentInputLayout.TextSize = new System.Drawing.Size(245, 25);
      // 
      // stateRadioLayout
      // 
      this.stateRadioLayout.Control = this.stateRadio;
      this.stateRadioLayout.Location = new System.Drawing.Point(0, 105);
      this.stateRadioLayout.MaxSize = new System.Drawing.Size(640, 68);
      this.stateRadioLayout.MinSize = new System.Drawing.Size(640, 68);
      this.stateRadioLayout.Name = "stateRadioLayout";
      this.stateRadioLayout.Size = new System.Drawing.Size(647, 68);
      this.stateRadioLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.stateRadioLayout.Text = "Trạng thái";
      this.stateRadioLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.stateRadioLayout.TextSize = new System.Drawing.Size(245, 25);
      // 
      // MicroGroup
      // 
      this.AcceptButton = this.updateButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(667, 515);
      this.Controls.Add(this.layoutControl);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.Name = "MicroGroup";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Sửa nhóm vi thể";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraEditors.TextEdit nameInput;
    private DevExpress.XtraEditors.SimpleButton updateButton;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem nameInputLayout1;
    private DevExpress.XtraLayout.LayoutControlItem updateButtonLayout;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraLayout.SimpleLabelItem requiredLabel;
    private DevExpress.XtraLayout.SimpleLabelItem notRequiredLabel;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraEditors.RadioGroup stateRadio;
    private DevExpress.XtraLayout.LayoutControlItem stateRadioLayout;
  }
}