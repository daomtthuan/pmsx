using PMSX.Pattern.Base;

namespace PMSX.Exception {
  internal class SettingException : SingletonBase<SettingException> {
    internal enum Type : int {
      NotFound,
      ErrorReading
    }

    private ExceptionBase notFound;
    private ExceptionBase errorReading;

    private SettingException() { }

    private ExceptionBase Create(Type type, string message) {
      return new ExceptionBase(nameof(SettingException), typeof(Type), (int)type, message);
    }

    public ExceptionBase NotFound {
      get {
        if (notFound == null) {
          notFound = Create(Type.NotFound, "Không tìm thấy dữ liệu cấu hình");
        }
        return notFound;
      }
    }

    public ExceptionBase ErrorReading {
      get {
        if (errorReading == null) {
          errorReading = Create(Type.ErrorReading, "Lỗi trong quá trình nạp dữ liệu cấu hình");
        }
        return errorReading;
      }
    }
  }
}
