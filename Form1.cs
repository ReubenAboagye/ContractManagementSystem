using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ContractManagementSystem
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        bool CheckShowPassword()
        {
            return Password_textBox.UseSystemPasswordChar;
        }
        
        private void ShowPassword_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckShowPassword())
            {
                Password_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                Password_textBox.UseSystemPasswordChar = true;
            }

        }

        string connection = "";
        public void MyConnection()
        {
            MySqlConnection mconn = new MySqlConnection(connection);
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            Username_textBox.Focus();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
        }
    }
}
