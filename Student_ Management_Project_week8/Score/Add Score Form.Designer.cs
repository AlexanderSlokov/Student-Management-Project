namespace Student_Management_Project_week8.Score
{
    partial class Add_Score_Form
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
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.panelDataGridViewDocked = new System.Windows.Forms.Panel();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.panelDataGridViewDocked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.Cyan;
            this.buttonAddScore.ForeColor = System.Drawing.Color.Coral;
            this.buttonAddScore.Location = new System.Drawing.Point(188, 461);
            this.buttonAddScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(292, 49);
            this.buttonAddScore.TabIndex = 17;
            this.buttonAddScore.Text = "Add Score";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(188, 77);
            this.comboBoxSelectCourse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(291, 24);
            this.comboBoxSelectCourse.TabIndex = 16;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(188, 269);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(291, 184);
            this.textBoxDescription.TabIndex = 15;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(188, 162);
            this.textBoxScore.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(291, 22);
            this.textBoxScore.TabIndex = 14;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(9, 269);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(104, 24);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "Description";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.Location = new System.Drawing.Point(9, 82);
            this.labelSelectCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(133, 24);
            this.labelSelectCourse.TabIndex = 12;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(9, 160);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(65, 24);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "Score:";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(188, 14);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(291, 22);
            this.textBoxStudentID.TabIndex = 10;
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(9, 14);
            this.labelStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(101, 24);
            this.labelStudentID.TabIndex = 9;
            this.labelStudentID.Text = "Student ID:";
            // 
            // panelDataGridViewDocked
            // 
            this.panelDataGridViewDocked.Controls.Add(this.dataGridViewStudent);
            this.panelDataGridViewDocked.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelDataGridViewDocked.Location = new System.Drawing.Point(526, 20);
            this.panelDataGridViewDocked.Margin = new System.Windows.Forms.Padding(4);
            this.panelDataGridViewDocked.Name = "panelDataGridViewDocked";
            this.panelDataGridViewDocked.Size = new System.Drawing.Size(388, 433);
            this.panelDataGridViewDocked.TabIndex = 18;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.Size = new System.Drawing.Size(388, 433);
            this.dataGridViewStudent.TabIndex = 9;
            // 
            // Add_Score_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 556);
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
            this.Name = "Add_Score_Form";
            this.Text = "Add_Score_Form";
            this.Load += new System.EventHandler(this.Add_Score_Form_Load);
            this.panelDataGridViewDocked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Panel panelDataGridViewDocked;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
    }
}