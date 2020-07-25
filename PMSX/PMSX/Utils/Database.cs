using System.Data;
using MySql.Data.MySqlClient;

namespace PMSX.Utils {
  internal class Database : Pattern.Class.Singleton<Database> {
    private Database() { }

    public DataTable Excute(string query, MySqlParameter[] parameters = null) {
      DataTable table = new DataTable();
      using (MySqlConnection connection = new MySqlConnection(Setting.Instance.ConnectionString)) {
        try {
          connection.Open();
          using (MySqlCommand command = connection.CreateCommand()) {
            command.CommandText = query;
            if (parameters != null) {
              foreach (MySqlParameter parameter in parameters) {
                command.Parameters.Add(parameter);
              }
            }
            using (MySqlDataReader reader = command.ExecuteReader()) {
              table.Load(reader);
              reader.Close();
            }
          }
          connection.Close();
        } catch (MySqlException e) {
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

    public void ExcuteNon(string query, MySqlParameter[] parameters = null) {
      using (MySqlConnection connection = new MySqlConnection(Setting.Instance.ConnectionString)) {
        try {
          connection.Open();
          using (MySqlCommand command = connection.CreateCommand()) {
            command.CommandText = query;
            if (parameters != null) {
              foreach (MySqlParameter parameter in parameters) {
                command.Parameters.Add(parameter);
              }
            }
            command.ExecuteNonQuery();
          }
          connection.Close();
        } catch (MySqlException e) {
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

    public object ExecuteScalar(string query, MySqlParameter[] parameters = null) {
      object result = null;
      using (MySqlConnection connection = new MySqlConnection(Setting.Instance.ConnectionString)) {
        try {
          connection.Open();
          using (MySqlCommand command = connection.CreateCommand()) {
            command.CommandText = query;
            if (parameters != null) {
              foreach (MySqlParameter parameter in parameters) {
                command.Parameters.Add(parameter);
              }
            }
            result = command.ExecuteScalar();
          }
          connection.Close();
        } catch (MySqlException e) {
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
