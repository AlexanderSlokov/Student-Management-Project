namespace Student_Management_Project_week8.Courses
{
    partial class AddingCourses
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.textBoxCourseLabel = new System.Windows.Forms.TextBox();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.labelCourseLabel = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelCourseIDError = new System.Windows.Forms.Label();
            this.labelCourseLabelError = new System.Windows.Forms.Label();
            this.labelPeriodError = new System.Windows.Forms.Label();
            this.labelSemesterError = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(154, 264);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(201, 115);
            this.textBoxDescription.TabIndex = 2;
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(154, 148);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(201, 22);
            this.textBoxPeriod.TabIndex = 4;
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(154, 32);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(201, 22);
            this.textBoxCourseID.TabIndex = 5;
            // 
            // textBoxCourseLabel
            // 
            this.textBoxCourseLabel.Location = new System.Drawing.Point(154, 93);
            this.textBoxCourseLabel.Name = "textBoxCourseLabel";
            this.textBoxCourseLabel.Size = new System.Drawing.Size(201, 22);
            this.textBoxCourseLabel.TabIndex = 6;
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.Location = new System.Drawing.Point(13, 29);
            this.labelCourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(106, 25);
            this.labelCourseID.TabIndex = 8;
            this.labelCourseID.Text = "Course ID:";
            // 
            // labelCourseLabel
            // 
            this.labelCourseLabel.AutoSize = true;
            this.labelCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseLabel.Location = new System.Drawing.Point(53, 89);
            this.labelCourseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseLabel.Name = "labelCourseLabel";
            this.labelCourseLabel.Size = new System.Drawing.Size(66, 25);
            this.labelCourseLabel.TabIndex = 9;
            this.labelCourseLabel.Text = "Label:";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriod.Location = new System.Drawing.Point(45, 148);
            this.labelPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(74, 25);
            this.labelPeriod.TabIndex = 10;
            this.labelPeriod.Text = "Period:";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(17, 201);
            this.labelSemester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(102, 25);
            this.labelSemester.TabIndex = 16;
            this.labelSemester.Text = "Semester:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(4, 260);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(115, 25);
            this.labelDescription.TabIndex = 17;
            this.labelDescription.Text = "Description:";
            // 
            // labelCourseIDError
            // 
            this.labelCourseIDError.AutoSize = true;
            this.labelCourseIDError.ForeColor = System.Drawing.Color.Red;
            this.labelCourseIDError.Location = new System.Drawing.Point(161, 57);
            this.labelCourseIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseIDError.Name = "labelCourseIDError";
            this.labelCourseIDError.Size = new System.Drawing.Size(122, 16);
            this.labelCourseIDError.TabIndex = 18;
            this.labelCourseIDError.Text = "labelCourseIDError";
            // 
            // labelCourseLabelError
            // 
            this.labelCourseLabelError.AutoSize = true;
            this.labelCourseLabelError.ForeColor = System.Drawing.Color.Red;
            this.labelCourseLabelError.Location = new System.Drawing.Point(161, 118);
            this.labelCourseLabelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourseLabelError.Name = "labelCourseLabelError";
            this.labelCourseLabelError.Size = new System.Drawing.Size(143, 16);
            this.labelCourseLabelError.TabIndex = 19;
            this.labelCourseLabelError.Text = "labelCourseLabelError";
            // 
            // labelPeriodError
            // 
            this.labelPeriodError.AutoSize = true;
            this.labelPeriodError.ForeColor = System.Drawing.Color.Red;
            this.labelPeriodError.Location = new System.Drawing.Point(161, 173);
            this.labelPeriodError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeriodError.Name = "labelPeriodError";
            this.labelPeriodError.Size = new System.Drawing.Size(106, 16);
            this.labelPeriodError.TabIndex = 20;
            this.labelPeriodError.Text = "labelPeriodError";
            // 
            // labelSemesterError
            // 
            this.labelSemesterError.AutoSize = true;
            this.labelSemesterError.ForeColor = System.Drawing.Color.Red;
            this.labelSemesterError.Location = new System.Drawing.Point(161, 229);
            this.labelSemesterError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemesterError.Name = "labelSemesterError";
            this.labelSemesterError.Size = new System.Drawing.Size(124, 16);
            this.labelSemesterError.TabIndex = 21;
            this.labelSemesterError.Text = "labelSemesterError";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(154, 395);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 33);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Cyan;
            this.buttonCancel.Location = new System.Drawing.Point(259, 395);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 34);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(154, 201);
            this.comboBoxSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(201, 24);
            this.comboBoxSemester.TabIndex = 24;
            // 
            // AddingCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSemesterError);
            this.Controls.Add(this.labelPeriodError);
            this.Controls.Add(this.labelCourseLabelError);
            this.Controls.Add(this.labelCourseIDError);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelCourseLabel);
            this.Controls.Add(this.labelCourseID);
            this.Controls.Add(this.textBoxCourseLabel);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.textBoxDescription);
            this.Name = "AddingCourses";
            this.Text = "AddingCourses";
            this.Load += new System.EventHandler(this.AddingCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.TextBox textBoxCourseLabel;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.Label labelCourseLabel;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelCourseIDError;
        private System.Windows.Forms.Label labelCourseLabelError;
        private System.Windows.Forms.Label labelPeriodError;
        private System.Windows.Forms.Label labelSemesterError;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxSemester;
    }
}