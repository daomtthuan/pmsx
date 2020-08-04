namespace PMSX.App.View.Form.Add {
  partial class AddPermissionForm {
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
      this.staffSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.addButton = new DevExpress.XtraEditors.SimpleButton();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.staffSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.separator = new DevExpress.XtraLayout.SimpleSeparator();
      this.addButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.staffSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.staffSelect);
      this.layout.Controls.Add(this.commentInput);
      this.layout.Controls.Add(this.addButton);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 320);
      this.layout.TabIndex = 1;
      this.layout.Text = "layoutControl1";
      // 
      // staffSelect
      // 
      this.staffSelect.Location = new System.Drawing.Point(70, 14);
      this.staffSelect.Name = "staffSelect";
      this.staffSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.staffSelect.Properties.NullText = "";
      this.staffSelect.Properties.Padding = new System.Windows.Forms.Padding(1);
      this.staffSelect.Size = new System.Drawing.Size(366, 24);
      this.staffSelect.StyleController = this.layout;
      this.staffSelect.TabIndex = 5;
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(70, 51);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 1000;
      this.commentInput.Properties.Padding = new System.Windows.Forms.Padding(1);
      this.commentInput.Size = new System.Drawing.Size(366, 221);
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
            this.staffSelectLayout,
            this.commentInputLayout,
            this.separator,
            this.addButtonLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(450, 320);
      this.root.TextVisible = false;
      // 
      // staffSelectLayout
      // 
      this.staffSelectLayout.Control = this.staffSelect;
      this.staffSelectLayout.Location = new System.Drawing.Point(0, 0);
      this.staffSelectLayout.Name = "staffSelectLayout";
      this.staffSelectLayout.Size = new System.Drawing.Size(430, 32);
      this.staffSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.staffSelectLayout.Text = "Nhân viên";
      this.staffSelectLayout.TextSize = new System.Drawing.Size(53, 15);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.AppearanceItemCaption.Options.UseTextOptions = true;
      this.commentInputLayout.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 37);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(430, 229);
      this.commentInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextSize = new System.Drawing.Size(53, 15);
      // 
      // separator
      // 
      this.separator.AllowHotTrack = false;
      this.separator.Location = new System.Drawing.Point(0, 32);
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
      // AddPermissionForm
      // 
      this.AcceptButton = this.addButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 320);
      this.Controls.Add(this.layout);
      this.Name = "AddPermissionForm";
      this.Text = "Thêm phân quyền";
      this.Load += new System.EventHandler(this.AddPermissionForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.staffSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.LookUpEdit staffSelect;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraEditors.SimpleButton addButton;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem staffSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.SimpleSeparator separator;
    private DevExpress.XtraLayout.LayoutControlItem addButtonLayout;
  }
}