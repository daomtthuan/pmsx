using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  public partial class Patient : XtraUserControl {
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
        if (GetSelectedRow() == null) {
          return;
        }

        new Form.Admin.Update.Patient((Model.Patient)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        if (GetSelectedRow() == null) {
          return;
        }

        Controller.Patient.Instance.Disable(((Model.Patient)GetSelectedRow()).Id);
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
