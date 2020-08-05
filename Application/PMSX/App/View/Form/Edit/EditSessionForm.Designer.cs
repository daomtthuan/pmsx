namespace PMSX.App.View.Form.Edit {
  partial class EditSessionForm {
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
      this.dateSelect = new DevExpress.XtraEditors.DateEdit();
      this.doctorPermissionSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.technicianPermissionSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.editButton = new DevExpress.XtraEditors.SimpleButton();
      this.stateRadio = new DevExpress.XtraEditors.RadioGroup();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.dateSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.doctorPermissionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.technicianPermissionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.separator = new DevExpress.XtraLayout.SimpleSeparator();
      this.editButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.stateRadioLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelect.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorPermissionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianPermissionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorPermissionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianPermissionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.dateSelect);
      this.layout.Controls.Add(this.doctorPermissionSelect);
      this.layout.Controls.Add(this.technicianPermissionSelect);
      this.layout.Controls.Add(this.commentInput);
      this.layout.Controls.Add(this.editButton);
      this.layout.Controls.Add(this.stateRadio);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 320);
      this.layout.TabIndex = 1;
      this.layout.Text = "layoutControl1";
      // 
      // dateSelect
      // 
      this.dateSelect.EditValue = null;
      this.dateSelect.Location = new System.Drawing.Point(86, 14);
      this.dateSelect.Name = "dateSelect";
      this.dateSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dateSelect.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dateSelect.Properties.Mask.UseMaskAsDisplayFormat = true;
      this.dateSelect.Size = new System.Drawing.Size(350, 22);
      this.dateSelect.StyleController = this.layout;
      this.dateSelect.TabIndex = 4;
      // 
      // doctorPermissionSelect
      // 
      this.doctorPermissionSelect.Location = new System.Drawing.Point(86, 44);
      this.doctorPermissionSelect.Name = "doctorPermissionSelect";
      this.doctorPermissionSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.doctorPermissionSelect.Properties.NullText = "";
      this.doctorPermissionSelect.Size = new System.Drawing.Size(350, 22);
      this.doctorPermissionSelect.StyleController = this.layout;
      this.doctorPermissionSelect.TabIndex = 5;
      // 
      // technicianPermissionSelect
      // 
      this.technicianPermissionSelect.Location = new System.Drawing.Point(86, 74);
      this.technicianPermissionSelect.Name = "technicianPermissionSelect";
      this.technicianPermissionSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.technicianPermissionSelect.Properties.NullText = "";
      this.technicianPermissionSelect.Size = new System.Drawing.Size(350, 22);
      this.technicianPermissionSelect.StyleController = this.layout;
      this.technicianPermissionSelect.TabIndex = 6;
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(86, 140);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 1000;
      this.commentInput.Size = new System.Drawing.Size(350, 132);
      this.commentInput.StyleController = this.layout;
      this.commentInput.TabIndex = 7;
      // 
      // editButton
      // 
      this.editButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.editButton.Appearance.Options.UseBackColor = true;
      this.editButton.Location = new System.Drawing.Point(14, 280);
      this.editButton.Name = "editButton";
      this.editButton.Padding = new System.Windows.Forms.Padding(2);
      this.editButton.Size = new System.Drawing.Size(422, 26);
      this.editButton.StyleController = this.layout;
      this.editButton.TabIndex = 8;
      this.editButton.Text = "Chỉnh sửa";
      this.editButton.Click += new System.EventHandler(this.EditButton_Click);
      // 
      // stateRadio
      // 
      this.stateRadio.Location = new System.Drawing.Point(86, 104);
      this.stateRadio.Name = "stateRadio";
      this.stateRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.stateRadio.Properties.Appearance.Options.UseBackColor = true;
      this.stateRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.stateRadio.Properties.Columns = 2;
      this.stateRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Kích hoạt", true, null, "enabled"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Vô hiệu hoá", true, null, "disabled")});
      this.stateRadio.Size = new System.Drawing.Size(350, 23);
      this.stateRadio.StyleController = this.layout;
      this.stateRadio.TabIndex = 9;
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.dateSelectLayout,
            this.doctorPermissionSelectLayout,
            this.technicianPermissionSelectLayout,
            this.commentInputLayout,
            this.separator,
            this.editButtonLayout,
            this.stateRadioLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(450, 320);
      this.root.TextVisible = false;
      // 
      // dateSelectLayout
      // 
      this.dateSelectLayout.Control = this.dateSelect;
      this.dateSelectLayout.Location = new System.Drawing.Point(0, 0);
      this.dateSelectLayout.Name = "dateSelectLayout";
      this.dateSelectLayout.Size = new System.Drawing.Size(430, 30);
      this.dateSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.dateSelectLayout.Text = "Ngày";
      this.dateSelectLayout.TextSize = new System.Drawing.Size(69, 15);
      // 
      // doctorPermissionSelectLayout
      // 
      this.doctorPermissionSelectLayout.Control = this.doctorPermissionSelect;
      this.doctorPermissionSelectLayout.Location = new System.Drawing.Point(0, 30);
      this.doctorPermissionSelectLayout.Name = "doctorPermissionSelectLayout";
      this.doctorPermissionSelectLayout.Size = new System.Drawing.Size(430, 30);
      this.doctorPermissionSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.doctorPermissionSelectLayout.Text = "Bác sĩ";
      this.doctorPermissionSelectLayout.TextSize = new System.Drawing.Size(69, 15);
      // 
      // technicianPermissionSelectLayout
      // 
      this.technicianPermissionSelectLayout.Control = this.technicianPermissionSelect;
      this.technicianPermissionSelectLayout.Location = new System.Drawing.Point(0, 60);
      this.technicianPermissionSelectLayout.Name = "technicianPermissionSelectLayout";
      this.technicianPermissionSelectLayout.Size = new System.Drawing.Size(430, 30);
      this.technicianPermissionSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.technicianPermissionSelectLayout.Text = "Kỹ thuật viên";
      this.technicianPermissionSelectLayout.TextSize = new System.Drawing.Size(69, 15);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.AppearanceItemCaption.Options.UseTextOptions = true;
      this.commentInputLayout.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 126);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(430, 140);
      this.commentInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextSize = new System.Drawing.Size(69, 15);
      // 
      // separator
      // 
      this.separator.AllowHotTrack = false;
      this.separator.Location = new System.Drawing.Point(0, 121);
      this.separator.Name = "separator";
      this.separator.Size = new System.Drawing.Size(430, 5);
      this.separator.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      // 
      // editButtonLayout
      // 
      this.editButtonLayout.Control = this.editButton;
      this.editButtonLayout.Location = new System.Drawing.Point(0, 266);
      this.editButtonLayout.Name = "editButtonLayout";
      this.editButtonLayout.Size = new System.Drawing.Size(430, 34);
      this.editButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.editButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.editButtonLayout.TextVisible = false;
      // 
      // stateRadioLayout
      // 
      this.stateRadioLayout.Control = this.stateRadio;
      this.stateRadioLayout.Location = new System.Drawing.Point(0, 90);
      this.stateRadioLayout.MaxSize = new System.Drawing.Size(0, 31);
      this.stateRadioLayout.MinSize = new System.Drawing.Size(125, 31);
      this.stateRadioLayout.Name = "stateRadioLayout";
      this.stateRadioLayout.Size = new System.Drawing.Size(430, 31);
      this.stateRadioLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.stateRadioLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.stateRadioLayout.Text = "Trạng thái";
      this.stateRadioLayout.TextSize = new System.Drawing.Size(69, 15);
      // 
      // EditSessionForm
      // 
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 320);
      this.Controls.Add(this.layout);
      this.Font = new System.Drawing.Font("Kodchasan SemiBold", 8.249999F);
      this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.Name = "EditSessionForm";
      this.Text = "Chỉnh sửa phiên làm việc";
      this.Load += new System.EventHandler(this.EditSessionForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dateSelect.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorPermissionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianPermissionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorPermissionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianPermissionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.DateEdit dateSelect;
    private DevExpress.XtraEditors.LookUpEdit doctorPermissionSelect;
    private DevExpress.XtraEditors.LookUpEdit technicianPermissionSelect;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraEditors.SimpleButton editButton;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem dateSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem doctorPermissionSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem technicianPermissionSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.SimpleSeparator separator;
    private DevExpress.XtraLayout.LayoutControlItem editButtonLayout;
    private DevExpress.XtraEditors.RadioGroup stateRadio;
    private DevExpress.XtraLayout.LayoutControlItem stateRadioLayout;
  }
}