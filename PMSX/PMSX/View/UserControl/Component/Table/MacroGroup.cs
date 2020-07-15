using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class MacroGroup : XtraUserControl {
    private class MacroGroupTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhóm đại thể";
      }

      protected override void OnLoad() {
        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.MacroGroup.Instance.SelectAll(), new[] {
          "Code", "Name", "State", "CreateDatetime",  "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Insert.MacroGroup().ShowDialog();
        OnLoad();
        // throw new NotImplementedException();
      }

      protected override void OnUpdate() {
        new Form.Update.MacroGroup((Model.MacroGroup)GetSelectedRow()).ShowDialog();
        OnLoad();
        //throw new NotImplementedException();
      }

      protected override void OnDisabled() {
        Controller.MacroGroup.Instance.Disable(((Model.MacroGroup)GetSelectedRow()).Id);
        OnLoad();
        //throw new NotImplementedException();
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