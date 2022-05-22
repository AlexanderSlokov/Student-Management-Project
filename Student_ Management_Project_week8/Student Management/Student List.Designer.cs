using System.Windows.Forms;

namespace Student_Management_Project_week8
{
    partial class Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_List));
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.ButtonToEXcelFileList = new System.Windows.Forms.Button();
            this.buttonCheckList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonMaleList = new System.Windows.Forms.RadioButton();
            this.radioButtonAllGenderList = new System.Windows.Forms.RadioButton();
            this.radioButtonFemaleList = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowUserToOrderColumns = true;
            this.dataGridViewStudentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(144)))), ((int)(((byte)(244)))));
            this.dataGridViewStudentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(182, 100);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.RowTemplate.Height = 100;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(706, 350);
            this.dataGridViewStudentList.TabIndex = 0;
            this.dataGridViewStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentList_CellContentClick);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(707, 2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(181, 32);
            this.dateTimePickerEndDate.TabIndex = 1;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(476, 2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(183, 32);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick Student Birth Date From:";
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshList.BackgroundImage")));
            this.buttonRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshList.Location = new System.Drawing.Point(0, 183);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(157, 74);
            this.buttonRefreshList.TabIndex = 4;
            this.buttonRefreshList.Text = "Refresh";
            this.buttonRefreshList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.radioButtonYes);
            this.panel1.Controls.Add(this.ButtonToEXcelFileList);
            this.panel1.Controls.Add(this.buttonCheckList);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonRefreshList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 466);
            this.panel1.TabIndex = 5;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(3, 111);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(158, 27);
            this.radioButtonYes.TabIndex = 8;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Use Birthdate";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // ButtonToEXcelFileList
            // 
            this.ButtonToEXcelFileList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToEXcelFileList.BackgroundImage")));
            this.ButtonToEXcelFileList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonToEXcelFileList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonToEXcelFileList.Location = new System.Drawing.Point(0, 373);
            this.ButtonToEXcelFileList.Name = "ButtonToEXcelFileList";
            this.ButtonToEXcelFileList.Size = new System.Drawing.Size(157, 77);
            this.ButtonToEXcelFileList.TabIndex = 7;
            this.ButtonToEXcelFileList.Text = "To PDF File";
            this.ButtonToEXcelFileList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonToEXcelFileList.UseVisualStyleBackColor = true;
            this.ButtonToEXcelFileList.Click += new System.EventHandler(this.ButtonToPdfFileList_Click);
            // 
            // buttonCheckList
            // 
            this.buttonCheckList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheckList.BackgroundImage")));
            this.buttonCheckList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckList.Location = new System.Drawing.Point(0, 277);
            this.buttonCheckList.Name = "buttonCheckList";
            this.buttonCheckList.Size = new System.Drawing.Size(157, 76);
            this.buttonCheckList.TabIndex = 6;
            this.buttonCheckList.Text = "Check";
            this.buttonCheckList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCheckList.UseVisualStyleBackColor = true;
            this.buttonCheckList.Click += new System.EventHandler(this.buttonCheckList_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 78);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(1, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Picking up students by gender:";
            // 
            // radioButtonMaleList
            // 
            this.radioButtonMaleList.AutoSize = true;
            this.radioButtonMaleList.Location = new System.Drawing.Point(674, 53);
            this.radioButtonMaleList.Name = "radioButtonMaleList";
            this.radioButtonMaleList.Size = new System.Drawing.Size(80, 27);
            this.radioButtonMaleList.TabIndex = 8;
            this.radioButtonMaleList.TabStop = true;
            this.radioButtonMaleList.Text = "Male";
            this.radioButtonMaleList.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllGenderList
            // 
            this.radioButtonAllGenderList.AutoSize = true;
            this.radioButtonAllGenderList.Location = new System.Drawing.Point(506, 53);
            this.radioButtonAllGenderList.Name = "radioButtonAllGenderList";
            this.radioButtonAllGenderList.Size = new System.Drawing.Size(137, 27);
            this.radioButtonAllGenderList.TabIndex = 9;
            this.radioButtonAllGenderList.TabStop = true;
            this.radioButtonAllGenderList.Text = "All Gender";
            this.radioButtonAllGenderList.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemaleList
            // 
            this.radioButtonFemaleList.AutoSize = true;
            this.radioButtonFemaleList.Location = new System.Drawing.Point(783, 53);
            this.radioButtonFemaleList.Name = "radioButtonFemaleList";
            this.radioButtonFemaleList.Size = new System.Drawing.Size(105, 27);
            this.radioButtonFemaleList.TabIndex = 10;
            this.radioButtonFemaleList.TabStop = true;
            this.radioButtonFemaleList.Text = "Female";
            this.radioButtonFemaleList.UseVisualStyleBackColor = true;
            // 
            // Student_List
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(910, 466);
            this.Controls.Add(this.radioButtonFemaleList);
            this.Controls.Add(this.radioButtonAllGenderList);
            this.Controls.Add(this.radioButtonMaleList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(110)))), ((int)(((byte)(226)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Student_List";
            this.Text = "Student_List";
            this.Load += new System.EventHandler(this.Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewStudentList;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private Label label1;
        private Button buttonRefreshList;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button buttonCheckList;
        private Button ButtonToEXcelFileList;
        private Label label3;
        private Label label4;
        private RadioButton radioButtonMaleList;
        private RadioButton radioButtonAllGenderList;
        private RadioButton radioButtonFemaleList;
        private RadioButton radioButtonYes;
    }
}