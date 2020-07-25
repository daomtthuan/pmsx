namespace PMSX.View.Form {
  partial class Main {
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
      DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PMSX.View.Form.Loading), true, true, true);
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.panelControl = new DevExpress.XtraEditors.PanelControl();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.Margin = new System.Windows.Forms.Padding(2);
      this.ribbon.MaxItemId = 1;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbon.Size = new System.Drawing.Size(960, 170);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "ribbonPageGroup1";
      // 
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 663);
      this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new System.Drawing.Size(960, 26);
      // 
      // panelControl
      // 
      this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControl.Location = new System.Drawing.Point(0, 170);
      this.panelControl.Name = "panelControl";
      this.panelControl.Size = new System.Drawing.Size(960, 493);
      this.panelControl.TabIndex = 2;
      // 
      // splashScreenManager
      // 
      splashScreenManager.ClosingDelay = 1000;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(960, 689);
      this.Controls.Add(this.panelControl);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.ribbon);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Main";
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "PMSX";
      this.Load += new System.EventHandler(this.Main_LoadAsync);
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraEditors.PanelControl panelControl;
  }
}