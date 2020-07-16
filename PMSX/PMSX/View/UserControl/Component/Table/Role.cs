using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Role : XtraUserControl {
    private class RoleTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách quyền";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Role.Instance.SelectAll(), new[] {
          "Name", "TechnicianName", "DoctorName", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Insert.Role().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        if (GetSelectedRow() == null) {
          return;
        }

        new Form.Update.Role((Model.Role)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (GetSelectedRow() == null) {
          return;
        }

        Controller.Role.Instance.Disable(((Model.Role)GetSelectedRow()).Id);
        OnLoad();
      }
    }

    public Role() {
      InitializeComponent();

      Controls.Add(new RoleTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
