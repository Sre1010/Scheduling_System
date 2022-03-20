
namespace Scheduling_System
{
    partial class Form_Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_temp_login = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_schedule = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_scheduled_events = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Location = new System.Drawing.Point(35, 25);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(55, 13);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome ";
            // 
            // button_temp_login
            // 
            this.button_temp_login.Location = new System.Drawing.Point(696, 250);
            this.button_temp_login.Name = "button_temp_login";
            this.button_temp_login.Size = new System.Drawing.Size(92, 58);
            this.button_temp_login.TabIndex = 1;
            this.button_temp_login.Text = "Logout";
            this.button_temp_login.UseVisualStyleBackColor = true;
            this.button_temp_login.Click += new System.EventHandler(this.button_temp_login_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 63);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(283, 63);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // button_settings
            // 
            this.button_settings.Location = new System.Drawing.Point(697, 313);
            this.button_settings.Margin = new System.Windows.Forms.Padding(2);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(92, 58);
            this.button_settings.TabIndex = 5;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // button_schedule
            // 
            this.button_schedule.Location = new System.Drawing.Point(697, 63);
            this.button_schedule.Margin = new System.Windows.Forms.Padding(2);
            this.button_schedule.Name = "button_schedule";
            this.button_schedule.Size = new System.Drawing.Size(92, 58);
            this.button_schedule.TabIndex = 6;
            this.button_schedule.Text = "Schedule an Event";
            this.button_schedule.UseVisualStyleBackColor = true;
            this.button_schedule.Click += new System.EventHandler(this.button_schedule_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(697, 187);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(92, 58);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel Event";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_scheduled_events
            // 
            this.button_scheduled_events.Location = new System.Drawing.Point(697, 125);
            this.button_scheduled_events.Margin = new System.Windows.Forms.Padding(2);
            this.button_scheduled_events.Name = "button_scheduled_events";
            this.button_scheduled_events.Size = new System.Drawing.Size(92, 58);
            this.button_scheduled_events.TabIndex = 8;
            this.button_scheduled_events.Text = "See Upcomming Events";
            this.button_scheduled_events.UseVisualStyleBackColor = true;
            this.button_scheduled_events.Click += new System.EventHandler(this.button_scheduled_events_Click);
            // 
            // Form_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_scheduled_events);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_schedule);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_temp_login);
            this.Controls.Add(this.label_welcome);
            this.Name = "Form_Main_Menu";
            this.Text = "Form_Main_Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_Menu_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_temp_login;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_schedule;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_scheduled_events;
    }
}