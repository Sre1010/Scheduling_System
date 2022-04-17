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
    public partial class Form_Modify_Event : Form
    {
        Form_Main_Menu fmm = null;
        Event modifiedEvent = null;
        public Form_Modify_Event(Form_Main_Menu mainMenuForm, Event ev)
        {
            InitializeComponent();
            fmm = mainMenuForm;
            modifiedEvent = ev;
            label_event_ID.Text = "Event ID: " + ev.EventID;
            label_customer_ID.Text = "Customer ID: " + ev.CustomerIDE;
            label_booked_date.Text = "Booked Date: " + ev.BookedDate.ToString();
            label_description.Text = "Description: " + ev.Description;
        }

        private void button_exit_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_change_date_Click(object sender, EventArgs e)
        {
            if (isDateAvailable())
            {
                modifyDateOfEvent();
                MessageBox.Show("Event has been modified");
            }
            else
            {
                MessageBox.Show("Date not available. Select another date.");
            }
        }

        private void button_change_description_Click(object sender, EventArgs e)
        {
            modifyDescriptionOfEvent();
            MessageBox.Show("Event has been modified");
        }

        private bool isDateAvailable()
        {
            if (Form_Login.eventList.Exists(x => x.BookedDate == DateTime.Parse(dateTimePicker_new_date.Text).Date))
            {
                return false;
            }

            return true;
        }

        private void modifyDateOfEvent()
        {
            // Modify event from event list
            foreach (Event ev in Form_Login.eventList)
            {
                if (ev.EventID == modifiedEvent.EventID)     // Modify date of event based on event ID
                {
                    ev.BookedDate = DateTime.Parse(dateTimePicker_new_date.Text).Date;
                    modifiedEvent.BookedDate = DateTime.Parse(dateTimePicker_new_date.Text).Date;
                    break;
                }
            }

            // Modify in file
            string[] oldLines = File.ReadAllLines("..//..//text_files//EventFile.txt");
            string[] newLines = new string[oldLines.Length];
            int index = 0;
            foreach (string line in oldLines)
            {
                if (line == null)
                    break;
                string[] lineInfo = line.Split(',');
                if (lineInfo[0] == modifiedEvent.EventID) // If event ID of selected event found, modify the line
                {
                    newLines[index] = modifiedDateLine();
                    index++;
                    continue;
                }
                newLines[index] = line;
                index++;
            }

            File.WriteAllLines("..//..//text_files//EventFile.txt", newLines);     // Copy into the Event File
            update_modify_event_page();
        }

        private void modifyDescriptionOfEvent()
        {
            // Modify event from event list
            foreach (Event ev in Form_Login.eventList)
            {
                if (ev.EventID == modifiedEvent.EventID)     // Modify description of event based on event ID
                {
                    ev.Description = textBox_new_description.Text;
                    modifiedEvent.Description = textBox_new_description.Text;
                    break;
                }
            }

            // Modify in file
            string[] oldLines = File.ReadAllLines("..//..//text_files//EventFile.txt");
            string[] newLines = new string[oldLines.Length];
            int index = 0;
            foreach (string line in oldLines)
            {
                if (line == null)
                    break;
                string[] lineInfo = line.Split(',');
                if (lineInfo[0] == modifiedEvent.EventID) // If event ID of selected event found, modify the line
                {
                    newLines[index] = modifiedDescriptionLine();
                    index++;
                    continue;
                }
                newLines[index] = line;
                index++;
            }

            File.WriteAllLines("..//..//text_files//EventFile.txt", newLines);     // Copy into the Event File
            update_modify_event_page();
        }

        private string modifiedDateLine()
        {
            return modifiedEvent.EventID + "," + modifiedEvent.CustomerIDE + "," + DateTime.Parse(dateTimePicker_new_date.Text).Date + "," + modifiedEvent.Description + "," + Form_Login.current_employee;
        }

        private string modifiedDescriptionLine()
        {
            return modifiedEvent.EventID + "," + modifiedEvent.CustomerIDE + "," + modifiedEvent.BookedDate + "," + textBox_new_description.Text + "," + Form_Login.current_employee;
        }

        private void button_modify_different_event_Click(object sender, EventArgs e)
        {
            this.Close();
            fmm.loadform(new Form_See_Upcoming_Events(fmm));
        }

        private void update_modify_event_page()
        {
            label_event_ID.Text = "Event ID: " + modifiedEvent.EventID;
            label_customer_ID.Text = "Customer ID: " + modifiedEvent.CustomerIDE;
            label_booked_date.Text = "Booked Date: " + modifiedEvent.BookedDate.ToString();
            label_description.Text = "Description: " + modifiedEvent.Description;
        }
    }
}

