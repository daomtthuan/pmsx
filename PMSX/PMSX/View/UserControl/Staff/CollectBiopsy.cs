using System;
using System.Collections.Generic;

namespace PMSX.View.UserControl.Staff {
  internal partial class CollectBiopsy : Pattern.Class.UserControl {
    private List<Model.Biopsy> biopsies;

    public CollectBiopsy() {
      InitializeComponent();
    }

    private void CollectBiopsy_Load(object sender, System.EventArgs e) {
      Utils.View.Grid.Instance.Load(gridControl, gridView, Controller.Patient.Instance.SelectAll(1), new[] { "Name", "YearsOld" });
      Utils.View.Grid.Instance.Load(biopsyGroupSelect, Controller.BiopsyGroup.Instance.SelectAll(1), new[] { "Code" }, "Id", "Code");
    }

    private void LoadBiopsy() {
      if (Utils.View.Grid.Instance.GetSelectedRow(gridView) == null || biopsyGroupSelect.EditValue == null) {
        return;
      }

      biopsies = Controller.Biopsy.Instance.SelectByGroupIdAndPatientId(biopsyGroupSelect.EditValue.ToString(), ((Model.Patient)Utils.View.Grid.Instance.GetSelectedRow(gridView)).Id, 1);

      Utils.View.Grid.Instance.Load(biopsySelect, biopsies, new[] { "Code" }, "Id", "Code");

      Model.Biopsy biopsy = (Model.Biopsy)biopsySelect.GetSelectedDataRow();
      if (biopsy == null) {
        return;
      }

      fullCodeInput.Text = biopsy.FullCode;
      segmentInput.EditValue = biopsy.Segment;
      grossDatetimeSelect.DateTime = DateTime.Parse(biopsy.GrossDatetime);
      collectDatetimeSelect.DateTime = DateTime.Parse(biopsy.CollectDatetime);
      commentInput.Text = biopsy.Comment;
    }

    private void BiopsyGroupSelect_EditValueChanged(object sender, System.EventArgs e) {
      LoadBiopsy();
    }

    private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
      LoadBiopsy();
    }

    private void NextButton_Click(object sender, EventArgs e) {
      if (biopsies.Count == 0 || biopsySelect.ItemIndex + 1 == biopsies.Count) {
        gridView.MoveNext();
      } else {
        biopsySelect.ItemIndex++;
      }
    }

    private void PreviousButton_Click(object sender, EventArgs e) {
      if (biopsies.Count == 0 || biopsySelect.ItemIndex == 0) {
        gridView.MovePrev();
      } else {
        biopsySelect.ItemIndex--;
      }
    }
  }
}
