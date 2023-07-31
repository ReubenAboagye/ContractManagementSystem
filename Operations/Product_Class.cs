using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ContractManagementSystem.Operations
{
    internal class Product_Class
    {
       

        bool textNotEmpty(string productName, string productPrice)
        {
            if(productName.Trim() == String.Empty && productPrice.Trim() == String.Empty) {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SaveRecords()
        {
            //this will use the records that the user inputs to serve as a query to the database

        }
    }
}
