namespace Scheduling_System
{
    partial class ManagerForm
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
            this.removeCustomer_btn = new System.Windows.Forms.Button();
            this.upcomingEvents_Manager_btn = new System.Windows.Forms.Button();
            this.logOut_Manager_btn = new System.Windows.Forms.Button();
            this.cancel_Manager_btn = new System.Windows.Forms.Button();
            this.schedulEvent_Manager_btn = new System.Windows.Forms.Button();
            this.settings_Manager_btn = new System.Windows.Forms.Button();
            this.calander_Manager_btn = new System.Windows.Forms.MonthCalendar();
            this.welcome_Manager_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeCustomer_btn
            // 
            this.removeCustomer_btn.Location = new System.Drawing.Point(703, 348);
            this.removeCustomer_btn.Name = "removeCustomer_btn";
            this.removeCustomer_btn.Size = new System.Drawing.Size(85, 53);
            this.removeCustomer_btn.TabIndex = 0;
            this.removeCustomer_btn.Text = "Remove Customer";
            this.removeCustomer_btn.UseVisualStyleBackColor = true;
            this.removeCustomer_btn.Click += new System.EventHandler(this.removeCustomer_btn_Click);
            // 
            // upcomingEvents_Manager_btn
            // 
            this.upcomingEvents_Manager_btn.Location = new System.Drawing.Point(703, 53);
            this.upcomingEvents_Manager_btn.Name = "upcomingEvents_Manager_btn";
            this.upcomingEvents_Manager_btn.Size = new System.Drawing.Size(85, 53);
            this.upcomingEvents_Manager_btn.TabIndex = 1;
            this.upcomingEvents_Manager_btn.Text = "See Upcoming Events";
            this.upcomingEvents_Manager_btn.UseVisualStyleBackColor = true;
            this.upcomingEvents_Manager_btn.Click += new System.EventHandler(this.upcomingEvents_Manager_btn_Click);
            // 
            // logOut_Manager_btn
            // 
            this.logOut_Manager_btn.Location = new System.Drawing.Point(703, 112);
            this.logOut_Manager_btn.Name = "logOut_Manager_btn";
            this.logOut_Manager_btn.Size = new System.Drawing.Size(85, 53);
            this.logOut_Manager_btn.TabIndex = 2;
            this.logOut_Manager_btn.Text = "Log Out";
            this.logOut_Manager_btn.UseVisualStyleBackColor = true;
            this.logOut_Manager_btn.Click += new System.EventHandler(this.logOut_Manager_btn_Click);
            // 
            // cancel_Manager_btn
            // 
            this.cancel_Manager_btn.Location = new System.Drawing.Point(703, 171);
            this.cancel_Manager_btn.Name = "cancel_Manager_btn";
            this.cancel_Manager_btn.Size = new System.Drawing.Size(85, 53);
            this.cancel_Manager_btn.TabIndex = 3;
            this.cancel_Manager_btn.Text = "Cancel Event";
            this.cancel_Manager_btn.UseVisualStyleBackColor = true;
            this.cancel_Manager_btn.Click += new System.EventHandler(this.cancel_Manager_btn_Click);
            // 
            // schedulEvent_Manager_btn
            // 
            this.schedulEvent_Manager_btn.Location = new System.Drawing.Point(703, 230);
            this.schedulEvent_Manager_btn.Name = "schedulEvent_Manager_btn";
            this.schedulEvent_Manager_btn.Size = new System.Drawing.Size(85, 53);
            this.schedulEvent_Manager_btn.TabIndex = 4;
            this.schedulEvent_Manager_btn.Text = "Schedule an Event";
            this.schedulEvent_Manager_btn.UseVisualStyleBackColor = true;
            this.schedulEvent_Manager_btn.Click += new System.EventHandler(this.schedulEvent_Manager_btn_Click);
            // 
            // settings_Manager_btn
            // 
            this.settings_Manager_btn.Location = new System.Drawing.Point(703, 289);
            this.settings_Manager_btn.Name = "settings_Manager_btn";
            this.settings_Manager_btn.Size = new System.Drawing.Size(85, 53);
            this.settings_Manager_btn.TabIndex = 5;
            this.settings_Manager_btn.Text = "Settings";
            this.settings_Manager_btn.UseVisualStyleBackColor = true;
            this.settings_Manager_btn.Click += new System.EventHandler(this.settings_Manager_btn_Click);
            // 
            // calander_Manager_btn
            // 
            this.calander_Manager_btn.Location = new System.Drawing.Point(279, 89);
            this.calander_Manager_btn.Name = "calander_Manager_btn";
            this.calander_Manager_btn.TabIndex = 6;
            // 
            // welcome_Manager_label
            // 
            this.welcome_Manager_label.AutoSize = true;
            this.welcome_Manager_label.Location = new System.Drawing.Point(34, 30);
            this.welcome_Manager_label.Name = "welcome_Manager_label";
            this.welcome_Manager_label.Size = new System.Drawing.Size(55, 13);
            this.welcome_Manager_label.TabIndex = 7;
            this.welcome_Manager_label.Text = "Welcome ";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome_Manager_label);
            this.Controls.Add(this.calander_Manager_btn);
            this.Controls.Add(this.settings_Manager_btn);
            this.Controls.Add(this.schedulEvent_Manager_btn);
            this.Controls.Add(this.cancel_Manager_btn);
            this.Controls.Add(this.logOut_Manager_btn);
            this.Controls.Add(this.upcomingEvents_Manager_btn);
            this.Controls.Add(this.removeCustomer_btn);
            this.Name = "ManagerForm";
            this.Text = "Manager Form";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeCustomer_btn;
        private System.Windows.Forms.Button upcomingEvents_Manager_btn;
        private System.Windows.Forms.Button logOut_Manager_btn;
        private System.Windows.Forms.Button cancel_Manager_btn;
        private System.Windows.Forms.Button schedulEvent_Manager_btn;
        private System.Windows.Forms.Button settings_Manager_btn;
        private System.Windows.Forms.MonthCalendar calander_Manager_btn;
        private System.Windows.Forms.Label welcome_Manager_label;
    }
}