using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class Role : Pattern.Class.UserControl {
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
        new Form.Admin.Insert.Role().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.Role((Model.Role)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.Role.Instance.Disable(((Model.Role)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
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
