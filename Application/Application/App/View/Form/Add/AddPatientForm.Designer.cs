namespace PMSXApplication.App.View.Form.Add {
  internal partial class AddPatientForm {
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
      this.addButton = new DevExpress.XtraEditors.SimpleButton();
      this.nameInput = new DevExpress.XtraEditors.TextEdit();
      this.addressInput = new DevExpress.XtraEditors.MemoEdit();
      this.yearsOldSelect = new DevExpress.XtraEditors.ComboBoxEdit();
      this.yearSelect = new DevExpress.XtraEditors.ComboBoxEdit();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.nameInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.separator = new DevExpress.XtraLayout.SimpleSeparator();
      this.addButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.yearsOldSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.yearSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.addressInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInputLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.commentInput);
      this.layout.Controls.Add(this.addButton);
      this.layout.Controls.Add(this.nameInput);
      this.layout.Controls.Add(this.addressInput);
      this.layout.Controls.Add(this.yearsOldSelect);
      this.layout.Controls.Add(this.yearSelect);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 320);
      this.layout.TabIndex = 2;
      this.layout.Text = "layoutControl1";
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(66, 175);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 1000;
      this.commentInput.Size = new System.Drawing.Size(370, 97);
      this.commentInput.StyleController = this.layout;
      this.commentInput.TabIndex = 7;
      // 
      // addButton
      // 
      this.addButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.addButton.Appearance.Options.UseBackColor = true;
      this.addButton.Location = new System.Drawing.Point(14, 280);
      this.addButton.Name = "addButton";
      this.addButton.Padding = new System.Windows.Forms.Padding(2);
      this.addButton.Size = new System.Drawing.Size(422, 26);
      this.addButton.StyleController = this.layout;
      this.addButton.TabIndex = 8;
      this.addButton.Text = "Thêm";
      this.addButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // nameInput
      // 
      this.nameInput.Location = new System.Drawing.Point(66, 14);
      this.nameInput.Name = "nameInput";
      this.nameInput.Properties.MaxLength = 100;
      this.nameInput.Size = new System.Drawing.Size(370, 22);
      this.nameInput.StyleController = this.layout;
      this.nameInput.TabIndex = 5;
      // 
      // addressInput
      // 
      this.addressInput.Location = new System.Drawing.Point(66, 74);
      this.addressInput.Name = "addressInput";
      this.addressInput.Properties.MaxLength = 1000;
      this.addressInput.Size = new System.Drawing.Size(370, 88);
      this.addressInput.StyleController = this.layout;
      this.addressInput.TabIndex = 7;
      // 
      // yearsOldSelect
      // 
      this.yearsOldSelect.Location = new System.Drawing.Point(66, 44);
      this.yearsOldSelect.Name = "yearsOldSelect";
      this.yearsOldSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.yearsOldSelect.Size = new System.Drawing.Size(155, 22);
      this.yearsOldSelect.StyleController = this.layout;
      this.yearsOldSelect.TabIndex = 9;
      this.yearsOldSelect.SelectedIndexChanged += new System.EventHandler(this.YearsOldSelect_SelectedIndexChanged);
      // 
      // yearSelect
      // 
      this.yearSelect.Location = new System.Drawing.Point(281, 44);
      this.yearSelect.Name = "yearSelect";
      this.yearSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.yearSelect.Size = new System.Drawing.Size(155, 22);
      this.yearSelect.StyleController = this.layout;
      this.yearSelect.TabIndex = 10;
      this.yearSelect.SelectedIndexChanged += new System.EventHandler(this.YearSelect_SelectedIndexChanged);
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.nameInputLayout,
            this.commentInputLayout,
            this.separator,
            this.addButtonLayout,
            this.yearsOldSelectLayout,
            this.yearSelectLayout,
            this.addressInputLayout});
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
      this.nameInputLayout.TextSize = new System.Drawing.Size(49, 15);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.AppearanceItemCaption.Options.UseTextOptions = true;
      this.commentInputLayout.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 161);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(430, 105);
      this.commentInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextSize = new System.Drawing.Size(49, 15);
      // 
      // separator
      // 
      this.separator.AllowHotTrack = false;
      this.separator.Location = new System.Drawing.Point(0, 156);
      this.separator.Name = "separator";
      this.separator.Size = new System.Drawing.Size(430, 5);
      this.separator.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      // 
      // addButtonLayout
      // 
      this.addButtonLayout.Control = this.addButton;
      this.addButtonLayout.Location = new System.Drawing.Point(0, 266);
      this.addButtonLayout.Name = "addButtonLayout";
      this.addButtonLayout.Size = new System.Drawing.Size(430, 34);
      this.addButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.addButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.addButtonLayout.TextVisible = false;
      // 
      // yearsOldSelectLayout
      // 
      this.yearsOldSelectLayout.Control = this.yearsOldSelect;
      this.yearsOldSelectLayout.Location = new System.Drawing.Point(0, 30);
      this.yearsOldSelectLayout.Name = "yearsOldSelectLayout";
      this.yearsOldSelectLayout.Size = new System.Drawing.Size(215, 30);
      this.yearsOldSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.yearsOldSelectLayout.Text = "Tuổi";
      this.yearsOldSelectLayout.TextSize = new System.Drawing.Size(49, 15);
      // 
      // yearSelectLayout
      // 
      this.yearSelectLayout.Control = this.yearSelect;
      this.yearSelectLayout.Location = new System.Drawing.Point(215, 30);
      this.yearSelectLayout.Name = "yearSelectLayout";
      this.yearSelectLayout.Size = new System.Drawing.Size(215, 30);
      this.yearSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.yearSelectLayout.Text = "Năm sinh";
      this.yearSelectLayout.TextSize = new System.Drawing.Size(49, 15);
      // 
      // addressInputLayout
      // 
      this.addressInputLayout.AppearanceItemCaption.Options.UseTextOptions = true;
      this.addressInputLayout.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.addressInputLayout.Control = this.addressInput;
      this.addressInputLayout.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
      this.addressInputLayout.Location = new System.Drawing.Point(0, 60);
      this.addressInputLayout.Name = "addressInputLayout";
      this.addressInputLayout.Size = new System.Drawing.Size(430, 96);
      this.addressInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.addressInputLayout.Text = "Địa chỉ";
      this.addressInputLayout.TextSize = new System.Drawing.Size(49, 15);
      // 
      // AddPatientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 320);
      this.Controls.Add(this.layout);
      this.Name = "AddPatientForm";
      this.Text = "Thêm bệnh nhân";
      this.Load += new System.EventHandler(this.AddPatientForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nameInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearsOldSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.yearSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressInputLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraEditors.SimpleButton addButton;
    private DevExpress.XtraEditors.TextEdit nameInput;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem nameInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.SimpleSeparator separator;
    private DevExpress.XtraLayout.LayoutControlItem addButtonLayout;
    private DevExpress.XtraEditors.MemoEdit addressInput;
    private DevExpress.XtraLayout.LayoutControlItem addressInputLayout;
    private DevExpress.XtraEditors.ComboBoxEdit yearsOldSelect;
    private DevExpress.XtraEditors.ComboBoxEdit yearSelect;
    private DevExpress.XtraLayout.LayoutControlItem yearsOldSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem yearSelectLayout;
  }
}