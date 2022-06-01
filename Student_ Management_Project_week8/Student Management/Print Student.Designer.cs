namespace Student_Management_Project_week8.Student_Management

{
    partial class Print_Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSaveToTextFile = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelGender = new System.Windows.Forms.Panel();
            this.radioButtonAllGender = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brithDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelDate.SuspendLayout();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.label4);
            this.panelDate.Controls.Add(this.buttonSaveToTextFile);
            this.panelDate.Controls.Add(this.buttonCheck);
            this.panelDate.Controls.Add(this.label3);
            this.panelDate.Controls.Add(this.panelGender);
            this.panelDate.Controls.Add(this.dateTimePickerEndDate);
            this.panelDate.Controls.Add(this.radioButtonNo);
            this.panelDate.Controls.Add(this.radioButtonYes);
            this.panelDate.Controls.Add(this.dateTimePickerStartDate);
            this.panelDate.Controls.Add(this.label2);
            this.panelDate.Controls.Add(this.label1);
            this.panelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDate.Location = new System.Drawing.Point(13, 13);
            this.panelDate.Margin = new System.Windows.Forms.Padding(4);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(1722, 111);
            this.panelDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender:";
            // 
            // buttonSaveToTextFile
            // 
            this.buttonSaveToTextFile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSaveToTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonSaveToTextFile.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveToTextFile.Location = new System.Drawing.Point(1424, 22);
            this.buttonSaveToTextFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveToTextFile.Name = "buttonSaveToTextFile";
            this.buttonSaveToTextFile.Size = new System.Drawing.Size(281, 75);
            this.buttonSaveToTextFile.TabIndex = 3;
            this.buttonSaveToTextFile.Text = "Save To Text File";
            this.buttonSaveToTextFile.UseVisualStyleBackColor = false;
            this.buttonSaveToTextFile.Click += new System.EventHandler(this.buttonSaveToTextFile_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Aqua;
            this.buttonCheck.Location = new System.Drawing.Point(1192, 22);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(224, 73);
            this.buttonCheck.TabIndex = 6;
            this.buttonCheck.Text = "CHECK";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "And";
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.radioButtonAllGender);
            this.panelGender.Controls.Add(this.radioButtonFemale);
            this.panelGender.Controls.Add(this.radioButtonMale);
            this.panelGender.Location = new System.Drawing.Point(241, 50);
            this.panelGender.Margin = new System.Windows.Forms.Padding(4);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(400, 60);
            this.panelGender.TabIndex = 8;
            // 
            // radioButtonAllGender
            // 
            this.radioButtonAllGender.AutoSize = true;
            this.radioButtonAllGender.Checked = true;
            this.radioButtonAllGender.Location = new System.Drawing.Point(249, 16);
            this.radioButtonAllGender.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAllGender.Name = "radioButtonAllGender";
            this.radioButtonAllGender.Size = new System.Drawing.Size(135, 29);
            this.radioButtonAllGender.TabIndex = 2;
            this.radioButtonAllGender.TabStop = true;
            this.radioButtonAllGender.Text = "All Genders";
            this.radioButtonAllGender.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(123, 16);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(98, 29);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(4, 16);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(76, 29);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(887, 79);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(297, 26);
            this.dateTimePickerEndDate.TabIndex = 5;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Location = new System.Drawing.Point(364, 22);
            this.radioButtonNo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(63, 29);
            this.radioButtonNo.TabIndex = 3;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "NO";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(241, 22);
            this.radioButtonYes.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(73, 29);
            this.radioButtonYes.TabIndex = 2;
            this.radioButtonYes.Text = "YES";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(887, 20);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(297, 26);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(657, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "BirthDate Between:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Date Range:";
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowDrop = true;
            this.dataGridViewStudentList.AllowUserToAddRows = false;
            this.dataGridViewStudentList.AllowUserToDeleteRows = false;
            this.dataGridViewStudentList.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridViewStudentList.ColumnHeadersHeight = 30;
            this.dataGridViewStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.firstNameColumn,
            this.lastNameColumn,
            this.brithDateColumn,
            this.genderColumn,
            this.phoneColumn,
            this.addressColumn,
            this.pictureColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudentList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(13, 132);
            this.dataGridViewStudentList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.ReadOnly = true;
            this.dataGridViewStudentList.RowHeadersVisible = false;
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.RowTemplate.Height = 100;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(1705, 384);
            this.dataGridViewStudentList.TabIndex = 11;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idColumn.DataPropertyName = "id";
            this.idColumn.HeaderText = "ID";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 125;
            // 
            // firstNameColumn
            // 
            this.firstNameColumn.DataPropertyName = "fname";
            this.firstNameColumn.HeaderText = "First Name";
            this.firstNameColumn.MinimumWidth = 6;
            this.firstNameColumn.Name = "firstNameColumn";
            this.firstNameColumn.ReadOnly = true;
            this.firstNameColumn.Width = 125;
            // 
            // lastNameColumn
            // 
            this.lastNameColumn.DataPropertyName = "lname";
            this.lastNameColumn.HeaderText = "Last Name";
            this.lastNameColumn.MinimumWidth = 6;
            this.lastNameColumn.Name = "lastNameColumn";
            this.lastNameColumn.ReadOnly = true;
            this.lastNameColumn.Width = 125;
            // 
            // brithDateColumn
            // 
            this.brithDateColumn.DataPropertyName = "bdate";
            this.brithDateColumn.HeaderText = "Birth Date";
            this.brithDateColumn.MinimumWidth = 6;
            this.brithDateColumn.Name = "brithDateColumn";
            this.brithDateColumn.ReadOnly = true;
            this.brithDateColumn.Width = 250;
            // 
            // genderColumn
            // 
            this.genderColumn.DataPropertyName = "gender";
            this.genderColumn.HeaderText = "Gender";
            this.genderColumn.MinimumWidth = 6;
            this.genderColumn.Name = "genderColumn";
            this.genderColumn.ReadOnly = true;
            this.genderColumn.Width = 125;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "phone";
            this.phoneColumn.HeaderText = "Phone number";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            this.phoneColumn.Width = 200;
            // 
            // addressColumn
            // 
            this.addressColumn.DataPropertyName = "address";
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.MinimumWidth = 6;
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            this.addressColumn.Width = 250;
            // 
            // pictureColumn
            // 
            this.pictureColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pictureColumn.DataPropertyName = "picture";
            this.pictureColumn.HeaderText = "Student Picture";
            this.pictureColumn.MinimumWidth = 6;
            this.pictureColumn.Name = "pictureColumn";
            this.pictureColumn.ReadOnly = true;
            // 
            // Print_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 552);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.panelDate);
            this.Name = "Print_Student";
            this.Text = "Print_Student";
            this.Load += new System.EventHandler(this.Print_Student_Load);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSaveToTextFile;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radioButtonAllGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brithDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureColumn;
    }
}