using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Patient : XtraUserControl {
    private class PatientTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách bệnh nhân";
      }

      protected override void OnLoad() {
        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.Patient.Instance.SelectAll(), new[] {
          "Name", "Year", "Address", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        throw new NotImplementedException();
      }

      protected override void OnUpdate() {
        throw new NotImplementedException();
      }

      protected override void OnDisabled() {
        throw new NotImplementedException();
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
