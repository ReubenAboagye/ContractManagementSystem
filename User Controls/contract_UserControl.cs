﻿using System;
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
    public partial class contract_UserControl : UserControl
    {
        public contract_UserControl()
        {
            InitializeComponent();
        }

        private void New_Contract_Button_Click(object sender, EventArgs e)
        {
            Contract_TabPage.SetPage(1);
        }

        private void Contract_Summary_Button_Click(object sender, EventArgs e)
        {
            Contract_TabPage.SetPage(0);
        }
    }
}
