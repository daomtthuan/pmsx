using PMSX.Pattern.Base;

namespace PMSX.Exception {
  internal class DatabaseException : SingletonBase<DatabaseException> {
    internal enum Type : int {
      ErrorConnection,
      ErrorExecute
    }

    private DatabaseException() { }

    public ExceptionBase ErrorConnection(System.Exception exception = null) {
      return new ExceptionBase(nameof(DatabaseException), typeof(Type), (int)Type.ErrorConnection, "Lỗi kết nối cơ sở dữ liệu", exception);
    }

    public ExceptionBase ErrorExecute(System.Exception exception = null) {
      return new ExceptionBase(nameof(DatabaseException), typeof(Type), (int)Type.ErrorExecute, "Lỗi truy vấn cơ sở dữ liệu", exception);
    }
  }
}
