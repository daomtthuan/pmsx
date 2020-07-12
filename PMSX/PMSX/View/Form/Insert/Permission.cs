using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Permission : XtraForm {
    private readonly string roleId;
    private readonly List<Model.Staff> staffs;

    public Permission(string roleId, List<Model.Staff> staffs) {
      InitializeComponent();

      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      this.roleId = roleId;
      this.staffs = staffs;
    }

    private void Permission_Load(object sender, EventArgs e) {
      staffSelect.Properties.DataSource = staffs.Select(item => new {
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

    private void InsertButton_Click(object sender, EventArgs e) {
      Controller.Permission.Instance.Insert(staffSelect.EditValue.ToString(), roleId, commentInput.Text);
      Close();
    }
  }
}