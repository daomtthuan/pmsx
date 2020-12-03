using System;

namespace PMSXApplication.Pattern.Base {
  internal class ExceptionBase : System.Exception {
    public ExceptionBase(string exception, Type type, int code, string message, System.Exception innerException) : base(message, innerException) {
      string prefix = exception.Substring(0, exception.Length - "Exception".Length);
      int total = Enum.GetNames(type).Length;
      string codeName = code.ToString($"d{total.ToString().Length}");

      Code = $"{prefix} {codeName}";
      AlertMessage = $"[{Code}]: {message}";
    }

    public string Code { get; }
    public string AlertMessage { get; }
  }
}
