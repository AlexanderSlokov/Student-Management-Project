using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_Project_week8;

namespace Student_Management_Project_week8.Student_Management
{
    public partial class Manage_Student_Form : Form
    {
        public Manage_Student_Form()
        {
            InitializeComponent();
        }

        //private variables
        private MemoryStream pic = new MemoryStream();
        private int initialID;
        private int id;
        private string fname = string.Empty,
                        lname = string.Empty,
                        phone = string.Empty,
                        adrs = string.Empty,
                        gender = string.Empty;

        //constructor for picture variable
        public MemoryStream Pic { get => pic; set => pic = value; }

        private void Manage_Student_Form_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM StudentInfo", mydb.GetConnection));
        }

        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        DateTime bdate;

       
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = student.getStudent(command);

            DataGridViewImageColumn PicCol = new DataGridViewImageColumn();
            PicCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            PicCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            labelTotalStudent.Text = ("Total students: " + dataGridView1.Rows.Count);

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            textBoxFNAME.Text = string.Empty;
            textBoxLNAME.Text = string.Empty;
            dateTimePicker.Value = DateTime.Today;
            textBoxPHONE.Text = string.Empty;
            richTextBoxADR.Text = string.Empty;
            radioButtonMALE.Checked = true;
            radioButtonFEMALE.Checked = false;
            if (pictureBoxManage.Image != null)
            {
                pictureBoxManage.Image.Dispose();
                pictureBoxManage.Image = null;
            }
            textBoxID.Focus();
            refreshfunc();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM StudentInfo WHERE CONCAT(fname, lname, address) LIKE'%" + textBoxSearch.Text + "%'", mydb.GetConnection);
            fillGrid(command);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            getImage();
        }

        private MemoryStream getImage()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxManage.Image = Image.FromFile(opf.FileName);
                pictureBoxManage.Image.Save(Pic, pictureBoxManage.Image.RawFormat);
                pictureBoxManage.Text = string.Empty;
                return Pic;
            }
            else
            {
                if (pictureBoxManage.Image != null)
                {
                    return Pic;
                }
                else
                {
                    Pic = null;
                    labelPictureError.Visible = true;
                    labelPictureError.Text = "Xin mời chèn hình học sinh";
                    return null;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.MinValue;
            string fname = string.Empty, lname = string.Empty, phone = string.Empty, adrs = string.Empty, gender = string.Empty;
            DateTime bdate;

            int born_year = dateTimePicker.Value.Year;
            int this_year = DateTime.Now.Year;

            //error for ID
            try
            {
                if (Int32.Parse(textBoxID.Text) >= 1)
                {
                    id = Convert.ToInt32(textBoxID.Text);
                    //if no error, no execute label below
                    labelStudentIdError.Text = string.Empty;
                }
            }
            catch
            {
                labelStudentIdError.Visible = true;
                labelStudentIdError.Text = ("Xin mời nhập ID");
            }

            //another error catchers added 
            if (textBoxFNAME.TextLength > 0)
            {
                fname = textBoxFNAME.Text;
                labelFirstNameError.Text = string.Empty;
            }
            else
            {
                labelFirstNameError.Visible = true;
                labelFirstNameError.Text = ("Xin mời nhập họ tên lót");
            }
            if (textBoxLNAME.TextLength > 0)
            {
                lname = textBoxLNAME.Text;
                labelLastNameError.Text = string.Empty;
            }
            else
            {
                labelLastNameError.Visible = true;
                labelLastNameError.Text = ("Xin mời nhập họ tên");
            }

            bdate = dateTimePicker.Value;
            
            if (textBoxPHONE.TextLength > 0)
            {
                phone = textBoxPHONE.Text;
                labelPhoneError.Text = string.Empty;
            }
            else
            {
                labelPhoneError.Visible = true;
                labelPhoneError.Text = "Mời nhập số điện thoại";
            }
            if (richTextBoxADR.TextLength > 0)
            {
                adrs = richTextBoxADR.Text;
                labelAddressError.Text = string.Empty;
            }
            else
            {
                labelPhoneError.Visible=true;   
                labelPhoneError.Text = "Mời nhập địa chỉ";
            }
            if (radioButtonFEMALE.Checked == false && radioButtonMALE.Checked == false)
            {
                labelGenderError.Visible = true;
                labelGenderError.Text = "Mời xác nhận giới tính";
            }
            else
            {
                labelGenderError.Text = string.Empty;
            }
            gender = "Male";

            if (radioButtonFEMALE.Checked)
            {
                gender = "Female";
            }
            if (pictureBoxManage.Image == null)
            {
                labelPictureError.Visible = true;   
                labelPictureError.Text = "Xin mời chèn hình học sinh";
            }
            else
            {
                labelPictureError.Text = string.Empty;
            }
            if (richTextBoxADR.TextLength > 0)
            {
                adrs = richTextBoxADR.Text;
                labelAddressError.Text = string.Empty;
            }
            else
            {
                labelAddressError.Visible = true;   
                labelAddressError.Text = "Xin mời nhập địa chỉ";
            }

            //especially student 's age
            if ((this_year - born_year) < 10 || ((this_year - born_year) > 100))
            {
                labelBirthDateError.Visible = true;
                labelBirthDateError.Text = "Tuổi sinh viên từ 10 đến 100 tuổi";
            }
            else
            {
                labelBirthDateError.Text = string.Empty;
                if (verif())
                {
                    if (labelPictureError.Text == string.Empty)
                    {
                        // if infomations added successfully 
                        if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, Pic))
                        {
                            fillGrid(new SqlCommand("SELECT * FROM StudentInfo", mydb.GetConnection));
                            MessageBox.Show("New Student Added!", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // In case have already existed student ID
                        else
                        {
                            MessageBox.Show("Existed Student ID...", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //in case no picture added
                    else
                    {
                        MessageBox.Show("You need to insert Student's Picture", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                if (Int32.Parse(textBoxID.Text) >= 1)
                {
                    id = Convert.ToInt32(textBoxID.Text);
                    labelStudentIdError.Text = string.Empty;
                }
            }
            catch
            {
                labelStudentIdError.Text = "Xin mời nhập ID hợp lệ";
            }
            //error catchers added
            if (textBoxFNAME.TextLength > 0)
            {
                fname = textBoxFNAME.Text;
                labelFirstNameError.Text = string.Empty;
            }
            else
            {
                labelFirstNameError.Text = ("Xin mời nhập họ tên lót");
            }
            if (textBoxLNAME.TextLength > 0)
            {
                lname = textBoxLNAME.Text;
                labelLastNameError.Text = string.Empty;
            }
            else
            {
                labelLastNameError.Text = ("Xin mời nhập họ tên");
            }

            bdate = dateTimePicker.Value;

            if (textBoxPHONE.TextLength > 0)
            {
                phone = textBoxPHONE.Text;
                labelPhoneError.Text = string.Empty;
            }
            else
            {
                labelPhoneError.Text = "Mời nhập số điện thoại";
            }
            if (richTextBoxADR.TextLength > 0)
            {
                adrs = richTextBoxADR.Text;
                labelAddressError.Text = string.Empty;
            }
            else
            {
                labelAddressError.Text = "Mời nhập địa chỉ";
            }
            gender = "Male";
            if (radioButtonFEMALE.Checked)
            {
                gender = "Female";
            }
            if (pictureBoxManage.Image == null)
            {
                labelPictureError.Text = "Xin mời chèn hình học sinh";
            }
            else
            {
                labelPictureError.Text = string.Empty;
            }
            if (richTextBoxADR.TextLength > 0)
            {
                adrs = richTextBoxADR.Text;
                labelAddressError.Text = string.Empty;
            }
            else
            {
                labelAddressError.Text = "Xin mời nhập địa chỉ";
            }

            //determite values to calculate student 's valid age
            int born_year = dateTimePicker.Value.Year;
            int this_year = DateTime.Now.Year;

            if ((this_year - born_year) < 10 || ((this_year - born_year) > 100))
            {

                labelBirthDateError.Text = "Tuổi sinh viên từ 10 đến 100 tuổi";
            }
            else
            {
                labelBirthDateError.Text = string.Empty;
                if (verif())
                {
                    if (labelPictureError.Text == string.Empty)
                    {
                        if (textBoxID.Text == initialID.ToString())
                        {

                            if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                            {
                                pictureBoxManage.Image.Save(this.pic, pictureBoxManage.Image.RawFormat);
                                // new FIll function to change Grid
                                fillGrid(new SqlCommand("SELECT * FROM StudentInfo", mydb.GetConnection));
                                MessageBox.Show("Informations Updated", "Updating student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Updating Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        if (textBoxID.Text != initialID.ToString())
                        {
                            if (!student.existID(id))
                            {
                                pictureBoxManage.Image.Save(this.pic, pictureBoxManage.Image.RawFormat);
                                student.deleteStudent(initialID, fname, lname, bdate, phone, adrs, gender);
                                pictureBoxManage.Image.Save(this.pic, pictureBoxManage.Image.RawFormat);
                                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                                {
                                    fillGrid(new SqlCommand("SELECT * FROM std", mydb.GetConnection));
                                    MessageBox.Show("Informations Updated", "Updating student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error", "Updating Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("ID already existed", "Updating Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Insert Student's Picture", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool studentFind()
        {
            string fname = string.Empty;
            string lname = string.Empty;
            DateTime bdate = DateTime.MinValue;
            string phone = string.Empty;
            string adrs = string.Empty;
            string gender = string.Empty;
            string address = string.Empty;
            try
            {
                id = Int32.Parse(textBoxID.Text);
                if (id != 0)
                {
                    if (student.getData(id, ref fname, ref lname, ref bdate, ref gender, ref phone, ref address, pictureBoxManage))
                    {
                        if (gender == "Female")
                        {
                            radioButtonMALE.Checked = false;
                            radioButtonFEMALE.Checked = true;
                        }
                        else
                        {
                            radioButtonMALE.Checked = true;
                            radioButtonFEMALE.Checked = false;
                        }
                        textBoxFNAME.Text = fname;
                        textBoxLNAME.Text = lname;
                        try { dateTimePicker.Value = bdate; } catch { }
                        textBoxPHONE.Text = phone;
                        richTextBoxADR.Text = address;
                        buttonEdit.Enabled = true;
                        buttonRemove.Enabled = true;
                        dateTimePicker.Visible = true;
                        return true;
                    }
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Nhập ID tìm kiếm");
                return false;
            }
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
            }
            catch
            {
                MessageBox.Show("Xin mời nhập ID");
            }

            string fname = textBoxFNAME.Text;
            string lname = textBoxLNAME.Text;
            DateTime bdate = dateTimePicker.Value;
            string phone = textBoxPHONE.Text;
            string adrs = richTextBoxADR.Text;
            
            string gender = "Male";
            if (radioButtonFEMALE.Checked)
            {
                gender = "Female";
            }

            if (student.deleteStudent(id, fname, lname, bdate, phone, adrs, gender))
            {
                textBoxID.Text = string.Empty;
                textBoxFNAME.Text = string.Empty;
                textBoxLNAME.Text = string.Empty;
                dateTimePicker.Value = DateTime.Today;
                textBoxPHONE.Text = string.Empty;
                richTextBoxADR.Text = string.Empty;
                radioButtonMALE.Checked = true;
                radioButtonFEMALE.Checked = false;
                pictureBoxManage.Image.Dispose();
                pictureBoxManage.Image = null;
                buttonEdit.Enabled = false;
                buttonRemove.Enabled = false;
                MessageBox.Show("Information Deleted");
                fillGrid(new SqlCommand("SELECT * FROM StudentInfo", mydb.GetConnection));
            }
        }

        bool verif()
        {
            if ((textBoxFNAME.Text.Trim()) == ""
                || (textBoxLNAME.Text.Trim() == "")
                || (richTextBoxADR.Text.Trim() == "")
                || (textBoxPHONE.Text.Trim() == "")
                || (pictureBoxManage == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void refreshfunc()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}

