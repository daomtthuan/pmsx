namespace PMSX.View.Form {
    partial class Loading {
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
      this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
      this.brandPanel = new DevExpress.XtraEditors.PanelControl();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.copyrightLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.brandPanelLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.brandPanel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandPanelLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.brandPanel);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.root;
      this.layoutControl.Size = new System.Drawing.Size(500, 319);
      this.layoutControl.TabIndex = 10;
      this.layoutControl.Text = "layoutControl1";
      // 
      // brandPanel
      // 
      this.brandPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.brandPanel.Location = new System.Drawing.Point(12, 12);
      this.brandPanel.Name = "brandPanel";
      this.brandPanel.Size = new System.Drawing.Size(476, 254);
      this.brandPanel.TabIndex = 14;
      // 
      // root
      // 
      this.root.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
      this.root.AppearanceGroup.Options.UseBackColor = true;
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.copyrightLabel,
            this.brandPanelLayout});
      this.root.Name = "root";
      this.root.Size = new System.Drawing.Size(500, 319);
      this.root.TextVisible = false;
      // 
      // copyrightLabel
      // 
      this.copyrightLabel.AllowHotTrack = false;
      this.copyrightLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.copyrightLabel.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
      this.copyrightLabel.AppearanceItemCaption.Options.UseFont = true;
      this.copyrightLabel.AppearanceItemCaption.Options.UseForeColor = true;
      this.copyrightLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.copyrightLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.copyrightLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
      this.copyrightLabel.Location = new System.Drawing.Point(0, 258);
      this.copyrightLabel.MinSize = new System.Drawing.Size(419, 21);
      this.copyrightLabel.Name = "copyrightLabel";
      this.copyrightLabel.Size = new System.Drawing.Size(480, 41);
      this.copyrightLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.copyrightLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.copyrightLabel.Text = "Copyright";
      this.copyrightLabel.TextSize = new System.Drawing.Size(57, 17);
      // 
      // brandPanelLayout
      // 
      this.brandPanelLayout.Control = this.brandPanel;
      this.brandPanelLayout.Location = new System.Drawing.Point(0, 0);
      this.brandPanelLayout.Name = "brandPanelLayout";
      this.brandPanelLayout.Size = new System.Drawing.Size(480, 258);
      this.brandPanelLayout.TextSize = new System.Drawing.Size(0, 0);
      this.brandPanelLayout.TextVisible = false;
      // 
      // Loading
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 319);
      this.Controls.Add(this.layoutControl);
      this.Name = "Loading";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.brandPanel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandPanelLayout)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup root;
        private DevExpress.XtraLayout.SimpleLabelItem copyrightLabel;
    private DevExpress.XtraEditors.PanelControl brandPanel;
    private DevExpress.XtraLayout.LayoutControlItem brandPanelLayout;
  }
}
