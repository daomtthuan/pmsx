using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class BiopsyGroup : XtraUserControl {
    private class BiopsyGroupTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhóm sinh thiết";
      }

      protected override void OnLoad() {
        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.BiopsyGroup.Instance.SelectAll(), new[] {
          "Username", "Name", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Insert.Staff().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        new Form.Update.Staff((Model.Staff)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        Controller.Staff.Instance.Disable(((Model.Staff)GetSelectedRow()).Id);
        OnLoad();
      }
    }

    public BiopsyGroup() {
      InitializeComponent();
      Controls.Add(new BiopsyGroupTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
