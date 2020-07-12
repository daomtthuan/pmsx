using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Permission : XtraForm {
    private readonly Model.Role data;

    public Permission(Model.Role data) {
      InitializeComponent();

      Icon = Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      this.data = data;
    }

    private void Permission_Load(object sender, EventArgs e) {
      List<Model.Staff> data = Controller.Staff.Instance.SelectByNotRoleId(this.data.Id);
      if (data.Count == 0) {
        XtraMessageBox.Show("Không thể thêm.\nTất cả nhân viên đã có quyền này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        Close();
      } else {
        staffSelect.Properties.DataSource = data.Select(item => new {
          item.Id,
          item.Username,
          item.Name,
          State = item.State == 0 ? "Vô hiệu hoá" : "Kích hoạt"
        });
        staffSelect.Properties.PopulateColumns();
        staffSelect.Properties.DisplayMember = "Name";
        staffSelect.Properties.ValueMember = "Id";
        staffSelect.Properties.Columns["Id"].Caption = "Mã định danh";
        staffSelect.Properties.Columns["Id"].Visible = false;
        staffSelect.Properties.Columns["Username"].Caption = "Tên đăng nhập";
        staffSelect.Properties.Columns["Name"].Caption = "Tên";
        staffSelect.Properties.Columns["State"].Caption = "Trạng thái";

        staffSelect.ItemIndex = 0;
      }
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      Controller.Permission.Instance.Insert(staffSelect.EditValue.ToString(), data.Id, commentInput.Text);
      Close();
    }
  }
}