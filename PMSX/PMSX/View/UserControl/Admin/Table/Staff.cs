using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class Staff : Pattern.Class.UserControl {
    private class StaffTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhân viên";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Staff.Instance.SelectAll(), new[] {
          "Username", "Name", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Admin.Insert.Staff().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.Staff((Model.Staff)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.Staff.Instance.Disable(((Model.Staff)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
        OnLoad();
      }
    }

    public Staff() {
      InitializeComponent();
      Controls.Add(new StaffTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
