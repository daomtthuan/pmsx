using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class MacroGroup : Pattern.Class.UserControl {
    private class MacroGroupTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhóm đại thể";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.MacroGroup.Instance.SelectAll(), new[] {
          "Code", "Name", "State", "CreateDatetime",  "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Admin.Insert.MacroGroup().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.MacroGroup((Model.MacroGroup)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.MacroGroup.Instance.Disable(((Model.MacroGroup)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
        OnLoad();
      }
    }

    public MacroGroup() {
      InitializeComponent();
      Controls.Add(new MacroGroupTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}