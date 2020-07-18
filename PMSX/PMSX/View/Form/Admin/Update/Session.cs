using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form.Admin.Update {
  internal partial class Session : Pattern.Class.EscCloseForm {
    private readonly Model.Session session;
    private readonly List<Model.Staff> technicians;
    private readonly List<Model.Staff> doctors;

    public Session(Model.Session session, List<Model.Staff> technicians, List<Model.Staff> doctors) {
      InitializeComponent();

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      this.session = session;
      this.technicians = technicians;
      this.doctors = doctors;
    }

    private void Session_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(technicianSelect, technicians, new[] { "Username", "Name", "State" }, "Id", "Name", session.TechnicianId);
      Utils.View.Grid.Instance.Load(doctorSelect, doctors, new[] { "Username", "Name", "State" }, "Id", "Name", session.DoctorId);

      nameSelect.EditValue = DateTime.Parse(session.Name);
      stateRadio.EditValue = session.GetStateNumber();
      commentInput.Text = session.Comment;
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (!Controller.Session.Instance.Update(session.Id, nameSelect.DateTime, technicianSelect.EditValue.ToString(), doctorSelect.EditValue.ToString(), commentInput.Text, (int)stateRadio.EditValue)) {
        Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nTên phiên làm việc đã tồn tại.");
      } else {
        Close();
      }
    }
  }
}