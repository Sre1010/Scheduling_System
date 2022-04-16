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
        }

        private void button_exit_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
