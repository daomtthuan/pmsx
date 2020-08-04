using PMSX.Pattern.Base;

namespace PMSX.Exception {
  internal class ConfigException : SingletonBase<ConfigException> {
    internal enum Type : int {
      NotFound,
      ErrorReading
    }

    private ConfigException() { }

    public ExceptionBase NotFound(System.Exception exception = null) {
      return new ExceptionBase(nameof(ConfigException), typeof(Type), (int)Type.NotFound, "Không tìm thấy dữ liệu cấu hình", exception);
    }

    public ExceptionBase ErrorReading(System.Exception exception = null) {
      return new ExceptionBase(nameof(ConfigException), typeof(Type), (int)Type.ErrorReading, "Lỗi trong quá trình nạp dữ liệu cấu hình", exception);
    }
  }
}
