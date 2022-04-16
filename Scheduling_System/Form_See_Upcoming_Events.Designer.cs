
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
            // Form_See_Upcoming_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.button_exit_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_See_Upcoming_Events";
            this.Text = "Form_See_Upcoming_Events";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit_form;
    }
}