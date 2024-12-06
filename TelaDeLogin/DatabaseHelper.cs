using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace TelaDeLogin
{
    public class DatabaseHelper
    {
        // String de Conexão
        private static string connectionString = "Server=localhost;Database=FarmaciaDB;Integrated Security=True;";

        // Método para abrir a conexão com o banco de dados
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        // Método para executar uma consulta SQL (Select)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        // Método para executar comandos SQL (Insert, Update, Delete)
        public static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
