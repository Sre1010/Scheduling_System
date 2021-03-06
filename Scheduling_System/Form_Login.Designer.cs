
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
            this.textBox_username.Location = new System.Drawing.Point(378, 136);
            this.textBox_username.MaxLength = 9;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 20);
            this.textBox_username.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_username.Location = new System.Drawing.Point(284, 132);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(91, 21);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_password.Location = new System.Drawing.Point(287, 179);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(86, 21);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(378, 183);
            this.textBox_password.MaxLength = 8;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // label_login_title
            // 
            this.label_login_title.AutoSize = true;
            this.label_login_title.BackColor = System.Drawing.Color.Transparent;
            this.label_login_title.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_title.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_login_title.Location = new System.Drawing.Point(621, 389);
            this.label_login_title.Name = "label_login_title";
            this.label_login_title.Size = new System.Drawing.Size(233, 21);
            this.label_login_title.TabIndex = 4;
            this.label_login_title.Text = "Scheduling System Login";
            // 
            // button_usernameHint
            // 
            this.button_usernameHint.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_usernameHint.Location = new System.Drawing.Point(494, 134);
            this.button_usernameHint.Name = "button_usernameHint";
            this.button_usernameHint.Size = new System.Drawing.Size(27, 23);
            this.button_usernameHint.TabIndex = 4;
            this.button_usernameHint.Text = "💡";
            this.button_usernameHint.UseVisualStyleBackColor = false;
            this.button_usernameHint.Click += new System.EventHandler(this.button_usernameHint_Click);
            // 
            // label_usernameHint
            // 
            this.label_usernameHint.AutoSize = true;
            this.label_usernameHint.Location = new System.Drawing.Point(526, 134);
            this.label_usernameHint.Name = "label_usernameHint";
            this.label_usernameHint.Size = new System.Drawing.Size(181, 13);
            this.label_usernameHint.TabIndex = 8;
            this.label_usernameHint.Text = "username + password hint (HIDDEN)";
            this.label_usernameHint.UseWaitCursor = true;
            this.label_usernameHint.Visible = false;
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.Transparent;
            this.button_exit.Location = new System.Drawing.Point(362, 327);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 24);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_verifyLogin
            // 
            this.label_verifyLogin.ForeColor = System.Drawing.Color.Red;
            this.label_verifyLogin.Location = new System.Drawing.Point(299, 286);
            this.label_verifyLogin.Name = "label_verifyLogin";
            this.label_verifyLogin.Size = new System.Drawing.Size(186, 38);
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
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 106);
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
            this.button_login.Location = new System.Drawing.Point(302, 232);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(176, 24);
            this.button_login.TabIndex = 2;
            this.button_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 491);
            this.ControlBox = false;
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
            this.MinimumSize = new System.Drawing.Size(873, 493);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scheduling System";
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

