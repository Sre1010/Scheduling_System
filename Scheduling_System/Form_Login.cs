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
        public static Form_Login form_login_instance;
        public Form_Login()
        {
            form_login_instance = this;
            InitializeComponent();
        }

        /// <summary>
        /// This function hides the login page and shows the main menu to the user.
        /// This is a temporary function for demonstration purposes for the group.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_temp_main_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_Menu fmm = new Form_Main_Menu(form_login_instance, textBox_username.Text);
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

                //if Username and password are acceptable, check against the databse
                checkEmployeeInTheEmployeeFile(textBox_username.Text, textBox_password.Text);
            }
        }

        private void checkEmployeeInTheEmployeeFile(string username, string password)
        {
            string currentline = "";
            string[] fields;

            //The TXT file is stored inside of automatically created Debug folder
            StreamReader FileReader = new StreamReader(@"EmployeeFile.txt");

            //check if the right username is passed
            Console.WriteLine("Current username is {0}", username);
   
            while (!FileReader.EndOfStream)
            {
                currentline = FileReader.ReadLine();

                fields = currentline.Split(',');

                Console.WriteLine(fields[0]); //gets only ID!!!!

                /*This version only checks the appearance of the password and username in the file. They are not linked together.
                  If password is connected to another username it will still says that the username was found*/
                if (fields[0].Contains(username) && fields[1].Contains(password))
                {
                    Console.WriteLine("USERNAME FOUND IN THE DATABASE");
                    break;
                }
              
            }
        }
    
    }
}
