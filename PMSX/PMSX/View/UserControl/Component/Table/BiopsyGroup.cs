﻿using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.View.UserControl.Component.Table {
  public partial class BiopsyGroup : XtraUserControl {
    private class BiopsyGroupTable : Layout.Table {
      protected override void OnInit() {
        TitleLabel.Text = "Danh sách nhóm sinh thiết";
      }

      protected override void OnLoad() {
        Util.View.Grid.Instance.Load(GridControl, GridView, Controller.BiopsyGroup.Instance.SelectAll(), new[] {
          "Code", "NumberBiopsy", "State", "CreateDatetime", "UpdateDatetime"
        });
      }

      protected override void OnInsert() {
        new Form.Insert.BiopsyGroup().ShowDialog();
        OnLoad();
      }

      protected override void OnUpdate() {
        new Form.Update.BiopsyGroup((Model.BiopsyGroup)GetSelectedRow()).ShowDialog();
        OnLoad();
      }

      protected override void OnDisabled() {
        Controller.BiopsyGroup.Instance.Disable(((Model.BiopsyGroup)GetSelectedRow()).Id);
        OnLoad();
      }
    }

    public BiopsyGroup() {
      InitializeComponent();
      Controls.Add(new BiopsyGroupTable() {
        Dock = DockStyle.Fill
      });
    }
  }
}
