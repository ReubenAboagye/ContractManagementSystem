using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace ContractManagementSystem.Classes
{
    public class DatabaseConnection
    {
        private string _connectionString;

       public void connector()
        {
            var connectionString = "server=localhost;user=root;password=!Won2Develop?;database=gaayanenterprise";
            var databaseConnection = new DatabaseConnection(connectionString);
        }

        public DatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable CallSelectAllUsers()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new MySqlCommand("select_all_users", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        var dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }

        public void InsertNewUser(string username, string salt, string hashedPassword, string user_Role)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new MySqlCommand("insert_user", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("p_username", username);
                    command.Parameters.AddWithValue("p_salt", salt);
                    command.Parameters.AddWithValue("p_hashed_password", hashedPassword);
                    command.Parameters.AddWithValue("userRole", user_Role);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

// Additional methods to call other stored procedures can be added here


