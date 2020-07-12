using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Role : XtraUserControl {
    private class RoleTable : Layout.Table {
      private List<Model.Role> data;

      protected override void OnInit() {
        TitleLabel.Text = "Danh sách quyền";
      }

      protected override void OnLoad() {
        data = Controller.Role.Instance.SelectAll();
        GridControl.DataSource = data.Select(item => new {
          item.Id,
          item.Name,
          item.CreateDatetime,
          item.UpdateDatetime,
          State = item.State == 0 ? "Vô hiệu hoá" : "Kích hoạt"
        });
        GridView.PopulateColumns();
        GridView.Columns["Id"].Caption = "Mã định danh";
        GridView.Columns["Id"].Visible = false;
        GridView.Columns["Name"].Caption = "Tên";
        GridView.Columns["CreateDatetime"].Caption = "Ngày tạo";
        GridView.Columns["UpdateDatetime"].Caption = "Ngày sửa";
        GridView.Columns["State"].Caption = "Trạng thái";
      }

      protected override void OnInsert() {
        new Form.Insert.Role().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        new Form.Update.Role(data.Where(item => item.Id == SelectedId).First()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        Controller.Role.Instance.Disabled(SelectedId);
        OnLoad();
      }

      protected override void RowStyle(RowStyleEventArgs e) {
        if (e.RowHandle >= 0) {
          if (GridView.GetRowCellValue(e.RowHandle, "State").ToString() == "Vô hiệu hoá") {
            e.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
          }
        }
      }
    }

    public Role() {
      InitializeComponent();

      Controls.Add(new RoleTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
