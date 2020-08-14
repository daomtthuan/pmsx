namespace PMSX.App.View.Form.Edit {
  internal partial class EditPatientForm {
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
      this.editButton = new DevExpress.XtraEditors.SimpleButton();
      this.nameInput = new DevExpress.XtraEditors.TextEdit();
      this.addressInput = new DevExpress.XtraEditors.MemoEdit();
      this.yearsOldSelect = new DevExpress.XtraEditors.ComboBoxEdit();
      this.yearSelect = new DevExpress.XtraEditors.ComboBoxEdit();
      this.stateRadio = new DevExpress.XtraEditors.RadioGroup();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.nameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.separator = new DevExpress.XtraLayout.SimpleSeparator();
      this.editButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.yearsOldSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.yearSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.addressInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.stateRadioLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.commentInput);
      this.layout.Controls.Add(this.editButton);
      this.layout.Controls.Add(this.nameInput);
      this.layout.Controls.Add(this.addressInput);
      this.layout.Controls.Add(this.yearsOldSelect);
      this.layout.Controls.Add(this.yearSelect);
      this.layout.Controls.Add(this.stateRadio);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 320);
      this.layout.TabIndex = 3;
      this.layout.Text = "layoutControl1";
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(69, 190);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 1000;
      this.commentInput.Size = new System.Drawing.Size(367, 82);
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
      // nameInput
      // 
      this.nameInput.Location = new System.Drawing.Point(69, 14);
      this.nameInput.Name = "nameInput";
      this.nameInput.Properties.MaxLength = 100;
      this.nameInput.Size = new System.Drawing.Size(367, 22);
      this.nameInput.StyleController = this.layout;
      this.nameInput.TabIndex = 5;
      // 
      // addressInput
      // 
      this.addressInput.Location = new System.Drawing.Point(69, 74);
      this.addressInput.Name = "addressInput";
      this.addressInput.Properties.MaxLength = 1000;
      this.addressInput.Size = new System.Drawing.Size(367, 63);
      this.addressInput.StyleController = this.layout;
      this.addressInput.TabIndex = 7;
      // 
      // yearsOldSelect
      // 
      this.yearsOldSelect.Location = new System.Drawing.Point(69, 44);
      this.yearsOldSelect.Name = "yearsOldSelect";
      this.yearsOldSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.yearsOldSelect.Size = new System.Drawing.Size(152, 22);
      this.yearsOldSelect.StyleController = this.layout;
      this.yearsOldSelect.TabIndex = 9;
      this.yearsOldSelect.SelectedIndexChanged += new System.EventHandler(this.YearsOldSelect_SelectedIndexChanged);
      // 
      // yearSelect
      // 
      this.yearSelect.Location = new System.Drawing.Point(284, 44);
      this.yearSelect.Name = "yearSelect";
      this.yearSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.yearSelect.Size = new System.Drawing.Size(152, 22);
      this.yearSelect.StyleController = this.layout;
      this.yearSelect.TabIndex = 10;
      this.yearSelect.SelectedIndexChanged += new System.EventHandler(this.YearSelect_SelectedIndexChanged);
      // 
      // stateRadio
      // 
      this.stateRadio.Location = new System.Drawing.Point(69, 145);
      this.stateRadio.Name = "stateRadio";
      this.stateRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.stateRadio.Properties.Appearance.Options.UseBackColor = true;
      this.stateRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.stateRadio.Properties.Columns = 2;
      this.stateRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Kích hoạt", true, null, "enabled"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Vô hiệu hoá", true, null, "disabled")});
      this.stateRadio.Size = new System.Drawing.Size(367, 32);
      this.stateRadio.StyleController = this.layout;
      this.stateRadio.TabIndex = 9;
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.nameInputLayout,
            this.commentInputLayout,
            this.separator,
            this.editButtonLayout,
            this.yearsOldSelectLayout,
            this.yearSelectLayout,
            this.addressInputLayout,
            this.stateRadioLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(450, 320);
      this.root.TextVisible = false;
      // 
      // nameInputLayout
      // 
      this.nameInputLayout.Control = this.nameInput;
      this.nameInputLayout.Location = new System.Drawing.Point(0, 0);
      this.nameInputLayout.Name = "nameInputLayout";
      this.nameInputLayout.Size = new System.Drawing.Size(430, 30);
      this.nameInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.nameInputLayout.Text = "Tên";
      this.nameInputLayout.TextSize = new System.Drawing.Size(52, 15);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.AppearanceItemCaption.Options.UseTextOptions = true;
      this.commentInputLayout.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 176);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(430, 90);
      this.commentInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextSize = new System.Drawing.Size(52, 15);
      // 
      // separator
      // 
      this.separator.AllowHotTrack = false;
      this.separator.Location = new System.Drawing.Point(0, 171);
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
      // yearsOldSelectLayout
      // 
      this.yearsOldSelectLayout.Control = this.yearsOldSelect;
      this.yearsOldSelectLayout.Location = new System.Drawing.Point(0, 30);
      this.yearsOldSelectLayout.Name = "yearsOldSelectLayout";
      this.yearsOldSelectLayout.Size = new System.Drawing.Size(215, 30);
      this.yearsOldSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.yearsOldSelectLayout.Text = "Tuổi";
      this.yearsOldSelectLayout.TextSize = new System.Drawing.Size(52, 15);
      // 
      // yearSelectLayout
      // 
      this.yearSelectLayout.Control = this.yearSelect;
      this.yearSelectLayout.Location = new System.Drawing.Point(215, 30);
      this.yearSelectLayout.Name = "yearSelectLayout";
      this.yearSelectLayout.Size = new System.Drawing.Size(215, 30);
      this.yearSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.yearSelectLayout.Text = "Năm sinh";
      this.yearSelectLayout.TextSize = new System.Drawing.Size(52, 15);
      // 
      // addressInputLayout
      // 
      this.addressInputLayout.AppearanceItemCaption.Options.UseTextOptions = true;
      this.addressInputLayout.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.addressInputLayout.Control = this.addressInput;
      this.addressInputLayout.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
      this.addressInputLayout.Location = new System.Drawing.Point(0, 60);
      this.addressInputLayout.Name = "addressInputLayout";
      this.addressInputLayout.Size = new System.Drawing.Size(430, 71);
      this.addressInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.addressInputLayout.Text = "Địa chỉ";
      this.addressInputLayout.TextSize = new System.Drawing.Size(52, 15);
      // 
      // stateRadioLayout
      // 
      this.stateRadioLayout.Control = this.stateRadio;
      this.stateRadioLayout.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
      this.stateRadioLayout.CustomizationFormText = "Trạng thái";
      this.stateRadioLayout.Location = new System.Drawing.Point(0, 131);
      this.stateRadioLayout.MaxSize = new System.Drawing.Size(0, 40);
      this.stateRadioLayout.MinSize = new System.Drawing.Size(113, 40);
      this.stateRadioLayout.Name = "stateRadioLayout";
      this.stateRadioLayout.Size = new System.Drawing.Size(430, 40);
      this.stateRadioLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.stateRadioLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.stateRadioLayout.Text = "Trạng thái";
      this.stateRadioLayout.TextSize = new System.Drawing.Size(52, 15);
      // 
      // EditPatientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 320);
      this.Controls.Add(this.layout);
      this.Name = "EditPatientForm";
      this.Text = "Chỉnh sửa bệnh nhân";
      this.Load += new System.EventHandler(this.EditPatientForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadio.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stateRadioLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraEditors.SimpleButton editButton;
    private DevExpress.XtraEditors.TextEdit nameInput;
    private DevExpress.XtraEditors.MemoEdit addressInput;
    private DevExpress.XtraEditors.ComboBoxEdit yearsOldSelect;
    private DevExpress.XtraEditors.ComboBoxEdit yearSelect;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem nameInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.SimpleSeparator separator;
    private DevExpress.XtraLayout.LayoutControlItem editButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem yearsOldSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem yearSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem addressInputLayout;
    private DevExpress.XtraEditors.RadioGroup stateRadio;
    private DevExpress.XtraLayout.LayoutControlItem stateRadioLayout;
  }
}