
namespace Scheduling_System
{
    partial class Form_See_Upcoming_Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_See_Upcoming_Events));
            this.button_exit_form = new System.Windows.Forms.Button();
            this.dataGridView_events = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label_date_range = new System.Windows.Forms.Label();
            this.label_date_range_2 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_client_company_name = new System.Windows.Forms.TextBox();
            this.label_client_company_name = new System.Windows.Forms.Label();
            this.button_modify_event = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_events)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit_form
            // 
            this.button_exit_form.BackColor = System.Drawing.Color.SteelBlue;
            this.button_exit_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit_form.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold);
            this.button_exit_form.Location = new System.Drawing.Point(591, -1);
            this.button_exit_form.Margin = new System.Windows.Forms.Padding(2);
            this.button_exit_form.Name = "button_exit_form";
            this.button_exit_form.Size = new System.Drawing.Size(19, 21);
            this.button_exit_form.TabIndex = 5;
            this.button_exit_form.Text = "X";
            this.button_exit_form.UseVisualStyleBackColor = false;
            this.button_exit_form.Click += new System.EventHandler(this.button_exit_form_Click);
            // 
            // dataGridView_events
            // 
            this.dataGridView_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_events.Location = new System.Drawing.Point(21, 216);
            this.dataGridView_events.Name = "dataGridView_events";
            this.dataGridView_events.ReadOnly = true;
            this.dataGridView_events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_events.Size = new System.Drawing.Size(564, 163);
            this.dataGridView_events.TabIndex = 6;
            this.dataGridView_events.SelectionChanged += new System.EventHandler(this.dataGridView_events_SelectionChanged);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(69, 99);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_start.TabIndex = 1;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(327, 99);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_end.TabIndex = 2;
            // 
            // label_date_range
            // 
            this.label_date_range.AutoSize = true;
            this.label_date_range.BackColor = System.Drawing.Color.Transparent;
            this.label_date_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_range.Location = new System.Drawing.Point(219, 75);
            this.label_date_range.Name = "label_date_range";
            this.label_date_range.Size = new System.Drawing.Size(173, 16);
            this.label_date_range.TabIndex = 9;
            this.label_date_range.Text = "Select a specific date range";
            // 
            // label_date_range_2
            // 
            this.label_date_range_2.AutoSize = true;
            this.label_date_range_2.BackColor = System.Drawing.Color.Transparent;
            this.label_date_range_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_range_2.Location = new System.Drawing.Point(291, 103);
            this.label_date_range_2.Name = "label_date_range_2";
            this.label_date_range_2.Size = new System.Drawing.Size(18, 16);
            this.label_date_range_2.TabIndex = 10;
            this.label_date_range_2.Text = "to";
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(21, 182);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(79, 28);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_client_company_name
            // 
            this.textBox_client_company_name.Location = new System.Drawing.Point(126, 137);
            this.textBox_client_company_name.Name = "textBox_client_company_name";
            this.textBox_client_company_name.Size = new System.Drawing.Size(143, 20);
            this.textBox_client_company_name.TabIndex = 3;
            // 
            // label_client_company_name
            // 
            this.label_client_company_name.AutoSize = true;
            this.label_client_company_name.BackColor = System.Drawing.Color.Transparent;
            this.label_client_company_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_client_company_name.Location = new System.Drawing.Point(18, 137);
            this.label_client_company_name.Name = "label_client_company_name";
            this.label_client_company_name.Size = new System.Drawing.Size(101, 16);
            this.label_client_company_name.TabIndex = 13;
            this.label_client_company_name.Text = "Client Company";
            // 
            // button_modify_event
            // 
            this.button_modify_event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_modify_event.BackgroundImage")));
            this.button_modify_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modify_event.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modify_event.ForeColor = System.Drawing.Color.White;
            this.button_modify_event.Location = new System.Drawing.Point(467, 182);
            this.button_modify_event.Name = "button_modify_event";
            this.button_modify_event.Size = new System.Drawing.Size(118, 28);
            this.button_modify_event.TabIndex = 5;
            this.button_modify_event.Text = "Modify Event";
            this.button_modify_event.UseVisualStyleBackColor = true;
            this.button_modify_event.Click += new System.EventHandler(this.button_modify_event_Click);
            // 
            // Form_See_Upcoming_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.button_modify_event);
            this.Controls.Add(this.label_client_company_name);
            this.Controls.Add(this.textBox_client_company_name);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_date_range_2);
            this.Controls.Add(this.label_date_range);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.dataGridView_events);
            this.Controls.Add(this.button_exit_form);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_See_Upcoming_Events";
            this.Text = "Form_See_Upcoming_Events";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_events)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit_form;
        private System.Windows.Forms.DataGridView dataGridView_events;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label_date_range;
        private System.Windows.Forms.Label label_date_range_2;
        public System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_client_company_name;
        private System.Windows.Forms.Label label_client_company_name;
        public System.Windows.Forms.Button button_modify_event;
    }
}