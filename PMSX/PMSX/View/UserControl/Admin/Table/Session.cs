using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class Session : Pattern.Class.UserControl {
    private class SessionTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách phiên làm việc";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Session.Instance.SelectAll(), new[] {
          "Name", "State", "TechnicianName", "DoctorName", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        List<Model.Role> technicianRoles = Controller.Role.Instance.SelectByName("Kỹ thuật viên");
        if (technicianRoles.Count == 0) {
          Utils.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy quyền Kỹ thuật viên.");
        } else {
          List<Model.Role> doctorRoles = Controller.Role.Instance.SelectByName("Bác sĩ");
          if (doctorRoles.Count == 0) {
            Utils.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy quyền Bác sĩ.");
          } else {
            List<Model.Staff> technicians = Controller.Staff.Instance.SelectByRoleId(technicianRoles[0].Id);
            if (technicians.Count == 0) {
              Utils.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy nhân viên có quyền Kỹ thuật viên.");
            } else {
              List<Model.Staff> doctors = Controller.Staff.Instance.SelectByRoleId(doctorRoles[0].Id);
              if (doctors.Count == 0) {
                Utils.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy nhân viên có quyền Bác sĩ.");
              } else {
                new Form.Admin.Insert.Session(technicians, doctors).ShowDialog();
                OnLoad();
              }
            }
          }
        }
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        List<Model.Role> technicianRoles = Controller.Role.Instance.SelectByName("Kỹ thuật viên");
        if (technicianRoles.Count == 0) {
          Utils.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy quyền Kỹ thuật viên.");
        } else {
          List<Model.Role> doctorRoles = Controller.Role.Instance.SelectByName("Bác sĩ");
          if (doctorRoles.Count == 0) {
            Utils.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy quyền Bác sĩ.");
          } else {
            List<Model.Staff> technicians = Controller.Staff.Instance.SelectByRoleId(technicianRoles[0].Id);
            if (technicians.Count == 0) {
              Utils.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy nhân viên có quyền Kỹ thuật viên.");
            } else {
              List<Model.Staff> doctors = Controller.Staff.Instance.SelectByRoleId(doctorRoles[0].Id);
              if (doctors.Count == 0) {
                Utils.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy nhân viên có quyền Bác sĩ.");
              } else {
                new Form.Admin.Update.Session((Model.Session)Utils.View.Grid.Instance.GetSelectedRow(GridView), technicians, doctors).ShowDialog();
                OnLoad();
              }
            }
          }
        }
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.Session.Instance.Disable(((Model.Session)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
        OnLoad();
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
