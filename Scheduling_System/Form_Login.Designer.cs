
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_login_title = new System.Windows.Forms.Label();
            this.button_usernameHint = new System.Windows.Forms.Button();
            this.label_usernameHint = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_verifyLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(504, 167);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_username.MaxLength = 9;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(132, 22);
            this.textBox_username.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_username.Location = new System.Drawing.Point(379, 162);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(113, 27);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_password.Location = new System.Drawing.Point(383, 220);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(108, 27);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(504, 225);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.MaxLength = 8;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(132, 22);
            this.textBox_password.TabIndex = 3;
            // 
            // label_login_title
            // 
            this.label_login_title.AutoSize = true;
            this.label_login_title.BackColor = System.Drawing.Color.Transparent;
            this.label_login_title.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_title.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_login_title.Location = new System.Drawing.Point(828, 479);
            this.label_login_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login_title.Name = "label_login_title";
            this.label_login_title.Size = new System.Drawing.Size(277, 26);
            this.label_login_title.TabIndex = 4;
            this.label_login_title.Text = "Scheduling System Login";
            // 
            // button_usernameHint
            // 
            this.button_usernameHint.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_usernameHint.Location = new System.Drawing.Point(659, 165);
            this.button_usernameHint.Margin = new System.Windows.Forms.Padding(4);
            this.button_usernameHint.Name = "button_usernameHint";
            this.button_usernameHint.Size = new System.Drawing.Size(36, 28);
            this.button_usernameHint.TabIndex = 7;
            this.button_usernameHint.Text = "💡";
            this.button_usernameHint.UseVisualStyleBackColor = false;
            this.button_usernameHint.Click += new System.EventHandler(this.button_usernameHint_Click);
            // 
            // label_usernameHint
            // 
            this.label_usernameHint.AutoSize = true;
            this.label_usernameHint.Location = new System.Drawing.Point(701, 165);
            this.label_usernameHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_usernameHint.Name = "label_usernameHint";
            this.label_usernameHint.Size = new System.Drawing.Size(225, 16);
            this.label_usernameHint.TabIndex = 8;
            this.label_usernameHint.Text = "username + password hint (HIDDEN)";
            this.label_usernameHint.UseWaitCursor = true;
            this.label_usernameHint.Visible = false;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(483, 402);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(100, 30);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_verifyLogin
            // 
            this.label_verifyLogin.ForeColor = System.Drawing.Color.Red;
            this.label_verifyLogin.Location = new System.Drawing.Point(399, 352);
            this.label_verifyLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_verifyLogin.Name = "label_verifyLogin";
            this.label_verifyLogin.Size = new System.Drawing.Size(248, 47);
            this.label_verifyLogin.TabIndex = 11;
            this.label_verifyLogin.Text = "verify input (HIDDEN)";
            this.label_verifyLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_verifyLogin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 130);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.White;
            this.button_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_login.BackgroundImage")));
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.ForeColor = System.Drawing.Color.Transparent;
            this.button_login.Location = new System.Drawing.Point(403, 286);
            this.button_login.Margin = new System.Windows.Forms.Padding(4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(235, 30);
            this.button_login.TabIndex = 10;
            this.button_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_verifyLogin);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_usernameHint);
            this.Controls.Add(this.button_usernameHint);
            this.Controls.Add(this.label_login_title);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_username);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1159, 598);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SSS Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login_title;
        private System.Windows.Forms.Button button_usernameHint;
        private System.Windows.Forms.Label label_usernameHint;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_verifyLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_login;
        public System.Windows.Forms.TextBox textBox_username;
        public System.Windows.Forms.TextBox textBox_password;
    }
}

