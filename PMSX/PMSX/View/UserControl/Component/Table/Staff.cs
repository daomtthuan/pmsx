using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Staff : XtraUserControl {
    private class StaffTable : Layout.Table {
      private List<Model.Staff> staffs;

      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhân viên";
      }

      protected override void OnLoad() {
        staffs = Controller.Staff.Instance.SelectAll();
        GridControl.DataSource = staffs.Select(item => new {
          item.Id,
          item.Username,
          item.Name,
          item.CreateDatetime,
          item.UpdateDatetime,
          State = item.State == 0 ? "Vô hiệu hoá" : "Kích hoạt"
        });
        GridView.PopulateColumns();
        GridView.Columns["Id"].Caption = "Mã định danh";
        GridView.Columns["Id"].Visible = false;
        GridView.Columns["Username"].Caption = "Tên đăng nhập";
        GridView.Columns["Name"].Caption = "Tên";
        GridView.Columns["CreateDatetime"].Caption = "Ngày tạo";
        GridView.Columns["UpdateDatetime"].Caption = "Ngày sửa";
        GridView.Columns["State"].Caption = "Trạng thái";
      }

      protected override void OnInsert() {
        new Form.Insert.Staff().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        new Form.Update.Staff(staffs.Where(item => item.Id == SelectedId).First()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        Controller.Staff.Instance.Disabled(SelectedId);
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

    public Staff() {
      InitializeComponent();
      Controls.Add(new StaffTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
