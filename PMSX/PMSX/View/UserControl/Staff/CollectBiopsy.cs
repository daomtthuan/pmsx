using System;
using System.Collections.Generic;

namespace PMSX.View.UserControl.Staff {
  internal partial class CollectBiopsy : Pattern.Class.UserControl {
    private List<Model.Biopsy> biopsies;
    private bool isRead;


    public CollectBiopsy() {
      InitializeComponent();
    }

    private void CollectBiopsy_Load(object sender, EventArgs e) {
      Utils.View.Grid.Instance.Load(gridControl, gridView, Controller.Patient.Instance.SelectAll(1), new[] { "Name", "YearsOld" });
      Utils.View.Grid.Instance.Load(biopsyGroupSelect, Controller.BiopsyGroup.Instance.SelectAll(1), new[] { "Code" }, "Id", "Code");
    }

    private void LoadBiopsy(bool selectLast = false) {
      isRead = true;

      if (Utils.View.Grid.Instance.GetSelectedRow(gridView) == null || biopsyGroupSelect.EditValue == null) {
        return;
      }

      biopsies = Controller.Biopsy.Instance.SelectByGroupIdAndPatientId(biopsyGroupSelect.EditValue.ToString(), ((Model.Patient)Utils.View.Grid.Instance.GetSelectedRow(gridView)).Id, 1);

      Utils.View.Grid.Instance.Load(biopsySelect, biopsies, new[] { "Code" }, "Id", "Code", selectLast ? biopsies.Count - 1 : 0);
    }

    private void BiopsyGroupSelect_EditValueChanged(object sender, EventArgs e) {
      LoadBiopsy();
      BiopsySelect_EditValueChanged(sender, e);
    }

    private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
      LoadBiopsy();
      BiopsySelect_EditValueChanged(sender, e);
    }

    private void BiopsySelect_EditValueChanged(object sender, EventArgs e) {
      Model.Biopsy biopsy = (Model.Biopsy)biopsySelect.GetSelectedDataRow();
      if (biopsy == null) {
        fullCodeInput.EditValue = null;
        segmentInput.EditValue = null;
        grossDatetimeSelect.EditValue = null;
        collectDatetimeSelect.EditValue = null;
        commentInput.EditValue = null;
      } else {
        fullCodeInput.Text = biopsy.FullCode;
        segmentInput.EditValue = biopsy.Segment;
        grossDatetimeSelect.DateTime = DateTime.Parse(biopsy.GrossDatetime);
        collectDatetimeSelect.DateTime = DateTime.Parse(biopsy.CollectDatetime);
        commentInput.Text = biopsy.Comment;
      }
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

    private void SaveButton_Click(object sender, EventArgs e) {
      if (isRead) {
        Model.Biopsy biopsy = (Model.Biopsy)biopsySelect.GetSelectedDataRow();
        if (biopsy == null) {
          return;
        }

        if (grossDatetimeSelect.Text.Length == 0 || collectDatetimeSelect.Text.Length == 0 || segmentInput.Text.Length == 0) {
          Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
        } else if (int.Parse(segmentInput.Text) == 0) {
          Utils.View.MessageBox.Instance.Warning("Sửa không thành công.\nSố mảnh không hợp lệ.\nSố mảnh tối thiểu là 1.");
        } else {
          Controller.Biopsy.Instance.Update(
            biopsy.Id,
            ((Model.Patient)Utils.View.Grid.Instance.GetSelectedRow(gridView)).Id,
            Controller.Main.Instance.Session.Id,
            Controller.Main.Instance.Session.DoctorId,
            int.Parse(segmentInput.Text),
            grossDatetimeSelect.DateTime,
            collectDatetimeSelect.DateTime,
            commentInput.Text,
            biopsy.GetStateNumber());
        }
      } else {
        Model.BiopsyGroup biopsyGroup = (Model.BiopsyGroup)biopsyGroupSelect.GetSelectedDataRow();
        if (biopsyGroup == null) {
          Utils.View.MessageBox.Instance.Warning("Không thể thêm.\nVui lòng tạo nhóm sinh thiết trước.");
        } else if (grossDatetimeSelect.Text.Length == 0 || collectDatetimeSelect.Text.Length == 0 || segmentInput.Text.Length == 0) {
          Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nVui lòng nhập đầy đủ thông tin bắt buộc.");
        } else if (int.Parse(segmentInput.Text) == 0) {
          Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nSố mảnh không hợp lệ.\nSố mảnh tối thiểu là 1.");
        } else if (!Controller.Biopsy.Instance.Insert(
          biopsyGroup.Id,
          ((Model.Patient)Utils.View.Grid.Instance.GetSelectedRow(gridView)).Id,
          Controller.Main.Instance.Session.Id,
          Controller.Main.Instance.Session.DoctorId,
          int.Parse(segmentInput.Text),
          grossDatetimeSelect.DateTime,
          collectDatetimeSelect.DateTime,
          commentInput.Text)) {
          Utils.View.MessageBox.Instance.Warning("Thêm không thành công.\nThao tác thêm bị huỷ trong quá trình thực thi.");
        } else {
          LoadBiopsy(true);
          isRead = true;
        }
      }
    }

    private void InsertButton_Click(object sender, EventArgs e) {
      biopsySelect.EditValue = null;

      isRead = false;
    }

    private void DiagnoseButton_Click(object sender, EventArgs e) {
      Model.Biopsy biopsy = (Model.Biopsy)biopsySelect.GetSelectedDataRow();
      if (biopsy == null) {
        return;
      }

      List<Model.Diagnose.Type1> diagnoses = Controller.Diagnose.Type1.Instance.SelectByBiopsyId(biopsy.Id);
      if (diagnoses.Count == 0) {
        new Form.Staff.Insert.Diagnose.Type1(Controller.MacroGroup.Instance.SelectAll(1), Controller.MicroGroup.Instance.SelectAll(1), biopsy).ShowDialog();
      } else {
        new Form.Staff.Update.Diagnose.Type1(diagnoses[0], Controller.MacroGroup.Instance.SelectAll(1), Controller.MicroGroup.Instance.SelectAll(1), biopsy).ShowDialog();
      }
    }
  }
}
