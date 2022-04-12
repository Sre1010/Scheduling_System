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
    public partial class Form_Cancel_Event : Form
    {
        List<string> EventIDs = new List<string>();      // List of customer IDs (used to figure out which person to remove from list/file)
        ManagerForm mForm = null;                           // Manager form object (to open and close file)
        public Form_Cancel_Event(ManagerForm managerForm)
        {
            InitializeComponent();
            ShowEventID();
            mForm = managerForm;
        }

        public Form_Cancel_Event()
        {
            InitializeComponent();
            ShowEventID();
            //mForm = managerForm;
        }

        public void ShowEventID()
        {
            foreach (Event ev in Form_Login.eventList)
            {
                string line = ev.EventID;      // Only show Event ID
                listBox_Delete_Event.Items.Add(line);
                EventIDs.Add(ev.EventID);                      // Keep track of IDs
            }
        }



        // Returns user back to manager form
        private void return_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main_Menu fmm = new Form_Main_Menu();

            this.Hide();
            fmm.Show();
            //mForm.Show();
        }

        private void Form_Cancel_Event_Load_1(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click_1(object sender, EventArgs e)
        {
            if (listBox_Delete_Event.SelectedItem != null)
            {
                string selectedItem = listBox_Delete_Event.SelectedItem.ToString();          // What the user selected on the listbox
                int indexOfSelectedItem = listBox_Delete_Event.SelectedIndex;
                listBox_Delete_Event.Items.Remove(listBox_Delete_Event.SelectedItem);     // Remove from listbox

                // Remove from list of customers
                foreach (Event ev in Form_Login.eventList)
                {
                    if (ev.EventID == EventIDs.ElementAt(indexOfSelectedItem))     // Remove customer based on customer ID
                    {
                        Form_Login.eventList.Remove(ev);
                        break;
                    }
                }

                // Remove from file
                string[] oldLines = File.ReadAllLines("EventFile.txt");
                string[] newLines = new string[oldLines.Length - 1];
                int index = 0;
                foreach (string line in oldLines)
                {
                    if (line == null)
                        break;
                    string[] lineInfo = line.Split(',');
                    if (lineInfo[0] == EventIDs.ElementAt(indexOfSelectedItem))      // If customer ID of selected customer found, remove line from file
                        continue;
                    newLines[index] = line;
                    index++;
                }

                File.WriteAllLines("ClientFile.txt", newLines);     // Copy into the Client File
                EventIDs.Remove(EventIDs.ElementAt(indexOfSelectedItem));
            }
        }
       
    }
}
