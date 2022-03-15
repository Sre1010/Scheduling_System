
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
            this.button_usernameHint = new System.Windows.Forms.Button();
            this.label_usernameHint = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.label_verifyLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(374, 105);
            this.textBox_username.MaxLength = 9;
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
            this.label_login_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_title.Location = new System.Drawing.Point(283, 34);
            this.label_login_title.Name = "label_login_title";
            this.label_login_title.Size = new System.Drawing.Size(255, 25);
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
            // button_usernameHint
            // 
            this.button_usernameHint.Location = new System.Drawing.Point(490, 103);
            this.button_usernameHint.Name = "button_usernameHint";
            this.button_usernameHint.Size = new System.Drawing.Size(27, 23);
            this.button_usernameHint.TabIndex = 7;
            this.button_usernameHint.Text = "💡";
            this.button_usernameHint.UseVisualStyleBackColor = true;
            this.button_usernameHint.Click += new System.EventHandler(this.button_usernameHint_Click);
            // 
            // label_usernameHint
            // 
            this.label_usernameHint.AutoSize = true;
            this.label_usernameHint.Location = new System.Drawing.Point(523, 103);
            this.label_usernameHint.Name = "label_usernameHint";
            this.label_usernameHint.Size = new System.Drawing.Size(181, 13);
            this.label_usernameHint.TabIndex = 8;
            this.label_usernameHint.Text = "username + password hint (HIDDEN)";
            this.label_usernameHint.UseWaitCursor = true;
            this.label_usernameHint.Visible = false;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(388, 326);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(388, 207);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 10;
            this.button_login.Text = "Log in";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_verifyLogin
            // 
            this.label_verifyLogin.ForeColor = System.Drawing.Color.Red;
            this.label_verifyLogin.Location = new System.Drawing.Point(331, 233);
            this.label_verifyLogin.Name = "label_verifyLogin";
            this.label_verifyLogin.Size = new System.Drawing.Size(186, 38);
            this.label_verifyLogin.TabIndex = 11;
            this.label_verifyLogin.Text = "verify input (HIDDEN)";
            this.label_verifyLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_verifyLogin.Visible = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.label_verifyLogin);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_usernameHint);
            this.Controls.Add(this.button_usernameHint);
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
        private System.Windows.Forms.Button button_usernameHint;
        private System.Windows.Forms.Label label_usernameHint;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_verifyLogin;
    }
}

