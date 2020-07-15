using System.Data;
using System.Data.SqlClient;

namespace PMSX.Utils {
  public class Database {
    private static Database instance;
    private readonly string connectionString;

    private Database() {
      connectionString = Setting.Instance.ConnectionString;
    }

    public static Database Instance {
      get {
        if (instance == null)
          instance = new Database();
        return instance;
      }
      private set => instance = value;
    }

    public DataTable Excute(string query, SqlParameter[] parameters = null) {
      DataTable table = new DataTable();
      using (SqlConnection connection = new SqlConnection(connectionString)) {
        try {
          connection.Open();
          using (SqlCommand command = connection.CreateCommand()) {
            command.CommandText = query;
            if (parameters != null) {
              foreach (SqlParameter parameter in parameters) {
                command.Parameters.Add(parameter);
              }
            }
            using (SqlDataReader reader = command.ExecuteReader()) {
              table.Load(reader);
              reader.Close();
            }
          }
          connection.Close();
        } catch (SqlException e) {
          if (connection.State != ConnectionState.Closed) {
            View.MessageBox.Instance.Error("Truy vấn cơ sở dữ liệu thất bại.");
            connection.Close();
          } else {
            View.MessageBox.Instance.Error("Kết nối cơ sở dữ liệu thất bại.");
          }
#if DEBUG
          throw e;
#else
          Environment.Exit(e.Number);
#endif
        }
      }
      return table;
    }

    public void ExcuteNon(string query, SqlParameter[] parameters = null) {
      using (SqlConnection connection = new SqlConnection(connectionString)) {
        try {
          connection.Open();
          using (SqlCommand command = connection.CreateCommand()) {
            command.CommandText = query;
            if (parameters != null) {
              foreach (SqlParameter parameter in parameters) {
                command.Parameters.Add(parameter);
              }
            }
            command.ExecuteNonQuery();
          }
          connection.Close();
        } catch (SqlException e) {
          if (connection.State != ConnectionState.Closed) {
            View.MessageBox.Instance.Error("Truy vấn cơ sở dữ liệu thất bại.");
            connection.Close();
          } else {
            View.MessageBox.Instance.Error("Kết nối cơ sở dữ liệu thất bại.");
          }
#if DEBUG
          throw e;
#else
          Environment.Exit(e.Number);
#endif
        }
      }
    }

    public object ExecuteScalar(string query, SqlParameter[] parameters = null) {
      object result = null;
      using (SqlConnection connection = new SqlConnection(connectionString)) {
        try {
          connection.Open();
          using (SqlCommand command = connection.CreateCommand()) {
            command.CommandText = query;
            if (parameters != null) {
              foreach (SqlParameter parameter in parameters) {
                command.Parameters.Add(parameter);
              }
            }
            result = command.ExecuteScalar();
          }
          connection.Close();
        } catch (SqlException e) {
          if (connection.State != ConnectionState.Closed) {
            View.MessageBox.Instance.Error("Truy vấn cơ sở dữ liệu thất bại.");
            connection.Close();
          } else {
            View.MessageBox.Instance.Error("Kết nối cơ sở dữ liệu thất bại.");
          }
#if DEBUG
          throw e;
#else
          Environment.Exit(e.Number);
#endif
        }
      }
      return result;
    }
  }
}
