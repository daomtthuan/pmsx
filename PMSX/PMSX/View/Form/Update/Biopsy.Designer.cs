namespace PMSX.View.Form.Update {
    partial class Biopsy {
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
      this.segmentInput = new DevExpress.XtraEditors.TextEdit();
      this.updateButton = new DevExpress.XtraEditors.SimpleButton();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.patientSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.sessionSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.grossDoctorSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.grossDatetimeSelect = new DevExpress.XtraEditors.DateEdit();
      this.collectDatetimeSelect = new DevExpress.XtraEditors.DateEdit();
      this.stateRadio = new DevExpress.XtraEditors.RadioGroup();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.patientSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.segmentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.updateButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.sampleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.notRequiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.grossDoctorSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.grossDatetimeSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.collectDatetimeSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.requiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.sessionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.stateRadioLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.segmentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.patientSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDoctorSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDatetimeSelect.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDatetimeSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.collectDatetimeSelect.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.collectDatetimeSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.patientSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.segmentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sampleLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDoctorSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDatetimeSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.collectDatetimeSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.segmentInput);
      this.layoutControl.Controls.Add(this.updateButton);
      this.layoutControl.Controls.Add(this.commentInput);
      this.layoutControl.Controls.Add(this.patientSelect);
      this.layoutControl.Controls.Add(this.sessionSelect);
      this.layoutControl.Controls.Add(this.grossDoctorSelect);
      this.layoutControl.Controls.Add(this.grossDatetimeSelect);
      this.layoutControl.Controls.Add(this.collectDatetimeSelect);
      this.layoutControl.Controls.Add(this.stateRadio);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(997, 232, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(500, 720);
      this.layoutControl.TabIndex = 2;
      this.layoutControl.Text = "layoutControl";
      // 
      // segmentInput
      // 
      this.segmentInput.EditValue = "1";
      this.segmentInput.Location = new System.Drawing.Point(12, 284);
      this.segmentInput.Name = "segmentInput";
      this.segmentInput.Properties.Mask.EditMask = "\\d+";
      this.segmentInput.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
      this.segmentInput.Properties.MaxLength = 100;
      this.segmentInput.Size = new System.Drawing.Size(476, 28);
      this.segmentInput.StyleController = this.layoutControl;
      this.segmentInput.TabIndex = 5;
      // 
      // updateButton
      // 
      this.updateButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.updateButton.Appearance.Options.UseBackColor = true;
      this.updateButton.Location = new System.Drawing.Point(12, 672);
      this.updateButton.Name = "updateButton";
      this.updateButton.Padding = new System.Windows.Forms.Padding(5);
      this.updateButton.Size = new System.Drawing.Size(476, 36);
      this.updateButton.StyleController = this.layoutControl;
      this.updateButton.TabIndex = 6;
      this.updateButton.Text = "Sửa";
      this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(12, 554);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 500;
      this.commentInput.Size = new System.Drawing.Size(476, 104);
      this.commentInput.StyleController = this.layoutControl;
      this.commentInput.TabIndex = 7;
      // 
      // patientSelect
      // 
      this.patientSelect.Location = new System.Drawing.Point(12, 172);
      this.patientSelect.Name = "patientSelect";
      this.patientSelect.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
      this.patientSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.patientSelect.Properties.DropDownRows = 10;
      this.patientSelect.Properties.MaxLength = 100;
      this.patientSelect.Properties.NullText = "";
      this.patientSelect.Size = new System.Drawing.Size(476, 28);
      this.patientSelect.StyleController = this.layoutControl;
      this.patientSelect.TabIndex = 4;
      this.patientSelect.EditValueChanged += new System.EventHandler(this.PatientSelect_EditValueChanged);
      // 
      // sessionSelect
      // 
      this.sessionSelect.Location = new System.Drawing.Point(12, 71);
      this.sessionSelect.Name = "sessionSelect";
      this.sessionSelect.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
      this.sessionSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.sessionSelect.Properties.DropDownRows = 10;
      this.sessionSelect.Properties.MaxLength = 100;
      this.sessionSelect.Properties.NullText = "";
      this.sessionSelect.Size = new System.Drawing.Size(476, 28);
      this.sessionSelect.StyleController = this.layoutControl;
      this.sessionSelect.TabIndex = 4;
      this.sessionSelect.EditValueChanged += new System.EventHandler(this.SessionSelect_EditValueChanged);
      // 
      // grossDoctorSelect
      // 
      this.grossDoctorSelect.Location = new System.Drawing.Point(12, 228);
      this.grossDoctorSelect.Name = "grossDoctorSelect";
      this.grossDoctorSelect.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
      this.grossDoctorSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.grossDoctorSelect.Properties.DropDownRows = 10;
      this.grossDoctorSelect.Properties.MaxLength = 100;
      this.grossDoctorSelect.Properties.NullText = "";
      this.grossDoctorSelect.Size = new System.Drawing.Size(476, 28);
      this.grossDoctorSelect.StyleController = this.layoutControl;
      this.grossDoctorSelect.TabIndex = 4;
      // 
      // grossDatetimeSelect
      // 
      this.grossDatetimeSelect.EditValue = null;
      this.grossDatetimeSelect.Location = new System.Drawing.Point(12, 340);
      this.grossDatetimeSelect.Name = "grossDatetimeSelect";
      this.grossDatetimeSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.grossDatetimeSelect.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.grossDatetimeSelect.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
      this.grossDatetimeSelect.Properties.DisplayFormat.FormatString = "";
      this.grossDatetimeSelect.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.grossDatetimeSelect.Properties.EditFormat.FormatString = "";
      this.grossDatetimeSelect.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.grossDatetimeSelect.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.grossDatetimeSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.grossDatetimeSelect.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
      this.grossDatetimeSelect.Size = new System.Drawing.Size(476, 28);
      this.grossDatetimeSelect.StyleController = this.layoutControl;
      this.grossDatetimeSelect.TabIndex = 4;
      this.grossDatetimeSelect.EditValueChanged += new System.EventHandler(this.GrossDatetimeSelect_EditValueChanged);
      // 
      // collectDatetimeSelect
      // 
      this.collectDatetimeSelect.EditValue = null;
      this.collectDatetimeSelect.Location = new System.Drawing.Point(12, 396);
      this.collectDatetimeSelect.Name = "collectDatetimeSelect";
      this.collectDatetimeSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.collectDatetimeSelect.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.collectDatetimeSelect.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
      this.collectDatetimeSelect.Properties.DisplayFormat.FormatString = "";
      this.collectDatetimeSelect.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.collectDatetimeSelect.Properties.EditFormat.FormatString = "";
      this.collectDatetimeSelect.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.collectDatetimeSelect.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.collectDatetimeSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.collectDatetimeSelect.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
      this.collectDatetimeSelect.Size = new System.Drawing.Size(476, 28);
      this.collectDatetimeSelect.StyleController = this.layoutControl;
      this.collectDatetimeSelect.TabIndex = 4;
      // 
      // stateRadio
      // 
      this.stateRadio.Location = new System.Drawing.Point(12, 452);
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
            this.patientSelectLayout,
            this.segmentInputLayout,
            this.updateButtonLayout,
            this.sampleLabel,
            this.notRequiredLabel,
            this.commentInputLayout,
            this.grossDoctorSelectLayout,
            this.grossDatetimeSelectLayout,
            this.collectDatetimeSelectLayout,
            this.requiredLabel,
            this.sessionSelectLayout,
            this.stateRadioLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(500, 720);
      this.Root.TextVisible = false;
      // 
      // patientSelectLayout
      // 
      this.patientSelectLayout.Control = this.patientSelect;
      this.patientSelectLayout.Location = new System.Drawing.Point(0, 136);
      this.patientSelectLayout.Name = "patientSelectLayout";
      this.patientSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.patientSelectLayout.Text = "Bệnh nhân";
      this.patientSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.patientSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // segmentInputLayout
      // 
      this.segmentInputLayout.Control = this.segmentInput;
      this.segmentInputLayout.Location = new System.Drawing.Point(0, 248);
      this.segmentInputLayout.Name = "segmentInputLayout";
      this.segmentInputLayout.Size = new System.Drawing.Size(480, 56);
      this.segmentInputLayout.Text = "Số mảnh";
      this.segmentInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.segmentInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // updateButtonLayout
      // 
      this.updateButtonLayout.Control = this.updateButton;
      this.updateButtonLayout.Location = new System.Drawing.Point(0, 650);
      this.updateButtonLayout.Name = "updateButtonLayout";
      this.updateButtonLayout.Size = new System.Drawing.Size(480, 50);
      this.updateButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.updateButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.updateButtonLayout.TextVisible = false;
      // 
      // sampleLabel
      // 
      this.sampleLabel.AllowHotTrack = false;
      this.sampleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
      this.sampleLabel.AppearanceItemCaption.Options.UseFont = true;
      this.sampleLabel.Location = new System.Drawing.Point(0, 0);
      this.sampleLabel.Name = "sampleLabel";
      this.sampleLabel.Size = new System.Drawing.Size(480, 35);
      this.sampleLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
      this.sampleLabel.Text = "Thông tin mẫu";
      this.sampleLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // notRequiredLabel
      // 
      this.notRequiredLabel.AllowHotTrack = false;
      this.notRequiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
      this.notRequiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.notRequiredLabel.Location = new System.Drawing.Point(0, 473);
      this.notRequiredLabel.Name = "notRequiredLabel";
      this.notRequiredLabel.Size = new System.Drawing.Size(480, 45);
      this.notRequiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
      this.notRequiredLabel.Text = "Thông tin không bắt buộc";
      this.notRequiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 518);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(480, 132);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.commentInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // grossDoctorSelectLayout
      // 
      this.grossDoctorSelectLayout.Control = this.grossDoctorSelect;
      this.grossDoctorSelectLayout.CustomizationFormText = "Bệnh nhân";
      this.grossDoctorSelectLayout.Location = new System.Drawing.Point(0, 192);
      this.grossDoctorSelectLayout.Name = "grossDoctorSelectLayout";
      this.grossDoctorSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.grossDoctorSelectLayout.Text = "Bác sĩ gọt";
      this.grossDoctorSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.grossDoctorSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // grossDatetimeSelectLayout
      // 
      this.grossDatetimeSelectLayout.Control = this.grossDatetimeSelect;
      this.grossDatetimeSelectLayout.CustomizationFormText = "Kỹ thuật viên";
      this.grossDatetimeSelectLayout.Location = new System.Drawing.Point(0, 304);
      this.grossDatetimeSelectLayout.Name = "grossDatetimeSelectLayout";
      this.grossDatetimeSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.grossDatetimeSelectLayout.Text = "Ngày gọt";
      this.grossDatetimeSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.grossDatetimeSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // collectDatetimeSelectLayout
      // 
      this.collectDatetimeSelectLayout.Control = this.collectDatetimeSelect;
      this.collectDatetimeSelectLayout.CustomizationFormText = "Kỹ thuật viên";
      this.collectDatetimeSelectLayout.Location = new System.Drawing.Point(0, 360);
      this.collectDatetimeSelectLayout.Name = "collectDatetimeSelectLayout";
      this.collectDatetimeSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.collectDatetimeSelectLayout.Text = "Ngày thu thập";
      this.collectDatetimeSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.collectDatetimeSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // requiredLabel
      // 
      this.requiredLabel.AllowHotTrack = false;
      this.requiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.requiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.requiredLabel.CustomizationFormText = "Thông tin không bắt buộc";
      this.requiredLabel.Location = new System.Drawing.Point(0, 91);
      this.requiredLabel.Name = "requiredLabel";
      this.requiredLabel.Size = new System.Drawing.Size(480, 45);
      this.requiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
      this.requiredLabel.Text = "Thông tin bắt buộc";
      this.requiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // sessionSelectLayout
      // 
      this.sessionSelectLayout.Control = this.sessionSelect;
      this.sessionSelectLayout.CustomizationFormText = "Bệnh nhân";
      this.sessionSelectLayout.Location = new System.Drawing.Point(0, 35);
      this.sessionSelectLayout.Name = "sessionSelectLayout";
      this.sessionSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.sessionSelectLayout.Text = "Phiên làm việc";
      this.sessionSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.sessionSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // stateRadioLayout
      // 
      this.stateRadioLayout.Control = this.stateRadio;
      this.stateRadioLayout.CustomizationFormText = "Trạng thái";
      this.stateRadioLayout.Location = new System.Drawing.Point(0, 416);
      this.stateRadioLayout.MaxSize = new System.Drawing.Size(480, 57);
      this.stateRadioLayout.MinSize = new System.Drawing.Size(480, 57);
      this.stateRadioLayout.Name = "stateRadioLayout";
      this.stateRadioLayout.Size = new System.Drawing.Size(480, 57);
      this.stateRadioLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.stateRadioLayout.Text = "Trạng thái";
      this.stateRadioLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.stateRadioLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // Biopsy
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(500, 720);
      this.Controls.Add(this.layoutControl);
      this.MaximizeBox = false;
      this.Name = "Biopsy";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Sửa mẫu sinh thiết";
      this.Load += new System.EventHandler(this.Biopsy_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.segmentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.patientSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDoctorSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDatetimeSelect.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDatetimeSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.collectDatetimeSelect.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.collectDatetimeSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.patientSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.segmentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sampleLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDoctorSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grossDatetimeSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.collectDatetimeSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).EndInit();
      this.ResumeLayout(false);

        }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraEditors.TextEdit segmentInput;
    private DevExpress.XtraEditors.SimpleButton updateButton;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraEditors.LookUpEdit patientSelect;
    private DevExpress.XtraEditors.LookUpEdit sessionSelect;
    private DevExpress.XtraEditors.LookUpEdit grossDoctorSelect;
    private DevExpress.XtraEditors.DateEdit grossDatetimeSelect;
    private DevExpress.XtraEditors.DateEdit collectDatetimeSelect;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem patientSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem segmentInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem updateButtonLayout;
    private DevExpress.XtraLayout.SimpleLabelItem sampleLabel;
    private DevExpress.XtraLayout.SimpleLabelItem notRequiredLabel;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem grossDoctorSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem grossDatetimeSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem collectDatetimeSelectLayout;
    private DevExpress.XtraLayout.SimpleLabelItem requiredLabel;
    private DevExpress.XtraLayout.LayoutControlItem sessionSelectLayout;
    private DevExpress.XtraEditors.RadioGroup stateRadio;
    private DevExpress.XtraLayout.LayoutControlItem stateRadioLayout;
  }
}