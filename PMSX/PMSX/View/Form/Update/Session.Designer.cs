namespace PMSX.View.Form.Update {
  partial class Session {
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
      this.technicianSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.doctorSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.nameSelect = new DevExpress.XtraEditors.DateEdit();
      this.updateButton = new DevExpress.XtraEditors.SimpleButton();
      this.stateRadio = new DevExpress.XtraEditors.RadioGroup();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.technicianSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.requiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.notRequiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.doctorSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.nameSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.updateButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.stateRadioLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.technicianSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameSelect.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.technicianSelect);
      this.layoutControl.Controls.Add(this.commentInput);
      this.layoutControl.Controls.Add(this.doctorSelect);
      this.layoutControl.Controls.Add(this.nameSelect);
      this.layoutControl.Controls.Add(this.updateButton);
      this.layoutControl.Controls.Add(this.stateRadio);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(997, 232, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(500, 564);
      this.layoutControl.TabIndex = 2;
      this.layoutControl.Text = "layoutControl";
      // 
      // technicianSelect
      // 
      this.technicianSelect.Location = new System.Drawing.Point(12, 127);
      this.technicianSelect.Name = "technicianSelect";
      this.technicianSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.technicianSelect.Properties.NullText = "";
      this.technicianSelect.Size = new System.Drawing.Size(476, 28);
      this.technicianSelect.StyleController = this.layoutControl;
      this.technicianSelect.TabIndex = 4;
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(12, 343);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 500;
      this.commentInput.Size = new System.Drawing.Size(476, 159);
      this.commentInput.StyleController = this.layoutControl;
      this.commentInput.TabIndex = 7;
      // 
      // doctorSelect
      // 
      this.doctorSelect.Location = new System.Drawing.Point(12, 183);
      this.doctorSelect.Name = "doctorSelect";
      this.doctorSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.doctorSelect.Properties.NullText = "";
      this.doctorSelect.Size = new System.Drawing.Size(476, 28);
      this.doctorSelect.StyleController = this.layoutControl;
      this.doctorSelect.TabIndex = 4;
      // 
      // nameSelect
      // 
      this.nameSelect.EditValue = null;
      this.nameSelect.Location = new System.Drawing.Point(12, 71);
      this.nameSelect.Name = "nameSelect";
      this.nameSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.nameSelect.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.nameSelect.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
      this.nameSelect.Properties.DisplayFormat.FormatString = "";
      this.nameSelect.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.nameSelect.Properties.EditFormat.FormatString = "";
      this.nameSelect.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.nameSelect.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.nameSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.nameSelect.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
      this.nameSelect.Size = new System.Drawing.Size(476, 28);
      this.nameSelect.StyleController = this.layoutControl;
      this.nameSelect.TabIndex = 4;
      // 
      // updateButton
      // 
      this.updateButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.updateButton.Appearance.Options.UseBackColor = true;
      this.updateButton.Location = new System.Drawing.Point(12, 516);
      this.updateButton.Name = "updateButton";
      this.updateButton.Padding = new System.Windows.Forms.Padding(5);
      this.updateButton.Size = new System.Drawing.Size(476, 36);
      this.updateButton.StyleController = this.layoutControl;
      this.updateButton.TabIndex = 8;
      this.updateButton.Text = "Sửa";
      this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
      // 
      // stateRadio
      // 
      this.stateRadio.Location = new System.Drawing.Point(12, 239);
      this.stateRadio.Name = "stateRadio";
      this.stateRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.stateRadio.Properties.Appearance.Options.UseBackColor = true;
      this.stateRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.stateRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Kích hoạt"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Vô hiệu hoá")});
      this.stateRadio.Size = new System.Drawing.Size(476, 29);
      this.stateRadio.StyleController = this.layoutControl;
      this.stateRadio.TabIndex = 8;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.technicianSelectLayout,
            this.requiredLabel,
            this.notRequiredLabel,
            this.commentInputLayout,
            this.doctorSelectLayout,
            this.nameSelectLayout,
            this.updateButtonLayout,
            this.stateRadioLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(500, 564);
      this.Root.TextVisible = false;
      // 
      // technicianSelectLayout
      // 
      this.technicianSelectLayout.Control = this.technicianSelect;
      this.technicianSelectLayout.Location = new System.Drawing.Point(0, 91);
      this.technicianSelectLayout.Name = "technicianSelectLayout";
      this.technicianSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.technicianSelectLayout.Text = "Kỹ thuật viên";
      this.technicianSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.technicianSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // requiredLabel
      // 
      this.requiredLabel.AllowHotTrack = false;
      this.requiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
      this.requiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.requiredLabel.Location = new System.Drawing.Point(0, 0);
      this.requiredLabel.Name = "requiredLabel";
      this.requiredLabel.Size = new System.Drawing.Size(480, 35);
      this.requiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
      this.requiredLabel.Text = "Thông tin bắt buộc";
      this.requiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // notRequiredLabel
      // 
      this.notRequiredLabel.AllowHotTrack = false;
      this.notRequiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
      this.notRequiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.notRequiredLabel.CustomizationFormText = "Thông tin không bắt buộc";
      this.notRequiredLabel.Location = new System.Drawing.Point(0, 260);
      this.notRequiredLabel.Name = "notRequiredLabel";
      this.notRequiredLabel.Size = new System.Drawing.Size(480, 47);
      this.notRequiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 11, 11);
      this.notRequiredLabel.Text = "Thông tin không bắt buộc";
      this.notRequiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.CustomizationFormText = "Ghi chú";
      this.commentInputLayout.Location = new System.Drawing.Point(0, 307);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(480, 187);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.commentInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // doctorSelectLayout
      // 
      this.doctorSelectLayout.Control = this.doctorSelect;
      this.doctorSelectLayout.CustomizationFormText = "Nhân viên";
      this.doctorSelectLayout.Location = new System.Drawing.Point(0, 147);
      this.doctorSelectLayout.Name = "doctorSelectLayout";
      this.doctorSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.doctorSelectLayout.Text = "Bác sĩ";
      this.doctorSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.doctorSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // nameSelectLayout
      // 
      this.nameSelectLayout.Control = this.nameSelect;
      this.nameSelectLayout.CustomizationFormText = "Kỹ thuật viên";
      this.nameSelectLayout.Location = new System.Drawing.Point(0, 35);
      this.nameSelectLayout.Name = "nameSelectLayout";
      this.nameSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.nameSelectLayout.Text = "Tên";
      this.nameSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.nameSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // updateButtonLayout
      // 
      this.updateButtonLayout.Control = this.updateButton;
      this.updateButtonLayout.Location = new System.Drawing.Point(0, 494);
      this.updateButtonLayout.Name = "updateButtonLayout";
      this.updateButtonLayout.Size = new System.Drawing.Size(480, 50);
      this.updateButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.updateButtonLayout.Text = "Thêm";
      this.updateButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.updateButtonLayout.TextVisible = false;
      // 
      // stateRadioLayout
      // 
      this.stateRadioLayout.Control = this.stateRadio;
      this.stateRadioLayout.CustomizationFormText = "Trạng thái";
      this.stateRadioLayout.Location = new System.Drawing.Point(0, 203);
      this.stateRadioLayout.MaxSize = new System.Drawing.Size(480, 57);
      this.stateRadioLayout.MinSize = new System.Drawing.Size(480, 57);
      this.stateRadioLayout.Name = "stateRadioLayout";
      this.stateRadioLayout.Size = new System.Drawing.Size(480, 57);
      this.stateRadioLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.stateRadioLayout.Text = "Trạng thái";
      this.stateRadioLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.stateRadioLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // Session
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(500, 564);
      this.Controls.Add(this.layoutControl);
      this.MaximizeBox = false;
      this.Name = "Session";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Thêm quyền";
      this.Load += new System.EventHandler(this.Session_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.technicianSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameSelect.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraEditors.LookUpEdit technicianSelect;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraEditors.LookUpEdit doctorSelect;
    private DevExpress.XtraEditors.DateEdit nameSelect;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem technicianSelectLayout;
    private DevExpress.XtraLayout.SimpleLabelItem requiredLabel;
    private DevExpress.XtraLayout.SimpleLabelItem notRequiredLabel;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem doctorSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem nameSelectLayout;
    private DevExpress.XtraEditors.SimpleButton updateButton;
    private DevExpress.XtraLayout.LayoutControlItem updateButtonLayout;
    private DevExpress.XtraEditors.RadioGroup stateRadio;
    private DevExpress.XtraLayout.LayoutControlItem stateRadioLayout;
  }
}