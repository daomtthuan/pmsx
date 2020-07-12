namespace PMSX.View.Form {
    partial class SelectSession {
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
      this.startButton = new DevExpress.XtraEditors.SimpleButton();
      this.sessionSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.sessionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.startButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.brandPanelLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.brandPanel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.startButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandPanelLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.brandPanel);
      this.layoutControl.Controls.Add(this.startButton);
      this.layoutControl.Controls.Add(this.sessionSelect);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(500, 384);
      this.layoutControl.TabIndex = 0;
      this.layoutControl.Text = "layoutControl";
      // 
      // brandPanel
      // 
      this.brandPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.brandPanel.Location = new System.Drawing.Point(12, 12);
      this.brandPanel.Name = "brandPanel";
      this.brandPanel.Size = new System.Drawing.Size(476, 254);
      this.brandPanel.TabIndex = 12;
      // 
      // startButton
      // 
      this.startButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.startButton.Appearance.Options.UseBackColor = true;
      this.startButton.Location = new System.Drawing.Point(12, 336);
      this.startButton.Name = "startButton";
      this.startButton.Padding = new System.Windows.Forms.Padding(5);
      this.startButton.Size = new System.Drawing.Size(476, 36);
      this.startButton.StyleController = this.layoutControl;
      this.startButton.TabIndex = 5;
      this.startButton.Text = "Bắt đầu";
      this.startButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // sessionSelect
      // 
      this.sessionSelect.Location = new System.Drawing.Point(12, 294);
      this.sessionSelect.Name = "sessionSelect";
      this.sessionSelect.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
      this.sessionSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.sessionSelect.Properties.ImmediatePopup = true;
      this.sessionSelect.Properties.NullText = "";
      this.sessionSelect.Properties.PopupSizeable = false;
      this.sessionSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
      this.sessionSelect.Size = new System.Drawing.Size(476, 28);
      this.sessionSelect.StyleController = this.layoutControl;
      this.sessionSelect.TabIndex = 4;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sessionSelectLayout,
            this.startButtonLayout,
            this.brandPanelLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(500, 384);
      this.Root.TextVisible = false;
      // 
      // sessionSelectLayout
      // 
      this.sessionSelectLayout.Control = this.sessionSelect;
      this.sessionSelectLayout.Location = new System.Drawing.Point(0, 258);
      this.sessionSelectLayout.Name = "sessionSelectLayout";
      this.sessionSelectLayout.Size = new System.Drawing.Size(480, 56);
      this.sessionSelectLayout.Text = "Phiên làm việc";
      this.sessionSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.sessionSelectLayout.TextSize = new System.Drawing.Size(103, 21);
      // 
      // startButtonLayout
      // 
      this.startButtonLayout.Control = this.startButton;
      this.startButtonLayout.Location = new System.Drawing.Point(0, 314);
      this.startButtonLayout.Name = "startButtonLayout";
      this.startButtonLayout.Size = new System.Drawing.Size(480, 50);
      this.startButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.startButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.startButtonLayout.TextVisible = false;
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
      // SelectSession
      // 
      this.AcceptButton = this.startButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 384);
      this.Controls.Add(this.layoutControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "SelectSession";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Chọn phiên làm việc";
      this.Load += new System.EventHandler(this.SelectSession_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.brandPanel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.startButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandPanelLayout)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem sessionSelectLayout;
        private DevExpress.XtraEditors.SimpleButton startButton;
        private DevExpress.XtraLayout.LayoutControlItem startButtonLayout;
        private DevExpress.XtraEditors.LookUpEdit sessionSelect;
    private DevExpress.XtraEditors.PanelControl brandPanel;
    private DevExpress.XtraLayout.LayoutControlItem brandPanelLayout;
  }
}