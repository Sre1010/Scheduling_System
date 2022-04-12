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
    public partial class ManagerForm : Form
    {
        private string username;
        Form_Login form_login;

        // This is the constructor for the main menu form.
        // It expects a username.
        public ManagerForm(Form_Login fl, string u)
        {
            InitializeComponent();
            username = u;
            welcome_Manager_label.Text += u;
            form_login = fl;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        // Takes user to remove customer form so they can select a client to remove
        private void removeCustomer_btn_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            Delete_Customer_Form removeCustomerForm = new Delete_Customer_Form(this);
            removeCustomerForm.Show();*/
        }

        private void upcomingEvents_Manager_btn_Click(object sender, EventArgs e)
        {

        }

        // Closes this form and brings user back to log in screen
        private void logOut_Manager_btn_Click(object sender, EventArgs e)
        {
            form_login.Show();
            this.Close();
        }

        private void cancel_Manager_btn_Click(object sender, EventArgs e)
        {

        }

        private void schedulEvent_Manager_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Event_Form event_form = new New_Event_Form();
            event_form.ShowDialog();
            this.Show();
        }

        private void settings_Manager_btn_Click(object sender, EventArgs e)
        {

        }
    }
}