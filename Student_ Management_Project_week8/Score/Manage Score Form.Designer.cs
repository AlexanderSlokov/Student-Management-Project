namespace Student_Management_Project_week8.Class
{ 
    partial class formManageScore
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
            this.buttonAverageScore = new System.Windows.Forms.Button();
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            this.buttonShowScores = new System.Windows.Forms.Button();
            this.buttonShowStudents = new System.Windows.Forms.Button();
            this.panelDataGridViewDocked = new System.Windows.Forms.Panel();
            this.dataGridViewStudentScore = new System.Windows.Forms.DataGridView();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.panelDataGridViewDocked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAverageScore
            // 
            this.buttonAverageScore.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonAverageScore.ForeColor = System.Drawing.Color.Coral;
            this.buttonAverageScore.Location = new System.Drawing.Point(26, 552);
            this.buttonAverageScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAverageScore.Name = "buttonAverageScore";
            this.buttonAverageScore.Size = new System.Drawing.Size(583, 49);
            this.buttonAverageScore.TabIndex = 38;
            this.buttonAverageScore.Text = "Average Score By Course";
            this.buttonAverageScore.UseVisualStyleBackColor = false;
            this.buttonAverageScore.Click += new System.EventHandler(this.buttonAverageScore_Click);
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveScore.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonRemoveScore.Location = new System.Drawing.Point(315, 496);
            this.buttonRemoveScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Size = new System.Drawing.Size(292, 49);
            this.buttonRemoveScore.TabIndex = 37;
            this.buttonRemoveScore.Text = "Remove Score";
            this.buttonRemoveScore.UseVisualStyleBackColor = false;
            this.buttonRemoveScore.Click += new System.EventHandler(this.buttonRemoveScore_Click);
            // 
            // buttonShowScores
            // 
            this.buttonShowScores.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonShowScores.Location = new System.Drawing.Point(1042, 6);
            this.buttonShowScores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowScores.Name = "buttonShowScores";
            this.buttonShowScores.Size = new System.Drawing.Size(423, 38);
            this.buttonShowScores.TabIndex = 36;
            this.buttonShowScores.Text = "Show Scores";
            this.buttonShowScores.UseVisualStyleBackColor = false;
            this.buttonShowScores.Click += new System.EventHandler(this.buttonShowScores_Click);
            // 
            // buttonShowStudents
            // 
            this.buttonShowStudents.BackColor = System.Drawing.Color.Gold;
            this.buttonShowStudents.Location = new System.Drawing.Point(619, 6);
            this.buttonShowStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShowStudents.Name = "buttonShowStudents";
            this.buttonShowStudents.Size = new System.Drawing.Size(428, 38);
            this.buttonShowStudents.TabIndex = 35;
            this.buttonShowStudents.Text = "Show Students";
            this.buttonShowStudents.UseVisualStyleBackColor = false;
            this.buttonShowStudents.Click += new System.EventHandler(this.buttonShowStudents_Click);
            // 
            // panelDataGridViewDocked
            // 
            this.panelDataGridViewDocked.Controls.Add(this.dataGridViewStudentScore);
            this.panelDataGridViewDocked.Location = new System.Drawing.Point(619, 50);
            this.panelDataGridViewDocked.Margin = new System.Windows.Forms.Padding(4);
            this.panelDataGridViewDocked.Name = "panelDataGridViewDocked";
            this.panelDataGridViewDocked.Size = new System.Drawing.Size(844, 665);
            this.panelDataGridViewDocked.TabIndex = 34;
            // 
            // dataGridViewStudentScore
            // 
            this.dataGridViewStudentScore.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridViewStudentScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudentScore.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStudentScore.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudentScore.Name = "dataGridViewStudentScore";
            this.dataGridViewStudentScore.RowHeadersWidth = 51;
            this.dataGridViewStudentScore.Size = new System.Drawing.Size(844, 665);
            this.dataGridViewStudentScore.TabIndex = 9;
            this.dataGridViewStudentScore.Click += new System.EventHandler(this.dataGridViewStudentScore_Click);
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.Cyan;
            this.buttonAddScore.ForeColor = System.Drawing.Color.Coral;
            this.buttonAddScore.Location = new System.Drawing.Point(25, 496);
            this.buttonAddScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(292, 49);
            this.buttonAddScore.TabIndex = 33;
            this.buttonAddScore.Text = "Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(187, 103);
            this.comboBoxSelectCourse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(291, 24);
            this.comboBoxSelectCourse.TabIndex = 32;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(187, 262);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(291, 184);
            this.textBoxDescription.TabIndex = 31;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(187, 188);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(291, 22);
            this.textBoxScore.TabIndex = 30;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(9, 262);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 24);
            this.labelDescription.TabIndex = 29;
            this.labelDescription.Text = "Description:";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.Location = new System.Drawing.Point(9, 108);
            this.labelSelectCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(133, 24);
            this.labelSelectCourse.TabIndex = 28;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(9, 186);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(65, 24);
            this.labelScore.TabIndex = 27;
            this.labelScore.Text = "Score:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(187, 40);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(291, 22);
            this.textBoxStudentID.TabIndex = 26;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(9, 40);
            this.labelStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(101, 24);
            this.labelStudentID.TabIndex = 25;
            this.labelStudentID.Text = "Student ID:";
            // 
            // formManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 755);
            this.Controls.Add(this.buttonAverageScore);
            this.Controls.Add(this.buttonRemoveScore);
            this.Controls.Add(this.buttonShowScores);
            this.Controls.Add(this.buttonShowStudents);
            this.Controls.Add(this.panelDataGridViewDocked);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSelectCourse);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelStudentID);
            this.Name = "formManageScore";
            this.Text = "Manage_Score_Form";
            this.Load += new System.EventHandler(this.formManageScore_Load);
            this.panelDataGridViewDocked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAverageScore;
        private System.Windows.Forms.Button buttonRemoveScore;
        private System.Windows.Forms.Button buttonShowScores;
        private System.Windows.Forms.Button buttonShowStudents;
        private System.Windows.Forms.Panel panelDataGridViewDocked;
        private System.Windows.Forms.DataGridView dataGridViewStudentScore;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelStudentID;
    }
}