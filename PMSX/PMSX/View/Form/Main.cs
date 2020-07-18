using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSX.View.Form {
  internal partial class Main : RibbonForm {
    private PanelControl panelControl;

    public Main() {
      InitializeComponent();

      managePageGroup.Visible = false;
      personnelPage.Visible = false;
      clinicPage.Visible = false;
      Icon = Properties.Resources.icon;
      Display = false;
    }

    public bool Display {
      get => Visible;
      private set {
        Visible = value;
        ShowInTaskbar = value;
        Opacity = value ? 1 : 0;
        FormBorderEffect = value ? FormBorderEffect.Default : FormBorderEffect.None;
      }
    }

    private void OnLoad() {
      Controls.Add(panelControl = new PanelControl() { Dock = DockStyle.Fill });

      if (Controller.Main.Instance.HasRole(Controller.Main.Role.Doctor)) {
        managePageGroup.Visible = true;
        clinicPage.Visible = true;
      }

      if (Controller.Main.Instance.HasRole(Controller.Main.Role.Technician)) {
        managePageGroup.Visible = true;
      }

      Display = true;
    }

    private void AddUserControl<T>() where T : XtraUserControl, new() {
      Utils.View.Progress.Instance.Start(panelControl, () => {
        if (panelControl.Controls.Count > 0) {
          panelControl.Controls[0].Dispose();
          panelControl.Controls.Clear();
        }

        panelControl.Controls.Add(new T() { Dock = DockStyle.Fill });
      });
    }

    private async void Main_Load(object sender, System.EventArgs e) {
      await Task.Delay(2000);

      new Login().ShowDialog();

      if (Controller.Main.Instance.Staff == null) {
        Application.Exit();
      } else {
        if (!Controller.Main.Instance.HasRole(Controller.Main.Role.Admin)) {
          List<Model.Session> sessions = Controller.Session.Instance.SelectAll(1);
          if (sessions.Count == 0) {
            Utils.View.MessageBox.Instance.Warning("Không thể truy cập hệ thống.\nHiện tại không có phiên làm việc nào.");
            Application.Exit();
            return;
          } else {
            SelectSession selectSessionForm = new SelectSession(sessions);
            selectSessionForm.ShowDialog();
          }
        }

        Utils.View.Progress.Instance.Start(this, OnLoad);
      }
    }

    private void ExitButton_Click(object sender, BackstageViewItemEventArgs e) {
      Application.Exit();
    }

    private void LogoutButton_Click(object sender, BackstageViewItemEventArgs e) {
      Application.Restart();
    }

    private void StaffButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Staff>();
    }

    private void RoleButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Role>();
    }

    private void PermissionButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Permission>();
    }

    private void PatientButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Patient>();
    }

    private void SessionButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Session>();
    }

    private void BiopsyButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Biopsy>();
    }

    private void BiopsyGroupButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.BiopsyGroup>();
    }

    private void DiagnoseType1Button_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Diagnose.Type1>();
    }

    private void MacroGroupButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.MacroGroup>();
    }

    private void MacroButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Macro>();
    }

    private void MicroGroupButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.MicroGroup>();
    }

    private void MicroButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Admin.Table.Micro>();
    }

    private void CollectBiopsyButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Technician.CollectBiopsy>();
    }

    private void InputDiagnoseType1Button_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl<UserControl.Doctor.InputDiagnose.Type1>();
    }
  }
}