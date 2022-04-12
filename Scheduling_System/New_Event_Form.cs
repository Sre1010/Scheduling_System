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
    public partial class New_Event_Form : Form
    {
        public New_Event_Form()
        {
            InitializeComponent();
        }

        /*creates a New Event*/
        private void button1_Click(object sender, EventArgs e)
        {
            createNewEvent();
            //buttons: bussines, first, last, phone, email, dateofbirth, event date, event description
        }

        private void createNewEvent()
        {
            int exist;

            //generate an Event ID
            string filepath = @"EventFile.txt";
            string start = "EV";

            Random rand = new Random();
            string digits = rand.Next(0000, 9999).ToString();
            string event_id = start + digits;

            string cust_id = checkIfCustomerExist(); //if customer exists, it returns existing customer id, "0" is doesnt exist
            
            if(cust_id == "0")// ==0 customer does not exist
            {
              cust_id = createNewCustomer(); //override with the new customer ID
            }
            while (true)
            {
                //check if date is available
                if (isDateAvailable() == false)
                {
                    MessageBox.Show("Date not available");

                    //reset the date
                    dateTimePicker_Event.Value = DateTime.Now;
                    break;
                }
                else
                {
                    Event new_event = new Event(event_id, cust_id, DateTime.Parse(dateTimePicker_Event.Text), textBox_EventDescription.Text, Form_Login.current_employee);

                    Form_Login.eventList.Add(new_event);

                    List<string> lines = new List<string>();

                    string event_new = event_id + "," + cust_id + "," + DateTime.Parse(dateTimePicker_Event.Text) + "," + textBox_EventDescription.Text + "," + Form_Login.current_employee;
                    lines.Add(event_new);

                    File.AppendAllLines(filepath, lines);
                    MessageBox.Show("Event has been scheduled!");
                    break;
                }
            }

        }
        private bool isDateAvailable()
        {
            if (Form_Login.eventList.Exists(x => x.BookedDate == DateTime.Parse(dateTimePicker_Event.Text)))
                return false;

            return true;
        }
        private string createNewCustomer()
        {
            //generate a customer ID
            //CL1234
            string filepath = @"ClientFile.txt";
            string start = "CL";

            Random rand = new Random();
            string digits = rand.Next(0000, 9999).ToString();
            string id = start + digits;

            //create a new Customer
            Customer new_cust = new Customer(id, textBox_BusName.Text, textBox_FirstName.Text, textBox_LastName.Text,
                DateTime.Parse(this.dateTimePicker_DOB.Text), textBox_Email.Text, textBox_PhoneNum.Text);

            Form_Login.customerList.Add(new_cust);

            //need to write to a file as well
            List<string> lines = new List<string>();

            string customer = id + "," + textBox_BusName.Text + "," + textBox_FirstName.Text + "," + textBox_LastName.Text + "," +
                DateTime.Parse(this.dateTimePicker_DOB.Text) + "," + textBox_Email.Text + "," + textBox_PhoneNum.Text;
            lines.Add(customer);

            File.AppendAllLines(filepath, lines);

            //outputting all customers to the console to check if added
            foreach (Customer cust in Form_Login.customerList)
            {
                Console.WriteLine(cust);
            }

            return id;

        }

        public string checkIfCustomerExist()
        {
            // if (Form_Login.customerList.Contains( new Customer { BussinessName = textBox_BusName.Text } ));
            string id1;
            //right now only checks for exact match
            if (Form_Login.customerList.Exists(x => x.BussinessName == textBox_BusName.Text))
            {
                //if customer exist, get its ID.
                //var matches = Form_Login.customerList.Where(p => String.Equals(p.BussinessName, textBox_BusName.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                id1 = Form_Login.customerList.Where(x => x.BussinessName == textBox_BusName.Text).Select(x => x.CustomerID).ToString();
                

            }
            else
            {
                id1 = "0";
            }
            return id1;            
        }

        private void button_backToMainMenu_Click(object sender, EventArgs e)
        {
            /*Form_Main_Menu main_form = new Form_Main_Menu();
            this.Hide();
            main_form.Show(); */
            this.DialogResult = DialogResult.OK;

        }

        private void New_Event_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
