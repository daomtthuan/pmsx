using PMSXApplication.Pattern.Base;

namespace PMSXApplication.Exception {
  internal class SystemException : SingletonBase<SystemException> {
    internal enum Type : int {
      Error,
      Encode,
      Decode
    }

    private SystemException() { }

    public ExceptionBase Error(System.Exception exception = null) {
      return new ExceptionBase(nameof(SystemException), typeof(Type), (int)Type.Error, "Lỗi hệ thống", exception);
    }

    public ExceptionBase Encode(System.Exception exception = null) {
      return new ExceptionBase(nameof(SystemException), typeof(Type), (int)Type.Encode, "Không thể mã hoá thông tin", exception);
    }

    public ExceptionBase Decode(System.Exception exception = null) {
      return new ExceptionBase(nameof(SystemException), typeof(Type), (int)Type.Decode, "Không thể giải mã thông tin", exception);
    }
  }
}