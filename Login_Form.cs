using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using ContractManagementSystem.Classes;
using MySql.Data.MySqlClient;

namespace ContractManagementSystem
{
    public partial class Login_Form : Form
    {
        readonly string server = "db4free.net";
        readonly int port = 3306;
        string username = "gaayan23";
        string password = "123Gaayan45?";
        readonly string database = "gaayanenterprise";

        public Login_Form()
        {
            InitializeComponent();
        }
        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

      


        private string HashPassword(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (var sha256 = SHA256.Create())
            {
                // Combine the password bytes and salt bytes
                byte[] combinedBytes = new byte[passwordBytes.Length + saltBytes.Length];
                Buffer.BlockCopy(passwordBytes, 0, combinedBytes, 0, passwordBytes.Length);
                Buffer.BlockCopy(saltBytes, 0, combinedBytes, passwordBytes.Length, saltBytes.Length);

                // Compute the hash
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);

                // Convert the hash to a base64 string and return
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Picture_Databases_Status.Visible = true;
            string connectionString = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";
            // Check if any of the fields is empty
            if (string.IsNullOrWhiteSpace(Username_textBox.Text) || string.IsNullOrWhiteSpace(Password_textBox.Text))
            {
                MessageBox.Show("Please enter both username and password.", "All fields Required",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Call the stored procedure to get the user's salt and hashed password based on the entered username
                    using (var command = new MySqlCommand("select_user_by_username", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("p_username", Username_textBox.Text);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string salt = reader["salt"].ToString();
                                string hashedPasswordFromDB = reader["hashed_password"].ToString();

                                // Hash the entered password with the salt from the database
                                string hashedEnteredPassword = HashPassword(Password_textBox.Text, salt);

                                if (hashedEnteredPassword == hashedPasswordFromDB)
                                {
                                    // Passwords match, login successful
                                    // Show the dashboard or do whatever you need to do after successful login
                                    Picture_Databases_Status.Visible = false;

                                    MessageBox.Show("Login successful. Welcome to the dashboard!","Login Succesful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    this.Hide();
                                    Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
                                    admin_Dashboard.Show();
                                }
                                else
                                {
                                    // Passwords do not match, login failed
                                    MessageBox.Show("Invalid username or password. Please try again.","Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                Picture_Databases_Status.Visible = false;
                            }
                            else
                            {
                                Picture_Databases_Status.Visible = false;

                                // User not found in the database
                                MessageBox.Show("Invalid username or password. Please try again.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that might occur during the database connection
                MessageBox.Show($"Error: {ex.Message}");
            }

            
        }

        private void bunifuPictureBox1_DoubleClick(object sender, EventArgs e)
        {
            
            RegisterUser newUser = new RegisterUser();
            newUser.ShowDialog();
        }
    }
}
