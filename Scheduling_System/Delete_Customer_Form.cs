using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Scheduling_System
{
    public partial class Delete_Customer_Form : Form
    {
        List<string> customerIDs = new List<string>();      // List of customer IDs (used to figure out which person to remove from list/file)
        ManagerForm mForm = null;                           // Manager form object (to open and close file)
        
        public Delete_Customer_Form(ManagerForm managerForm)
        {
            InitializeComponent();
            ShowCustomerNames();
            mForm = managerForm;
        }

        // Show the customers to the screen (on the list box)
        public void ShowCustomerNames()
        {
            foreach (Customer c in Form_Login.customerList)
            {
                string line = c.FirstName + ", " + c.LastName;      // Only show first and last names
                listBox_Delete_Customer.Items.Add(line);
                customerIDs.Add(c.CustomerID);                      // Keep track of IDs
            }
        }

        // When user clicks on the "Delete" button, will remove client from listbox and from file
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (listBox_Delete_Customer.SelectedItem != null)
            {
                string selectedItem = listBox_Delete_Customer.SelectedItem.ToString();          // What the user selected on the listbox
                int indexOfSelectedItem = listBox_Delete_Customer.SelectedIndex;
                listBox_Delete_Customer.Items.Remove(listBox_Delete_Customer.SelectedItem);     // Remove from listbox

                // Remove from list of customers
                foreach (Customer c in Form_Login.customerList)
                {
                    if (c.CustomerID == customerIDs.ElementAt(indexOfSelectedItem))     // Remove customer based on customer ID
                    {
                        Form_Login.customerList.Remove(c);
                        break;
                    }
                }

                // Remove from file
                string[] oldLines = File.ReadAllLines("ClientFile.txt");
                string[] newLines = new string[oldLines.Length-1];
                int index = 0;
                foreach (string line in oldLines)
                {
                    if (line == null)
                        break;
                    string[] lineInfo = line.Split(',');
                    if (lineInfo[0] == customerIDs.ElementAt(indexOfSelectedItem))      // If customer ID of selected customer found, remove line from file
                        continue;
                    newLines[index] = line;
                    index++;
                }

                File.WriteAllLines("ClientFile.txt", newLines);     // Copy into the Client File
                customerIDs.Remove(customerIDs.ElementAt(indexOfSelectedItem));
            }
        }

        // Returns user back to manager form
        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mForm.Show();
        }
    }
}
