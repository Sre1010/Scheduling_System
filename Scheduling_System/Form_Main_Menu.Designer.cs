
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
            this.label_temp_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Location = new System.Drawing.Point(122, 66);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(55, 13);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome ";
            // 
            // button_temp_login
            // 
            this.button_temp_login.Location = new System.Drawing.Point(335, 340);
            this.button_temp_login.Name = "button_temp_login";
            this.button_temp_login.Size = new System.Drawing.Size(172, 23);
            this.button_temp_login.TabIndex = 1;
            this.button_temp_login.Text = "Go back to the login page";
            this.button_temp_login.UseVisualStyleBackColor = true;
            this.button_temp_login.Click += new System.EventHandler(this.button_temp_login_Click);
            // 
            // label_temp_login
            // 
            this.label_temp_login.AutoSize = true;
            this.label_temp_login.Location = new System.Drawing.Point(290, 315);
            this.label_temp_login.Name = "label_temp_login";
            this.label_temp_login.Size = new System.Drawing.Size(279, 13);
            this.label_temp_login.TabIndex = 2;
            this.label_temp_login.Text = "This temporary button will take you back to the login page";
            // 
            // Form_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_temp_login);
            this.Controls.Add(this.button_temp_login);
            this.Controls.Add(this.label_welcome);
            this.Name = "Form_Main_Menu";
            this.Text = "Form_Main_Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_Menu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_temp_login;
        private System.Windows.Forms.Label label_temp_login;
    }
}