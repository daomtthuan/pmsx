using DevExpress.XtraEditors;
using PMSX.Pattern.Base;
using System.Windows.Forms;

namespace PMSX.Utility.View {
  internal class AlertUtility : SingletonBase<AlertUtility> {
    private AlertUtility() { }

    public DialogResult ShowError(string message) {
      string contact =
        "\nLiên hệ hỗ trợ Nhà phát triển:" +
        "\nEmail: dao.mt.thuan@gmail.com" +
        "\nSố điện thoại: +84 939 908 568" +
        "\nWebsite: daomtthuan.com" +
        "\nFacebook: facebook.com/dao.mt.thuan";
      return XtraMessageBox.Show($"{message}\n{contact}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
