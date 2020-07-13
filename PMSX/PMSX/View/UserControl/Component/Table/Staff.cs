using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Staff : XtraUserControl {
    private class StaffTable : Layout.Table {
      private List<Model.Staff> staffs;

      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhân viên";
      }

      protected override void OnLoad() {
        staffs = Controller.Staff.Instance.SelectAll();
        GridControl.DataSource = staffs;
        GridView.PopulateColumns();

        foreach (GridColumn column in GridView.Columns) {
          column.Caption = Util.Locale.Instance.Caption[column.FieldName];
          column.Visible =
            column.FieldName == "Username" ||
            column.FieldName == "Name" ||
            column.FieldName == "State" ||
            column.FieldName == "CreateDatetime" ||
            column.FieldName == "UpdateDatetime";
        }
      }

      protected override void OnInsert() {
        new Form.Insert.Staff().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        new Form.Update.Staff((Model.Staff)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        Controller.Staff.Instance.Disabled(((Model.Staff)GetSelectedRow()).Id);
        OnLoad();
      }
    }

    public Staff() {
      InitializeComponent();
      Controls.Add(new StaffTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
