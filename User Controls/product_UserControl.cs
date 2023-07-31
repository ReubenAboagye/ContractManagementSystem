using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagementSystem.User_Controls
{
    public partial class product_UserControl : UserControl
    {
        public product_UserControl()
        {
            InitializeComponent();
        }

        private void Product_Summary_Button_Click(object sender, EventArgs e)
        {
            Product_Page.SetPage(0);
        }

        private void AddProduct_Button_Click(object sender, EventArgs e)
        {
            Product_Page.SetPage(1);
        }
    }
}
