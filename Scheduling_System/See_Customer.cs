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
    public partial class See_Customer_panel : Form
    {
        List<string> customers = new List<string>();      // List of customer IDs (used to figure out which person to remove from list/file)
        Form_Main_Menu rmc = null;
        Customer modify_customer = null;
        public See_Customer_panel(Form_Main_Menu mainMenuForm)
        {
            InitializeComponent();
            rmc = mainMenuForm;
            //modify_customer = cust;
            dataGrid_customer.DataSource = Form_Login.customerList; // Display all events by default
        }    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_removeCustomer_Click(object sender, EventArgs e)
        {
            // Open delete customer form and hide this one
            this.Close();
            rmc.loadform(new Form_Delete_Customer(rmc));
        }
        private void modifycustomerbusiness()
        {
            // Modify client from  clientlist
            foreach (Customer cust in Form_Login.customerList)
            {
                if (cust.CustomerID == modify_customer.CustomerID)     // Modify date of event based on event ID
                {
                    cust.BussinessName = change_business.Text;
                    modify_customer.BussinessName = cust.BussinessName;
                    break;
                }
            }

            // Modify in file
            string[] oldLines = File.ReadAllLines("..//..//text_files//ClientFile.txt");
            string[] newLines = new string[oldLines.Length];
            int index = 0;
            foreach (string line in oldLines)
            {
                if (line == null)
                    break;
                string[] lineInfo = line.Split(',');
                if (lineInfo[0] == modify_customer.CustomerID) // If event ID of selected event found, modify the line
                {
                    newLines[index] = modifiedBusiness();
                    index++;
                    continue;
                }
                newLines[index] = line;
                index++;
            }

            File.WriteAllLines("..//..//text_files//ClientFile.txt", newLines);     // Copy into the Event File
            
        }
        private void modifycustomerfname()
        {
            // Modify client from  clientlist
            foreach (Customer cust in Form_Login.customerList)
            {
                if (cust.CustomerID == modify_customer.CustomerID)     // Modify date of event based on event ID
                {
                    cust.FirstName = change_FL.Text;
                    modify_customer.BussinessName = cust.BussinessName;
                    break;
                }
            }

            // Modify in file
            string[] oldLines = File.ReadAllLines("..//..//text_files//ClientFile.txt");
            string[] newLines = new string[oldLines.Length];
            int index = 0;
            foreach (string line in oldLines)
            {
                if (line == null)
                    break;
                string[] lineInfo = line.Split(',');
                if (lineInfo[0] == modify_customer.CustomerID) // If event ID of selected event found, modify the line
                {
                    newLines[index] = modifiedfirstname();
                    index++;
                    continue;
                }
                newLines[index] = line;
                index++;
            }

            File.WriteAllLines("..//..//text_files//ClientFile.txt", newLines);     // Copy into the Event File

        }
        private void modifycustomerlname()
        {
            // Modify client from  clientlist
            foreach (Customer cust in Form_Login.customerList)
            {
                if (cust.CustomerID == modify_customer.CustomerID)     // Modify date of event based on event ID
                {
                    cust.LastName = change_LN.Text;
                    modify_customer.BussinessName = cust.BussinessName;
                    break;
                }
            }

            // Modify in file
            string[] oldLines = File.ReadAllLines("..//..//text_files//ClientFile.txt");
            string[] newLines = new string[oldLines.Length];
            int index = 0;
            foreach (string line in oldLines)
            {
                if (line == null)
                    break;
                string[] lineInfo = line.Split(',');
                if (lineInfo[0] == modify_customer.CustomerID) // If event ID of selected event found, modify the line
                {
                    newLines[index] = modifiedlastname();
                    index++;
                    continue;
                }
                newLines[index] = line;
                index++;
            }

            File.WriteAllLines("..//..//text_files//ClientFile.txt", newLines);     // Copy into the Event File

        }
        private string modifiedBusiness()
        {
            return modify_customer.CustomerID + "," + change_business.Text + "," + modify_customer.FirstName + "," + modify_customer.LastName + "," + modify_customer.EmailC + modify_customer.PhoneNumberC + Form_Login.current_employee;
            //CL1231,"BussinesName1",ClientFirstName1,ClientLastName1,03/04/1974,client1@usf.edu,123-456-789
        }

        private string modifiedfirstname()
        {
            return modify_customer.CustomerID + "," + modify_customer.BussinessName + "," + change_FL.Text + "," + modify_customer.LastName + "," + modify_customer.EmailC + modify_customer.PhoneNumberC + Form_Login.current_employee;
        }
        private string modifiedlastname()
        {
            return modify_customer.CustomerID + "," + modify_customer.BussinessName + "," + modify_customer.FirstName + "," + change_LN.Text + "," + modify_customer.EmailC + modify_customer.PhoneNumberC + Form_Login.current_employee;
        }

        private void modify_bus_Click(object sender, EventArgs e)
        {
            if(change_business.Text != null)
            {
                modifycustomerbusiness();
            }
            if (change_FL.Text != null)
            {
                modifycustomerfname();
            }
            if (change_LN.Text != null)
            {
                modifycustomerlname();
            }

        }
    }
}
