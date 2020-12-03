using MySqlConnector;
using PMSXApplication.App;
using PMSXApplication.Exception;
using PMSXApplication.Pattern.Base;
using PMSXApplication.Utility.View;
using System.Data;

namespace PMSXApplication.Utility {
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
        } catch (System.Exception exception) {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            AlertUtility.Instance.ShowError(DatabaseException.Instance.Execute(exception));
            return null;
          } else {
            AlertUtility.Instance.ShowError(DatabaseException.Instance.Connection(exception));
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
        } catch (System.Exception exception) {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            AlertUtility.Instance.ShowError(DatabaseException.Instance.Execute(exception));
            return -1;
          } else {
            AlertUtility.Instance.ShowError(DatabaseException.Instance.Connection(exception));
            return -1;
          }
        }
      }
      return row;
    }

    public int ExecuteTransactionNonQuery(string[] querys, MySqlParameter[][] parametersList) {
      int row = 0;
      using (MySqlConnection connection = new MySqlConnection(connectionString)) {
        MySqlTransaction transaction;
        try {
          connection.Open();
          using (transaction = connection.BeginTransaction()) {
            using (MySqlCommand command = connection.CreateCommand()) {
              command.Connection = connection;
              command.Transaction = transaction;
              try {
                for (int index = 0; index < querys.Length; index++) {
                  command.CommandText = querys[index];
                  if (parametersList[index] != null) {
                    foreach (MySqlParameter parameter in parametersList[index]) {
                      command.Parameters.Add(parameter);
                    }
                  }
                  row = command.ExecuteNonQuery();
                }
                transaction.Commit();
              } catch (System.Exception exception) {
                try {
                  transaction.Rollback();
                } catch (System.Exception rollbackException) {
                  if (transaction.Connection != null) {
                    connection.Close();
                    AlertUtility.Instance.ShowError(DatabaseException.Instance.Rollback(rollbackException));
                    return -1;
                  }
                }

                connection.Close();
                AlertUtility.Instance.ShowError(DatabaseException.Instance.Execute(exception));
                return -1;
              }
            }
          }
          connection.Close();
        } catch (System.Exception exception) {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            AlertUtility.Instance.ShowError(DatabaseException.Instance.Execute(exception));
            return -1;
          } else {
            AlertUtility.Instance.ShowError(DatabaseException.Instance.Connection(exception));
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
        } catch (System.Exception exception) {
          if (connection.State != ConnectionState.Closed) {
            connection.Close();
            AlertUtility.Instance.ShowError(DatabaseException.Instance.Execute(exception));
            return null;
          } else {
            AlertUtility.Instance.ShowError(DatabaseException.Instance.Connection(exception));
            return null;
          }
        }
      }
      return result;
    }
  }
}
