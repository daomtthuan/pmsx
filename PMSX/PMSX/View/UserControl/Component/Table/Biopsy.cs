using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Biopsy : XtraUserControl {
    private class BiopsyTable : Layout.Table {
      private string groupId;
      private string groupName;

      protected override void OnInsert() {
        if (groupId == null) {
          Util.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy nhóm sinh thiết nào.");
        } else {
          List<Model.Patient> patients = Controller.Patient.Instance.SelectAll();
          if (patients.Count == 0) {
            Util.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy bệnh nhân nào.");
          } else {
            List<Model.Role> doctorRoles = Controller.Role.Instance.SelectByName("Bác sĩ");
            if (doctorRoles.Count == 0) {
              Util.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy quyền Bác sĩ.");
            } else {
              List<Model.Staff> grossDoctors = Controller.Staff.Instance.SelectByRoleId(doctorRoles[0].Id);
              if (grossDoctors.Count == 0) {
                Util.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy nhân viên có quyền Bác sĩ.");
              } else {
                new Form.Insert.Biopsy(groupId, patients, grossDoctors, Controller.Session.Instance.SelectAll()).ShowDialog();
                LoadData(groupId, groupName);
              }
            }
          }
        }
      }

      protected override void OnUpdate() {
      }

      protected override void OnDisabled() {
      }

      public void LoadData(string groupId, string groupName) {
        if (groupId == null) {
          return;
        }

        this.groupId = groupId;
        this.groupName = groupName;

        TitleLabel.Text = "Danh sách mẫu sinh thiết thuộc nhóm " + groupName;
        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.Biopsy.Instance.SelectByGroupId(groupId), new[] { "Code", "State", "CreateDatetime", "UpdateDatetime" });
      }
    }

    public Biopsy() {
      InitializeComponent();
      biopsyPanel.Controls.Add(new BiopsyTable() {
        Dock = DockStyle.Fill
      });
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Util.View.Grid.Instance.Load(biopsyGroupSelect, Controller.BiopsyGroup.Instance.SelectAll(), new[] { "Code", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Code");
    }

    private void BiopsyGroupSelect_EditValueChanged(object sender, EventArgs e) {
      ((BiopsyTable)biopsyPanel.Controls[0]).LoadData(biopsyGroupSelect.EditValue.ToString(), biopsyGroupSelect.Text);
    }
  }
}
