using System.Windows.Forms;

namespace Student_Management_Project_week8
{
    partial class UpdateStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonUpdateMale = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateFemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStudentUpdate = new System.Windows.Forms.PictureBox();
            this.Update_ImageButton = new System.Windows.Forms.Button();
            this.textBox_Update_ID = new System.Windows.Forms.TextBox();
            this.textBox_Fname_Update = new System.Windows.Forms.TextBox();
            this.button_FindStudent_Update = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Lname_Update = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Update = new System.Windows.Forms.DateTimePicker();
            this.textBoxUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.richTextBoxUpdateAddress = new System.Windows.Forms.RichTextBox();
            this.labelAddressErrorUpdate = new System.Windows.Forms.Label();
            this.labelPhoneErrorUpdate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDateTimeErrorUpdate = new System.Windows.Forms.Label();
            this.labelLnameErrorUpdate = new System.Windows.Forms.Label();
            this.labelFnameErrorUpdate = new System.Windows.Forms.Label();
            this.label_ID_errorUpdate = new System.Windows.Forms.Label();
            this.labelPIctureEmtyUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Family Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.HotPink;
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.HotPink;
            this.label4.Location = new System.Drawing.Point(11, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.HotPink;
            this.label5.Location = new System.Drawing.Point(11, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            // 
            // radioButtonUpdateMale
            // 
            this.radioButtonUpdateMale.AutoSize = true;
            this.radioButtonUpdateMale.Location = new System.Drawing.Point(159, 204);
            this.radioButtonUpdateMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUpdateMale.Name = "radioButtonUpdateMale";
            this.radioButtonUpdateMale.Size = new System.Drawing.Size(58, 20);
            this.radioButtonUpdateMale.TabIndex = 5;
            this.radioButtonUpdateMale.TabStop = true;
            this.radioButtonUpdateMale.Text = "Male";
            this.radioButtonUpdateMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdateFemale
            // 
            this.radioButtonUpdateFemale.AutoSize = true;
            this.radioButtonUpdateFemale.Location = new System.Drawing.Point(249, 204);
            this.radioButtonUpdateFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonUpdateFemale.Name = "radioButtonUpdateFemale";
            this.radioButtonUpdateFemale.Size = new System.Drawing.Size(74, 20);
            this.radioButtonUpdateFemale.TabIndex = 6;
            this.radioButtonUpdateFemale.TabStop = true;
            this.radioButtonUpdateFemale.Text = "Female";
            this.radioButtonUpdateFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.HotPink;
            this.label6.Location = new System.Drawing.Point(11, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.HotPink;
            this.label7.Location = new System.Drawing.Point(11, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Address:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(625, 288);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxStudentUpdate
            // 
            this.pictureBoxStudentUpdate.Location = new System.Drawing.Point(419, 10);
            this.pictureBoxStudentUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxStudentUpdate.Name = "pictureBoxStudentUpdate";
            this.pictureBoxStudentUpdate.Size = new System.Drawing.Size(376, 201);
            this.pictureBoxStudentUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStudentUpdate.TabIndex = 10;
            this.pictureBoxStudentUpdate.TabStop = false;
            // 
            // Update_ImageButton
            // 
            this.Update_ImageButton.BackColor = System.Drawing.Color.SandyBrown;
            this.Update_ImageButton.Location = new System.Drawing.Point(419, 237);
            this.Update_ImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_ImageButton.Name = "Update_ImageButton";
            this.Update_ImageButton.Size = new System.Drawing.Size(376, 41);
            this.Update_ImageButton.TabIndex = 11;
            this.Update_ImageButton.Text = "Update Image";
            this.Update_ImageButton.UseVisualStyleBackColor = false;
            this.Update_ImageButton.Click += new System.EventHandler(this.Update_ImageButton_Click);
            // 
            // textBox_Update_ID
            // 
            this.textBox_Update_ID.Location = new System.Drawing.Point(117, 25);
            this.textBox_Update_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Update_ID.Name = "textBox_Update_ID";
            this.textBox_Update_ID.Size = new System.Drawing.Size(165, 22);
            this.textBox_Update_ID.TabIndex = 12;
            // 
            // textBox_Fname_Update
            // 
            this.textBox_Fname_Update.Location = new System.Drawing.Point(117, 60);
            this.textBox_Fname_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Fname_Update.Name = "textBox_Fname_Update";
            this.textBox_Fname_Update.Size = new System.Drawing.Size(265, 22);
            this.textBox_Fname_Update.TabIndex = 13;
            // 
            // button_FindStudent_Update
            // 
            this.button_FindStudent_Update.BackColor = System.Drawing.Color.Pink;
            this.button_FindStudent_Update.Location = new System.Drawing.Point(287, 23);
            this.button_FindStudent_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_FindStudent_Update.Name = "button_FindStudent_Update";
            this.button_FindStudent_Update.Size = new System.Drawing.Size(94, 23);
            this.button_FindStudent_Update.TabIndex = 14;
            this.button_FindStudent_Update.Text = "Find";
            this.button_FindStudent_Update.UseVisualStyleBackColor = false;
            this.button_FindStudent_Update.Click += new System.EventHandler(this.button_FindStudent_Update_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.SandyBrown;
            this.Update_button.Location = new System.Drawing.Point(419, 327);
            this.Update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(185, 33);
            this.Update_button.TabIndex = 15;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.LightCoral;
            this.Delete_button.Location = new System.Drawing.Point(419, 375);
            this.Delete_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(185, 32);
            this.Delete_button.TabIndex = 16;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(393, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Some times, just lazy a bit!";
            // 
            // textBox_Lname_Update
            // 
            this.textBox_Lname_Update.Location = new System.Drawing.Point(117, 115);
            this.textBox_Lname_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Lname_Update.Name = "textBox_Lname_Update";
            this.textBox_Lname_Update.Size = new System.Drawing.Size(265, 22);
            this.textBox_Lname_Update.TabIndex = 18;
            // 
            // dateTimePicker_Update
            // 
            this.dateTimePicker_Update.Location = new System.Drawing.Point(117, 161);
            this.dateTimePicker_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Update.Name = "dateTimePicker_Update";
            this.dateTimePicker_Update.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_Update.TabIndex = 19;
            // 
            // textBoxUpdatePhoneNumber
            // 
            this.textBoxUpdatePhoneNumber.Location = new System.Drawing.Point(117, 251);
            this.textBoxUpdatePhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUpdatePhoneNumber.Name = "textBoxUpdatePhoneNumber";
            this.textBoxUpdatePhoneNumber.Size = new System.Drawing.Size(265, 22);
            this.textBoxUpdatePhoneNumber.TabIndex = 20;
            // 
            // richTextBoxUpdateAddress
            // 
            this.richTextBoxUpdateAddress.Location = new System.Drawing.Point(117, 302);
            this.richTextBoxUpdateAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxUpdateAddress.Name = "richTextBoxUpdateAddress";
            this.richTextBoxUpdateAddress.Size = new System.Drawing.Size(265, 103);
            this.richTextBoxUpdateAddress.TabIndex = 21;
            this.richTextBoxUpdateAddress.Text = "";
            // 
            // labelAddressErrorUpdate
            // 
            this.labelAddressErrorUpdate.AutoSize = true;
            this.labelAddressErrorUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelAddressErrorUpdate.Location = new System.Drawing.Point(117, 408);
            this.labelAddressErrorUpdate.Name = "labelAddressErrorUpdate";
            this.labelAddressErrorUpdate.Size = new System.Drawing.Size(173, 20);
            this.labelAddressErrorUpdate.TabIndex = 22;
            this.labelAddressErrorUpdate.Text = "Please, Enter a Address!";
            this.labelAddressErrorUpdate.Visible = false;
            // 
            // labelPhoneErrorUpdate
            // 
            this.labelPhoneErrorUpdate.AutoSize = true;
            this.labelPhoneErrorUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPhoneErrorUpdate.ForeColor = System.Drawing.Color.IndianRed;
            this.labelPhoneErrorUpdate.Location = new System.Drawing.Point(117, 274);
            this.labelPhoneErrorUpdate.Name = "labelPhoneErrorUpdate";
            this.labelPhoneErrorUpdate.Size = new System.Drawing.Size(223, 20);
            this.labelPhoneErrorUpdate.TabIndex = 23;
            this.labelPhoneErrorUpdate.Text = "Please, Enter a Phone Number!";
            this.labelPhoneErrorUpdate.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(117, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "You are a Boy or a Girl, to be honest?";
            this.label10.Visible = false;
            // 
            // labelDateTimeErrorUpdate
            // 
            this.labelDateTimeErrorUpdate.AutoSize = true;
            this.labelDateTimeErrorUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelDateTimeErrorUpdate.ForeColor = System.Drawing.Color.IndianRed;
            this.labelDateTimeErrorUpdate.Location = new System.Drawing.Point(117, 186);
            this.labelDateTimeErrorUpdate.Name = "labelDateTimeErrorUpdate";
            this.labelDateTimeErrorUpdate.Size = new System.Drawing.Size(219, 20);
            this.labelDateTimeErrorUpdate.TabIndex = 25;
            this.labelDateTimeErrorUpdate.Text = "Only from 10 to 100 years old...";
            this.labelDateTimeErrorUpdate.Visible = false;
            // 
            // labelLnameErrorUpdate
            // 
            this.labelLnameErrorUpdate.AutoSize = true;
            this.labelLnameErrorUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelLnameErrorUpdate.ForeColor = System.Drawing.Color.IndianRed;
            this.labelLnameErrorUpdate.Location = new System.Drawing.Point(117, 140);
            this.labelLnameErrorUpdate.Name = "labelLnameErrorUpdate";
            this.labelLnameErrorUpdate.Size = new System.Drawing.Size(136, 20);
            this.labelLnameErrorUpdate.TabIndex = 26;
            this.labelLnameErrorUpdate.Text = "Last name, please!";
            this.labelLnameErrorUpdate.Visible = false;
            // 
            // labelFnameErrorUpdate
            // 
            this.labelFnameErrorUpdate.AutoSize = true;
            this.labelFnameErrorUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelFnameErrorUpdate.ForeColor = System.Drawing.Color.IndianRed;
            this.labelFnameErrorUpdate.Location = new System.Drawing.Point(117, 83);
            this.labelFnameErrorUpdate.Name = "labelFnameErrorUpdate";
            this.labelFnameErrorUpdate.Size = new System.Drawing.Size(155, 20);
            this.labelFnameErrorUpdate.TabIndex = 27;
            this.labelFnameErrorUpdate.Text = "Family name, please!";
            this.labelFnameErrorUpdate.Visible = false;
            // 
            // label_ID_errorUpdate
            // 
            this.label_ID_errorUpdate.AutoSize = true;
            this.label_ID_errorUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_ID_errorUpdate.ForeColor = System.Drawing.Color.IndianRed;
            this.label_ID_errorUpdate.Location = new System.Drawing.Point(117, 6);
            this.label_ID_errorUpdate.Name = "label_ID_errorUpdate";
            this.label_ID_errorUpdate.Size = new System.Drawing.Size(169, 20);
            this.label_ID_errorUpdate.TabIndex = 28;
            this.label_ID_errorUpdate.Text = "How about an valid ID?";
            this.label_ID_errorUpdate.Visible = false;
            // 
            // labelPIctureEmtyUpdate
            // 
            this.labelPIctureEmtyUpdate.AutoSize = true;
            this.labelPIctureEmtyUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPIctureEmtyUpdate.Location = new System.Drawing.Point(419, 212);
            this.labelPIctureEmtyUpdate.Name = "labelPIctureEmtyUpdate";
            this.labelPIctureEmtyUpdate.Size = new System.Drawing.Size(163, 20);
            this.labelPIctureEmtyUpdate.TabIndex = 29;
            this.labelPIctureEmtyUpdate.Text = "You forgot a picture :<";
            this.labelPIctureEmtyUpdate.Visible = false;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(807, 443);
            this.Controls.Add(this.labelPIctureEmtyUpdate);
            this.Controls.Add(this.label_ID_errorUpdate);
            this.Controls.Add(this.labelFnameErrorUpdate);
            this.Controls.Add(this.labelLnameErrorUpdate);
            this.Controls.Add(this.labelDateTimeErrorUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelPhoneErrorUpdate);
            this.Controls.Add(this.labelAddressErrorUpdate);
            this.Controls.Add(this.richTextBoxUpdateAddress);
            this.Controls.Add(this.textBoxUpdatePhoneNumber);
            this.Controls.Add(this.dateTimePicker_Update);
            this.Controls.Add(this.textBox_Lname_Update);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.button_FindStudent_Update);
            this.Controls.Add(this.textBox_Fname_Update);
            this.Controls.Add(this.textBox_Update_ID);
            this.Controls.Add(this.Update_ImageButton);
            this.Controls.Add(this.pictureBoxStudentUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonUpdateFemale);
            this.Controls.Add(this.radioButtonUpdateMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RadioButton radioButtonUpdateMale;
        private RadioButton radioButtonUpdateFemale;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxStudentUpdate;
        private Button Update_ImageButton;
        private TextBox textBox_Update_ID;
        private TextBox textBox_Fname_Update;
        private Button button_FindStudent_Update;
        private Button Update_button;
        private Button Delete_button;
        private Label label8;
        private TextBox textBox_Lname_Update;
        private DateTimePicker dateTimePicker_Update;
        private TextBox textBoxUpdatePhoneNumber;
        private RichTextBox richTextBoxUpdateAddress;
        private Label labelAddressErrorUpdate;
        private Label labelPhoneErrorUpdate;
        private Label label10;
        private Label labelDateTimeErrorUpdate;
        private Label labelLnameErrorUpdate;
        private Label labelFnameErrorUpdate;
        private Label label_ID_errorUpdate;
        private Label labelPIctureEmtyUpdate;
    }
}