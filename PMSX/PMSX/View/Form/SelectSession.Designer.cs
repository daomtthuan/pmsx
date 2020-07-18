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
      this.brand1 = new PMSX.View.UserControl.Brand();
      this.startButton = new DevExpress.XtraEditors.SimpleButton();
      this.sessionSelect = new DevExpress.XtraEditors.LookUpEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.sessionSelectLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.startButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.insertButton = new DevExpress.XtraEditors.SimpleButton();
      this.insertButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.startButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.brand1);
      this.layoutControl.Controls.Add(this.startButton);
      this.layoutControl.Controls.Add(this.sessionSelect);
      this.layoutControl.Controls.Add(this.insertButton);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(398, 397);
      this.layoutControl.TabIndex = 0;
      this.layoutControl.Text = "layoutControl";
      // 
      // brand1
      // 
      this.brand1.Location = new System.Drawing.Point(12, 12);
      this.brand1.Name = "brand1";
      this.brand1.Size = new System.Drawing.Size(374, 267);
      this.brand1.TabIndex = 6;
      this.brand1.TabStop = false;
      // 
      // startButton
      // 
      this.startButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.startButton.Appearance.Options.UseBackColor = true;
      this.startButton.Location = new System.Drawing.Point(201, 349);
      this.startButton.Name = "startButton";
      this.startButton.Padding = new System.Windows.Forms.Padding(5);
      this.startButton.Size = new System.Drawing.Size(185, 36);
      this.startButton.StyleController = this.layoutControl;
      this.startButton.TabIndex = 5;
      this.startButton.Text = "Bắt đầu";
      this.startButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // sessionSelect
      // 
      this.sessionSelect.Location = new System.Drawing.Point(12, 307);
      this.sessionSelect.Name = "sessionSelect";
      this.sessionSelect.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
      this.sessionSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.sessionSelect.Properties.ImmediatePopup = true;
      this.sessionSelect.Properties.NullText = "";
      this.sessionSelect.Properties.PopupSizeable = false;
      this.sessionSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
      this.sessionSelect.Size = new System.Drawing.Size(374, 28);
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
            this.layoutControlItem1,
            this.insertButtonLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(398, 397);
      this.Root.TextVisible = false;
      // 
      // sessionSelectLayout
      // 
      this.sessionSelectLayout.Control = this.sessionSelect;
      this.sessionSelectLayout.Location = new System.Drawing.Point(0, 271);
      this.sessionSelectLayout.Name = "sessionSelectLayout";
      this.sessionSelectLayout.Size = new System.Drawing.Size(378, 56);
      this.sessionSelectLayout.Text = "Phiên làm việc";
      this.sessionSelectLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.sessionSelectLayout.TextSize = new System.Drawing.Size(103, 21);
      // 
      // startButtonLayout
      // 
      this.startButtonLayout.Control = this.startButton;
      this.startButtonLayout.Location = new System.Drawing.Point(189, 327);
      this.startButtonLayout.Name = "startButtonLayout";
      this.startButtonLayout.Size = new System.Drawing.Size(189, 50);
      this.startButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.startButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.startButtonLayout.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.brand1;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(378, 271);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // insertButton
      // 
      this.insertButton.Location = new System.Drawing.Point(12, 349);
      this.insertButton.Name = "insertButton";
      this.insertButton.Padding = new System.Windows.Forms.Padding(5);
      this.insertButton.Size = new System.Drawing.Size(185, 36);
      this.insertButton.StyleController = this.layoutControl;
      this.insertButton.TabIndex = 7;
      this.insertButton.Text = "Thêm";
      this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
      // 
      // insertButtonLayout
      // 
      this.insertButtonLayout.Control = this.insertButton;
      this.insertButtonLayout.Location = new System.Drawing.Point(0, 327);
      this.insertButtonLayout.Name = "insertButtonLayout";
      this.insertButtonLayout.Size = new System.Drawing.Size(189, 50);
      this.insertButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.insertButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.insertButtonLayout.TextVisible = false;
      // 
      // SelectSession
      // 
      this.AcceptButton = this.startButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(398, 397);
      this.Controls.Add(this.layoutControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "SelectSession";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Chọn phiên làm việc";
      this.Load += new System.EventHandler(this.SelectSession_Load);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelect.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sessionSelectLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.startButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem sessionSelectLayout;
        private DevExpress.XtraEditors.SimpleButton startButton;
        private DevExpress.XtraLayout.LayoutControlItem startButtonLayout;
        private DevExpress.XtraEditors.LookUpEdit sessionSelect;
    private UserControl.Brand brand1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.SimpleButton insertButton;
    private DevExpress.XtraLayout.LayoutControlItem insertButtonLayout;
  }
}