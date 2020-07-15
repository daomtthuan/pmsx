using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Staff : XtraUserControl {
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

    public Staff() {
      InitializeComponent();
      Controls.Add(new StaffTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
