using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMSX.Util {
  public class Database {
    private static Database instance;
    private readonly string connectionString;

    private Database() {
      connectionString = "Data Source = .; Initial Catalog = pmsx; User ID = sa; Password = sa";
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
        } catch (Exception e) {
          if (connection.State != ConnectionState.Closed) {
            MessageBox.Instance.Error("Truy vấn cơ sở dữ liệu thất bại.");
            connection.Close();
          } else {
            MessageBox.Instance.Error("Kết nối cơ sở dữ liệu thất bại.");
          }
          Application.Exit();
#if DEBUG
          throw e;
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
        } catch (Exception e) {
          if (connection.State != ConnectionState.Closed) {
            MessageBox.Instance.Error("Truy vấn cơ sở dữ liệu thất bại.");
            connection.Close();
          } else {
            MessageBox.Instance.Error("Kết nối cơ sở dữ liệu thất bại.");
          }
          Application.Exit();
#if DEBUG
          throw e;
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
        } catch (Exception e) {
          if (connection.State != ConnectionState.Closed) {
            MessageBox.Instance.Error("Truy vấn cơ sở dữ liệu thất bại.");
            connection.Close();
          } else {
            MessageBox.Instance.Error("Kết nối cơ sở dữ liệu thất bại.");
          }
          Application.Exit();
#if DEBUG
          throw e;
#endif
        }
      }
      return result;
    }
  }
}
