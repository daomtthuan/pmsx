using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  public partial class MacroGroup : XtraUserControl {
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
        if (GetSelectedRow() == null) {
          return;
        }

        new Form.Admin.Update.MacroGroup((Model.MacroGroup)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (GetSelectedRow() == null) {
          return;
        }

        Controller.MacroGroup.Instance.Disable(((Model.MacroGroup)GetSelectedRow()).Id);
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