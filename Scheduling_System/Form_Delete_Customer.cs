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
    public partial class Form_Delete_Customer : Form
    {
        List<string> customerIDs = new List<string>();      // List of customer IDs (used to figure out which person to remove from list/file)
        Form_Main_Menu mmForm = null;                           // Manager form object (to open and close file)

        public Form_Delete_Customer(Form_Main_Menu mainMenuForm)
        {
            InitializeComponent();
            ShowCustomerNames();
            mmForm = mainMenuForm;
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
        private void button_removeCustomer_Click(object sender, EventArgs e)
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
                string[] oldLines = File.ReadAllLines("..//..//text_files//ClientFile.txt");
                string[] newLines = new string[oldLines.Length - 1];
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

                File.WriteAllLines("..//..//text_files//ClientFile.txt", newLines);     // Copy into the Client File
                customerIDs.Remove(customerIDs.ElementAt(indexOfSelectedItem));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Returns user back to manager form
            this.Close();
        }
    }
}
