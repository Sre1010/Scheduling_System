using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_System
{
    internal class Class1
    {
    }
    public class Employee
    {
        //Constructor
        public Employee(string employeeID, string password, string firstNameE, string lastNameE,
            DateTime dobE, string emailE, string phoneNumberE, string adressE)
        {
            EmployeeID = employeeID;
            Password = password;
            FirstNameE = firstNameE;
            LastNameE = lastNameE;
            this.dobE = dobE;
            EmailE = emailE;
            PhoneNumberE = phoneNumberE;
            AdressE = adressE;
        }

        public Employee(string employeeID, DateTime recent)
        {
            EmployeeID = employeeID;
            this.recent = recent;
        }

        DateTime recent { get; set; }
        public string EmployeeID { get; set; }
        public string Password { get; set; }
        public string FirstNameE { get; set; }
        public string LastNameE { get; set; }
        DateTime dobE { get; set; }

        public string EmailE { get; set; }
        public string PhoneNumberE { get; set; }
        public string AdressE { get; set; }

        public override string ToString()
        {
            return EmployeeID + " " + Password + " " + FirstNameE + " " + LastNameE + " " + dobE + " " + EmailE + " " + PhoneNumberE + " " + AdressE;
        }

    }


    public class Customer
    {
        public Customer(string customerID, string bussinessName, string firstName, string lastName,
            DateTime dobC, string emailC, string phoneNumberC)
        {
            CustomerID = customerID;
            BussinessName = bussinessName;
            FirstName = firstName;
            LastName = lastName;
            this.dobC = dobC;
            EmailC = emailC;
            PhoneNumberC = phoneNumberC;
        }

        public Customer()
        {
        }

        public string CustomerID { get; set; }
        public string BussinessName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        DateTime dobC { get; set; }
        public string EmailC { get; set; }
        public string PhoneNumberC { get; set; }
        public override string ToString()
        {
            return CustomerID + " " + BussinessName + " " + FirstName + " " + LastName + " " + dobC + " " + EmailC + " " + PhoneNumberC + " ";
        }

    }
    public class Event
    {
        public Event(string eventID, string customerIDE, DateTime bookedDate,
            string description, string employeeIDE)
        {
            EventID = eventID;
            CustomerIDE = customerIDE;
            BookedDate = bookedDate;
            Description = description;
            EmployeeIDE = employeeIDE;
        }

        public string EventID { get; set; }
        public string CustomerIDE { get; set; }
        public DateTime BookedDate { get; set; }
        public string Description { get; set; }
        public string EmployeeIDE { get; set; }

        public override string ToString()
        {
            return EventID + " " + CustomerIDE + " " + BookedDate + " " + Description + " " + EmployeeIDE;
        }

    }

}
