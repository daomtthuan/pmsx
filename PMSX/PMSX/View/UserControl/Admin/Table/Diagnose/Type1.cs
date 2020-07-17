using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table.Diagnose {
  public partial class Type1 : XtraUserControl {
    private class DiagnoseTable : Layout {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách kết quả chẩn đoán loại 1";
      }

      protected override void OnLoad() {
        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Diagnose.Type1.Instance.SelectAll(), new[] {
          "Code", "PatientName", "BiopsyCode", "MacroCode", "MicroCode", "Conclusion", "ReadDate", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        List<Model.BiopsyGroup> biopsyGroups = Controller.BiopsyGroup.Instance.SelectAll();
        if (biopsyGroups.Count == 0) {
          Utils.View.MessageBox.Instance.Warning("Không thể thêm.\nKhông tìm thấy nhóm sinh thiết nào.");
        } else {
          new Form.Admin.Insert.Diagnose.Type1(Controller.MacroGroup.Instance.SelectAll(), Controller.MicroGroup.Instance.SelectAll(), biopsyGroups).ShowDialog();
          OnLoad();
        }
      }

      protected override void OnUpdate() {
        if (GetSelectedRow() == null) {
          return;
        }

        List<Model.BiopsyGroup> biopsyGroups = Controller.BiopsyGroup.Instance.SelectAll();
        if (biopsyGroups.Count == 0) {
          Utils.View.MessageBox.Instance.Warning("Không thể sửa.\nKhông tìm thấy nhóm sinh thiết nào.");
        } else {
          new Form.Admin.Update.Diagnose.Type1((Model.Diagnose.Type1)GetSelectedRow(), Controller.MacroGroup.Instance.SelectAll(), Controller.MicroGroup.Instance.SelectAll(), biopsyGroups).ShowDialog();
          OnLoad();
        }
      }

      protected override void OnDisabled() {
        if (GetSelectedRow() == null) {
          return;
        }

        Controller.Diagnose.Type1.Instance.Disable(((Model.Diagnose.Type1)GetSelectedRow()).Id);
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
