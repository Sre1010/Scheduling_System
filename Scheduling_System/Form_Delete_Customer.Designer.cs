namespace Scheduling_System
{
    partial class Form_Delete_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Delete_Customer));
            this.listBox_Delete_Customer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_removeCustomer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Delete_Customer
            // 
            this.listBox_Delete_Customer.FormattingEnabled = true;
            this.listBox_Delete_Customer.ItemHeight = 16;
            this.listBox_Delete_Customer.Location = new System.Drawing.Point(159, 150);
            this.listBox_Delete_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Delete_Customer.Name = "listBox_Delete_Customer";
            this.listBox_Delete_Customer.Size = new System.Drawing.Size(511, 212);
            this.listBox_Delete_Customer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a customer to remove";
            // 
            // button_removeCustomer
            // 
            this.button_removeCustomer.BackColor = System.Drawing.Color.Transparent;
            this.button_removeCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_removeCustomer.BackgroundImage")));
            this.button_removeCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_removeCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_removeCustomer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeCustomer.ForeColor = System.Drawing.Color.White;
            this.button_removeCustomer.Location = new System.Drawing.Point(300, 381);
            this.button_removeCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_removeCustomer.Name = "button_removeCustomer";
            this.button_removeCustomer.Size = new System.Drawing.Size(192, 43);
            this.button_removeCustomer.TabIndex = 2;
            this.button_removeCustomer.Text = "Remove";
            this.button_removeCustomer.UseVisualStyleBackColor = false;
            this.button_removeCustomer.Click += new System.EventHandler(this.button_removeCustomer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(785, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Delete_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_removeCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Delete_Customer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Delete_Customer";
            this.Text = "Remove Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Delete_Customer;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_removeCustomer;
        private System.Windows.Forms.Button button1;
    }
}