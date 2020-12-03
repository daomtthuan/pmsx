namespace PMSXApplication.App.View.Form.Add {
  partial class AddMacroForm {
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
      this.codeInput = new DevExpress.XtraEditors.TextEdit();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.codeInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.separator = new DevExpress.XtraLayout.SimpleSeparator();
      this.addButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.descriptionInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.descriptionInput = new DevExpress.XtraEditors.MemoEdit();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionInput.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.AllowCustomization = false;
      this.layout.Controls.Add(this.commentInput);
      this.layout.Controls.Add(this.addButton);
      this.layout.Controls.Add(this.codeInput);
      this.layout.Controls.Add(this.descriptionInput);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Margin = new System.Windows.Forms.Padding(2);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(450, 320);
      this.layout.TabIndex = 4;
      this.layout.Text = "layoutControl1";
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(57, 147);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 1000;
      this.commentInput.Size = new System.Drawing.Size(379, 125);
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
      // codeInput
      // 
      this.codeInput.Location = new System.Drawing.Point(57, 14);
      this.codeInput.Name = "codeInput";
      this.codeInput.Properties.MaxLength = 100;
      this.codeInput.Size = new System.Drawing.Size(379, 22);
      this.codeInput.StyleController = this.layout;
      this.codeInput.TabIndex = 5;
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.codeInputLayout,
            this.commentInputLayout,
            this.separator,
            this.addButtonLayout,
            this.descriptionInputLayout});
      this.root.Name = "Root";
      this.root.Size = new System.Drawing.Size(450, 320);
      this.root.TextVisible = false;
      // 
      // codeInputLayout
      // 
      this.codeInputLayout.Control = this.codeInput;
      this.codeInputLayout.Location = new System.Drawing.Point(0, 0);
      this.codeInputLayout.Name = "codeInputLayout";
      this.codeInputLayout.Size = new System.Drawing.Size(430, 30);
      this.codeInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.codeInputLayout.Text = "Mã số";
      this.codeInputLayout.TextSize = new System.Drawing.Size(40, 15);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.AppearanceItemCaption.Options.UseTextOptions = true;
      this.commentInputLayout.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 133);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(430, 133);
      this.commentInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextSize = new System.Drawing.Size(40, 15);
      // 
      // separator
      // 
      this.separator.AllowHotTrack = false;
      this.separator.Location = new System.Drawing.Point(0, 128);
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
      // descriptionInputLayout
      // 
      this.descriptionInputLayout.Control = this.descriptionInput;
      this.descriptionInputLayout.Location = new System.Drawing.Point(0, 30);
      this.descriptionInputLayout.Name = "descriptionInputLayout";
      this.descriptionInputLayout.Size = new System.Drawing.Size(430, 98);
      this.descriptionInputLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.descriptionInputLayout.Text = "Mô tả";
      this.descriptionInputLayout.TextSize = new System.Drawing.Size(40, 15);
      // 
      // descriptionInput
      // 
      this.descriptionInput.Location = new System.Drawing.Point(57, 44);
      this.descriptionInput.Name = "descriptionInput";
      this.descriptionInput.Properties.MaxLength = 100;
      this.descriptionInput.Size = new System.Drawing.Size(379, 90);
      this.descriptionInput.StyleController = this.layout;
      this.descriptionInput.TabIndex = 9;
      // 
      // AddMacroForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 320);
      this.Controls.Add(this.layout);
      this.Name = "AddMacroForm";
      this.Text = "Thêm đại thể";
      this.Load += new System.EventHandler(this.AddMacroForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.descriptionInput.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraEditors.MemoEdit commentInput;
    private DevExpress.XtraEditors.SimpleButton addButton;
    private DevExpress.XtraEditors.TextEdit codeInput;
    private DevExpress.XtraEditors.MemoEdit descriptionInput;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraLayout.LayoutControlItem codeInputLayout;
    private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    private DevExpress.XtraLayout.SimpleSeparator separator;
    private DevExpress.XtraLayout.LayoutControlItem addButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem descriptionInputLayout;
  }
}