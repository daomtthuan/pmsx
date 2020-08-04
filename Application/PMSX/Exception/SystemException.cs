using PMSX.Pattern.Base;

namespace PMSX.Exception {
  internal class SystemException : SingletonBase<SystemException> {
    internal enum Type : int {
      Error
    }

    private SystemException() { }

    public ExceptionBase Error(System.Exception exception = null) {
      return new ExceptionBase(nameof(SystemException), typeof(Type), (int)Type.Error, "Lỗi hệ thống", exception);
    }
  }
}