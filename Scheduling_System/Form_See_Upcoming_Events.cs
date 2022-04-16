using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_System
{
    public partial class Form_See_Upcoming_Events : Form
    {
        public Form_See_Upcoming_Events()
        {
            InitializeComponent();
            dataGridView_events.DataSource = Form_Login.eventList; // Display all events by default
        }

        private void button_exit_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            List<Event> filteredEventList = new List<Event>();

            foreach (Event ev in Form_Login.eventList)
            {
                if (filter_date_range(ev)) // checks date range and searches for company name
                {
                    if (textBox_client_company_name.Text == "") // No client company name was provided
                    {
                        filteredEventList.Add(ev); // Include this event
                        continue; 
                    }

                    string customerID = filter_company_name();


                    if (customerID == "") // No registered client found with given company name
                    {
                        continue; // Do not include this event
                    }
                    else if (ev.CustomerIDE == customerID) // Client is registered in the system and scheduled this event
                    {
                        Console.WriteLine(customerID);
                        filteredEventList.Add(ev); // Include this event
                        continue;
                    }
                    else // Client is registered in the system but did not schedule this event
                    {
                        continue; // Do not include this event
                    }
                }
                else 
                {
                    continue; // Do not include this event
                }

                
            }

            dataGridView_events.DataSource = filteredEventList;
        }

        private bool filter_date_range(Event ev)
        {
            if (ev.BookedDate >= dateTimePicker_start.Value && ev.BookedDate <= dateTimePicker_end.Value) // Check if event date is between start and end date
            {
                return true;
            }

            return false;
        }

        private string filter_company_name()
        {
            foreach(Customer c in Form_Login.customerList) // Search for the customer ID that matches the client company name
            {
                if (c.BussinessName.ToLower() == textBox_client_company_name.Text.ToLower())
                {
                    return c.CustomerID;
                }
            }

            return "";
        }

        private void button_modify_events_Click(object sender, EventArgs e) // DOES NOT DO ANYTHING OTHER THAN CLOSING THE CURRENT FORM
        {
            this.Close();
        }
    }
}
