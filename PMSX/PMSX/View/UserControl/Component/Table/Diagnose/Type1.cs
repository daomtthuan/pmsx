using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Type1 : XtraUserControl {
    private class DiagnoseTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách kết quả chẩn đoán loại 1";
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

    public Type1() {
      InitializeComponent();
      Controls.Add(new DiagnoseTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
