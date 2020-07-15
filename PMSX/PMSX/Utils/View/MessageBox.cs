using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.Utils.View {
  public class MessageBox : Pattern.Singleton<MessageBox> {
    private MessageBox() { }

    public DialogResult Error(string message) {
      return XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public DialogResult Warning(string message) {
      return XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public DialogResult Information(string message) {
      return XtraMessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
