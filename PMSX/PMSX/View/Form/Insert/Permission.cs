using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      this.roleId = roleId;
      this.staffs = staffs;
    }

    private void Permission_Load(object sender, EventArgs e) {
      staffSelect.Properties.DataSource = staffs;
      staffSelect.Properties.PopulateColumns();

      foreach (LookUpColumnInfo column in staffSelect.Properties.Columns) {
        column.Caption = Util.Locale.Instance.Caption[column.FieldName];
      }

      staffSelect.ItemIndex = 0;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      Controller.Permission.Instance.Insert(staffSelect.EditValue.ToString(), roleId, commentInput.Text);
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}