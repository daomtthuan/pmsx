namespace PMSX.View.UserControl.Admin.Table {
    partial class Macro {
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
      this.macroPanel = new DevExpress.XtraEditors.PanelControl();
      this.macroGroupSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.macroGroupSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.staffRolePanelLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.macroPanel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.macroGroupSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.macroGroupSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.Controls.Add(this.macroPanel);
      this.layoutControl.Controls.Add(this.macroGroupSelect);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1016, 178, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(150, 150);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl1";
      // 
      // macroPanel
      // 
      this.macroPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.macroPanel.Location = new System.Drawing.Point(8, 75);
      this.macroPanel.Name = "macroPanel";
      this.macroPanel.Size = new System.Drawing.Size(134, 65);
      this.macroPanel.TabIndex = 4;
      // 
      // macroGroupSelect
      // 
      this.macroGroupSelect.Location = new System.Drawing.Point(8, 33);
      this.macroGroupSelect.Name = "macroGroupSelect";
      this.macroGroupSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.macroGroupSelect.Properties.NullText = "";
      this.macroGroupSelect.Properties.PopupSizeable = false;
      this.macroGroupSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
      this.macroGroupSelect.Size = new System.Drawing.Size(134, 28);
      this.macroGroupSelect.StyleController = this.layoutControl;
      this.macroGroupSelect.TabIndex = 5;
      this.macroGroupSelect.EditValueChanged += new System.EventHandler(this.MacroGroupSelect_EditValueChanged);
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.macroGroupSelectLayout,
            this.staffRolePanelLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(150, 150);
      this.Root.TextVisible = false;
      // 
      // macroGroupSelectLayout
      // 
      this.macroGroupSelectLayout.Control = this.macroGroupSelect;
      this.macroGroupSelectLayout.Location = new System.Drawing.Point(0, 0);
      this.macroGroupSelectLayout.Name = "macroGroupSelectLayout";
      this.macroGroupSelectLayout.Size = new System.Drawing.Size(136, 55);
      this.macroGroupSelectLayout.Text = "Nhóm đại thể";
      this.macroGroupSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.macroGroupSelectLayout.TextSize = new System.Drawing.Size(97, 21);
      // 
      // staffRolePanelLayout
      // 
      this.staffRolePanelLayout.Control = this.macroPanel;
      this.staffRolePanelLayout.Location = new System.Drawing.Point(0, 55);
      this.staffRolePanelLayout.Name = "staffRolePanelLayout";
      this.staffRolePanelLayout.Size = new System.Drawing.Size(136, 79);
      this.staffRolePanelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.staffRolePanelLayout.TextSize = new System.Drawing.Size(0, 0);
      this.staffRolePanelLayout.TextVisible = false;
      // 
      // Macro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.layoutControl);
      this.Name = "Macro";
      this.Load += new System.EventHandler(this.Macro_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.macroPanel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.macroGroupSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.macroGroupSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.PanelControl macroPanel;
        private DevExpress.XtraEditors.LookUpEdit macroGroupSelect;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem macroGroupSelectLayout;
        private DevExpress.XtraLayout.LayoutControlItem staffRolePanelLayout;
    }
}
