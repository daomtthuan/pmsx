using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Session : XtraUserControl {
    private class SessionTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách phiên làm việc";
      }

      protected override void OnLoad() {
        GridControl.DataSource = Controller.Session.Instance.SelectAll().Select(item => new {
          item.Id,
          item.Name,
          TechnicianName = item.GetTechnician().Name,
          DoctorName = item.GetDoctor().Name,
          item.CreateDatetime,
          item.UpdateDatetime,
          State = item.State == 0 ? "Vô hiệu hoá" : "Kích hoạt"
        });
        GridView.PopulateColumns();
        GridView.Columns["Id"].Caption = "Mã định danh";
        GridView.Columns["Id"].Visible = false;
        GridView.Columns["Name"].Caption = "Tên";
        GridView.Columns["TechnicianName"].Caption = "Kỹ thuật viên";
        GridView.Columns["DoctorName"].Caption = "Bác sĩ";
        GridView.Columns["CreateDatetime"].Caption = "Ngày tạo";
        GridView.Columns["UpdateDatetime"].Caption = "Ngày sửa";
        GridView.Columns["State"].Caption = "Trạng thái";
      }

      protected override void OnInsert() {
        new Form.Insert.Session().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        throw new NotImplementedException();
      }

      protected override void OnDisabled() {
        throw new NotImplementedException();
      }

      protected override void RowStyle(RowStyleEventArgs e) {
        if (e.RowHandle >= 0) {
          if (GridView.GetRowCellValue(e.RowHandle, "State").ToString() == "Vô hiệu hoá") {
            e.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
          }
        }
      }
    }

    public Session() {
      InitializeComponent();
      Controls.Add(new SessionTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
