
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main_Menu));
            this.label_date = new System.Windows.Forms.Label();
            this.button_temp_login = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_schedule_Event = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_scheduled_events = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_TodaysDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.AliceBlue;
            this.label_date.Location = new System.Drawing.Point(13, 526);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(60, 19);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "Today:";
            // 
            // button_temp_login
            // 
            this.button_temp_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_temp_login.BackgroundImage")));
            this.button_temp_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_temp_login.FlatAppearance.BorderSize = 0;
            this.button_temp_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_temp_login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_temp_login.ForeColor = System.Drawing.Color.White;
            this.button_temp_login.Location = new System.Drawing.Point(17, 282);
            this.button_temp_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_temp_login.Name = "button_temp_login";
            this.button_temp_login.Size = new System.Drawing.Size(220, 35);
            this.button_temp_login.TabIndex = 1;
            this.button_temp_login.Text = "Logout";
            this.button_temp_login.UseVisualStyleBackColor = true;
            this.button_temp_login.Click += new System.EventHandler(this.button_temp_login_Click);
            // 
            // button_settings
            // 
            this.button_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_settings.BackgroundImage")));
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(17, 398);
            this.button_settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(220, 35);
            this.button_settings.TabIndex = 5;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // button_schedule_Event
            // 
            this.button_schedule_Event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_schedule_Event.BackgroundImage")));
            this.button_schedule_Event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_schedule_Event.FlatAppearance.BorderSize = 0;
            this.button_schedule_Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_schedule_Event.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_schedule_Event.ForeColor = System.Drawing.Color.White;
            this.button_schedule_Event.Location = new System.Drawing.Point(17, 110);
            this.button_schedule_Event.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_schedule_Event.Name = "button_schedule_Event";
            this.button_schedule_Event.Size = new System.Drawing.Size(220, 35);
            this.button_schedule_Event.TabIndex = 6;
            this.button_schedule_Event.Text = "Schedule new Event";
            this.button_schedule_Event.UseVisualStyleBackColor = true;
            this.button_schedule_Event.Click += new System.EventHandler(this.button_schedule_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cancel.BackgroundImage")));
            this.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.White;
            this.button_cancel.Location = new System.Drawing.Point(17, 166);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(220, 35);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Cancel an Event";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_scheduled_events
            // 
            this.button_scheduled_events.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_scheduled_events.BackgroundImage")));
            this.button_scheduled_events.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_scheduled_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scheduled_events.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scheduled_events.ForeColor = System.Drawing.Color.White;
            this.button_scheduled_events.Location = new System.Drawing.Point(17, 224);
            this.button_scheduled_events.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_scheduled_events.Name = "button_scheduled_events";
            this.button_scheduled_events.Size = new System.Drawing.Size(220, 35);
            this.button_scheduled_events.TabIndex = 8;
            this.button_scheduled_events.Text = "See All Upcomming Events";
            this.button_scheduled_events.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_scheduled_events.UseVisualStyleBackColor = true;
            this.button_scheduled_events.Click += new System.EventHandler(this.button_scheduled_events_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1531, 351);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 338);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label_TodaysDate
            // 
            this.label_TodaysDate.AutoSize = true;
            this.label_TodaysDate.BackColor = System.Drawing.Color.Transparent;
            this.label_TodaysDate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TodaysDate.ForeColor = System.Drawing.Color.White;
            this.label_TodaysDate.Location = new System.Drawing.Point(119, 526);
            this.label_TodaysDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TodaysDate.Name = "label_TodaysDate";
            this.label_TodaysDate.Size = new System.Drawing.Size(0, 23);
            this.label_TodaysDate.TabIndex = 10;
            this.label_TodaysDate.Click += new System.EventHandler(this.label_TodaysDate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 77);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.menu_panel.Controls.Add(this.panel1);
            this.menu_panel.Controls.Add(this.pictureBox1);
            this.menu_panel.Controls.Add(this.label_TodaysDate);
            this.menu_panel.Controls.Add(this.button_settings);
            this.menu_panel.Controls.Add(this.label_date);
            this.menu_panel.Controls.Add(this.button_temp_login);
            this.menu_panel.Controls.Add(this.button_scheduled_events);
            this.menu_panel.Controls.Add(this.button_schedule_Event);
            this.menu_panel.Controls.Add(this.button_cancel);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(259, 554);
            this.menu_panel.TabIndex = 14;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Transparent;
            this.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main_panel.Controls.Add(this.label1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.main_panel.Location = new System.Drawing.Point(256, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(811, 554);
            this.main_panel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(256, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 480);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Event for the next 2 weeks needs to be displayed here";
            // 
            // Form_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.main_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Main_Menu";
            this.Text = "SSS Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_Menu_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button button_temp_login;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_schedule_Event;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_scheduled_events;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label_TodaysDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}