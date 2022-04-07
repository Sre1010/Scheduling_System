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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_Menu fmm = new Form_Main_Menu(form_login_instance, textBox_username.Text);
            fmm.Show();
        }
    }
}
