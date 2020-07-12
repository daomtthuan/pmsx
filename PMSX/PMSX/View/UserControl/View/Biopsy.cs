using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.View {
  public partial class Biopsy : XtraUserControl {
    private class BiopsyTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách mẫu sinh thiết";
      }

      protected override void OnLoad() {
        //GridControl.DataSource = Controller.Biopsy.Instance.GetList();
        //GridView.PopulateColumns();
        //GridView.Columns["Id"].Visible = false;
        //GridView.Columns["FullCode"].Caption = "Mã số";
        //GridView.Columns["PatientName"].Caption = "Bệnh nhân";
        //GridView.Columns["TechnicianName"].Caption = "Kỹ thuật viên";
        //GridView.Columns["DoctorName"].Caption = "Bác sĩ";
        //GridView.Columns["GrossStaffName"].Caption = "Nhân viên gọt";
        //GridView.Columns["NumberSegment"].Caption = "Số phân thùy";
        //GridView.Columns["GrossDatetime"].Caption = "Ngày cắt";
        //GridView.Columns["CollectDatetime"].Caption = "Ngày thu thập";
        //GridView.Columns["Comment"].Caption = "Ghi chú";
        //GridView.Columns["State"].Caption = "Trạng thái";
        //GridView.Columns["CreateDatetime"].Caption = "Ngày tạo";
        //GridView.Columns["UpdateDatetime"].Caption = "Ngày sửa";
      }

      protected override void OnInsert() {
        throw new NotImplementedException();
      }

      protected override void OnUpdate() {
        throw new NotImplementedException();
      }

      protected override void OnDisabled() {
        throw new NotImplementedException();
      }
    }

    public Biopsy() {
      InitializeComponent();
      Controls.Add(new BiopsyTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
