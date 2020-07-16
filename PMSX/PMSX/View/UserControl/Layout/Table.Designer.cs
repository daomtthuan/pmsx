namespace PMSX.View.UserControl.Layout {
  partial class Table {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.gridControl = new DevExpress.XtraGrid.GridControl();
      this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
      this.insertButton = new DevExpress.XtraEditors.SimpleButton();
      this.updateButton = new DevExpress.XtraEditors.SimpleButton();
      this.disabledButton = new DevExpress.XtraEditors.SimpleButton();
      this.detailsButton = new DevExpress.XtraEditors.SimpleButton();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.gridControlLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.titleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.deleteButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.updateButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.insertButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.detailsButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControlLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.deleteButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailsButtonLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControl
      // 
      this.gridControl.Location = new System.Drawing.Point(12, 72);
      this.gridControl.MainView = this.gridView;
      this.gridControl.Name = "gridControl";
      this.gridControl.Size = new System.Drawing.Size(714, 616);
      this.gridControl.TabIndex = 0;
      this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
      // 
      // gridView
      // 
      this.gridView.GridControl = this.gridControl;
      this.gridView.Name = "gridView";
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.gridControl);
      this.layoutControl.Controls.Add(this.insertButton);
      this.layoutControl.Controls.Add(this.updateButton);
      this.layoutControl.Controls.Add(this.disabledButton);
      this.layoutControl.Controls.Add(this.detailsButton);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(738, 700);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl1";
      // 
      // insertButton
      // 
      this.insertButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.insertButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
      this.insertButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.actions_addcircled;
      this.insertButton.Location = new System.Drawing.Point(299, 12);
      this.insertButton.Name = "insertButton";
      this.insertButton.Padding = new System.Windows.Forms.Padding(5);
      this.insertButton.Size = new System.Drawing.Size(140, 46);
      this.insertButton.StyleController = this.layoutControl;
      this.insertButton.TabIndex = 3;
      this.insertButton.Text = "Thêm";
      this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
      // 
      // updateButton
      // 
      this.updateButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.updateButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
      this.updateButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.actions_edit;
      this.updateButton.Location = new System.Drawing.Point(443, 12);
      this.updateButton.Name = "updateButton";
      this.updateButton.Padding = new System.Windows.Forms.Padding(5);
      this.updateButton.Size = new System.Drawing.Size(139, 46);
      this.updateButton.StyleController = this.layoutControl;
      this.updateButton.TabIndex = 4;
      this.updateButton.Text = "Sửa";
      this.updateButton.ToolTip = "Sửa";
      this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
      // 
      // disabledButton
      // 
      this.disabledButton.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
      this.disabledButton.Appearance.Options.UseForeColor = true;
      this.disabledButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.disabledButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
      this.disabledButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.actions_deletecircled;
      this.disabledButton.Location = new System.Drawing.Point(586, 12);
      this.disabledButton.Name = "disabledButton";
      this.disabledButton.Padding = new System.Windows.Forms.Padding(5);
      this.disabledButton.Size = new System.Drawing.Size(140, 46);
      this.disabledButton.StyleController = this.layoutControl;
      this.disabledButton.TabIndex = 5;
      this.disabledButton.Text = "Vô hiệu hoá";
      this.disabledButton.Click += new System.EventHandler(this.DisabledButton_Click);
      // 
      // detailsButton
      // 
      this.detailsButton.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
      this.detailsButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
      this.detailsButton.ImageOptions.SvgImage = global::PMSX.Properties.Resources.actions_zoom;
      this.detailsButton.Location = new System.Drawing.Point(156, 12);
      this.detailsButton.Name = "detailsButton";
      this.detailsButton.Padding = new System.Windows.Forms.Padding(5);
      this.detailsButton.Size = new System.Drawing.Size(139, 46);
      this.detailsButton.StyleController = this.layoutControl;
      this.detailsButton.TabIndex = 6;
      this.detailsButton.Text = "Chi tiết";
      this.detailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.gridControlLayout,
            this.titleLabel,
            this.deleteButtonLayout,
            this.updateButtonLayout,
            this.insertButtonLayout,
            this.detailsButtonLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(738, 700);
      this.Root.TextVisible = false;
      // 
      // gridControlLayout
      // 
      this.gridControlLayout.Control = this.gridControl;
      this.gridControlLayout.Location = new System.Drawing.Point(0, 50);
      this.gridControlLayout.Name = "gridControlLayout";
      this.gridControlLayout.Size = new System.Drawing.Size(718, 630);
      this.gridControlLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.gridControlLayout.TextSize = new System.Drawing.Size(0, 0);
      this.gridControlLayout.TextVisible = false;
      // 
      // titleLabel
      // 
      this.titleLabel.AllowHotTrack = false;
      this.titleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titleLabel.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.titleLabel.AppearanceItemCaption.Options.UseFont = true;
      this.titleLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.titleLabel.Location = new System.Drawing.Point(0, 0);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(144, 50);
      this.titleLabel.Text = " ";
      this.titleLabel.TextSize = new System.Drawing.Size(5, 25);
      // 
      // deleteButtonLayout
      // 
      this.deleteButtonLayout.Control = this.disabledButton;
      this.deleteButtonLayout.Location = new System.Drawing.Point(574, 0);
      this.deleteButtonLayout.MaxSize = new System.Drawing.Size(144, 50);
      this.deleteButtonLayout.MinSize = new System.Drawing.Size(144, 50);
      this.deleteButtonLayout.Name = "deleteButtonLayout";
      this.deleteButtonLayout.Size = new System.Drawing.Size(144, 50);
      this.deleteButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.deleteButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.deleteButtonLayout.TextVisible = false;
      // 
      // updateButtonLayout
      // 
      this.updateButtonLayout.Control = this.updateButton;
      this.updateButtonLayout.Location = new System.Drawing.Point(431, 0);
      this.updateButtonLayout.MaxSize = new System.Drawing.Size(143, 50);
      this.updateButtonLayout.MinSize = new System.Drawing.Size(143, 50);
      this.updateButtonLayout.Name = "updateButtonLayout";
      this.updateButtonLayout.Size = new System.Drawing.Size(143, 50);
      this.updateButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.updateButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.updateButtonLayout.TextVisible = false;
      // 
      // insertButtonLayout
      // 
      this.insertButtonLayout.Control = this.insertButton;
      this.insertButtonLayout.Location = new System.Drawing.Point(287, 0);
      this.insertButtonLayout.MaxSize = new System.Drawing.Size(144, 50);
      this.insertButtonLayout.MinSize = new System.Drawing.Size(144, 50);
      this.insertButtonLayout.Name = "insertButtonLayout";
      this.insertButtonLayout.Size = new System.Drawing.Size(144, 50);
      this.insertButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.insertButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.insertButtonLayout.TextVisible = false;
      // 
      // detailsButtonLayout
      // 
      this.detailsButtonLayout.Control = this.detailsButton;
      this.detailsButtonLayout.Location = new System.Drawing.Point(144, 0);
      this.detailsButtonLayout.MaxSize = new System.Drawing.Size(143, 50);
      this.detailsButtonLayout.MinSize = new System.Drawing.Size(143, 50);
      this.detailsButtonLayout.Name = "detailsButtonLayout";
      this.detailsButtonLayout.Size = new System.Drawing.Size(143, 50);
      this.detailsButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.detailsButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.detailsButtonLayout.TextVisible = false;
      // 
      // Table
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl);
      this.Name = "Table";
      this.Size = new System.Drawing.Size(738, 700);
      this.Load += new System.EventHandler(this.View_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControlLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.deleteButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.updateButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.detailsButtonLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView;
    private DevExpress.XtraEditors.SimpleButton insertButton;
    private DevExpress.XtraEditors.SimpleButton updateButton;
    private DevExpress.XtraEditors.SimpleButton disabledButton;
    private DevExpress.XtraLayout.SimpleLabelItem titleLabel;
    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem gridControlLayout;
    private DevExpress.XtraLayout.LayoutControlItem insertButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem deleteButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem updateButtonLayout;
    private DevExpress.XtraEditors.SimpleButton detailsButton;
    private DevExpress.XtraLayout.LayoutControlItem detailsButtonLayout;
  }
}
