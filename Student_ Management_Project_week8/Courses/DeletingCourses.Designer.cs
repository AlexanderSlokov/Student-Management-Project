namespace Student_Management_Project_week8.Courses
{
    partial class DeletingCourses
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
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxCourseIDSearch = new System.Windows.Forms.TextBox();
            this.labelEnterTheCourseID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonRemove.Location = new System.Drawing.Point(619, 26);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(169, 63);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            // 
            // textBoxCourseIDSearch
            // 
            this.textBoxCourseIDSearch.Location = new System.Drawing.Point(212, 49);
            this.textBoxCourseIDSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCourseIDSearch.Name = "textBoxCourseIDSearch";
            this.textBoxCourseIDSearch.Size = new System.Drawing.Size(361, 22);
            this.textBoxCourseIDSearch.TabIndex = 7;
            // 
            // labelEnterTheCourseID
            // 
            this.labelEnterTheCourseID.AutoSize = true;
            this.labelEnterTheCourseID.Location = new System.Drawing.Point(12, 49);
            this.labelEnterTheCourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnterTheCourseID.Name = "labelEnterTheCourseID";
            this.labelEnterTheCourseID.Size = new System.Drawing.Size(130, 16);
            this.labelEnterTheCourseID.TabIndex = 6;
            this.labelEnterTheCourseID.Text = "Enter The Course ID:";
            // 
            // DeletingCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 127);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxCourseIDSearch);
            this.Controls.Add(this.labelEnterTheCourseID);
            this.Name = "DeletingCourses";
            this.Text = "DeletingCourses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxCourseIDSearch;
        private System.Windows.Forms.Label labelEnterTheCourseID;
    }
}