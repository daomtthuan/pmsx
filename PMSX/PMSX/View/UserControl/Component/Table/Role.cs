using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Role : XtraUserControl {
    private class RoleTable : Layout.Table {
      private List<Model.Role> roles;

      protected override void OnInit() {
        TitleLabel.Text = "Danh sách quyền";
      }

      protected override void OnLoad() {
        roles = Controller.Role.Instance.SelectAll();
        GridControl.DataSource = roles;
        GridView.PopulateColumns();

        foreach (GridColumn column in GridView.Columns) {
          column.Caption = Util.Locale.Instance.Caption[column.FieldName];
          column.Visible =
            column.FieldName == "Name" ||
            column.FieldName == "TechnicianName" ||
            column.FieldName == "DoctorName" ||
            column.FieldName == "State" ||
            column.FieldName == "CreateDatetime" ||
            column.FieldName == "UpdateDatetime";
        }
      }

      protected override void OnInsert() {
        new Form.Insert.Role().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        new Form.Update.Role((Model.Role)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        Controller.Role.Instance.Disabled(((Model.Role)GetSelectedRow()).Id);
        OnLoad();
      }
    }

    public Role() {
      InitializeComponent();

      Controls.Add(new RoleTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
