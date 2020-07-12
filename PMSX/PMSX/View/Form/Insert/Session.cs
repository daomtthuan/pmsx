using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Session : XtraForm {
    public Session() {
      InitializeComponent();

      Icon = Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;
    }

    private void Permission_Load(object sender, EventArgs e) {
      List<Model.Role> technicianRoles = Controller.Role.Instance.SelectByName("Kỹ thuật viên");
      if (technicianRoles.Count == 0) {
        XtraMessageBox.Show("Không thể thêm.\nKhông tìm thấy quyền Kỹ thuật viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        Close();
      } else {
        List<Model.Role> doctorRoles = Controller.Role.Instance.SelectByName("Bác sĩ");
        if (doctorRoles.Count == 0) {
          XtraMessageBox.Show("Không thể thêm.\nKhông tìm thấy quyền Bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          Close();
        } else {
          List<Model.Staff> technicians = Controller.Staff.Instance.SelectByRoleId(technicianRoles[0].Id);
          if (technicians.Count == 0) {
            XtraMessageBox.Show("Không thể thêm.\nKhông tìm thấy nhân viên có quyền Kỹ thuật viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
          } else {
            List<Model.Staff> doctors = Controller.Staff.Instance.SelectByRoleId(doctorRoles[0].Id);
            if (doctors.Count == 0) {
              XtraMessageBox.Show("Không thể thêm.\nKhông tìm thấy nhân viên có quyền Bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              Close();
            } else {
              technicianSelect.Properties.DataSource = technicians.Select(item => new {
                item.Id,
                item.Username,
                item.Name,
                State = item.State == 0 ? "Vô hiệu hoá" : "Kích hoạt"
              });
              technicianSelect.Properties.PopulateColumns();
              technicianSelect.Properties.DisplayMember = "Name";
              technicianSelect.Properties.ValueMember = "Id";
              technicianSelect.Properties.Columns["Id"].Caption = "Mã định danh";
              technicianSelect.Properties.Columns["Id"].Visible = false;
              technicianSelect.Properties.Columns["Username"].Caption = "Tên đăng nhập";
              technicianSelect.Properties.Columns["Name"].Caption = "Tên";
              technicianSelect.Properties.Columns["State"].Caption = "Tên";
              technicianSelect.ItemIndex = 0;

              doctorSelect.Properties.DataSource = doctors.Select(item => new {
                item.Id,
                item.Username,
                item.Name,
                State = item.State == 0 ? "Vô hiệu hoá" : "Kích hoạt"
              });
              technicianSelect.Properties.PopulateColumns();
              technicianSelect.Properties.DisplayMember = "Name";
              technicianSelect.Properties.ValueMember = "Id";
              technicianSelect.Properties.Columns["Id"].Caption = "Mã định danh";
              technicianSelect.Properties.Columns["Id"].Visible = false;
              technicianSelect.Properties.Columns["Username"].Caption = "Tên đăng nhập";
              technicianSelect.Properties.Columns["Name"].Caption = "Tên";
              technicianSelect.Properties.Columns["State"].Caption = "Tên";
              technicianSelect.ItemIndex = 0;
            }
          }
        }
      }
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      //Controller.Session.Instance.Insert();
      Close();
    }
  }
}