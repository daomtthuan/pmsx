namespace PMSX.View.UserControl.Component.Table {
    partial class Micro {
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
      this.microPanel = new DevExpress.XtraEditors.PanelControl();
      this.microGroupSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.microGroupSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.staffRolePanelLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.microPanel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.microGroupSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.microGroupSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.Controls.Add(this.microPanel);
      this.layoutControl.Controls.Add(this.microGroupSelect);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1016, 178, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(150, 150);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl1";
      // 
      // microPanel
      // 
      this.microPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.microPanel.Location = new System.Drawing.Point(12, 78);
      this.microPanel.Name = "microPanel";
      this.microPanel.Size = new System.Drawing.Size(126, 60);
      this.microPanel.TabIndex = 4;
      // 
      // microGroupSelect
      // 
      this.microGroupSelect.Location = new System.Drawing.Point(12, 36);
      this.microGroupSelect.Name = "microGroupSelect";
      this.microGroupSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.microGroupSelect.Properties.NullText = "";
      this.microGroupSelect.Properties.PopupSizeable = false;
      this.microGroupSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
      this.microGroupSelect.Size = new System.Drawing.Size(126, 28);
      this.microGroupSelect.StyleController = this.layoutControl;
      this.microGroupSelect.TabIndex = 5;
      this.microGroupSelect.EditValueChanged += new System.EventHandler(this.MicroGroupSelect_EditValueChanged);
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.microGroupSelectLayout,
            this.staffRolePanelLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(150, 150);
      this.Root.TextVisible = false;
      // 
      // microGroupSelectLayout
      // 
      this.microGroupSelectLayout.Control = this.microGroupSelect;
      this.microGroupSelectLayout.Location = new System.Drawing.Point(0, 0);
      this.microGroupSelectLayout.Name = "microGroupSelectLayout";
      this.microGroupSelectLayout.Size = new System.Drawing.Size(130, 56);
      this.microGroupSelectLayout.Text = "Nhóm vi thể";
      this.microGroupSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.microGroupSelectLayout.TextSize = new System.Drawing.Size(87, 21);
      // 
      // staffRolePanelLayout
      // 
      this.staffRolePanelLayout.Control = this.microPanel;
      this.staffRolePanelLayout.Location = new System.Drawing.Point(0, 56);
      this.staffRolePanelLayout.Name = "staffRolePanelLayout";
      this.staffRolePanelLayout.Size = new System.Drawing.Size(130, 74);
      this.staffRolePanelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.staffRolePanelLayout.TextSize = new System.Drawing.Size(0, 0);
      this.staffRolePanelLayout.TextVisible = false;
      // 
      // Micro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl);
      this.Name = "Micro";
      this.Load += new System.EventHandler(this.Micro_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.microPanel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.microGroupSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.microGroupSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.PanelControl microPanel;
        private DevExpress.XtraEditors.LookUpEdit microGroupSelect;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem microGroupSelectLayout;
        private DevExpress.XtraLayout.LayoutControlItem staffRolePanelLayout;
    }
}
