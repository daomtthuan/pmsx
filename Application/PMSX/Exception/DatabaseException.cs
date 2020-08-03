using PMSX.Pattern.Base;

namespace PMSX.Exception {
  internal class DatabaseException : SingletonBase<DatabaseException> {
    internal enum Type : int {
      ErrorConnection,
      ErrorExecute
    }

    private ExceptionBase errorConnection;
    private ExceptionBase errorExecute;

    private DatabaseException() { }

    private ExceptionBase Create(Type type, string message) {
      return new ExceptionBase(nameof(DatabaseException), typeof(Type), (int)type, message);
    }

    public ExceptionBase ErrorConnection {
      get {
        if (errorConnection == null) {
          errorConnection = Create(Type.ErrorConnection, "Lỗi kết nối cơ sở dữ liệu");
        }
        return errorConnection;
      }
    }

    public ExceptionBase ErrorExecute {
      get {
        if (errorExecute == null) {
          errorExecute = Create(Type.ErrorExecute, "Lỗi truy vấn cơ sở dữ liệu");
        }
        return errorExecute;
      }
    }
  }
}
