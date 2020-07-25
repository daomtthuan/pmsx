using DevExpress.XtraEditors;
using PMSX.Util.Pattern;
using System.Windows.Forms;

namespace PMSX.Util.View {

  /// <summary>
  /// Message Box
  /// </summary>
  internal class MessageBox : Singleton<MessageBox> {

    /// <summary>
    /// Create Message Box
    /// </summary>
    private MessageBox() { }

    /// <summary>
    /// Show Error message box
    /// </summary>
    /// <param name="message">Message</param>
    public void Error(string message) {
      string contact = "\n" + "\nĐể được hỗ trợ, vui lòng liên hệ:" + "\nEmail: dao.mt.thuan@gmail.com" + "\nSố điện thoại: +84 939 908 568" + "\nWebsite: daomtthuan.com" + "\nFacebook: facebook.com/dao.mt.thuan";
      XtraMessageBox.Show(message + contact, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    /// <summary>
    /// Show Warning message box
    /// </summary>
    /// <param name="message">Message</param>
    public void Warning(string message) {
      XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    /// <summary>
    /// Show Information message box
    /// </summary>
    /// <param name="message">Message</param>
    public void Information(string message) {
      XtraMessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
