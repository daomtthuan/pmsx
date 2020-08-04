using MySql.Data.MySqlClient;
using PMSX.App;
using PMSX.Exception;
using PMSX.Pattern.Base;
using PMSX.Utility.View;
using System.Data;

namespace PMSX.Utility {
  internal class DatabaseUtility : SingletonBase<DatabaseUtility> {
    private readonly string connectionString;

    private DatabaseUtility() {
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
        } catch (System.Exception e) {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            AlertUtility.Instance.ShowError(DatabaseException.Instance.ErrorExecute(e));
            return null;
          } else {
            AlertUtility.Instance.ShowError(DatabaseException.Instance.ErrorConnection(e));
            return null;
          }
        }
      }
      return table;
    }

    public int ExecuteNonQuery(string query, params MySqlParameter[] parameters) {
      int row = 0;
      using (MySqlConnection connection = new MySqlConnection(connectionString)) {
        try {
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
        } catch (System.Exception e) {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            AlertUtility.Instance.ShowError(DatabaseException.Instance.ErrorExecute(e));
            return -1;
          } else {
            AlertUtility.Instance.ShowError(DatabaseException.Instance.ErrorConnection(e));
            return -1;
          }
        }
      }
      return row;
    }

    public object ExecuteScalar(string query, params MySqlParameter[] parameters) {
      object result = null;
      using (MySqlConnection connection = new MySqlConnection(connectionString)) {
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
        } catch (System.Exception e) {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            AlertUtility.Instance.ShowError(DatabaseException.Instance.ErrorExecute(e));
            return null;
          } else {
            AlertUtility.Instance.ShowError(DatabaseException.Instance.ErrorConnection(e));
            return null;
          }
        }
      }
      return result;
    }
  }
}
