using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class BiopsyGroup : XtraUserControl, Pattern.Interface.IView {
    private class BiopsyGroupTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhóm sinh thiết";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.BiopsyGroup.Instance.SelectAll(), new[] {
          "Code", "NumberBiopsy", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Admin.Insert.BiopsyGroup().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.BiopsyGroup((Model.BiopsyGroup)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.BiopsyGroup.Instance.Disable(((Model.BiopsyGroup)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
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
