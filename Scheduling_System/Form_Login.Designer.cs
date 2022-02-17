
namespace Scheduling_System
{
    partial class Form_Login
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
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_login_title = new System.Windows.Forms.Label();
            this.button_temp_main_menu = new System.Windows.Forms.Button();
            this.label_temp_main_menu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(374, 105);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(310, 108);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(58, 13);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(312, 155);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(374, 152);
            this.textBox_password.MaxLength = 8;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 3;
            // 
            // label_login_title
            // 
            this.label_login_title.AutoSize = true;
            this.label_login_title.Location = new System.Drawing.Point(328, 35);
            this.label_login_title.Name = "label_login_title";
            this.label_login_title.Size = new System.Drawing.Size(126, 13);
            this.label_login_title.TabIndex = 4;
            this.label_login_title.Text = "Scheduling System Login";
            // 
            // button_temp_main_menu
            // 
            this.button_temp_main_menu.Location = new System.Drawing.Point(331, 297);
            this.button_temp_main_menu.Name = "button_temp_main_menu";
            this.button_temp_main_menu.Size = new System.Drawing.Size(186, 23);
            this.button_temp_main_menu.TabIndex = 5;
            this.button_temp_main_menu.Text = "Go to the main menu";
            this.button_temp_main_menu.UseVisualStyleBackColor = true;
            this.button_temp_main_menu.Click += new System.EventHandler(this.button_temp_main_menu_Click);
            // 
            // label_temp_main_menu
            // 
            this.label_temp_main_menu.AutoSize = true;
            this.label_temp_main_menu.Location = new System.Drawing.Point(233, 271);
            this.label_temp_main_menu.Name = "label_temp_main_menu";
            this.label_temp_main_menu.Size = new System.Drawing.Size(443, 13);
            this.label_temp_main_menu.TabIndex = 6;
            this.label_temp_main_menu.Text = "This button will take you to the main menu (temporary functionality and will be c" +
    "hanged later).";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_temp_main_menu);
            this.Controls.Add(this.button_temp_main_menu);
            this.Controls.Add(this.label_login_title);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_username);
            this.Name = "Form_Login";
            this.Text = "Scheduling System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_login_title;
        private System.Windows.Forms.Button button_temp_main_menu;
        private System.Windows.Forms.Label label_temp_main_menu;
    }
}

