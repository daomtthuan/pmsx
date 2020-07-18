using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form {
  internal partial class SelectSession : Pattern.Class.EscCloseForm {
    public SelectSession() {
      InitializeComponent();
    }

    private void SelectSession_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(sessionSelect, Controller.Session.Instance.SelectAll(1), new[] { "Name", "TechnicianName", "DoctorName" }, "Id", "Name");
    }

    private void StartButton_Click(object sender, EventArgs e) {
      Controller.Main.Instance.Session = (Model.Session)sessionSelect.GetSelectedDataRow();
      Close();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
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
              new Admin.Insert.Session(technicians, doctors).ShowDialog();
              SelectSession_Load(sender, e);
            }
          }
        }
      }
    }
  }
}