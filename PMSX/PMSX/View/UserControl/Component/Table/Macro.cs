using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Macro : XtraUserControl {
    private class MacroTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách đại thể";
      }

      protected override void OnLoad() {
        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.MacroGroup.Instance.SelectAll(), new[] {
          "Code", "Description"
        });
      }

      protected override void OnInsert() {
        new Form.Insert.Macro().ShowDialog();
        OnLoad();
        // throw new NotImplementedException();
      }

      protected override void OnUpdate() {
        new Form.Update.Macro((Model.Macro)GetSelectedRow()).ShowDialog();
        OnLoad();
        //throw new NotImplementedException();
      }

      protected override void OnDisabled() {
        Controller.Macro.Instance.Disable(((Model.Macro)GetSelectedRow()).Id);
        OnLoad();
        //throw new NotImplementedException();
      }
    }

    public Macro() {
      InitializeComponent();
      Controls.Add(new MacroTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
