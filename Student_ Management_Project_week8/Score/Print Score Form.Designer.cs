namespace Student_Management_Project_week8.Score
{
    partial class Print_Score_Form
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSaveToTextFile = new System.Windows.Forms.Button();
            this.labelStudentList = new System.Windows.Forms.Label();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.dataGridViewScores = new System.Windows.Forms.DataGridView();
            this.labelScores = new System.Windows.Forms.Label();
            this.labelCoursesList = new System.Windows.Forms.Label();
            this.listBoxCoursesList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonReset.ForeColor = System.Drawing.Color.Black;
            this.buttonReset.Location = new System.Drawing.Point(1071, 862);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(849, 75);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSaveToTextFile
            // 
            this.buttonSaveToTextFile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSaveToTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonSaveToTextFile.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveToTextFile.Location = new System.Drawing.Point(11, 862);
            this.buttonSaveToTextFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveToTextFile.Name = "buttonSaveToTextFile";
            this.buttonSaveToTextFile.Size = new System.Drawing.Size(1060, 75);
            this.buttonSaveToTextFile.TabIndex = 15;
            this.buttonSaveToTextFile.Text = "Save To Text File";
            this.buttonSaveToTextFile.UseVisualStyleBackColor = false;
            this.buttonSaveToTextFile.Click += new System.EventHandler(this.buttonSaveToTextFile_Click);
            // 
            // labelStudentList
            // 
            this.labelStudentList.AutoSize = true;
            this.labelStudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelStudentList.ForeColor = System.Drawing.Color.Red;
            this.labelStudentList.Location = new System.Drawing.Point(1406, 4);
            this.labelStudentList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentList.Name = "labelStudentList";
            this.labelStudentList.Size = new System.Drawing.Size(173, 36);
            this.labelStudentList.TabIndex = 14;
            this.labelStudentList.Text = "Student List";
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowUserToAddRows = false;
            this.dataGridViewStudentList.AllowUserToDeleteRows = false;
            this.dataGridViewStudentList.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(1071, 67);
            this.dataGridViewStudentList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(849, 802);
            this.dataGridViewStudentList.TabIndex = 13;
            this.dataGridViewStudentList.Click += new System.EventHandler(this.dataGridViewStudentList_Click);
            // 
            // dataGridViewScores
            // 
            this.dataGridViewScores.AllowUserToAddRows = false;
            this.dataGridViewScores.AllowUserToDeleteRows = false;
            this.dataGridViewScores.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridViewScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScores.Location = new System.Drawing.Point(244, 67);
            this.dataGridViewScores.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewScores.Name = "dataGridViewScores";
            this.dataGridViewScores.RowHeadersWidth = 51;
            this.dataGridViewScores.Size = new System.Drawing.Size(827, 802);
            this.dataGridViewScores.TabIndex = 12;
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelScores.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelScores.Location = new System.Drawing.Point(578, 4);
            this.labelScores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(108, 36);
            this.labelScores.TabIndex = 11;
            this.labelScores.Text = "Scores";
            // 
            // labelCoursesList
            // 
            this.labelCoursesList.AutoSize = true;
            this.labelCoursesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoursesList.ForeColor = System.Drawing.Color.Cyan;
            this.labelCoursesList.Location = new System.Drawing.Point(23, 4);
            this.labelCoursesList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoursesList.Name = "labelCoursesList";
            this.labelCoursesList.Size = new System.Drawing.Size(181, 36);
            this.labelCoursesList.TabIndex = 10;
            this.labelCoursesList.Text = "Courses List";
            // 
            // listBoxCoursesList
            // 
            this.listBoxCoursesList.BackColor = System.Drawing.Color.Cyan;
            this.listBoxCoursesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCoursesList.FormattingEnabled = true;
            this.listBoxCoursesList.ItemHeight = 29;
            this.listBoxCoursesList.Location = new System.Drawing.Point(11, 67);
            this.listBoxCoursesList.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCoursesList.Name = "listBoxCoursesList";
            this.listBoxCoursesList.Size = new System.Drawing.Size(239, 816);
            this.listBoxCoursesList.TabIndex = 9;
            this.listBoxCoursesList.Click += new System.EventHandler(this.listBoxCoursesList_Click);
            // 
            // Print_Score_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSaveToTextFile);
            this.Controls.Add(this.labelStudentList);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.dataGridViewScores);
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.labelCoursesList);
            this.Controls.Add(this.listBoxCoursesList);
            this.Name = "Print_Score_Form";
            this.Text = "Print_Score_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSaveToTextFile;
        private System.Windows.Forms.Label labelStudentList;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.DataGridView dataGridViewScores;
        private System.Windows.Forms.Label labelScores;
        private System.Windows.Forms.Label labelCoursesList;
        private System.Windows.Forms.ListBox listBoxCoursesList;
    }
}