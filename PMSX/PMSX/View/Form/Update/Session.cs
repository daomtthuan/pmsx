using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form.Update {
  public partial class Session : XtraForm {
    private readonly Model.Session session;
    private readonly List<Model.Staff> technicians;
    private readonly List<Model.Staff> doctors;

    public Session(Model.Session session, List<Model.Staff> technicians, List<Model.Staff> doctors) {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      this.session = session;
      this.technicians = technicians;
      this.doctors = doctors;      
    }

    private void Session_Load(object sender, EventArgs e) {
      technicianSelect.Properties.DataSource = technicians;
      technicianSelect.Properties.PopulateColumns();

      doctorSelect.Properties.DataSource = doctors;
      doctorSelect.Properties.PopulateColumns();

      foreach (LookUpColumnInfo column in technicianSelect.Properties.Columns) {
        column.Caption = Util.Locale.Instance.Caption[column.FieldName];
        column.Visible =
          column.FieldName == "Username" ||
          column.FieldName == "Name" ||
          column.FieldName == "State";
      }

      foreach (LookUpColumnInfo column in doctorSelect.Properties.Columns) {
        column.Caption = Util.Locale.Instance.Caption[column.FieldName];
        column.Visible =
          column.FieldName == "Username" ||
          column.FieldName == "Name" ||
          column.FieldName == "State";
      }

      technicianSelect.Properties.ValueMember = "Id";
      technicianSelect.Properties.DisplayMember = "Name";
      doctorSelect.Properties.ValueMember = "Id";
      doctorSelect.Properties.DisplayMember = "Name";

      nameSelect.EditValue = DateTime.Parse(session.Name);
      technicianSelect.EditValue = session.TechnicianId;
      doctorSelect.EditValue = session.DoctorId;
      stateRadio.EditValue = session.GetStateNumber();
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
      if (!Controller.Session.Instance.Update(session.Id, nameSelect.DateTime, technicianSelect.EditValue.ToString(), doctorSelect.EditValue.ToString(), commentInput.Text, (int)stateRadio.EditValue)) {
        Util.View.MessageBox.Instance.Warning("Không thể sửa.\nTên phiên làm việc đã tồn tại.");
      } else {
        DialogResult = DialogResult.OK;
        Close();
      }
    }
  }
}