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

        private void NewOrder_Button_Click(object sender, EventArgs e)
        {
            OrderPage_AddInfo.SetPage("Add Order");
        }


        private void GoBack_Order_Click(object sender, EventArgs e)
        {
            OrderPage_AddInfo.SetPage("Order Summary");
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

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            try
            {
                OrderClass orderClass = new OrderClass();
                TabPage selectedTabPage = OrderPage_AddInfo.SelectedTab;
                orderClass.ResetControls(selectedTabPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
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

        private void New_Customer_Button_Click(object sender, EventArgs e)
        {
            Customer_TabPage.SetPage("Add Customer");
        }

        private void Customer_Summary_Button_Click(object sender, EventArgs e)
        {
            Customer_TabPage.SetPage("Customer Summary");
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void Product_Summary_Button_Click(object sender, EventArgs e)
        {
            Product_Page.SetPage("Product Summary");
        }

        private void AddProduct_Button_Click(object sender, EventArgs e)
        {
            Product_Page.SetPage("Add Product");
        }

        private void AddSupplier_Button_Click(object sender, EventArgs e)
        {
            SupplierPage.SetPage("New Supplier");
        }

        private void Supplier_Summary_Button_Click(object sender, EventArgs e)
        {
            SupplierPage.SetPage("Supplier Summary");
        }

        private void Supplier_Button_Click(object sender, EventArgs e)
        {
            tabPages.SetPage("Supplier");
        }
    }
}

