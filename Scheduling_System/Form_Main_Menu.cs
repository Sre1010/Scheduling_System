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
    public partial class Form_Main_Menu : Form
    {
        private string username;
        Form_Login form_login;
        New_Event_Form form_event;

        /// <summary>
        /// This is the constructor for the main menu form.
        /// It expects a username.
        /// </summary>
        /// <param name="u"></param>
        public Form_Main_Menu(Form_Login fl, string u)
        {
            InitializeComponent();
            username = u;
            label_TodaysDate.Text = DateTime.Now.ToShortDateString();
            form_login = fl;

            // Hide remove customer button from associate  
            if (username[2] == 'A')
                button_removeCustomer.Visible = false;
            // Show remove customer button to manager
            else if (username[2] == 'M')
                button_removeCustomer.Visible = true;
        }

        public void loadform(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
            {
                this.main_panel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();

        }
        public Form_Main_Menu()
        {
        }

        /// <summary>
        /// This functions shows the login page to the user and closes the main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_temp_login_Click(object sender, EventArgs e)
        {
            form_login.Show();
            this.Close();
        }

        /// <summary>
        /// This function shows the login page to the user if the close out of the main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Show();
        }

        private void Form_Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button_scheduled_events_Click(object sender, EventArgs e)
        {
            Control control = new Control();
            control.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_schedule_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            New_Event_Form event_form = new New_Event_Form();
            event_form.ShowDialog();
            this.Show(); */
            loadform(new New_Event_Form());

        }

        private void label_TodaysDate_Click(object sender, EventArgs e)
        {
            
        }

        // Only shows for manager, able to remove cutomer from client file
        private void button_removeCustomer_Click(object sender, EventArgs e)
        {
            // Open delete customer form and hide this one
            loadform(new Form_Delete_Customer(this));
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            loadform(new Cancel_Event_Form());

        }
    }
}
