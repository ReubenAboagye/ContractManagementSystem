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
    public partial class customer_UserControl : UserControl
    {
        public customer_UserControl()
        {
            InitializeComponent();
        }

        private void New_Customer_Button_Click(object sender, EventArgs e)
        {
            Customer_TabPage.SetPage(1);
        }

        private void Customer_Summary_Button_Click(object sender, EventArgs e)
        {
            Customer_TabPage.SetPage(0);
        }
    }
}
