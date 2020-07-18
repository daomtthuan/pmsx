using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class Macro : Pattern.Class.UserControl {
    private class MacroTable : Layout.Table {
      private string groupId;
      private string groupName;

      protected override void OnInsert() {
        new Form.Admin.Insert.Macro(groupId).ShowDialog();
        LoadData(groupId, groupName);
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.Macro((Model.Macro)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        LoadData(groupId, groupName);
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.Macro.Instance.Disable(((Model.Macro)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
        LoadData(groupId, groupName);
      }

      public void LoadData(string groupId, string groupName) {
        this.groupId = groupId;
        this.groupName = groupName;

        TitleLabel.Text = "Danh sách đại thể thuộc nhóm " + groupName;

        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Macro.Instance.SelectByGroupId(groupId), new[] {
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
      Utils.View.Grid.Instance.Load(macroGroupSelect, Controller.MacroGroup.Instance.SelectAll(), new[] { "Code", "Name", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Name");
    }

    private void MacroGroupSelect_EditValueChanged(object sender, System.EventArgs e) {
      ((MacroTable)macroPanel.Controls[0]).LoadData(macroGroupSelect.EditValue.ToString(), macroGroupSelect.Text);
    }
  }
}
