using PMSXApplication.Pattern.Base;

namespace PMSXApplication.Exception {
  internal class DatabaseException : SingletonBase<DatabaseException> {
    internal enum Type : int {
      Connection,
      Execute,
      Rollback
    }

    private DatabaseException() { }

    public ExceptionBase Connection(System.Exception exception = null) {
      return new ExceptionBase(nameof(DatabaseException), typeof(Type), (int)Type.Connection, "Lỗi kết nối cơ sở dữ liệu", exception);
    }

    public ExceptionBase Execute(System.Exception exception = null) {
      return new ExceptionBase(nameof(DatabaseException), typeof(Type), (int)Type.Execute, "Lỗi truy vấn cơ sở dữ liệu", exception);
    }

    public ExceptionBase Rollback(System.Exception exception = null) {
      return new ExceptionBase(nameof(DatabaseException), typeof(Type), (int)Type.Execute, "Lỗi khôi phục cơ sở dữ liệu", exception);
    }
  }
}
