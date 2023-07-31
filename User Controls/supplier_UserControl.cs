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
    public partial class supplier_UserControl : UserControl
    {
        public supplier_UserControl()
        {
            InitializeComponent();
        }

        private void Supplier_Summary_Button_Click(object sender, EventArgs e)
        {
            SupplierPage.SetPage(0);
        }

        private void AddSupplier_Button_Click(object sender, EventArgs e)
        {
            SupplierPage.SetPage(1);
        }
    }
}
