using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table.Diagnose {
  public partial class Type1 : XtraUserControl {
    private class DiagnoseTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách kết quả chẩn đoán loại 1";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Diagnose.Type1.Instance.SelectAll(), new[] {
          "Code", "PatientName", "BiopsyCode", "MacroCode", "MicroCode", "Conclusion", "ReadDate", "Sate", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        List<Model.BiopsyGroup> biopsyGroups = Controller.BiopsyGroup.Instance.SelectAll();
        if (biopsyGroups.Count == 0) {
          Utils.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy nhóm sinh thiết nào.");
        } else {
          new Form.Insert.Diagnose.Type1(Controller.MacroGroup.Instance.SelectAll(), Controller.MicroGroup.Instance.SelectAll(), biopsyGroups).ShowDialog();
          OnLoad();
        }
      }

      protected override void OnUpdate() {
        new Form.Update.Staff((Model.Staff)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        Controller.Staff.Instance.Disable(((Model.Staff)GetSelectedRow()).Id);
        OnLoad();
      }
    }

    public Type1() {
      InitializeComponent();
      Controls.Add(new DiagnoseTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
