namespace PMSX.View.Form.Insert {
    partial class BiopsyGroup {
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
      this.codeInput = new DevExpress.XtraEditors.TextEdit();
      this.insertButton = new DevExpress.XtraEditors.SimpleButton();
      this.commentInput = new DevExpress.XtraEditors.MemoEdit();
      this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
      this.codeInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.insertButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
      this.requiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.notRequiredLabel = new DevExpress.XtraLayout.SimpleLabelItem();
      this.commentInputLayout = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
      this.layoutControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.codeInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInputLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl
      // 
      this.layoutControl.AllowCustomization = false;
      this.layoutControl.Controls.Add(this.codeInput);
      this.layoutControl.Controls.Add(this.insertButton);
      this.layoutControl.Controls.Add(this.commentInput);
      this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl.Location = new System.Drawing.Point(0, 0);
      this.layoutControl.Name = "layoutControl";
      this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(997, 232, 650, 400);
      this.layoutControl.Root = this.Root;
      this.layoutControl.Size = new System.Drawing.Size(500, 426);
      this.layoutControl.TabIndex = 1;
      this.layoutControl.Text = "layoutControl";
      // 
      // codeInput
      // 
      this.codeInput.Location = new System.Drawing.Point(12, 71);
      this.codeInput.Name = "codeInput";
      this.codeInput.Properties.MaxLength = 100;
      this.codeInput.Size = new System.Drawing.Size(476, 28);
      this.codeInput.StyleController = this.layoutControl;
      this.codeInput.TabIndex = 4;
      // 
      // insertButton
      // 
      this.insertButton.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
      this.insertButton.Appearance.Options.UseBackColor = true;
      this.insertButton.Location = new System.Drawing.Point(12, 378);
      this.insertButton.Name = "insertButton";
      this.insertButton.Padding = new System.Windows.Forms.Padding(5);
      this.insertButton.Size = new System.Drawing.Size(476, 36);
      this.insertButton.StyleController = this.layoutControl;
      this.insertButton.TabIndex = 6;
      this.insertButton.Text = "Thêm";
      this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
      // 
      // commentInput
      // 
      this.commentInput.Location = new System.Drawing.Point(12, 172);
      this.commentInput.Name = "commentInput";
      this.commentInput.Properties.MaxLength = 500;
      this.commentInput.Size = new System.Drawing.Size(476, 192);
      this.commentInput.StyleController = this.layoutControl;
      this.commentInput.TabIndex = 7;
      // 
      // Root
      // 
      this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.Root.GroupBordersVisible = false;
      this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.codeInputLayout,
            this.insertButtonLayout,
            this.requiredLabel,
            this.notRequiredLabel,
            this.commentInputLayout});
      this.Root.Name = "Root";
      this.Root.Size = new System.Drawing.Size(500, 426);
      this.Root.TextVisible = false;
      // 
      // codeInputLayout
      // 
      this.codeInputLayout.Control = this.codeInput;
      this.codeInputLayout.Location = new System.Drawing.Point(0, 35);
      this.codeInputLayout.Name = "codeInputLayout";
      this.codeInputLayout.Size = new System.Drawing.Size(480, 56);
      this.codeInputLayout.Text = "Mã số";
      this.codeInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.codeInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // insertButtonLayout
      // 
      this.insertButtonLayout.Control = this.insertButton;
      this.insertButtonLayout.Location = new System.Drawing.Point(0, 356);
      this.insertButtonLayout.Name = "insertButtonLayout";
      this.insertButtonLayout.Size = new System.Drawing.Size(480, 50);
      this.insertButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
      this.insertButtonLayout.TextSize = new System.Drawing.Size(0, 0);
      this.insertButtonLayout.TextVisible = false;
      // 
      // requiredLabel
      // 
      this.requiredLabel.AllowHotTrack = false;
      this.requiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
      this.requiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.requiredLabel.Location = new System.Drawing.Point(0, 0);
      this.requiredLabel.Name = "requiredLabel";
      this.requiredLabel.Size = new System.Drawing.Size(480, 35);
      this.requiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
      this.requiredLabel.Text = "Thông tin bắt buộc";
      this.requiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // notRequiredLabel
      // 
      this.notRequiredLabel.AllowHotTrack = false;
      this.notRequiredLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold);
      this.notRequiredLabel.AppearanceItemCaption.Options.UseFont = true;
      this.notRequiredLabel.Location = new System.Drawing.Point(0, 91);
      this.notRequiredLabel.Name = "notRequiredLabel";
      this.notRequiredLabel.Size = new System.Drawing.Size(480, 45);
      this.notRequiredLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
      this.notRequiredLabel.Text = "Thông tin không bắt buộc";
      this.notRequiredLabel.TextSize = new System.Drawing.Size(190, 21);
      // 
      // commentInputLayout
      // 
      this.commentInputLayout.Control = this.commentInput;
      this.commentInputLayout.Location = new System.Drawing.Point(0, 136);
      this.commentInputLayout.Name = "commentInputLayout";
      this.commentInputLayout.Size = new System.Drawing.Size(480, 220);
      this.commentInputLayout.Text = "Ghi chú";
      this.commentInputLayout.TextLocation = DevExpress.Utils.Locations.Top;
      this.commentInputLayout.TextSize = new System.Drawing.Size(190, 21);
      // 
      // BiopsyGroup
      // 
      this.AcceptButton = this.insertButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(500, 426);
      this.Controls.Add(this.layoutControl);
      this.MaximizeBox = false;
      this.Name = "BiopsyGroup";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PMSX - Thêm nhóm sinh thiết";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
      this.layoutControl.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.codeInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInput.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.codeInputLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.insertButtonLayout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.requiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.notRequiredLabel)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.commentInputLayout)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.TextEdit codeInput;
        private DevExpress.XtraEditors.SimpleButton insertButton;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem codeInputLayout;
        private DevExpress.XtraLayout.LayoutControlItem insertButtonLayout;
        private DevExpress.XtraEditors.MemoEdit commentInput;
        private DevExpress.XtraLayout.SimpleLabelItem requiredLabel;
        private DevExpress.XtraLayout.SimpleLabelItem notRequiredLabel;
        private DevExpress.XtraLayout.LayoutControlItem commentInputLayout;
    }
}