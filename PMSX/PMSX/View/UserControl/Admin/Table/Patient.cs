using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class Patient : XtraUserControl, Pattern.Interface.IView {
    private class PatientTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách bệnh nhân";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Patient.Instance.SelectAll(), new[] {
          "Name", "YearsOld", "Address", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Admin.Insert.Patient().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.Patient((Model.Patient)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.Patient.Instance.Disable(((Model.Patient)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
        OnLoad();
      }
    }

    public Patient() {
      InitializeComponent();
      Controls.Add(new PatientTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
