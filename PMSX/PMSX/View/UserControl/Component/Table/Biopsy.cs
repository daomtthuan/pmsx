using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class Biopsy : XtraUserControl {
    private class BiopsyTable : Layout.Table {
      private string groupId;
      private string groupName;

      protected override void OnInsert() {       
      }

      protected override void OnUpdate() {       
      }

      protected override void OnDisabled() {        
      }

      public void LoadData(string groupId, string groupName) {
        this.groupId = groupId;
        this.groupName = groupName;

        TitleLabel.Text = "Danh sách mẫu sinh thiết thuộc nhóm " + groupName;

        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.Biopsy.Instance.SelectByGroupId(groupId), new[] {
          "Code", "State", "CreateDatetime", "UpdateDatetime"
        });
      }
    }

    public Biopsy() {
      InitializeComponent();
      biopsyPanel.Controls.Add(new BiopsyTable() {
        Dock = DockStyle.Fill
      });
    }

    private void Biopsy_Load(object sender, EventArgs e) {
      Util.View.Grid.Instance.Load(biopsyGroupSelect, Controller.BiopsyGroup.Instance.SelectAll(), new[] { "Code", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Code");
    }

    private void BiopsyGroupSelect_EditValueChanged(object sender, EventArgs e) {
      ((BiopsyTable)biopsyPanel.Controls[0]).LoadData(biopsyGroupSelect.EditValue.ToString(), biopsyGroupSelect.Text);
    }
  }
}
