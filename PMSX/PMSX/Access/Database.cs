using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMSX.Access {
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

        public DataTable Excute(string query, SqlParameter[] parameters) {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString)) {
                try {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand()) {
                        command.CommandText = query;
                        foreach (SqlParameter parameter in parameters) {
                            command.Parameters.Add(parameter);
                        }
                        using (SqlDataReader reader = command.ExecuteReader()) {
                            data.Load(reader);
                            reader.Close();
                        }
                    }
                    connection.Close();
                } catch {
                    XtraMessageBox.Show("Kết nối cơ sở dữ liệu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (connection.State != ConnectionState.Closed) {
                        connection.Close();
                    }
                    Application.Exit();
                }
            }
            return data;
        }
    }
}
