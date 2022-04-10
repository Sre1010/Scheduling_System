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
            //if customer does not exist, generate new customer ID. -->
            //               function checkiIfCustomerExist(take the textboxes, check for bussiness - first - last in the current list).


            //if booked date is available --> checkCalendar function
            //put employee ID under which the system if working

            //Event new_event = new Event();
         }

        public void checkIfCustomerExist()
        {
            // if (Form_Login.customerList.Contains( new Customer { BussinessName = textBox_BusName.Text } ));
            //right now only checks for exact match
            if (Form_Login.customerList.Exists(x => x.BussinessName == textBox_BusName.Text))
            {

            }
            
        }


    }
}
