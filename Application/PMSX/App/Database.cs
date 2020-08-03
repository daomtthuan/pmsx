using MySql.Data.MySqlClient;
#if !DEBUG
using PMSX.Exception;
#endif
using PMSX.Pattern.Base;
using System.Data;

namespace PMSX.App {
  internal class Database : SingletonBase<Database> {
    private readonly string connectionString;

    private Database() {
      Config.DatabaseSetting database = Config.Instance.Database;
      connectionString = $@"
        server = {database.Host};
        port = {database.Port};
        database = {database.Name};
        user id = {database.Username};
        password = {database.Password};
      ";
    }

    public DataTable ExecuteReader(string query, params MySqlParameter[] parameters) {
      DataTable table = new DataTable();
      using (MySqlConnection connection = new MySqlConnection(connectionString)) {
#if !DEBUG
        try {
#endif
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
#if !DEBUG
        } catch {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            throw DatabaseException.Instance.ErrorExecute;
          } else {
            throw DatabaseException.Instance.ErrorConnection;
          }
        }
#endif
      }
      return table;
    }

    public int ExecuteNonQuery(string query, params MySqlParameter[] parameters) {
      int row = 0;
      using (MySqlConnection connection = new MySqlConnection(connectionString)) {
#if !DEBUG
        try {
#endif
        connection.Open();
        using (MySqlCommand command = connection.CreateCommand()) {
          command.CommandText = query;
          if (parameters != null) {
            foreach (MySqlParameter parameter in parameters) {
              command.Parameters.Add(parameter);
            }
          }
          row = command.ExecuteNonQuery();
        }
        connection.Close();
#if !DEBUG
        } catch {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            throw DatabaseException.Instance.ErrorExecute;
          } else {
            throw DatabaseException.Instance.ErrorConnection;
          }
        }
#endif
      }
      return row;
    }

    public object ExecuteScalar(string query, params MySqlParameter[] parameters) {
      object result = null;
      using (MySqlConnection connection = new MySqlConnection(connectionString)) {
#if !DEBUG
        try {
#endif
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
#if !DEBUG
        } catch {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            throw DatabaseException.Instance.ErrorExecute;
          } else {
            throw DatabaseException.Instance.ErrorConnection;
          }
        }
#endif
      }
      return result;
    }
  }
}
