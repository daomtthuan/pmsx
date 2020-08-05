namespace PMSX.App.View.Form.Add {
  partial class AddSessionForm {
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
      this.addButton = new DevExpress.XtraEditors.SimpleButton();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.dateSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.doctorPermissionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.technicianPermissionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.separator = new DevExpress.XtraLayout.SimpleSeparator();
      this.addButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelect.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorPermissionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianPermissionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorPermissionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianPermissionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.dateSelect);
      this.layout.Controls.Add(this.doctorPermissionSelect);
      this.layout.Controls.Add(this.technicianPermissionSelect);
      this.layout.Controls.Add(this.commentInput);
      this.layout.Controls.Add(this.addButton);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 320);
      this.layout.TabIndex = 0;
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
      this.commentInput.Location = new System.Drawing.Point(86, 109);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 1000;
      this.commentInput.Size = new System.Drawing.Size(350, 163);
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
            this.addButtonLayout});
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
      this.commentInputLayout.Location = new System.Drawing.Point(0, 95);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(430, 171);
      this.commentInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextSize = new System.Drawing.Size(69, 15);
      // 
      // separator
      // 
      this.separator.AllowHotTrack = false;
      this.separator.Location = new System.Drawing.Point(0, 90);
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
      // AddSessionForm
      // 
      this.AcceptButton = this.addButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 320);
      this.Controls.Add(this.layout);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "AddSessionForm";
      this.Text = "Thêm phiên làm việc";
      this.Load += new System.EventHandler(this.AddSessionForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dateSelect.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorPermissionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianPermissionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.doctorPermissionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.technicianPermissionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.DateEdit dateSelect;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem dateSelectLayout;
    private DevExpress.XtraEditors.LookUpEdit doctorPermissionSelect;
    private DevExpress.XtraEditors.LookUpEdit technicianPermissionSelect;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraLayout.LayoutControlItem doctorPermissionSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem technicianPermissionSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.SimpleSeparator separator;
    private DevExpress.XtraEditors.SimpleButton addButton;
    private DevExpress.XtraLayout.LayoutControlItem addButtonLayout;
  }
}