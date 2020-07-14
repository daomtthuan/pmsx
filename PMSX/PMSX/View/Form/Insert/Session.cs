using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PMSX.View.Form.Insert {
  public partial class Session : XtraForm {
    private readonly List<Model.Staff> technicians;
    private readonly List<Model.Staff> doctors;

    public Session(List<Model.Staff> technicians, List<Model.Staff> doctors) {
      InitializeComponent();

      DialogResult = DialogResult.Cancel;
      Icon = Properties.Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      this.technicians = technicians;
      this.doctors = doctors;
    }

    private void Session_Load(object sender, EventArgs e) {
      Util.View.Grid.Instance.Load(technicianSelect, technicians, new[] { "Username", "Name", "State" }, "Id", "Name");
      Util.View.Grid.Instance.Load(doctorSelect, doctors, new[] { "Username", "Name", "State" }, "Id", "Name");

      nameSelect.EditValue = DateTime.Now;
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      if (!Controller.Session.Instance.Insert(nameSelect.DateTime, technicianSelect.EditValue.ToString(), doctorSelect.EditValue.ToString(), commentInput.Text)) {
        Util.View.MessageBox.Instance.Warning("Thêm không thành công.\nTên phiên làm việc đã tồn tại.");
      } else {
        DialogResult = DialogResult.OK;
        Close();
      }
    }
  }
}