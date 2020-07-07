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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new DevExpress.XtraEditors.SimpleButton();
            this.sessionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sessionLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.startLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.titleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.enSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.viSubTitleLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.logoLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.pictureBox1);
            this.layoutControl.Controls.Add(this.startButton);
            this.layoutControl.Controls.Add(this.sessionLookUpEdit);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(616, 347);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMSX.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.startButton.Appearance.Options.UseBackColor = true;
            this.startButton.Location = new System.Drawing.Point(12, 300);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(591, 35);
            this.startButton.StyleController = this.layoutControl;
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Bắt đầu";
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // sessionLookUpEdit
            // 
            this.sessionLookUpEdit.Location = new System.Drawing.Point(12, 257);
            this.sessionLookUpEdit.Name = "sessionLookUpEdit";
            this.sessionLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.sessionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sessionLookUpEdit.Properties.ImmediatePopup = true;
            this.sessionLookUpEdit.Properties.NullText = "";
            this.sessionLookUpEdit.Properties.PopupSizeable = false;
            this.sessionLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.sessionLookUpEdit.Size = new System.Drawing.Size(592, 28);
            this.sessionLookUpEdit.StyleController = this.layoutControl;
            this.sessionLookUpEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sessionLayout,
            this.startLayout,
            this.emptySpaceItem,
            this.titleLabel,
            this.emptySpaceItem1,
            this.logoLayout,
            this.enSubTitleLabel,
            this.viSubTitleLabel});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(616, 347);
            this.Root.TextVisible = false;
            // 
            // sessionLayout
            // 
            this.sessionLayout.Control = this.sessionLookUpEdit;
            this.sessionLayout.Location = new System.Drawing.Point(0, 221);
            this.sessionLayout.MaxSize = new System.Drawing.Size(0, 56);
            this.sessionLayout.MinSize = new System.Drawing.Size(419, 56);
            this.sessionLayout.Name = "sessionLayout";
            this.sessionLayout.Size = new System.Drawing.Size(596, 56);
            this.sessionLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.sessionLayout.Text = "Phiên làm việc";
            this.sessionLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.sessionLayout.TextSize = new System.Drawing.Size(415, 21);
            // 
            // startLayout
            // 
            this.startLayout.Control = this.startButton;
            this.startLayout.Location = new System.Drawing.Point(0, 288);
            this.startLayout.MaxSize = new System.Drawing.Size(595, 39);
            this.startLayout.MinSize = new System.Drawing.Size(595, 39);
            this.startLayout.Name = "startLayout";
            this.startLayout.Size = new System.Drawing.Size(596, 39);
            this.startLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.startLayout.TextSize = new System.Drawing.Size(0, 0);
            this.startLayout.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 277);
            this.emptySpaceItem.MaxSize = new System.Drawing.Size(595, 11);
            this.emptySpaceItem.MinSize = new System.Drawing.Size(595, 11);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(596, 11);
            this.emptySpaceItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // titleLabel
            // 
            this.titleLabel.AllowHotTrack = false;
            this.titleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.titleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.titleLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.titleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.titleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.titleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.titleLabel.Location = new System.Drawing.Point(0, 104);
            this.titleLabel.MaxSize = new System.Drawing.Size(0, 49);
            this.titleLabel.MinSize = new System.Drawing.Size(419, 49);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(596, 49);
            this.titleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.titleLabel.Text = "PMSX";
            this.titleLabel.TextSize = new System.Drawing.Size(415, 45);
            // 
            // enSubTitleLabel
            // 
            this.enSubTitleLabel.AllowHotTrack = false;
            this.enSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.enSubTitleLabel.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseForeColor = true;
            this.enSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.enSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.enSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.enSubTitleLabel.Location = new System.Drawing.Point(0, 153);
            this.enSubTitleLabel.MaxSize = new System.Drawing.Size(0, 29);
            this.enSubTitleLabel.MinSize = new System.Drawing.Size(419, 29);
            this.enSubTitleLabel.Name = "enSubTitleLabel";
            this.enSubTitleLabel.Size = new System.Drawing.Size(596, 29);
            this.enSubTitleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.enSubTitleLabel.Text = "PATHOLOGY MANAGEMENT SYSTEM";
            this.enSubTitleLabel.TextSize = new System.Drawing.Size(415, 25);
            // 
            // viSubTitleLabel
            // 
            this.viSubTitleLabel.AllowHotTrack = false;
            this.viSubTitleLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viSubTitleLabel.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseFont = true;
            this.viSubTitleLabel.AppearanceItemCaption.Options.UseTextOptions = true;
            this.viSubTitleLabel.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viSubTitleLabel.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.viSubTitleLabel.Location = new System.Drawing.Point(0, 182);
            this.viSubTitleLabel.MaxSize = new System.Drawing.Size(0, 29);
            this.viSubTitleLabel.MinSize = new System.Drawing.Size(419, 29);
            this.viSubTitleLabel.Name = "viSubTitleLabel";
            this.viSubTitleLabel.Size = new System.Drawing.Size(596, 29);
            this.viSubTitleLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.viSubTitleLabel.Text = "HỆ THỐNG QUẢN LÝ KẾT QUẢ GIẢI PHẪU BỆNH";
            this.viSubTitleLabel.TextSize = new System.Drawing.Size(415, 25);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 211);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(498, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(498, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(596, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // logoLayout
            // 
            this.logoLayout.Control = this.pictureBox1;
            this.logoLayout.Location = new System.Drawing.Point(0, 0);
            this.logoLayout.MinSize = new System.Drawing.Size(104, 24);
            this.logoLayout.Name = "logoLayout";
            this.logoLayout.Size = new System.Drawing.Size(596, 104);
            this.logoLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.logoLayout.TextSize = new System.Drawing.Size(0, 0);
            this.logoLayout.TextVisible = false;
            // 
            // SelectSession
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 347);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMSX - Chọn phiên làm việc";
            this.Load += new System.EventHandler(this.SelectSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viSubTitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem sessionLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraEditors.SimpleButton startButton;
        private DevExpress.XtraLayout.LayoutControlItem startLayout;
        private DevExpress.XtraEditors.LookUpEdit sessionLookUpEdit;
        private DevExpress.XtraLayout.SimpleLabelItem titleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem enSubTitleLabel;
        private DevExpress.XtraLayout.SimpleLabelItem viSubTitleLabel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraLayout.LayoutControlItem logoLayout;
    }
}