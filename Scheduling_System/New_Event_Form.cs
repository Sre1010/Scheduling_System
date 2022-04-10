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
            //Client File: CL1234,"BussinesName3",ClientFirstName1,ClientLastName1,03/04/1974,client1@usf.edu,123-456-789
            //Event File: eventID, clientID.....employeeID EV010,CL1231,03/21/2022,"HolyMolly2 Event",SSA223456

            //every time we create a new event, we create a new object of: Event and Client
            /*          CustomerID = customerID;
            BussinessName = bussinessName;
            FirstName = firstName;
            LastName = lastName;
            this.dobC = dobC;
            EmailC = emailC;
            PhoneNumberC = phoneNumberC; 

            Event:             EventID = eventID;
            CustomerIDE = customerIDE;
            BookedDate = bookedDate;
            Description = description;
            EmployeeIDE = employeeIDE; */

            //generate an Event ID

            if (checkIfCustomerExist() == 0) // ==0 customer does not exist
            {
               createNewCustomer();
            }

            //check if date is available(not booked)
            //if booked, say booked and let the other person change the date
            //if not booked:
            //create a new event//get employeeID

            //Event new_event = new Event();
         }

        private void createNewCustomer()
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
                DateTime.Parse(textBox_DoB.Text), textBox_Email.Text, textBox_PhoneNum.Text);
            Form_Login.customerList.Add(new_cust);

            //need to write to a file as well
            List<string> lines = new List<string>();
            string customer = id + "," + textBox_BusName.Text + "," + textBox_FirstName.Text + "," + textBox_LastName.Text + "," +
                DateTime.Parse(textBox_DoB.Text) + "," + textBox_Email.Text + "," + textBox_PhoneNum.Text;
            lines.Add(customer);

            File.WriteAllLines(filepath, lines);

        }

        public int checkIfCustomerExist()
        {
            // if (Form_Login.customerList.Contains( new Customer { BussinessName = textBox_BusName.Text } ));
            int track;
            //right now only checks for exact match
            if (Form_Login.customerList.Exists(x => x.BussinessName == textBox_BusName.Text))
            {
                //if customer exist, return 1
                track = 1;

            }
            else
            {
                track = 0;
            }
            return track;
            
        }

        private void button_backToMainMenu_Click(object sender, EventArgs e)
        {
            /*Form_Main_Menu main_form = new Form_Main_Menu();
            this.Hide();
            main_form.Show(); */
            this.DialogResult = DialogResult.OK;

        }
    }
}
