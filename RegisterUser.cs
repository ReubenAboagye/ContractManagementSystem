using ContractManagementSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace ContractManagementSystem
{
    public partial class RegisterUser : Form
    {
        readonly string server = "db4free.net";
        readonly int port = 3306;
         string username = "gaayan23";
         string password = "123Gaayan45?";
        readonly string database = "gaayanenterprise";

        // Generate a random salt for hashing passwords
        private string GenerateSalt()
        {
            var rng = new RNGCryptoServiceProvider();
            var salt = new byte[16];
            rng.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }

        // Hash the password using SHA256 and the provided salt
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

        public RegisterUser()
        {
            InitializeComponent();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        // Method to register a new user
        private void RegisterNewUser(string usern, string pass)
        {
            try
            {
                // Generate a new salt for the user's password
                string salt = GenerateSalt();
                usern = Username_textBox.Text;
                pass = Password_textBox.Text;
                // Hash the password with the salt
                string hashedPassword = HashPassword(pass, salt);

                // Create an instance of the DatabaseConnection class to interact with the database
                var connectionString = $"Server={server};Database={database}; Port={port};Uid={username};Pwd={password}";
                var dbConnection = new DatabaseConnection(connectionString);

                // Call the method to insert the new user into the database
                dbConnection.InsertNewUser(usern, salt, hashedPassword);

                // Dispose the dbConnection when no longer needed
                

                // Optionally, show a success message to the user
                MessageBox.Show("Registration successful. You can now log in with your new account.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that might occur during the database connection
                MessageBox.Show($"Error: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Register_Button_Click(object sender, EventArgs e)
        {
            // Get the entered username and password from the textboxes
            string usernameInput = Username_textBox.Text;
            string passwordInput = Password_textBox.Text;

            // Check if any of the fields is empty
            if (string.IsNullOrWhiteSpace(usernameInput) || string.IsNullOrWhiteSpace(passwordInput))
            {
                MessageBox.Show("Please enter both username and password.", "All fields Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the method to register the new user
            RegisterNewUser(username, password);
        }
    }
}
