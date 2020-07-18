using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class Staff : XtraUserControl, Pattern.Interface.IView {
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
        if (GetSelectedRow() == null) {
          return;
        }

        new Form.Admin.Update.Staff((Model.Staff)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (GetSelectedRow() == null) {
          return;
        }

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
