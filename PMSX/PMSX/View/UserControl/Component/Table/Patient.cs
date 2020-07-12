using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Patient : XtraUserControl {
    private class PatientTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách bệnh nhân";
      }

      protected override void OnLoad() {
        GridControl.DataSource = Controller.Patient.Instance.SelectAll();
        GridView.PopulateColumns();
        GridView.Columns["Id"].Visible = false;
        GridView.Columns["Name"].Caption = "Tên";
        GridView.Columns["Year"].Caption = "Năm sinh";
        GridView.Columns["Address"].Caption = "Địa chỉ";
        GridView.Columns["Comment"].Caption = "Ghi chú";
        GridView.Columns["State"].Caption = "Trạng thái";
        GridView.Columns["CreateDatetime"].Caption = "Ngày tạo";
        GridView.Columns["UpdateDatetime"].Caption = "Ngày sửa";

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

    public Patient() {
      InitializeComponent();
      Controls.Add(new PatientTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
