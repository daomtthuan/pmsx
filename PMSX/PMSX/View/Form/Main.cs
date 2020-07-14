using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSX.View.Form {
  public partial class Main : RibbonForm {
    private readonly PanelControl panelControl;
    private readonly Login loginForm;

    public Main() {
      InitializeComponent();
      Display = false;

      Icon = Properties.Resources.icon;

      panelControl = new PanelControl() {
        Dock = DockStyle.Fill
      };
      Controls.Add(panelControl);

      loginForm = new Login();
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

    private void AddUserControl(XtraUserControl userControl) {
      if (panelControl.Controls.Count > 0) {
        panelControl.Controls[0].Dispose();
        panelControl.Controls.Clear();
      }
      panelControl.Controls.Add(userControl);
    }

    private async void Main_Load(object sender, System.EventArgs e) {
      await Task.Delay(2000);

      loginForm.ShowDialog();

      if (Controller.Main.Instance.Staff == null) {
        Application.Exit();
      } else {
        if (Controller.Main.Instance.Roles.Where(item => item.Name == "Quản trị viên").Count() != 1) {
          adminPageGroup.Dispose();

          List<Model.Session> sessions = Controller.Session.Instance.SelectAll(1);
          if (sessions.Count == 0) {
            Util.View.MessageBox.Instance.Warning("Không thể truy cập hệ thống.\nHiện tại không có phiên làm việc nào.");
            Application.Exit();
          } else {
            SelectSession selectSessionForm = new SelectSession(sessions);
            selectSessionForm.ShowDialog();
            Display = true;
          }
        } else {
          Display = true;
        }
      }
    }

    private void ExitButton_Click(object sender, BackstageViewItemEventArgs e) {
      Application.Exit();
    }

    private void LogoutButton_Click(object sender, BackstageViewItemEventArgs e) {
      Application.Restart();
    }

    private void StaffButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl(new UserControl.Component.Table.Staff() {
        Dock = DockStyle.Fill
      });
    }

    private void RoleButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl(new UserControl.Component.Table.Role() {
        Dock = DockStyle.Fill
      });
    }

    private void PermissionButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl(new UserControl.Component.Table.Permission() {
        Dock = DockStyle.Fill
      });
    }

    private void PatientButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl(new UserControl.Component.Table.Patient() {
        Dock = DockStyle.Fill
      });
    }

    private void SessionButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl(new UserControl.Component.Table.Session() {
        Dock = DockStyle.Fill
      });
    }

    private void BiopsyButton_Click(object sender, ItemClickEventArgs e) {
      AddUserControl(new UserControl.Component.Table.Biopsy() {
        Dock = DockStyle.Fill
      });
    }

    private void BiopsyGroupButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl(new UserControl.Component.Table.BiopsyGroup() {
        Dock = DockStyle.Fill
      });
    }

    private void Diagnose1Button_ItemClick(object sender, ItemClickEventArgs e) {

    }

    private void Diagnose2Button_ItemClick(object sender, ItemClickEventArgs e) {

    }

    private void Diagnose3Button_ItemClick(object sender, ItemClickEventArgs e) {

    }

    private void MacroGroupButton_ItemClick(object sender, ItemClickEventArgs e) {
      AddUserControl(new UserControl.Component.Table.MacroGroup() {
        Dock = DockStyle.Fill
      });
    }

    private void MacroButton_ItemClick(object sender, ItemClickEventArgs e) {

    }

    private void MicroGroupButton_ItemClick(object sender, ItemClickEventArgs e) {
        AddUserControl(new UserControl.Component.Table.MicroGroup() {
        Dock = DockStyle.Fill
      });
    }

    private void MicroButton_ItemClick(object sender, ItemClickEventArgs e) {

    }
  }
}