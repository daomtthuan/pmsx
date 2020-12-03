namespace PMSXApplication.App.View.Control {
  internal abstract partial class TableWithSelectControl {
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
      this.layout = new DevExpress.XtraLayout.LayoutControl();
      this.tableGrid = new DevExpress.XtraGrid.GridControl();
      this.tableView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.selectControl = new DevExpress.XtraEditors.LookUpEdit();
      this.addButton = new DevExpress.XtraEditors.SimpleButton();
      this.editButton = new DevExpress.XtraEditors.SimpleButton();
      this.disableButton = new DevExpress.XtraEditors.SimpleButton();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.tableGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.addButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.groupSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.editButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.disableButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
      this.layout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.selectControl.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableGridLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.disableButtonLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layout
      // 
      this.layout.Controls.Add(this.tableGrid);
      this.layout.Controls.Add(this.selectControl);
      this.layout.Controls.Add(this.addButton);
      this.layout.Controls.Add(this.editButton);
      this.layout.Controls.Add(this.disableButton);
      this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layout.Location = new System.Drawing.Point(0, 0);
      this.layout.Name = "layout";
      this.layout.Root = this.root;
      this.layout.Size = new System.Drawing.Size(632, 600);
      this.layout.TabIndex = 0;
      this.layout.Text = "layoutControl1";
      // 
      // tableGrid
      // 
      this.tableGrid.Location = new System.Drawing.Point(14, 48);
      this.tableGrid.MainView = this.tableView;
      this.tableGrid.Name = "tableGrid";
      this.tableGrid.Padding = new System.Windows.Forms.Padding(1);
      this.tableGrid.Size = new System.Drawing.Size(604, 538);
      this.tableGrid.TabIndex = 5;
      this.tableGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tableView});
      // 
      // tableView
      // 
      this.tableView.GridControl = this.tableGrid;
      this.tableView.Name = "tableView";
      this.tableView.OptionsView.ShowGroupPanel = false;
      // 
      // select
      // 
      this.selectControl.Location = new System.Drawing.Point(49, 14);
      this.selectControl.Name = "select";
      this.selectControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.selectControl.Properties.NullText = "";
      this.selectControl.Properties.Padding = new System.Windows.Forms.Padding(1);
      this.selectControl.Size = new System.Drawing.Size(110, 24);
      this.selectControl.StyleController = this.layout;
      this.selectControl.TabIndex = 4;
      this.selectControl.EditValueChanged += new System.EventHandler(this.GroupSelect_EditValueChanged);
      // 
      // addButton
      // 
      this.addButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.addButton.Appearance.Options.UseBackColor = true;
      this.addButton.Location = new System.Drawing.Point(167, 14);
      this.addButton.Name = "addButton";
      this.addButton.Padding = new System.Windows.Forms.Padding(2);
      this.addButton.Size = new System.Drawing.Size(145, 26);
      this.addButton.StyleController = this.layout;
      this.addButton.TabIndex = 6;
      this.addButton.Text = "Thêm";
      this.addButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // editButton
      // 
      this.editButton.Location = new System.Drawing.Point(320, 14);
      this.editButton.Name = "editButton";
      this.editButton.Padding = new System.Windows.Forms.Padding(2);
      this.editButton.Size = new System.Drawing.Size(145, 26);
      this.editButton.StyleController = this.layout;
      this.editButton.TabIndex = 7;
      this.editButton.Text = "Chỉnh sửa";
      this.editButton.Click += new System.EventHandler(this.EditButton_Click);
      // 
      // disableButton
      // 
      this.disableButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
      this.disableButton.Appearance.Options.UseBackColor = true;
      this.disableButton.Location = new System.Drawing.Point(473, 14);
      this.disableButton.Name = "disableButton";
      this.disableButton.Padding = new System.Windows.Forms.Padding(2);
      this.disableButton.Size = new System.Drawing.Size(145, 26);
      this.disableButton.StyleController = this.layout;
      this.disableButton.TabIndex = 8;
      this.disableButton.Text = "Vô hiệu hoá";
      this.disableButton.Click += new System.EventHandler(this.DisableButton_Click);
      // 
      // root
      // 
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tableGridLayout,
            this.addButtonLayout,
            this.groupSelectLayout,
            this.editButtonLayout,
            this.disableButtonLayout});
      this.root.Name = "root";
      this.root.Size = new System.Drawing.Size(632, 600);
      this.root.TextVisible = false;
      // 
      // tableGridLayout
      // 
      this.tableGridLayout.Control = this.tableGrid;
      this.tableGridLayout.Location = new System.Drawing.Point(0, 34);
      this.tableGridLayout.Name = "tableGridLayout";
      this.tableGridLayout.Size = new System.Drawing.Size(612, 546);
      this.tableGridLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.tableGridLayout.TextSize = new System.Drawing.Size(0, 0);
      this.tableGridLayout.TextVisible = false;
      // 
      // addButtonLayout
      // 
      this.addButtonLayout.Control = this.addButton;
      this.addButtonLayout.Location = new System.Drawing.Point(153, 0);
      this.addButtonLayout.MaxSize = new System.Drawing.Size(153, 34);
      this.addButtonLayout.MinSize = new System.Drawing.Size(153, 34);
      this.addButtonLayout.Name = "addButtonLayout";
      this.addButtonLayout.Size = new System.Drawing.Size(153, 34);
      this.addButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.addButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.addButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.addButtonLayout.TextVisible = false;
      // 
      // groupSelectLayout
      // 
      this.groupSelectLayout.Control = this.selectControl;
      this.groupSelectLayout.Location = new System.Drawing.Point(0, 0);
      this.groupSelectLayout.MinSize = new System.Drawing.Size(93, 34);
      this.groupSelectLayout.Name = "groupSelectLayout";
      this.groupSelectLayout.Size = new System.Drawing.Size(153, 34);
      this.groupSelectLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.groupSelectLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.groupSelectLayout.Text = "Nhóm";
      this.groupSelectLayout.TextSize = new System.Drawing.Size(32, 15);
      // 
      // editButtonLayout
      // 
      this.editButtonLayout.Control = this.editButton;
      this.editButtonLayout.Location = new System.Drawing.Point(306, 0);
      this.editButtonLayout.MaxSize = new System.Drawing.Size(153, 34);
      this.editButtonLayout.MinSize = new System.Drawing.Size(153, 34);
      this.editButtonLayout.Name = "editButtonLayout";
      this.editButtonLayout.Size = new System.Drawing.Size(153, 34);
      this.editButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.editButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.editButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.editButtonLayout.TextVisible = false;
      // 
      // disableButtonLayout
      // 
      this.disableButtonLayout.Control = this.disableButton;
      this.disableButtonLayout.Location = new System.Drawing.Point(459, 0);
      this.disableButtonLayout.MaxSize = new System.Drawing.Size(153, 34);
      this.disableButtonLayout.MinSize = new System.Drawing.Size(153, 34);
      this.disableButtonLayout.Name = "disableButtonLayout";
      this.disableButtonLayout.Size = new System.Drawing.Size(153, 34);
      this.disableButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.disableButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
      this.disableButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.disableButtonLayout.TextVisible = false;
      // 
      // TableWithSelectControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layout);
      this.Name = "TableWithSelectControl";
      this.Size = new System.Drawing.Size(632, 600);
      this.Load += new System.EventHandler(this.TableWithGroupControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
      this.layout.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.selectControl.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableGridLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.groupSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.editButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.disableButtonLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layout;
    private DevExpress.XtraLayout.LayoutControlGroup root;
    private DevExpress.XtraGrid.GridControl tableGrid;
    private DevExpress.XtraGrid.Views.Grid.GridView tableView;
    private DevExpress.XtraEditors.LookUpEdit selectControl;
    private DevExpress.XtraEditors.SimpleButton addButton;
    private DevExpress.XtraEditors.SimpleButton editButton;
    private DevExpress.XtraEditors.SimpleButton disableButton;
    private DevExpress.XtraLayout.LayoutControlItem tableGridLayout;
    private DevExpress.XtraLayout.LayoutControlItem addButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem groupSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem editButtonLayout;
    private DevExpress.XtraLayout.LayoutControlItem disableButtonLayout;
  }
}
