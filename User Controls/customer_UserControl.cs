using ContractManagementSystem.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using ContractManagementSystem.Classes;

namespace ContractManagementSystem.User_Controls
{
    public partial class customer_UserControl : UserControl
    {
        public customer_UserControl()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=!Won2Develop?; database=gaayanenterprise");
        private void New_Customer_Button_Click(object sender, EventArgs e)
        {
            Customer_TabPage.SetPage(1);
        }

        private void Customer_Summary_Button_Click(object sender, EventArgs e)
        {
            Customer_TabPage.SetPage(0);
        }

        private void Customer_Summary_page_Click(object sender, EventArgs e)
        {
            Summary_DataGridView.PopulateWithSampleData();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

            try
            {
                using (connection)
                {
                    connection.Open();
                }
                // Call the stored procedure to get the user's salt and hashed password based on the entered username
                using (var command = new MySqlCommand("insert_customer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                }   

            }
            catch (Exception ex) { }
        }
    }
}
