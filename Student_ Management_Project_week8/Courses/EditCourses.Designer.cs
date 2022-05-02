namespace Student_Management_Project_week8.Courses
{
    partial class EditCourses
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
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelCourseLabel = new System.Windows.Forms.Label();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.labelPeriodError = new System.Windows.Forms.Label();
            this.labelCourseLabelError = new System.Windows.Forms.Label();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(53, 176);
            this.labelSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(102, 25);
            this.labelSemester.TabIndex = 23;
            this.labelSemester.Text = "Semester:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(40, 235);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(115, 25);
            this.labelDescription.TabIndex = 22;
            this.labelDescription.Text = "Description:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.Location = new System.Drawing.Point(81, 120);
            this.labelPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(74, 25);
            this.labelPeriod.TabIndex = 21;
            this.labelPeriod.Text = "Period:";
            // 
            // labelCourseLabel
            // 
            this.labelCourseLabel.AutoSize = true;
            this.labelCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseLabel.Location = new System.Drawing.Point(89, 69);
            this.labelCourseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseLabel.Name = "labelCourseLabel";
            this.labelCourseLabel.Size = new System.Drawing.Size(66, 25);
            this.labelCourseLabel.TabIndex = 20;
            this.labelCourseLabel.Text = "Label:";
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.Location = new System.Drawing.Point(13, 13);
            this.labelSelectCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(142, 25);
            this.labelSelectCourse.TabIndex = 19;
            this.labelSelectCourse.Text = "Select Course:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(190, 177);
            this.comboBoxSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(239, 24);
            this.comboBoxSemester.TabIndex = 30;
            // 
            // labelPeriodError
            // 
            this.labelPeriodError.AutoSize = true;
            this.labelPeriodError.ForeColor = System.Drawing.Color.Red;
            this.labelPeriodError.Location = new System.Drawing.Point(187, 152);
            this.labelPeriodError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriodError.Name = "labelPeriodError";
            this.labelPeriodError.Size = new System.Drawing.Size(106, 16);
            this.labelPeriodError.TabIndex = 29;
            this.labelPeriodError.Text = "labelPeriodError";
            // 
            // labelCourseLabelError
            // 
            this.labelCourseLabelError.AutoSize = true;
            this.labelCourseLabelError.ForeColor = System.Drawing.Color.Red;
            this.labelCourseLabelError.Location = new System.Drawing.Point(187, 99);
            this.labelCourseLabelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseLabelError.Name = "labelCourseLabelError";
            this.labelCourseLabelError.Size = new System.Drawing.Size(143, 16);
            this.labelCourseLabelError.TabIndex = 28;
            this.labelCourseLabelError.Text = "labelCourseLabelError";
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPeriod.Location = new System.Drawing.Point(190, 122);
            this.numericUpDownPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(239, 26);
            this.numericUpDownPeriod.TabIndex = 27;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(190, 235);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(239, 104);
            this.textBoxDescription.TabIndex = 26;
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(190, 73);
            this.textBoxCourseID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(239, 22);
            this.textBoxCourseID.TabIndex = 25;
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(190, 13);
            this.comboBoxSelectCourse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(239, 24);
            this.comboBoxSelectCourse.TabIndex = 24;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(190, 370);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(239, 49);
            this.buttonEdit.TabIndex = 31;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // EditCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 443);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.labelPeriodError);
            this.Controls.Add(this.labelCourseLabelError);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelCourseLabel);
            this.Controls.Add(this.labelSelectCourse);
            this.Name = "EditCourses";
            this.Text = "EditCourses";
            this.Load += new System.EventHandler(this.EditCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelCourseLabel;
        private System.Windows.Forms.Label labelSelectCourse;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label labelPeriodError;
        private System.Windows.Forms.Label labelCourseLabelError;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Button buttonEdit;
    }
}