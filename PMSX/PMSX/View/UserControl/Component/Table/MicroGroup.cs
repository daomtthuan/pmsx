using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class MicroGroup : XtraUserControl {
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
        new Form.Insert.MicroGroup().ShowDialog();
        OnLoad();
        // throw new NotImplementedException();
      }

      protected override void OnUpdate() {
        if (GetSelectedRow() == null) {
          return;
        }
        new Form.Update.MicroGroup((Model.MicroGroup)GetSelectedRow()).ShowDialog();
        OnLoad();
        //throw new NotImplementedException();
      }

      protected override void OnDisabled() {
        if (GetSelectedRow() == null) {
          return;
        }
        Controller.MicroGroup.Instance.Disable(((Model.MicroGroup)GetSelectedRow()).Id);
        OnLoad();
        //throw new NotImplementedException();
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