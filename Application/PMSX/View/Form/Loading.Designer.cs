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
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.brand1 = new PMSX.View.Control.Brand();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.copyrightLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.Controls.Add(this.brand1);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(471, 275);
      this.layoutControl.TabIndex = 0;
      this.layoutControl.Text = "layoutControl1";
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.copyrightLabel});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(471, 275);
      this.Root.TextVisible = false;
      // 
      // brand1
      // 
      this.brand1.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.brand1.Appearance.Options.UseBackColor = true;
      this.brand1.Location = new System.Drawing.Point(12, 12);
      this.brand1.Name = "brand1";
      this.brand1.Size = new System.Drawing.Size(447, 229);
      this.brand1.TabIndex = 4;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.brand1;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(451, 233);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // copyrightLabel
      // 
      this.copyrightLabel.AllowHotTrack = false;
      this.copyrightLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.copyrightLabel.AppearanceItemCaption.Options.UseFont = true;
      this.copyrightLabel.AppearanceItemCaption.Options.UseTextOptions = true;
      this.copyrightLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.copyrightLabel.Location = new System.Drawing.Point(0, 233);
      this.copyrightLabel.Name = "copyrightLabel";
      this.copyrightLabel.Size = new System.Drawing.Size(451, 22);
      this.copyrightLabel.TextSize = new System.Drawing.Size(119, 18);
      // 
      // Loading
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(471, 275);
      this.Controls.Add(this.layoutControl);
      this.Name = "Loading";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.copyrightLabel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl;
    private Control.Brand brand1;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.SimpleLabelItem copyrightLabel;
  }
}
