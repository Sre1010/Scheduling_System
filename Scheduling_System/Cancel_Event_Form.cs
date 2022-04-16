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
    public partial class Cancel_Event_Form : Form
    {
        List<string> EventIDs = new List<string>();      // List of customer IDs (used to figure out which person to remove from list/file)
        public Cancel_Event_Form()
        {
            InitializeComponent();
            ShowEventID();
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_Delete_Event.SelectedItem != null)
            {
                string selectedItem = listBox_Delete_Event.SelectedItem.ToString();          // What the user selected on the listbox
                int indexOfSelectedItem = listBox_Delete_Event.SelectedIndex;
                listBox_Delete_Event.Items.Remove(listBox_Delete_Event.SelectedItem);     // Remove from listbox

                // Remove from list of customers
                foreach (Event ev in Form_Login.eventList)
                {
                    if (ev.EventID == EventIDs.ElementAt(indexOfSelectedItem))     // Remove event based on event ID
                    {
                        Form_Login.eventList.Remove(ev);
                        break;
                    }
                }

                // Remove from file
                string[] oldLines = File.ReadAllLines("..//..//text_files//EventFile.txt");
                string[] newLines = new string[oldLines.Length - 1];
                int index = 0;
                foreach (string line in oldLines)
                {
                    if (line == null)
                        break;
                    string[] lineInfo = line.Split(',');
                    if (lineInfo[0] == EventIDs.ElementAt(indexOfSelectedItem))      // If event ID of selected event found, remove line from file
                        continue;
                    newLines[index] = line;
                    index++;
                }

                File.WriteAllLines("..//..//text_files//EventFile.txt", newLines);     // Copy into the Event File
                EventIDs.Remove(EventIDs.ElementAt(indexOfSelectedItem));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
