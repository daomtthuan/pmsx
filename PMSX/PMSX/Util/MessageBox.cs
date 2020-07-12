using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace PMSX.Util {
  public class MessageBox {
    private static MessageBox instance;

    private MessageBox() { }

    public static MessageBox Instance {
      get {
        if (instance == null)
          instance = new MessageBox();
        return instance;
      }
      private set => instance = value;
    }

    public DialogResult Error(string message) {
      return XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public DialogResult Warning(string message) {
      return XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public DialogResult Info(string message) {
      return XtraMessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
