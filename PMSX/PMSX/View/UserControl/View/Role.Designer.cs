namespace PMSX.View.UserControl.View {
    partial class Role {
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
            this.staffRolePanel = new DevExpress.XtraEditors.PanelControl();
            this.roleLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.staffRolePanelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.rolePanelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.rolePanel = new DevExpress.XtraEditors.PanelControl();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffRolePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePanelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.rolePanel);
            this.layoutControl.Controls.Add(this.staffRolePanel);
            this.layoutControl.Controls.Add(this.roleLookUpEdit);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1016, 178, 650, 400);
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(1424, 841);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // staffRolePanel
            // 
            this.staffRolePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.staffRolePanel.Location = new System.Drawing.Point(12, 87);
            this.staffRolePanel.Name = "staffRolePanel";
            this.staffRolePanel.Size = new System.Drawing.Size(832, 742);
            this.staffRolePanel.TabIndex = 4;
            // 
            // roleLookUpEdit
            // 
            this.roleLookUpEdit.Location = new System.Drawing.Point(12, 36);
            this.roleLookUpEdit.Name = "roleLookUpEdit";
            this.roleLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.roleLookUpEdit.Properties.NullText = "";
            this.roleLookUpEdit.Properties.PopupSizeable = false;
            this.roleLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.roleLookUpEdit.Size = new System.Drawing.Size(832, 28);
            this.roleLookUpEdit.StyleController = this.layoutControl;
            this.roleLookUpEdit.TabIndex = 5;
            this.roleLookUpEdit.EditValueChanged += new System.EventHandler(this.RoleLookUpEdit_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.splitterItem1,
            this.roleLayout,
            this.rolePanelLayout,
            this.staffRolePanelLayout,
            this.emptySpaceItem});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1424, 841);
            this.Root.TextVisible = false;
            // 
            // staffRolePanelLayout
            // 
            this.staffRolePanelLayout.Control = this.staffRolePanel;
            this.staffRolePanelLayout.Location = new System.Drawing.Point(0, 75);
            this.staffRolePanelLayout.Name = "staffRolePanelLayout";
            this.staffRolePanelLayout.Size = new System.Drawing.Size(836, 746);
            this.staffRolePanelLayout.TextSize = new System.Drawing.Size(0, 0);
            this.staffRolePanelLayout.TextVisible = false;
            // 
            // roleLayout
            // 
            this.roleLayout.Control = this.roleLookUpEdit;
            this.roleLayout.Location = new System.Drawing.Point(0, 0);
            this.roleLayout.Name = "roleLayout";
            this.roleLayout.Size = new System.Drawing.Size(836, 56);
            this.roleLayout.Text = "Nhóm quyền";
            this.roleLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleLayout.TextSize = new System.Drawing.Size(91, 21);
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(836, 19);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // rolePanelLayout
            // 
            this.rolePanelLayout.Control = this.rolePanel;
            this.rolePanelLayout.Location = new System.Drawing.Point(846, 0);
            this.rolePanelLayout.Name = "rolePanelLayout";
            this.rolePanelLayout.Size = new System.Drawing.Size(558, 821);
            this.rolePanelLayout.TextSize = new System.Drawing.Size(0, 0);
            this.rolePanelLayout.TextVisible = false;
            // 
            // rolePanel
            // 
            this.rolePanel.Location = new System.Drawing.Point(858, 12);
            this.rolePanel.Name = "rolePanel";
            this.rolePanel.Size = new System.Drawing.Size(554, 817);
            this.rolePanel.TabIndex = 0;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(836, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(10, 821);
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "Role";
            this.Size = new System.Drawing.Size(1424, 841);
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffRolePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffRolePanelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePanelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl staffRolePanel;
        private DevExpress.XtraLayout.LayoutControlItem staffRolePanelLayout;
        private DevExpress.XtraLayout.LayoutControlItem roleLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraEditors.LookUpEdit roleLookUpEdit;
        private DevExpress.XtraEditors.PanelControl rolePanel;
        private DevExpress.XtraLayout.LayoutControlItem rolePanelLayout;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}
