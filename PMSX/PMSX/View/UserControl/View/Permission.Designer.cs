namespace PMSX.View.UserControl.View {
    partial class Permission {
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
            this.permissionPanel = new DevExpress.XtraEditors.PanelControl();
            this.roleSelect = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.roleSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.staffRolePanelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissionPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleSelectLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.permissionPanel);
            this.layoutControl.Controls.Add(this.roleSelect);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1016, 178, 650, 400);
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(150, 150);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // permissionPanel
            // 
            this.permissionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.permissionPanel.Location = new System.Drawing.Point(12, 78);
            this.permissionPanel.Name = "permissionPanel";
            this.permissionPanel.Size = new System.Drawing.Size(126, 60);
            this.permissionPanel.TabIndex = 4;
            // 
            // roleSelect
            // 
            this.roleSelect.Location = new System.Drawing.Point(12, 36);
            this.roleSelect.Name = "roleSelect";
            this.roleSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.roleSelect.Properties.NullText = "";
            this.roleSelect.Properties.PopupSizeable = false;
            this.roleSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.roleSelect.Size = new System.Drawing.Size(126, 28);
            this.roleSelect.StyleController = this.layoutControl;
            this.roleSelect.TabIndex = 5;
            this.roleSelect.EditValueChanged += new System.EventHandler(this.RoleSelect_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.roleSelectLayout,
            this.staffRolePanelLayout});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(150, 150);
            this.Root.TextVisible = false;
            // 
            // roleSelectLayout
            // 
            this.roleSelectLayout.Control = this.roleSelect;
            this.roleSelectLayout.Location = new System.Drawing.Point(0, 0);
            this.roleSelectLayout.Name = "roleSelectLayout";
            this.roleSelectLayout.Size = new System.Drawing.Size(130, 56);
            this.roleSelectLayout.Text = "Quyền";
            this.roleSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleSelectLayout.TextSize = new System.Drawing.Size(46, 21);
            // 
            // staffRolePanelLayout
            // 
            this.staffRolePanelLayout.Control = this.permissionPanel;
            this.staffRolePanelLayout.Location = new System.Drawing.Point(0, 56);
            this.staffRolePanelLayout.Name = "staffRolePanelLayout";
            this.staffRolePanelLayout.Size = new System.Drawing.Size(130, 74);
            this.staffRolePanelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.staffRolePanelLayout.TextSize = new System.Drawing.Size(0, 0);
            this.staffRolePanelLayout.TextVisible = false;
            // 
            // Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "Permission";
            this.Load += new System.EventHandler(this.Permission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.permissionPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleSelectLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.PanelControl permissionPanel;
        private DevExpress.XtraEditors.LookUpEdit roleSelect;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem roleSelectLayout;
        private DevExpress.XtraLayout.LayoutControlItem staffRolePanelLayout;
    }
}
