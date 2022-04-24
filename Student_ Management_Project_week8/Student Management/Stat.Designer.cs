namespace Student_Management_Project_week8.Student_Management
{
    partial class Stat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CountStudentlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(21, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 347);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "BAR CHART";
            // 
            // CountStudentlabel
            // 
            this.CountStudentlabel.AutoSize = true;
            this.CountStudentlabel.Location = new System.Drawing.Point(396, 14);
            this.CountStudentlabel.Name = "CountStudentlabel";
            this.CountStudentlabel.Size = new System.Drawing.Size(122, 16);
            this.CountStudentlabel.TabIndex = 2;
            this.CountStudentlabel.Text = "Count Student label";
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(578, 390);
            this.Controls.Add(this.CountStudentlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Stat";
            this.Text = "Stat";
            this.Load += new System.EventHandler(this.Stat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CountStudentlabel;
    }
}