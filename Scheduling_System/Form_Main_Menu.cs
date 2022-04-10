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

        /// <summary>
        /// This is the constructor for the main menu form.
        /// It expects a username.
        /// </summary>
        /// <param name="u"></param>
        public Form_Main_Menu(Form_Login fl, string u)
        {
            InitializeComponent();
            username = u;
            label_welcome.Text += u;
            form_login = fl;
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

        }
    }
}
