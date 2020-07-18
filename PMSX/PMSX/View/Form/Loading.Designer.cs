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
      this.brand1 = new PMSX.View.UserControl.Brand();
      this.root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.copyrightLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.brand1);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.root;
      this.layoutControl.Size = new System.Drawing.Size(515, 292);
      this.layoutControl.TabIndex = 10;
      this.layoutControl.Text = "layoutControl1";
      // 
      // brand1
      // 
      this.brand1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
      this.brand1.Appearance.Options.UseBackColor = true;
      this.brand1.Location = new System.Drawing.Point(12, 12);
      this.brand1.Name = "brand1";
      this.brand1.Size = new System.Drawing.Size(491, 234);
      this.brand1.TabIndex = 4;
      // 
      // root
      // 
      this.root.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
      this.root.AppearanceGroup.Options.UseBackColor = true;
      this.root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.root.GroupBordersVisible = false;
      this.root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.copyrightLabel,
            this.layoutControlItem1});
      this.root.Name = "root";
      this.root.Size = new System.Drawing.Size(515, 292);
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
      this.copyrightLabel.Location = new System.Drawing.Point(0, 238);
      this.copyrightLabel.MinSize = new System.Drawing.Size(419, 21);
      this.copyrightLabel.Name = "copyrightLabel";
      this.copyrightLabel.Size = new System.Drawing.Size(495, 34);
      this.copyrightLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.copyrightLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.copyrightLabel.Text = "Copyright";
      this.copyrightLabel.TextSize = new System.Drawing.Size(57, 17);
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.brand1;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(495, 238);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // Loading
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(515, 292);
      this.Controls.Add(this.layoutControl);
      this.Name = "Loading";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup root;
        private DevExpress.XtraLayout.SimpleLabelItem copyrightLabel;
    private UserControl.Brand brand1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
  }
}
