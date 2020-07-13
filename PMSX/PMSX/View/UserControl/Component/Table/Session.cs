using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Session : XtraUserControl {
    private class SessionTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách phiên làm việc";
      }

      protected override void OnLoad() {
        List<Model.Session> sessions = Controller.Session.Instance.SelectAll();
        GridControl.DataSource = sessions;
        GridView.PopulateColumns();

        foreach (GridColumn column in GridView.Columns) {
          column.Caption = Util.Locale.Instance.Caption[column.FieldName];
          column.Visible =
            column.FieldName == "Name" ||
            column.FieldName == "State" ||
            column.FieldName == "TechnicianName" ||
            column.FieldName == "DoctorName" ||
            column.FieldName == "State" ||
            column.FieldName == "CreateDatetime" ||
            column.FieldName == "UpdateDatetime";
        }
      }

      protected override void OnInsert() {
        List<Model.Role> technicianRoles = Controller.Role.Instance.SelectByName("Kỹ thuật viên");
        if (technicianRoles.Count == 0) {
          Util.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy quyền Kỹ thuật viên.");
        } else {
          List<Model.Role> doctorRoles = Controller.Role.Instance.SelectByName("Bác sĩ");
          if (doctorRoles.Count == 0) {
            Util.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy quyền Bác sĩ.");
          } else {
            List<Model.Staff> technicians = Controller.Staff.Instance.SelectByRoleId(technicianRoles[0].Id);
            if (technicians.Count == 0) {
              Util.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy nhân viên có quyền Kỹ thuật viên.");
            } else {
              List<Model.Staff> doctors = Controller.Staff.Instance.SelectByRoleId(doctorRoles[0].Id);
              if (doctors.Count == 0) {
                Util.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy nhân viên có quyền Bác sĩ.");
              } else {                
                new Form.Insert.Session(technicians, doctors).ShowDialog();
                OnLoad();
              }
            }
          }
        }
      }

      protected override void OnUpdate() {
        List<Model.Role> technicianRoles = Controller.Role.Instance.SelectByName("Kỹ thuật viên");
        if (technicianRoles.Count == 0) {
          Util.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy quyền Kỹ thuật viên.");
        } else {
          List<Model.Role> doctorRoles = Controller.Role.Instance.SelectByName("Bác sĩ");
          if (doctorRoles.Count == 0) {
            Util.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy quyền Bác sĩ.");
          } else {
            List<Model.Staff> technicians = Controller.Staff.Instance.SelectByRoleId(technicianRoles[0].Id);
            if (technicians.Count == 0) {
              Util.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy nhân viên có quyền Kỹ thuật viên.");
            } else {
              List<Model.Staff> doctors = Controller.Staff.Instance.SelectByRoleId(doctorRoles[0].Id);
              if (doctors.Count == 0) {
                Util.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy nhân viên có quyền Bác sĩ.");
              } else {
                new Form.Update.Session((Model.Session)GetSelectedRow(), technicians, doctors).ShowDialog();
                OnLoad();
              }
            }
          }
        }        
      }

      protected override void OnDisabled() {
        throw new NotImplementedException();
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
