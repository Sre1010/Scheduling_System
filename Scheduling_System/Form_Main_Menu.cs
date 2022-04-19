﻿using System;
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

            //Set Today's Event text
            if (Form_Login.eventList.Exists(x => x.BookedDate == DateTime.Today))
            {
                foreach (Event ev in Form_Login.eventList)
                {
                    if(ev.BookedDate == DateTime.Today)
                    {
                        string event_text = ev.Description;
                        event_text = event_text.Substring(1, event_text.Length-2); //removes quotations marks from description text
                        label_todays_event.Text = "Today's event: " + event_text + "!";
                        break;
                    }
                }
            }
            else
                label_todays_event.Text = "No events Scheduled for Today";
            
            //display Employee name
            label_employee_name.Text = getUserName(u);

            // Hide remove customer button and from associate  
            if (username[2] == 'A')
            {
                button_removeCustomer.Visible = false;
            }
            // Show remove customer button to manager
            else if (username[2] == 'M')
            {
                button_removeCustomer.Visible = true;
            }
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
            form_login.textBox_username.Text = "";
            form_login.textBox_password.Text = "";
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
            loadform(new Form_See_Upcoming_Events(this));
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

        private void todays_event_Click(object sender, EventArgs e)
        {

        }

        //takes User ID, returns string containing their first name and last name separated by a space
        private string getUserName(string id)
        {
            string filePath = "..//..//text_files//EmployeeFile.txt";

            List<string> names = File.ReadAllLines(filePath).ToList();

            string fullName = "";

            foreach (string name in names)
            {
                string[] items = name.Split(',');
                Console.WriteLine("ITEM LENGTH: " + items.Length);
                if (items[0].Equals(id))
                {
                    fullName = items[2] + " " + items[3];
                    goto found; //line 176, just returns fullName
                }
            }

            names.Clear();
            return "Failed to find matching ID";

            found:
            {
                names.Clear();
                return fullName;
            }
            
        }
    }
}
