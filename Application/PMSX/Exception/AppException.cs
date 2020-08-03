using PMSX.Pattern.Base;

namespace PMSX.Exception {
  internal class AppException : SingletonBase<AppException> {
    internal enum Type : int {
      Error
    }

    private ExceptionBase error;

    private AppException() { }

    private ExceptionBase Create(Type type, string message) {
      return new ExceptionBase(nameof(AppException), typeof(Type), (int)type, message);
    }

    public ExceptionBase Error {
      get {
        if (error == null) {
          error = Create(Type.Error, "Lỗi hệ thống");
        }
        return error;
      }
    }
  }
}