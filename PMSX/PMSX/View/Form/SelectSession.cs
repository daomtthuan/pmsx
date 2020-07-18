using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form {
  internal partial class SelectSession : Pattern.View.EscCloseForm, Pattern.Interface.IView {
    private readonly List<Model.Session> sessions;

    public SelectSession(List<Model.Session> sessions) {
      InitializeComponent();

      Icon = Properties.Resources.icon;
      this.sessions = sessions;
    }

    private void SelectSession_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(sessionSelect, sessions, new[] { "Name", "TechnicianName", "DoctorName" }, "Id", "Name");
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