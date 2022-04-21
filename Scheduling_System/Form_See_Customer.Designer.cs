
namespace Scheduling_System
{
    partial class Form_See_Customer_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_See_Customer_panel));
            this.dataGrid_customer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button_removeCustomer = new System.Windows.Forms.Button();
            this.change_business = new System.Windows.Forms.TextBox();
            this.change_FL = new System.Windows.Forms.TextBox();
            this.change_LN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.modify_bus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Change_email = new System.Windows.Forms.TextBox();
            this.Change_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Change_Dob = new System.Windows.Forms.TextBox();
            this.CustomerID_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_customer
            // 
            this.dataGrid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_customer.Location = new System.Drawing.Point(30, 61);
            this.dataGrid_customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid_customer.Name = "dataGrid_customer";
            this.dataGrid_customer.ReadOnly = true;
            this.dataGrid_customer.RowHeadersWidth = 51;
            this.dataGrid_customer.RowTemplate.Height = 24;
            this.dataGrid_customer.Size = new System.Drawing.Size(550, 181);
            this.dataGrid_customer.TabIndex = 0;
            this.dataGrid_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_customer_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(574, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_removeCustomer
            // 
            this.button_removeCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_removeCustomer.BackgroundImage")));
            this.button_removeCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_removeCustomer.FlatAppearance.BorderSize = 0;
            this.button_removeCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeCustomer.Location = new System.Drawing.Point(492, 305);
            this.button_removeCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_removeCustomer.Name = "button_removeCustomer";
            this.button_removeCustomer.Size = new System.Drawing.Size(88, 49);
            this.button_removeCustomer.TabIndex = 2;
            this.button_removeCustomer.Text = "Delete Customer";
            this.button_removeCustomer.UseVisualStyleBackColor = true;
            this.button_removeCustomer.Click += new System.EventHandler(this.button_removeCustomer_Click);
            // 
            // change_business
            // 
            this.change_business.Location = new System.Drawing.Point(30, 274);
            this.change_business.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.change_business.Name = "change_business";
            this.change_business.Size = new System.Drawing.Size(77, 20);
            this.change_business.TabIndex = 3;
            // 
            // change_FL
            // 
            this.change_FL.Location = new System.Drawing.Point(127, 274);
            this.change_FL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.change_FL.Name = "change_FL";
            this.change_FL.Size = new System.Drawing.Size(76, 20);
            this.change_FL.TabIndex = 4;
            // 
            // change_LN
            // 
            this.change_LN.Location = new System.Drawing.Point(216, 274);
            this.change_LN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.change_LN.Name = "change_LN";
            this.change_LN.Size = new System.Drawing.Size(76, 20);
            this.change_LN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Business Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(214, 249);
            this.lable3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(58, 13);
            this.lable3.TabIndex = 8;
            this.lable3.Text = "Last Name";
            // 
            // modify_bus
            // 
            this.modify_bus.Location = new System.Drawing.Point(262, 312);
            this.modify_bus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modify_bus.Name = "modify_bus";
            this.modify_bus.Size = new System.Drawing.Size(76, 20);
            this.modify_bus.TabIndex = 9;
            this.modify_bus.Text = "Modify";
            this.modify_bus.UseVisualStyleBackColor = true;
            this.modify_bus.Click += new System.EventHandler(this.modify_bus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone #";
            // 
            // Change_email
            // 
            this.Change_email.Location = new System.Drawing.Point(415, 274);
            this.Change_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Change_email.Name = "Change_email";
            this.Change_email.Size = new System.Drawing.Size(76, 20);
            this.Change_email.TabIndex = 12;
            // 
            // Change_phone
            // 
            this.Change_phone.Location = new System.Drawing.Point(505, 274);
            this.Change_phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Change_phone.Name = "Change_phone";
            this.Change_phone.Size = new System.Drawing.Size(76, 20);
            this.Change_phone.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DOB";
            // 
            // Change_Dob
            // 
            this.Change_Dob.Location = new System.Drawing.Point(314, 274);
            this.Change_Dob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Change_Dob.Name = "Change_Dob";
            this.Change_Dob.Size = new System.Drawing.Size(76, 20);
            this.Change_Dob.TabIndex = 16;
            // 
            // CustomerID_text
            // 
            this.CustomerID_text.AutoSize = true;
            this.CustomerID_text.Location = new System.Drawing.Point(30, 312);
            this.CustomerID_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerID_text.Name = "CustomerID_text";
            this.CustomerID_text.Size = new System.Drawing.Size(18, 13);
            this.CustomerID_text.TabIndex = 14;
            this.CustomerID_text.Text = "ID";
            // 
            // Form_See_Customer_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 412);
            this.Controls.Add(this.Change_Dob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerID_text);
            this.Controls.Add(this.Change_phone);
            this.Controls.Add(this.Change_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modify_bus);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.change_LN);
            this.Controls.Add(this.change_FL);
            this.Controls.Add(this.change_business);
            this.Controls.Add(this.button_removeCustomer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid_customer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_See_Customer_panel";
            this.Text = "See_Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_customer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_removeCustomer;
        private System.Windows.Forms.TextBox change_business;
        private System.Windows.Forms.TextBox change_FL;
        private System.Windows.Forms.TextBox change_LN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Button modify_bus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Change_email;
        private System.Windows.Forms.TextBox Change_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Change_Dob;
        private System.Windows.Forms.Label CustomerID_text;
    }
}