using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  public partial class BiopsyGroup : XtraUserControl {
    private class BiopsyGroupTable : Layout {
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
        if (GetSelectedRow() == null) {
          return;
        }

        new Form.Admin.Update.BiopsyGroup((Model.BiopsyGroup)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (GetSelectedRow() == null) {
          return;
        }

        Controller.BiopsyGroup.Instance.Disable(((Model.BiopsyGroup)GetSelectedRow()).Id);
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
