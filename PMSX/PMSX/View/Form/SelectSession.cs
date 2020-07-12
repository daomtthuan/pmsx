using DevExpress.XtraEditors;
using PMSX.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMSX.View.Form {
  public partial class SelectSession : XtraForm {
    private List<Model.Session> data;

    public SelectSession() {
      InitializeComponent();

      Icon = Resources.icon;

      Button closeButton = new Button();
      closeButton.Click += new EventHandler((sender, e) => Close());
      CancelButton = closeButton;

      brandPanel.Controls.Add(new UserControl.Component.Brand() {
        Dock = DockStyle.Fill
      });
    }

    private void SelectSession_Load(object sender, EventArgs e) {
      data = Controller.Session.Instance.SelectAll(1);
      if (data.Count > 0) {
        sessionSelect.Properties.DataSource = data.Select(item => new {
          item.Id,
          item.Name,
          TechnicianName = item.GetTechnician().Name,
          DoctorName = item.GetDoctor().Name,
        });
        sessionSelect.Properties.PopulateColumns();
        sessionSelect.Properties.DisplayMember = "Name";
        sessionSelect.Properties.ValueMember = "Id";
        sessionSelect.Properties.Columns["Id"].Caption = "Mã định danh";
        sessionSelect.Properties.Columns["Id"].Visible = false;
        sessionSelect.Properties.Columns["Name"].Caption = "Tên";
        sessionSelect.Properties.Columns["TechnicianName"].Caption = "Kỹ thuật viên";
        sessionSelect.Properties.Columns["DoctorName"].Caption = "Bác sĩ";

        sessionSelect.ItemIndex = 0;
      }
    }

    private void StartButton_Click(object sender, EventArgs e) {
      Controller.Main.Instance.Session = data.Where(item => item.Id == sessionSelect.EditValue.ToString()).First();
      Close();
    }
  }
}