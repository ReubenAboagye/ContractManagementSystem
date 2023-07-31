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
    public partial class order_UserControl : UserControl
    {
        public order_UserControl()
        {
            InitializeComponent();
        }

        private void NewOrder_Button_Click(object sender, EventArgs e)
        {
            OrderPage.SetPage(1);
        }

        private void GoBack_Order_Click(object sender, EventArgs e)
        {
            OrderPage.SetPage(0);
        }
    }
}
