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
    public partial class Form_Login : Form
    {
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
                return EmployeeID + Password + FirstNameE + LastNameE + dobE + EmailE + PhoneNumberE + AdressE;
            }

        }

        
        public class Customer
        {
            public Customer(string customerID, string bussinessName, string firstName, string lastName, 
                DateTime dobC, string emailC, string phoneNumberC, string adressC)
            {
                CustomerID = customerID;
                BussinessName = bussinessName;
                FirstName = firstName;
                LastName = lastName;
                this.dobC = dobC;
                EmailC = emailC;
                PhoneNumberC = phoneNumberC;
                AdressC = adressC;
            }

            public string CustomerID { get; set; }
            public string BussinessName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            DateTime dobC { get; set; }
            public string EmailC { get; set; }
            public string PhoneNumberC { get; set; }
            public string AdressC { get; set; }

        }
        public class Event
        {
            public Event(string eventID, string customerIDE, DateTime bookedDate, string employeeIDE)
            {
                EventID = eventID;
                CustomerIDE = customerIDE;
                BookedDate = bookedDate;
                EmployeeIDE = employeeIDE;
            }

            public string EventID { get; set; }
            public string CustomerIDE { get; set; }
            DateTime BookedDate { get; set; }
            public string EmployeeIDE { get; set; }

        }

        List<string> lines = new List<string>();
        List<Employee> employeeList = new List<Employee>();
        public static Form_Login form_login_instance;
        public Form_Login()
        {
            form_login_instance = this;
            InitializeComponent();
            createEmployeeList();

        }

      /*creates a lit of customer that will be used throughout the program*/

        private void button_temp_main_menu_Click(object sender, EventArgs e)
        { 

            Form_Main_Menu fmm = new Form_Main_Menu(form_login_instance, textBox_username.Text);

            this.Hide();
            fmm.Show();
        }

        // <summary>
        // When the user presses the lightbulb button (next to username)
        // It will display a hint on the username and password requirements
        private void button_usernameHint_Click(object sender, EventArgs e)
        {
            if (label_usernameHint.Visible == false)    // If hidden, make visible when user presses button
            {
                label_usernameHint.Text = "Username: 9 total characters (EX: SSM123456)\n3 uppercase letters for role then 5 numbers for ID.\n\nPassword: At least 8 characters (EX: Password$)\nAt least 1 lowercase, 1 uppercase, and 1 special symbol.";
                label_usernameHint.Visible = true;
            }
            else
                label_usernameHint.Visible = false;     // If hidden, make invisible when user presses button
        }

        // <summary>
        // When the user presses the "Exit" button
        // It will close the application
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // <summary>
        // When the user presses the "Log in" button
        // Verifies username and password and then opens another form if username and password follow the correct format
        private void button_login_Click(object sender, EventArgs e)
        {
            Boolean isUsernameAcceptable = true;    // Keep track if username fits qualifications (3 uppercase letters + 6 numbers)
            Boolean isPasswordAcceptable = true;    // Keep track if password fits qualifications (has at least 1 uppercase letter, 1 lowercase letter, 1 special symbol)
            Boolean hasUppercaseLetter = false;     // Keep track if password has at least 1 uppercase letter
            Boolean hasLowerCaseLetter = false;     // Keep track if password has at least 1 lowercase letter
            Boolean hasSpecialSymbol = false;       // Keep track if password has at least 1 special symbol

            //------------------------ Verify username ------------------------//

            // Verify letters, make sure there's 3 uppercase letters in beginning
            for (int i = 0; i <= 2; i++)
            {
                if (char.IsLetter(textBox_username.Text[i]) == false)
                    isUsernameAcceptable = false;
                if (char.IsUpper(textBox_username.Text[i]) == false)
                    isUsernameAcceptable = false;
            }

            // If the above qualifications are true (3 uppercase letters)
            if (isUsernameAcceptable == true)
            {
                // Verify numbers, make sure there's 6 numbers at end
                for (int i = 3; i <= 8; i++)
                {
                    if (char.IsNumber(textBox_username.Text[i]) == false)
                        isUsernameAcceptable = false;
                }
            }

            // Display to the user that the username does not follow the correct qualifications
            if (isUsernameAcceptable == false)
            {
                label_verifyLogin.Visible = true;
                label_verifyLogin.Text = "Invalid username.";
            }
            // If input does not have SSM or SSA role, display to user
            else if (!textBox_username.Text.StartsWith("SSM") && !textBox_username.Text.StartsWith("SSA"))
            {
                label_verifyLogin.Visible = true;
                label_verifyLogin.Text = "Invalid username role.\nValid roles are SSM or SSA.";
                isUsernameAcceptable = false;
            }

            //------------------------ Verify password ------------------------//

            // If the username folows the qualifications
            if (isUsernameAcceptable == true)
            {
                // Verify if password is at least 8 characters + at least 1 is uppercase, at least 1 is lowercase, and at least 1 is special symbol
                foreach (char c in textBox_password.Text)
                {
                    if (char.IsUpper(c))
                        hasUppercaseLetter = true;
                    if (char.IsLower(c))
                        hasLowerCaseLetter = true;
                    if (!char.IsLetterOrDigit(c))
                        hasSpecialSymbol = true;
                }

                // Display to the user that the password does not follow the correct qualifications
                if (hasUppercaseLetter == false || hasLowerCaseLetter == false || hasSpecialSymbol == false)
                {
                    label_verifyLogin.Visible = true;
                    label_verifyLogin.Text = "Invalid password.";
                    isPasswordAcceptable = false;
                }
            }

            // If username and password follow the right format, go to the main menu *FOR NOW*
            /* TO DO: Instead will have to go to Retention Form depending on first 3 letters */
            if (isUsernameAcceptable == true && isPasswordAcceptable == true)
            {
                label_verifyLogin.Visible = false;       // Hide verification of username/password (Don't remove)

                /////////////////////////////////////////////////////////////////// Remove later
                // Hide the login page and show the main menu to the user *FOR NOW*
                this.Hide();
                Form_Main_Menu fmm = new Form_Main_Menu(form_login_instance, textBox_username.Text);
                fmm.Show();
                /////////////////////////////////////////////////////////////////// Remove later

                // Redirect to Manager Retention Form
                if (textBox_username.Text.StartsWith("SSM"))
                {
                    /* TO DO */

                }
                // Redirect to Associate Retention Form
                else if (textBox_username.Text.StartsWith("SSA"))
                {
                    /* TO DO */

                }
            }

            checkPassword(textBox_username.Text, textBox_password.Text);
        }

        public void checkPassword(string s, string p)
        {
            bool isFound = false;
            foreach (Employee e in employeeList)
            {
                if (e.EmployeeID == s)
                {
                    if (e.Password == p)
                    {

                        Console.WriteLine("Employee found in the database");
                        isFound = true;
                        break;
                    }
                    else
                        Console.WriteLine("Employee found, but wrong password");
                    break;
                }
                else
                    isFound = false;
            }

            if (isFound == false)
            {
                Console.WriteLine("Employee not found or password is incorrect");
            }
        }
        private void createEmployeeList()
        {
            string filePath = @"EmployeeFile.txt";

            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Employee e = new Employee(items[0], items[1], items[2], items[3], DateTime.Parse(items[4]), items[5],
                    items[6], items[7]);
                employeeList.Add(e);

            }

            //to print the whole list
            foreach (Employee e in employeeList)
            {
                Console.WriteLine(e);
            }
        }
        /// ULIANA IS STILL WORKING ON IT 3/19

      
    
    }
}
