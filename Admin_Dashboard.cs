using Bunifu.UI.WinForms;
using ContractManagementSystem.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagementSystem
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFormControlBox1_CloseClicked(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }


        private void bunifuFormControlBox1_CloseClicked_1(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void Settings_Button_MouseHover(object sender, EventArgs e)
        {


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }


        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Home");
        }

        private void Order_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Orders");
        }


        private void Contract_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Contracts");
        }

        private void Customers_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Customers");
        }

        private void Sales_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Sales");
        }

        private void Product_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Products");
        }


        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Contract_TabPage_Click(object sender, EventArgs e)
        {

        }

        private void New_Contract_Button_Click(object sender, EventArgs e)
        {
           
        }

        private void Contract_Summary_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Supplier_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Supplier");
        }

        private void Expense_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Expense");
        }

        private void contract_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Settings");
        }
    }
}

