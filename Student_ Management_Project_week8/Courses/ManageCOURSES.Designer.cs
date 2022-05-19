namespace Student_Management_Project_week8.Courses
{
    partial class ManageCOURSES
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
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelHoursNumber = new System.Windows.Forms.Label();
            this.labelCourseLabel = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelSemesterError = new System.Windows.Forms.Label();
            this.labelPeriodError = new System.Windows.Forms.Label();
            this.labelCourseLabelError = new System.Windows.Forms.Label();
            this.labelCourseIDError = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.numericUpDownHoursNumber = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCourseLabel = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonTotalCourses = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoursNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(40, 202);
            this.labelSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(86, 20);
            this.labelSemester.TabIndex = 22;
            this.labelSemester.Text = "Semester:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(26, 260);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 20);
            this.labelDescription.TabIndex = 21;
            this.labelDescription.Text = "Description:";
            // 
            // labelHoursNumber
            // 
            this.labelHoursNumber.AutoSize = true;
            this.labelHoursNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoursNumber.Location = new System.Drawing.Point(8, 145);
            this.labelHoursNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHoursNumber.Name = "labelHoursNumber";
            this.labelHoursNumber.Size = new System.Drawing.Size(124, 20);
            this.labelHoursNumber.TabIndex = 20;
            this.labelHoursNumber.Text = "Hours Number:";
            // 
            // labelCourseLabel
            // 
            this.labelCourseLabel.AutoSize = true;
            this.labelCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseLabel.Location = new System.Drawing.Point(71, 75);
            this.labelCourseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseLabel.Name = "labelCourseLabel";
            this.labelCourseLabel.Size = new System.Drawing.Size(55, 20);
            this.labelCourseLabel.TabIndex = 19;
            this.labelCourseLabel.Text = "Label:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(95, 9);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 20);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "ID:";
            // 
            // labelSemesterError
            // 
            this.labelSemesterError.AutoSize = true;
            this.labelSemesterError.ForeColor = System.Drawing.Color.Red;
            this.labelSemesterError.Location = new System.Drawing.Point(484, 205);
            this.labelSemesterError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemesterError.Name = "labelSemesterError";
            this.labelSemesterError.Size = new System.Drawing.Size(124, 16);
            this.labelSemesterError.TabIndex = 31;
            this.labelSemesterError.Text = "labelSemesterError";
            // 
            // labelPeriodError
            // 
            this.labelPeriodError.AutoSize = true;
            this.labelPeriodError.ForeColor = System.Drawing.Color.Red;
            this.labelPeriodError.Location = new System.Drawing.Point(484, 143);
            this.labelPeriodError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriodError.Name = "labelPeriodError";
            this.labelPeriodError.Size = new System.Drawing.Size(106, 16);
            this.labelPeriodError.TabIndex = 30;
            this.labelPeriodError.Text = "labelPeriodError";
            // 
            // labelCourseLabelError
            // 
            this.labelCourseLabelError.AutoSize = true;
            this.labelCourseLabelError.ForeColor = System.Drawing.Color.Red;
            this.labelCourseLabelError.Location = new System.Drawing.Point(484, 86);
            this.labelCourseLabelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseLabelError.Name = "labelCourseLabelError";
            this.labelCourseLabelError.Size = new System.Drawing.Size(143, 16);
            this.labelCourseLabelError.TabIndex = 29;
            this.labelCourseLabelError.Text = "labelCourseLabelError";
            // 
            // labelCourseIDError
            // 
            this.labelCourseIDError.AutoSize = true;
            this.labelCourseIDError.ForeColor = System.Drawing.Color.Red;
            this.labelCourseIDError.Location = new System.Drawing.Point(484, 24);
            this.labelCourseIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseIDError.Name = "labelCourseIDError";
            this.labelCourseIDError.Size = new System.Drawing.Size(122, 16);
            this.labelCourseIDError.TabIndex = 28;
            this.labelCourseIDError.Text = "labelCourseIDError";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(174, 198);
            this.comboBoxSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(300, 24);
            this.comboBoxSemester.TabIndex = 27;
            // 
            // numericUpDownHoursNumber
            // 
            this.numericUpDownHoursNumber.Location = new System.Drawing.Point(174, 143);
            this.numericUpDownHoursNumber.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownHoursNumber.Name = "numericUpDownHoursNumber";
            this.numericUpDownHoursNumber.Size = new System.Drawing.Size(301, 22);
            this.numericUpDownHoursNumber.TabIndex = 26;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(174, 260);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(300, 202);
            this.textBoxDescription.TabIndex = 25;
            // 
            // textBoxCourseLabel
            // 
            this.textBoxCourseLabel.Location = new System.Drawing.Point(174, 83);
            this.textBoxCourseLabel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCourseLabel.Name = "textBoxCourseLabel";
            this.textBoxCourseLabel.Size = new System.Drawing.Size(300, 22);
            this.textBoxCourseLabel.TabIndex = 24;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(174, 21);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(300, 22);
            this.textBoxID.TabIndex = 23;
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 16;
            this.listBoxCourses.Location = new System.Drawing.Point(657, 13);
            this.listBoxCourses.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(267, 468);
            this.listBoxCourses.TabIndex = 32;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline);
            this.buttonNext.Location = new System.Drawing.Point(195, 470);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(122, 62);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline);
            this.buttonPrevious.Location = new System.Drawing.Point(352, 470);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(122, 62);
            this.buttonPrevious.TabIndex = 35;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.Color.DimGray;
            this.buttonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline);
            this.buttonLast.Location = new System.Drawing.Point(504, 470);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(122, 62);
            this.buttonLast.TabIndex = 34;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = false;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirst.Location = new System.Drawing.Point(43, 470);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(122, 62);
            this.buttonFirst.TabIndex = 33;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = false;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonTotalCourses
            // 
            this.buttonTotalCourses.Location = new System.Drawing.Point(657, 423);
            this.buttonTotalCourses.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTotalCourses.Name = "buttonTotalCourses";
            this.buttonTotalCourses.Size = new System.Drawing.Size(267, 58);
            this.buttonTotalCourses.TabIndex = 37;
            this.buttonTotalCourses.Text = "Total Course:";
            this.buttonTotalCourses.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(487, 260);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 62);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(487, 330);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(161, 62);
            this.buttonEdit.TabIndex = 39;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(488, 400);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(161, 62);
            this.buttonRemove.TabIndex = 38;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // ManageCOURSES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 545);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonTotalCourses);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.labelSemesterError);
            this.Controls.Add(this.labelPeriodError);
            this.Controls.Add(this.labelCourseLabelError);
            this.Controls.Add(this.labelCourseIDError);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.numericUpDownHoursNumber);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCourseLabel);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHoursNumber);
            this.Controls.Add(this.labelCourseLabel);
            this.Controls.Add(this.labelID);
            this.Name = "ManageCOURSES";
            this.Text = "ManageCOURSES";
            this.Load += new System.EventHandler(this.ManageCOURSES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoursNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHoursNumber;
        private System.Windows.Forms.Label labelCourseLabel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelSemesterError;
        private System.Windows.Forms.Label labelPeriodError;
        private System.Windows.Forms.Label labelCourseLabelError;
        private System.Windows.Forms.Label labelCourseIDError;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.NumericUpDown numericUpDownHoursNumber;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCourseLabel;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonTotalCourses;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
    }
}