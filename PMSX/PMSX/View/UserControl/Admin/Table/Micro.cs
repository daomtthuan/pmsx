﻿using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Admin.Table {
  internal partial class Micro : XtraUserControl, Pattern.Interface.IView {
    private class MicroTable : Layout.Table {
      private string groupId;
      private string groupName;

      protected override void OnInsert() {
        new Form.Admin.Insert.Micro(groupId).ShowDialog();
        LoadData(groupId, groupName);
      }

      protected override void OnUpdate() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        new Form.Admin.Update.Micro((Model.Micro)Utils.View.Grid.Instance.GetSelectedRow(GridView)).ShowDialog();
        LoadData(groupId, groupName);
      }

      protected override void OnDisabled() {
        if (Utils.View.Grid.Instance.GetSelectedRow(GridView) == null) {
          return;
        }

        Controller.Micro.Instance.Disable(((Model.Micro)Utils.View.Grid.Instance.GetSelectedRow(GridView)).Id);
        LoadData(groupId, groupName);
      }

      public void LoadData(string groupId, string groupName) {
        this.groupId = groupId;
        this.groupName = groupName;

        TitleLabel.Text = "Danh sách vi thể thuộc nhóm " + groupName;

        Utils.View.Grid.Instance.Load(GridControl, GridView, Controller.Micro.Instance.SelectByGroupId(groupId), new[] {
          "Code", "State", "CreateDatetime", "UpdateDatetime"
        });
      }
    }

    public Micro() {
      InitializeComponent();
      microPanel.Controls.Add(new MicroTable() {
        Dock = DockStyle.Fill
      });
    }

    private void Micro_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(microGroupSelect, Controller.MicroGroup.Instance.SelectAll(), new[] { "Code", "Name", "State", "CreateDatetime", "UpdateDatetime" }, "Id", "Name");
    }

    private void MicroGroupSelect_EditValueChanged(object sender, EventArgs e) {
      ((MicroTable)microPanel.Controls[0]).LoadData(microGroupSelect.EditValue.ToString(), microGroupSelect.Text);
    }
  }
}
