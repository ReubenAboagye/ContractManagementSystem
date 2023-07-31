using System;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace ContractManagementSystem.Operations
{
    internal class OrderClass
    {
        public void ResetControls(TabPage tabPage)
        {
            try
            {
                foreach (Control control in tabPage.Controls)
                {
                    // If the control is a TextBox, clear its text by setting the Text property to an empty string
                    if (control is TextBox textBox)
                    {
                        textBox.Text = "";
                    }
                    // If the control is a BunifuDropdown, clear its selected item by setting the SelectedIndex property to -1
                    else if (control is BunifuDropdown bunifuDropdown)
                    {
                        bunifuDropdown.SelectedIndex = -1;
                    }
                    // If the control is a BunifuDatePicker, set its Value property to the current date and time using the DateTime.Now property
                    else if (control is BunifuDatePicker bunifuDatePicker)
                    {
                        bunifuDatePicker.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
