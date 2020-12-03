using DevExpress.XtraEditors;
using PMSXApplication.Pattern.Base;
using System.Windows.Forms;

namespace PMSXApplication.Utility.View {
  internal class AlertUtility : SingletonBase<AlertUtility> {
    private AlertUtility() { }

    public DialogResult ShowError(string message) {
      return XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public DialogResult ShowError(ExceptionBase exception) {
#if DEBUG
      throw exception.InnerException;
#else
      return ShowError(exception.AlertMessage);
#endif
    }

    public DialogResult ShowWarning(string message) {
      return XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public DialogResult ShowInformation(string message) {
      return XtraMessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public DialogResult ShowConfirm(string message) {
      return XtraMessageBox.Show(message, "Xác nhận thao tác", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
    }
  }
}
