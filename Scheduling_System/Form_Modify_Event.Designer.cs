
namespace Scheduling_System
{
    partial class Form_Modify_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Modify_Event));
            this.button_exit_form = new System.Windows.Forms.Button();
            this.label_event_ID = new System.Windows.Forms.Label();
            this.label_customer_ID = new System.Windows.Forms.Label();
            this.label_booked_date = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_new_description = new System.Windows.Forms.Label();
            this.label_new_booked_date = new System.Windows.Forms.Label();
            this.button_change_date = new System.Windows.Forms.Button();
            this.dateTimePicker_new_date = new System.Windows.Forms.DateTimePicker();
            this.button_change_description = new System.Windows.Forms.Button();
            this.textBox_new_description = new System.Windows.Forms.TextBox();
            this.button_modify_different_event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit_form
            // 
            this.button_exit_form.BackColor = System.Drawing.Color.SteelBlue;
            this.button_exit_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit_form.FlatAppearance.BorderSize = 0;
            this.button_exit_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit_form.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold);
            this.button_exit_form.Location = new System.Drawing.Point(787, -1);
            this.button_exit_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit_form.Name = "button_exit_form";
            this.button_exit_form.Size = new System.Drawing.Size(25, 26);
            this.button_exit_form.TabIndex = 6;
            this.button_exit_form.Text = "X";
            this.button_exit_form.UseVisualStyleBackColor = false;
            this.button_exit_form.Click += new System.EventHandler(this.button_exit_form_Click);
            // 
            // label_event_ID
            // 
            this.label_event_ID.AutoSize = true;
            this.label_event_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_event_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_event_ID.Location = new System.Drawing.Point(16, 105);
            this.label_event_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_event_ID.Name = "label_event_ID";
            this.label_event_ID.Size = new System.Drawing.Size(83, 20);
            this.label_event_ID.TabIndex = 10;
            this.label_event_ID.Text = "Event ID: ";
            // 
            // label_customer_ID
            // 
            this.label_customer_ID.AutoSize = true;
            this.label_customer_ID.BackColor = System.Drawing.Color.Transparent;
            this.label_customer_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_ID.Location = new System.Drawing.Point(251, 105);
            this.label_customer_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customer_ID.Name = "label_customer_ID";
            this.label_customer_ID.Size = new System.Drawing.Size(114, 20);
            this.label_customer_ID.TabIndex = 11;
            this.label_customer_ID.Text = "Customer ID: ";
            // 
            // label_booked_date
            // 
            this.label_booked_date.AutoSize = true;
            this.label_booked_date.BackColor = System.Drawing.Color.Transparent;
            this.label_booked_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_booked_date.Location = new System.Drawing.Point(515, 105);
            this.label_booked_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_booked_date.Name = "label_booked_date";
            this.label_booked_date.Size = new System.Drawing.Size(116, 20);
            this.label_booked_date.TabIndex = 12;
            this.label_booked_date.Text = "Booked Date: ";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.BackColor = System.Drawing.Color.Transparent;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(16, 153);
            this.label_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(105, 20);
            this.label_description.TabIndex = 13;
            this.label_description.Text = "Description: ";
            // 
            // label_new_description
            // 
            this.label_new_description.AutoSize = true;
            this.label_new_description.BackColor = System.Drawing.Color.Transparent;
            this.label_new_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_new_description.Location = new System.Drawing.Point(16, 335);
            this.label_new_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_new_description.Name = "label_new_description";
            this.label_new_description.Size = new System.Drawing.Size(143, 20);
            this.label_new_description.TabIndex = 14;
            this.label_new_description.Text = "New Description: ";
            // 
            // label_new_booked_date
            // 
            this.label_new_booked_date.AutoSize = true;
            this.label_new_booked_date.BackColor = System.Drawing.Color.Transparent;
            this.label_new_booked_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_new_booked_date.Location = new System.Drawing.Point(16, 228);
            this.label_new_booked_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_new_booked_date.Name = "label_new_booked_date";
            this.label_new_booked_date.Size = new System.Drawing.Size(93, 20);
            this.label_new_booked_date.TabIndex = 15;
            this.label_new_booked_date.Text = "New Date: ";
            // 
            // button_change_date
            // 
            this.button_change_date.BackColor = System.Drawing.Color.Transparent;
            this.button_change_date.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_change_date.BackgroundImage")));
            this.button_change_date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_change_date.FlatAppearance.BorderSize = 0;
            this.button_change_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_date.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_date.ForeColor = System.Drawing.Color.White;
            this.button_change_date.Location = new System.Drawing.Point(604, 212);
            this.button_change_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_change_date.Name = "button_change_date";
            this.button_change_date.Size = new System.Drawing.Size(148, 53);
            this.button_change_date.TabIndex = 16;
            this.button_change_date.Text = "Change Date";
            this.button_change_date.UseVisualStyleBackColor = false;
            this.button_change_date.Click += new System.EventHandler(this.button_change_date_Click);
            // 
            // dateTimePicker_new_date
            // 
            this.dateTimePicker_new_date.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker_new_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_new_date.Location = new System.Drawing.Point(173, 228);
            this.dateTimePicker_new_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_new_date.MaxDate = new System.DateTime(2025, 4, 10, 12, 54, 0, 0);
            this.dateTimePicker_new_date.MinDate = new System.DateTime(2022, 4, 10, 0, 0, 0, 0);
            this.dateTimePicker_new_date.Name = "dateTimePicker_new_date";
            this.dateTimePicker_new_date.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker_new_date.TabIndex = 21;
            this.dateTimePicker_new_date.Value = new System.DateTime(2022, 4, 15, 0, 0, 0, 0);
            // 
            // button_change_description
            // 
            this.button_change_description.BackColor = System.Drawing.Color.Transparent;
            this.button_change_description.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_change_description.BackgroundImage")));
            this.button_change_description.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_change_description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_description.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_description.ForeColor = System.Drawing.Color.White;
            this.button_change_description.Location = new System.Drawing.Point(604, 320);
            this.button_change_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_change_description.Name = "button_change_description";
            this.button_change_description.Size = new System.Drawing.Size(148, 52);
            this.button_change_description.TabIndex = 22;
            this.button_change_description.Text = "Change Description";
            this.button_change_description.UseVisualStyleBackColor = false;
            this.button_change_description.Click += new System.EventHandler(this.button_change_description_Click);
            // 
            // textBox_new_description
            // 
            this.textBox_new_description.Location = new System.Drawing.Point(173, 335);
            this.textBox_new_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_new_description.Multiline = true;
            this.textBox_new_description.Name = "textBox_new_description";
            this.textBox_new_description.Size = new System.Drawing.Size(384, 96);
            this.textBox_new_description.TabIndex = 23;
            // 
            // button_modify_different_event
            // 
            this.button_modify_different_event.BackColor = System.Drawing.Color.Transparent;
            this.button_modify_different_event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_modify_different_event.BackgroundImage")));
            this.button_modify_different_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_modify_different_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modify_different_event.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modify_different_event.ForeColor = System.Drawing.Color.White;
            this.button_modify_different_event.Location = new System.Drawing.Point(604, 425);
            this.button_modify_different_event.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_modify_different_event.Name = "button_modify_different_event";
            this.button_modify_different_event.Size = new System.Drawing.Size(148, 52);
            this.button_modify_different_event.TabIndex = 24;
            this.button_modify_different_event.Text = "Modify a Different Event";
            this.button_modify_different_event.UseVisualStyleBackColor = false;
            this.button_modify_different_event.Click += new System.EventHandler(this.button_modify_different_event_Click);
            // 
            // Form_Modify_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 554);
            this.Controls.Add(this.button_modify_different_event);
            this.Controls.Add(this.textBox_new_description);
            this.Controls.Add(this.button_change_description);
            this.Controls.Add(this.dateTimePicker_new_date);
            this.Controls.Add(this.button_change_date);
            this.Controls.Add(this.label_new_booked_date);
            this.Controls.Add(this.label_new_description);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_booked_date);
            this.Controls.Add(this.label_customer_ID);
            this.Controls.Add(this.label_event_ID);
            this.Controls.Add(this.button_exit_form);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Modify_Event";
            this.Text = "Form_Modify_Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit_form;
        private System.Windows.Forms.Label label_event_ID;
        private System.Windows.Forms.Label label_customer_ID;
        private System.Windows.Forms.Label label_booked_date;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_new_description;
        private System.Windows.Forms.Label label_new_booked_date;
        public System.Windows.Forms.Button button_change_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_new_date;
        public System.Windows.Forms.Button button_change_description;
        private System.Windows.Forms.TextBox textBox_new_description;
        public System.Windows.Forms.Button button_modify_different_event;
    }
}