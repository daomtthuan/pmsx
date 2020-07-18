using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class MicroGroup : XtraUserControl, Pattern.Interface.IView {
    private class MicroGroupTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhóm vi thể";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.MicroGroup.Instance.SelectAll(), new[] {
          "Code", "Name", "State", "CreateDatetime",  "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Admin.Insert.MicroGroup().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.MicroGroup((Model.MicroGroup)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.MicroGroup.Instance.Disable(((Model.MicroGroup)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
        OnLoad();
      }
    }

    public MicroGroup() {
      InitializeComponent();
      Controls.Add(new MicroGroupTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}