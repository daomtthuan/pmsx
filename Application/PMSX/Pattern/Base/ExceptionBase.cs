using System;

namespace PMSX.Pattern.Base {
  internal class ExceptionBase : System.Exception {
    public ExceptionBase(string exception, Type type, int code, string message) : base(message) {
      string prefix = exception.Substring(0, exception.Length - "Exception".Length);
      int total = Enum.GetNames(type).Length;
      string codeName = code.ToString($"d{total.ToString().Length}");

      Code = $"{prefix} {codeName}";
    }

    public string Code { get; }
    public string FullMessage => $"[{Code}]: {Message}";
  }
}
