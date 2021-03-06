namespace Student_Management_Project_week8.Student_Management
{
    partial class Manage_Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Student_Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxManage = new System.Windows.Forms.PictureBox();
            this.richTextBoxADR = new System.Windows.Forms.RichTextBox();
            this.textBoxPHONE = new System.Windows.Forms.TextBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.radioButtonMALE = new System.Windows.Forms.RadioButton();
            this.radioButtonFEMALE = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxFNAME = new System.Windows.Forms.TextBox();
            this.textBoxLNAME = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelStudentIdError = new System.Windows.Forms.Label();
            this.labelFirstNameError = new System.Windows.Forms.Label();
            this.labelLastNameError = new System.Windows.Forms.Label();
            this.labelGenderError = new System.Windows.Forms.Label();
            this.labelPhoneError = new System.Windows.Forms.Label();
            this.labelAddressError = new System.Windows.Forms.Label();
            this.labelPictureError = new System.Windows.Forms.Label();
            this.labelBirthDateError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.Size = new System.Drawing.Size(496, 566);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.AutoSize = true;
            this.labelTotalStudent.Location = new System.Drawing.Point(726, 609);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(89, 16);
            this.labelTotalStudent.TabIndex = 1;
            this.labelTotalStudent.Text = "Total Student:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search With Name or Address:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(562, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(182, 22);
            this.textBoxSearch.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(763, 9);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(91, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search ";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Picture:";
            // 
            // pictureBoxManage
            // 
            this.pictureBoxManage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxManage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxManage.Image")));
            this.pictureBoxManage.Location = new System.Drawing.Point(101, 425);
            this.pictureBoxManage.Name = "pictureBoxManage";
            this.pictureBoxManage.Size = new System.Drawing.Size(247, 181);
            this.pictureBoxManage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxManage.TabIndex = 12;
            this.pictureBoxManage.TabStop = false;
            // 
            // richTextBoxADR
            // 
            this.richTextBoxADR.Location = new System.Drawing.Point(101, 345);
            this.richTextBoxADR.Name = "richTextBoxADR";
            this.richTextBoxADR.Size = new System.Drawing.Size(247, 42);
            this.richTextBoxADR.TabIndex = 13;
            this.richTextBoxADR.Text = "";
            // 
            // textBoxPHONE
            // 
            this.textBoxPHONE.Location = new System.Drawing.Point(101, 282);
            this.textBoxPHONE.Name = "textBoxPHONE";
            this.textBoxPHONE.Size = new System.Drawing.Size(247, 22);
            this.textBoxPHONE.TabIndex = 14;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(101, 636);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(247, 37);
            this.buttonUploadImage.TabIndex = 15;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(481, 636);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 36);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(358, 636);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 36);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(616, 635);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(117, 37);
            this.buttonRemove.TabIndex = 18;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(739, 636);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(115, 37);
            this.buttonRefresh.TabIndex = 19;
            this.buttonRefresh.Text = "Reflesh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // radioButtonMALE
            // 
            this.radioButtonMALE.AutoSize = true;
            this.radioButtonMALE.Location = new System.Drawing.Point(101, 229);
            this.radioButtonMALE.Name = "radioButtonMALE";
            this.radioButtonMALE.Size = new System.Drawing.Size(58, 20);
            this.radioButtonMALE.TabIndex = 20;
            this.radioButtonMALE.TabStop = true;
            this.radioButtonMALE.Text = "Male";
            this.radioButtonMALE.UseVisualStyleBackColor = true;
            // 
            // radioButtonFEMALE
            // 
            this.radioButtonFEMALE.AutoSize = true;
            this.radioButtonFEMALE.Location = new System.Drawing.Point(274, 229);
            this.radioButtonFEMALE.Name = "radioButtonFEMALE";
            this.radioButtonFEMALE.Size = new System.Drawing.Size(74, 20);
            this.radioButtonFEMALE.TabIndex = 21;
            this.radioButtonFEMALE.TabStop = true;
            this.radioButtonFEMALE.Text = "Female";
            this.radioButtonFEMALE.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(101, 174);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker.TabIndex = 22;
            // 
            // textBoxFNAME
            // 
            this.textBoxFNAME.Location = new System.Drawing.Point(101, 70);
            this.textBoxFNAME.Name = "textBoxFNAME";
            this.textBoxFNAME.Size = new System.Drawing.Size(247, 22);
            this.textBoxFNAME.TabIndex = 23;
            // 
            // textBoxLNAME
            // 
            this.textBoxLNAME.Location = new System.Drawing.Point(101, 124);
            this.textBoxLNAME.Name = "textBoxLNAME";
            this.textBoxLNAME.Size = new System.Drawing.Size(247, 22);
            this.textBoxLNAME.TabIndex = 24;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(101, 16);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(247, 22);
            this.textBoxID.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID:";
            // 
            // labelStudentIdError
            // 
            this.labelStudentIdError.AutoSize = true;
            this.labelStudentIdError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentIdError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelStudentIdError.Location = new System.Drawing.Point(101, 41);
            this.labelStudentIdError.Name = "labelStudentIdError";
            this.labelStudentIdError.Size = new System.Drawing.Size(106, 16);
            this.labelStudentIdError.TabIndex = 28;
            this.labelStudentIdError.Text = "StudentIdError";
            this.labelStudentIdError.Visible = false;
            // 
            // labelFirstNameError
            // 
            this.labelFirstNameError.AutoSize = true;
            this.labelFirstNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNameError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelFirstNameError.Location = new System.Drawing.Point(101, 95);
            this.labelFirstNameError.Name = "labelFirstNameError";
            this.labelFirstNameError.Size = new System.Drawing.Size(112, 16);
            this.labelFirstNameError.TabIndex = 29;
            this.labelFirstNameError.Text = "FirstNameError";
            this.labelFirstNameError.Visible = false;
            // 
            // labelLastNameError
            // 
            this.labelLastNameError.AutoSize = true;
            this.labelLastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastNameError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelLastNameError.Location = new System.Drawing.Point(98, 149);
            this.labelLastNameError.Name = "labelLastNameError";
            this.labelLastNameError.Size = new System.Drawing.Size(111, 16);
            this.labelLastNameError.TabIndex = 30;
            this.labelLastNameError.Text = "LastNameError";
            this.labelLastNameError.Visible = false;
            // 
            // labelGenderError
            // 
            this.labelGenderError.AutoSize = true;
            this.labelGenderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelGenderError.Location = new System.Drawing.Point(102, 252);
            this.labelGenderError.Name = "labelGenderError";
            this.labelGenderError.Size = new System.Drawing.Size(92, 16);
            this.labelGenderError.TabIndex = 31;
            this.labelGenderError.Text = "GenderError";
            this.labelGenderError.Visible = false;
            // 
            // labelPhoneError
            // 
            this.labelPhoneError.AutoSize = true;
            this.labelPhoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelPhoneError.Location = new System.Drawing.Point(102, 307);
            this.labelPhoneError.Name = "labelPhoneError";
            this.labelPhoneError.Size = new System.Drawing.Size(85, 16);
            this.labelPhoneError.TabIndex = 32;
            this.labelPhoneError.Text = "PhoneError";
            this.labelPhoneError.Visible = false;
            // 
            // labelAddressError
            // 
            this.labelAddressError.AutoSize = true;
            this.labelAddressError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddressError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelAddressError.Location = new System.Drawing.Point(102, 390);
            this.labelAddressError.Name = "labelAddressError";
            this.labelAddressError.Size = new System.Drawing.Size(99, 16);
            this.labelAddressError.TabIndex = 33;
            this.labelAddressError.Text = "AddressError";
            this.labelAddressError.Visible = false;
            // 
            // labelPictureError
            // 
            this.labelPictureError.AutoSize = true;
            this.labelPictureError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPictureError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelPictureError.Location = new System.Drawing.Point(102, 609);
            this.labelPictureError.Name = "labelPictureError";
            this.labelPictureError.Size = new System.Drawing.Size(89, 16);
            this.labelPictureError.TabIndex = 34;
            this.labelPictureError.Text = "PictureError";
            this.labelPictureError.Visible = false;
            // 
            // labelBirthDateError
            // 
            this.labelBirthDateError.AutoSize = true;
            this.labelBirthDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDateError.ForeColor = System.Drawing.Color.IndianRed;
            this.labelBirthDateError.Location = new System.Drawing.Point(101, 199);
            this.labelBirthDateError.Name = "labelBirthDateError";
            this.labelBirthDateError.Size = new System.Drawing.Size(105, 16);
            this.labelBirthDateError.TabIndex = 35;
            this.labelBirthDateError.Text = "BirthDateError";
            this.labelBirthDateError.Visible = false;
            // 
            // Manage_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(876, 709);
            this.Controls.Add(this.labelBirthDateError);
            this.Controls.Add(this.labelPictureError);
            this.Controls.Add(this.labelAddressError);
            this.Controls.Add(this.labelPhoneError);
            this.Controls.Add(this.labelGenderError);
            this.Controls.Add(this.labelLastNameError);
            this.Controls.Add(this.labelFirstNameError);
            this.Controls.Add(this.labelStudentIdError);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxLNAME);
            this.Controls.Add(this.textBoxFNAME);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.radioButtonFEMALE);
            this.Controls.Add(this.radioButtonMALE);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.textBoxPHONE);
            this.Controls.Add(this.richTextBoxADR);
            this.Controls.Add(this.pictureBoxManage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotalStudent);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Manage_Student_Form";
            this.Text = "Manage_Student_Form";
            this.Load += new System.EventHandler(this.Manage_Student_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxManage;
        private System.Windows.Forms.RichTextBox richTextBoxADR;
        private System.Windows.Forms.TextBox textBoxPHONE;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.RadioButton radioButtonMALE;
        private System.Windows.Forms.RadioButton radioButtonFEMALE;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxFNAME;
        private System.Windows.Forms.TextBox textBoxLNAME;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelStudentIdError;
        private System.Windows.Forms.Label labelFirstNameError;
        private System.Windows.Forms.Label labelLastNameError;
        private System.Windows.Forms.Label labelGenderError;
        private System.Windows.Forms.Label labelPhoneError;
        private System.Windows.Forms.Label labelAddressError;
        private System.Windows.Forms.Label labelPictureError;
        private System.Windows.Forms.Label labelBirthDateError;
    }
}