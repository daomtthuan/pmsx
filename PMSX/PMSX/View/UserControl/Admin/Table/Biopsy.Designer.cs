namespace PMSX.View.UserControl.Admin.Table {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
      this.biopsyPanel = new DevExpress.XtraEditors.PanelControl();
      this.biopsyGroupSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.biopsyGroupSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.staffRolePanelLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.biopsyPanel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.biopsyGroupSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.biopsyGroupSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.Controls.Add(this.biopsyPanel);
      this.layoutControl.Controls.Add(this.biopsyGroupSelect);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1016, 178, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(150, 150);
      this.layoutControl.TabIndex = 2;
      this.layoutControl.Text = "layoutControl1";
      // 
      // biopsyPanel
      // 
      this.biopsyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.biopsyPanel.Location = new System.Drawing.Point(12, 78);
      this.biopsyPanel.Name = "biopsyPanel";
      this.biopsyPanel.Size = new System.Drawing.Size(126, 60);
      this.biopsyPanel.TabIndex = 4;
      // 
      // biopsyGroupSelect
      // 
      this.biopsyGroupSelect.Location = new System.Drawing.Point(12, 36);
      this.biopsyGroupSelect.Name = "biopsyGroupSelect";
      this.biopsyGroupSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.biopsyGroupSelect.Properties.NullText = "";
      this.biopsyGroupSelect.Properties.PopupSizeable = false;
      this.biopsyGroupSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
      this.biopsyGroupSelect.Size = new System.Drawing.Size(126, 28);
      this.biopsyGroupSelect.StyleController = this.layoutControl;
      this.biopsyGroupSelect.TabIndex = 5;
      this.biopsyGroupSelect.EditValueChanged += new System.EventHandler(this.BiopsyGroupSelect_EditValueChanged);
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.biopsyGroupSelectLayout,
            this.staffRolePanelLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(150, 150);
      this.Root.TextVisible = false;
      // 
      // biopsyGroupSelectLayout
      // 
      this.biopsyGroupSelectLayout.Control = this.biopsyGroupSelect;
      this.biopsyGroupSelectLayout.Location = new System.Drawing.Point(0, 0);
      this.biopsyGroupSelectLayout.Name = "biopsyGroupSelectLayout";
      this.biopsyGroupSelectLayout.Size = new System.Drawing.Size(130, 56);
      this.biopsyGroupSelectLayout.Text = "Nhóm sinh thiết";
      this.biopsyGroupSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.biopsyGroupSelectLayout.TextSize = new System.Drawing.Size(115, 21);
      // 
      // staffRolePanelLayout
      // 
      this.staffRolePanelLayout.Control = this.biopsyPanel;
      this.staffRolePanelLayout.Location = new System.Drawing.Point(0, 56);
      this.staffRolePanelLayout.Name = "staffRolePanelLayout";
      this.staffRolePanelLayout.Size = new System.Drawing.Size(130, 74);
      this.staffRolePanelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.staffRolePanelLayout.TextSize = new System.Drawing.Size(0, 0);
      this.staffRolePanelLayout.TextVisible = false;
      // 
      // Biopsy
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl);
      this.Name = "Biopsy";
      this.Load += new System.EventHandler(this.Biopsy_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.biopsyPanel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.biopsyGroupSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.biopsyGroupSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private DevExpress.XtraEditors.PanelControl biopsyPanel;
    private DevExpress.XtraEditors.LookUpEdit biopsyGroupSelect;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem biopsyGroupSelectLayout;
    private DevExpress.XtraLayout.LayoutControlItem staffRolePanelLayout;
  }
}
