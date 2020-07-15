using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Windows.Forms;
 
namespace PMSX.View.UserControl.Component.Table {
  public partial class Macro : XtraUserControl {
    private class MacroTable : Layout.Table {
      private string groupId;
      private string groupName;

      protected override void OnInsert() {
        new Form.Insert.Macro(groupId).ShowDialog();
        LoadData(groupId,groupName);
      }

      protected override void OnUpdate() {
        new Form.Update.Macro((Model.Macro)GetSelectedRow()).ShowDialog();
        LoadData(groupId, groupName);
      }

      protected override void OnDisabled() {
        Controller.Macro.Instance.Disable(((Model.Macro)GetSelectedRow()).Id);
        LoadData(groupId, groupName);
      }

      public void LoadData(string groupId, string groupName) {
        this.groupId = groupId;
        this.groupName = groupName;

        TitleLabel.Text = "Danh sách đại thể thuộc nhóm " + groupName;

        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.Macro.Instance.SelectByGroupId(groupId), new[] {
          "Code", "State", "CreateDatetime", "UpdateDatetime"
        });
      }
    }

    public Macro() {
      InitializeComponent();
      macroPanel.Controls.Add(new MacroTable() {
        Dock = DockStyle.Fill
      });
    }

    private void Macro_Load(object sender, System.EventArgs e) {
      Util.View.Grid.Instance.Load(macroGroupSelect, Controller.MacroGroup.Instance.SelectAll(), new[] { "Code", "Name", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Name");
    }

    private void MacroGroupSelect_EditValueChanged(object sender, System.EventArgs e) {
      ((MacroTable)macroPanel.Controls[0]).LoadData(macroGroupSelect.EditValue.ToString(), macroGroupSelect.Text);
    }
  }
}
