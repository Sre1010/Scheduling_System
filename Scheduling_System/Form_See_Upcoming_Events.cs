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
    public partial class Form_See_Upcoming_Events : Form
    {
        public Form_See_Upcoming_Events()
        {
            InitializeComponent();
            dataGridView_events.DataSource = Form_Login.eventList; // Display all events by default
        }

        private void button_exit_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            List<Event> filteredEventList = new List<Event>();

            foreach (Event ev in Form_Login.eventList)
            {
                if (ev.BookedDate >= dateTimePicker_start.Value && ev.BookedDate <= dateTimePicker_end.Value)
                {
                    filteredEventList.Add(ev);
                }
            }

            dataGridView_events.DataSource = filteredEventList;
        }
    }
}
