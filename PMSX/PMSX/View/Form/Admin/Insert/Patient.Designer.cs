namespace PMSX.View.Form.Admin.Insert {
    partial class Patient {
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
      this.insertButton = new DevExpress.XtraEditors.SimpleButton();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.yearSelect = new DevExpress.XtraEditors.DateEdit();
      this.yearsOldInput = new DevExpress.XtraEditors.TextEdit();
      this.addressInput = new DevExpress.XtraEditors.MemoEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.nameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.insertButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.requiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.notRequiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.yearSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.yearsOldInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.addressInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelect.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInputLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.nameInput);
      this.layoutControl.Controls.Add(this.insertButton);
      this.layoutControl.Controls.Add(this.commentInput);
      this.layoutControl.Controls.Add(this.yearSelect);
      this.layoutControl.Controls.Add(this.yearsOldInput);
      this.layoutControl.Controls.Add(this.addressInput);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(997, 232, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(500, 612);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl";
      // 
      // nameInput
      // 
      this.nameInput.Location = new System.Drawing.Point(12, 71);
      this.nameInput.Name = "nameInput";
      this.nameInput.Properties.MaxLength = 100;
      this.nameInput.Size = new System.Drawing.Size(476, 28);
      this.nameInput.StyleController = this.layoutControl;
      this.nameInput.TabIndex = 5;
      // 
      // insertButton
      // 
      this.insertButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.insertButton.Appearance.Options.UseBackColor = true;
      this.insertButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.insertButton.Location = new System.Drawing.Point(12, 564);
      this.insertButton.Name = "insertButton";
      this.insertButton.Padding = new System.Windows.Forms.Padding(5);
      this.insertButton.Size = new System.Drawing.Size(476, 36);
      this.insertButton.StyleController = this.layoutControl;
      this.insertButton.TabIndex = 6;
      this.insertButton.Text = "Thêm";
      this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(12, 387);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 500;
      this.commentInput.Size = new System.Drawing.Size(476, 163);
      this.commentInput.StyleController = this.layoutControl;
      this.commentInput.TabIndex = 7;
      // 
      // yearSelect
      // 
      this.yearSelect.EditValue = null;
      this.yearSelect.Location = new System.Drawing.Point(12, 127);
      this.yearSelect.Name = "yearSelect";
      this.yearSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.yearSelect.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.yearSelect.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
      this.yearSelect.Properties.DisplayFormat.FormatString = "";
      this.yearSelect.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.yearSelect.Properties.EditFormat.FormatString = "";
      this.yearSelect.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.yearSelect.Properties.Mask.EditMask = "yyyy";
      this.yearSelect.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.yearSelect.Properties.MaxLength = 100;
      this.yearSelect.Properties.MaxValue = new System.DateTime(2020, 7, 14, 0, 0, 0, 0);
      this.yearSelect.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
      this.yearSelect.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
      this.yearSelect.Size = new System.Drawing.Size(236, 28);
      this.yearSelect.StyleController = this.layoutControl;
      this.yearSelect.TabIndex = 5;
      this.yearSelect.EditValueChanged += new System.EventHandler(this.YearSelect_EditValueChanged);
      // 
      // yearsOldInput
      // 
      this.yearsOldInput.Location = new System.Drawing.Point(252, 127);
      this.yearsOldInput.Name = "yearsOldInput";
      this.yearsOldInput.Properties.Mask.EditMask = "\\d+";
      this.yearsOldInput.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
      this.yearsOldInput.Properties.MaxLength = 3;
      this.yearsOldInput.Size = new System.Drawing.Size(236, 28);
      this.yearsOldInput.StyleController = this.layoutControl;
      this.yearsOldInput.TabIndex = 5;
      this.yearsOldInput.EditValueChanged += new System.EventHandler(this.YearsOldInput_EditValueChanged);
      // 
      // addressInput
      // 
      this.addressInput.Location = new System.Drawing.Point(12, 183);
      this.addressInput.Name = "addressInput";
      this.addressInput.Properties.MaxLength = 500;
      this.addressInput.Size = new System.Drawing.Size(476, 131);
      this.addressInput.StyleController = this.layoutControl;
      this.addressInput.TabIndex = 7;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.nameInputLayout,
            this.insertButtonLayout,
            this.requiredLabel,
            this.notRequiredLabel,
            this.commentInputLayout,
            this.yearSelectLayout,
            this.yearsOldInputLayout,
            this.addressInputLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(500, 612);
      this.Root.TextVisible = false;
      // 
      // nameInputLayout
      // 
      this.nameInputLayout.Control = this.nameInput;
      this.nameInputLayout.Location = new System.Drawing.Point(0, 35);
      this.nameInputLayout.Name = "nameInputLayout";
      this.nameInputLayout.Size = new System.Drawing.Size(480, 56);
      this.nameInputLayout.Text = "Tên";
      this.nameInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.nameInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // insertButtonLayout
      // 
      this.insertButtonLayout.Control = this.insertButton;
      this.insertButtonLayout.Location = new System.Drawing.Point(0, 542);
      this.insertButtonLayout.Name = "insertButtonLayout";
      this.insertButtonLayout.Size = new System.Drawing.Size(480, 50);
      this.insertButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.insertButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.insertButtonLayout.TextVisible = false;
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
      this.notRequiredLabel.Location = new System.Drawing.Point(0, 306);
      this.notRequiredLabel.Name = "notRequiredLabel";
      this.notRequiredLabel.Size = new System.Drawing.Size(480, 45);
      this.notRequiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
      this.notRequiredLabel.Text = "Thông tin không bắt buộc";
      this.notRequiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 351);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(480, 191);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.commentInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // yearSelectLayout
      // 
      this.yearSelectLayout.Control = this.yearSelect;
      this.yearSelectLayout.CustomizationFormText = "Tên";
      this.yearSelectLayout.Location = new System.Drawing.Point(0, 91);
      this.yearSelectLayout.Name = "yearSelectLayout";
      this.yearSelectLayout.Size = new System.Drawing.Size(240, 56);
      this.yearSelectLayout.Text = "Năm sinh";
      this.yearSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.yearSelectLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // yearsOldInputLayout
      // 
      this.yearsOldInputLayout.Control = this.yearsOldInput;
      this.yearsOldInputLayout.CustomizationFormText = "Tên";
      this.yearsOldInputLayout.Location = new System.Drawing.Point(240, 91);
      this.yearsOldInputLayout.Name = "yearsOldInputLayout";
      this.yearsOldInputLayout.Size = new System.Drawing.Size(240, 56);
      this.yearsOldInputLayout.Text = "Tuổi";
      this.yearsOldInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.yearsOldInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // addressInputLayout
      // 
      this.addressInputLayout.Control = this.addressInput;
      this.addressInputLayout.CustomizationFormText = "Ghi chú";
      this.addressInputLayout.Location = new System.Drawing.Point(0, 147);
      this.addressInputLayout.Name = "addressInputLayout";
      this.addressInputLayout.Size = new System.Drawing.Size(480, 159);
      this.addressInputLayout.Text = "Địa chỉ";
      this.addressInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.addressInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // Patient
      // 
      this.AcceptButton = this.insertButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(500, 612);
      this.Controls.Add(this.layoutControl);
      this.MaximizeBox = false;
      this.Name = "Patient";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Thêm bệnh nhân";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelect.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInputLayout)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.TextEdit nameInput;
        private DevExpress.XtraEditors.SimpleButton insertButton;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem nameInputLayout;
        private DevExpress.XtraLayout.LayoutControlItem insertButtonLayout;
        private DevExpress.XtraEditors.MemoEdit commentInput;
        private DevExpress.XtraLayout.SimpleLabelItem requiredLabel;
        private DevExpress.XtraLayout.SimpleLabelItem notRequiredLabel;
        private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem yearSelectLayout;
    private DevExpress.XtraEditors.DateEdit yearSelect;
    private DevExpress.XtraEditors.TextEdit yearsOldInput;
    private DevExpress.XtraLayout.LayoutControlItem yearsOldInputLayout;
    private DevExpress.XtraEditors.MemoEdit addressInput;
    private DevExpress.XtraLayout.LayoutControlItem addressInputLayout;
  }
}