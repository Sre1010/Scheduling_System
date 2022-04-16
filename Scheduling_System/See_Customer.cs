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
    public partial class See_Customer : Form
    {
        List<string> customers = new List<string>();      // List of customer IDs (used to figure out which person to remove from list/file)

        public See_Customer()
        {
            InitializeComponent();
            dataGrid_customer.DataSource = Form_Login.customerList; // Display all events by default

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*public void ShowCustomerList()
{
   foreach (Customer cust in Form_Login.customerList)
   {
       string line = cust.FirstName + cust.LastName + ;      // Only show Event ID
       listBox_Delete_Event.Items.Add(line);
       EventIDs.Add(ev.EventID);                      // Keep track of IDs
   }
}*/
    }
}
