using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form {
  public partial class SelectSession : XtraForm {
    private List<Model.Session> sessions;

    public SelectSession() {
      InitializeComponent();

      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      brandPanel.Controls.Add(new UserControl.Component.Brand() {
        Dock = DockStyle.Fill
      });
    }

    private void SelectSession_Load(object sender, EventArgs e) {
      sessions = Controller.Session.Instance.SelectAll(1);
      if (sessions.Count > 0) {
        sessionSelect.Properties.DataSource = sessions;
        sessionSelect.Properties.PopulateColumns();

        foreach (LookUpColumnInfo column in sessionSelect.Properties.Columns) {
          column.Caption = Util.Locale.Instance.Caption[column.FieldName];
          column.Visible =
            column.FieldName == "Name" ||
            column.FieldName == "TechnicianName" ||
            column.FieldName == "DoctorName";
        }

        sessionSelect.Properties.ValueMember = "Id";
        sessionSelect.Properties.DisplayMember = "Name";
        sessionSelect.ItemIndex = 0;
      }
    }

    private void StartButton_Click(object sender, EventArgs e) {
      Controller.Main.Instance.Session = (Model.Session)sessionSelect.GetSelectedDataRow();
      Close();
    }

    private void SelectSession_FormClosing(object sender, FormClosingEventArgs e) {
      if (Controller.Main.Instance.Session == null) {
        Application.Exit();
      }
    }
  }
}