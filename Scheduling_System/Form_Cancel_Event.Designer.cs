
namespace Scheduling_System
{
    partial class Form_Cancel_Event
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.listBox_Delete_Event = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(55, 325);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(100, 28);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click_1);
            // 
            // listBox_Delete_Event
            // 
            this.listBox_Delete_Event.FormattingEnabled = true;
            this.listBox_Delete_Event.ItemHeight = 16;
            this.listBox_Delete_Event.Location = new System.Drawing.Point(55, 57);
            this.listBox_Delete_Event.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Delete_Event.Name = "listBox_Delete_Event";
            this.listBox_Delete_Event.Size = new System.Drawing.Size(360, 260);
            this.listBox_Delete_Event.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the Event you would like to remove";
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(316, 325);
            this.return_btn.Margin = new System.Windows.Forms.Padding(4);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(100, 28);
            this.return_btn.TabIndex = 4;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click_1);
            // 
            // Form_Cancel_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 393);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Delete_Event);
            this.Controls.Add(this.delete_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Cancel_Event";
            this.Text = "Remove Customer";
            this.Load += new System.EventHandler(this.Form_Cancel_Event_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ListBox listBox_Delete_Event;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button return_btn;
    }
}
