using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Student_Management_Project_week8;

namespace Student_Management_Project_week8
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private int id;
        public int Id { get => id; set => id = value; }
        string fname = string.Empty, lname = string.Empty, phone = string.Empty, adrs = string.Empty, gender = string.Empty;
        DateTime bdate;
        MemoryStream pic = new MemoryStream();
        STUDENT student = new STUDENT();

        

        public int initialID;


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
                id = Int32.Parse(textBox_Update_ID.Text);
                if (id != 0)
                {
                    if (student.getData(id, ref fname, ref lname, ref bdate, ref gender, ref phone, ref address, pictureBoxStudentUpdate))
                    {
                        if (gender == "Female")
                        {
                            radioButtonUpdateMale.Checked = false;
                            radioButtonUpdateFemale.Checked = true;
                        }
                        else
                        {
                            radioButtonUpdateMale.Checked = true;
                            radioButtonUpdateFemale.Checked = false;
                        }
                        textBox_Fname_Update.Text = fname;
                        textBox_Lname_Update.Text = lname;
                        try { dateTimePicker_Update.Value = bdate; } catch { }
                        textBoxUpdatePhoneNumber.Text = phone;
                        richTextBoxUpdateAddress.Text = address;
                        Update_button.Enabled = true;
                        Delete_button.Enabled = true;
                        dateTimePicker_Update.Visible = true;
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

        private void Delete_button_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                int id = Convert.ToInt32(textBox_Update_ID.Text);
            }
            catch
            {
                MessageBox.Show("Xin mời nhập ID");
            }
            string fname = textBox_Fname_Update.Text;
            string lname = textBox_Lname_Update.Text;
            DateTime bdate = dateTimePicker_Update.Value;
            string phone = textBoxUpdatePhoneNumber.Text;
            string adrs = richTextBoxUpdateAddress.Text;
            string gender = "Male";
            if (radioButtonUpdateFemale.Checked)
            {
                gender = "Female";
            }
            if (student.deleteStudent(id, fname, lname, bdate, phone, adrs, gender))
            {
                textBox_Update_ID.Text = string.Empty;
                textBox_Fname_Update.Text = string.Empty;
                textBox_Lname_Update.Text = string.Empty;
                dateTimePicker_Update.Value = DateTime.Today;
               
                textBoxUpdatePhoneNumber.Text = string.Empty;
                richTextBoxUpdateAddress.Text = string.Empty;
                
                radioButtonUpdateMale.Checked = true;
                radioButtonUpdateFemale.Checked = false;
                
                pictureBoxStudentUpdate.Image.Dispose();
               
                Update_button.Enabled = false;
                Delete_button.Enabled = false;
                MessageBox.Show("Deleted");
            }








        }

        private void Update_ImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxStudentUpdate.Image = Image.FromFile(opf.FileName);
                pictureBoxStudentUpdate.Image.Save(pic, pictureBoxStudentUpdate.Image.RawFormat);
                
            }
            else
            {
                labelPIctureEmtyUpdate.Visible = true;
            }
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                textBox_Update_ID.Text = id.ToString();
            }
            Update_button.Enabled = false;
            Delete_button.Enabled = false;
        }

        private void button_FindStudent_Update_Click(object sender, EventArgs e)
        {
            if (textBox_Update_ID.Text == string.Empty)
            {
                MessageBox.Show("Did you Forget to give me an ID?");
            }

            else
            {
                try
                {
                    id = Int32.Parse(textBox_Update_ID.Text);
                    initialID = id;
                }
                catch
                {
                    MessageBox.Show("A valid ID, PLease?");
                }
                if (!student.existID(id))
                {
                    MessageBox.Show("No ID student Existed");
                    Update_button.Enabled = false;
                    Delete_button.Enabled = false;
                    textBox_Fname_Update.Text = string.Empty;
                    textBox_Lname_Update.Text = string.Empty;
                    dateTimePicker_Update.Visible = false;
                    textBoxUpdatePhoneNumber.Text = string.Empty;
                    richTextBoxUpdateAddress.Text = string.Empty;
                    radioButtonUpdateMale.Checked = true;
                    radioButtonUpdateFemale.Checked = false;
                    try
                    {
                        if (pictureBoxStudentUpdate.Image != null)
                        {
                            pictureBoxStudentUpdate.Image.Dispose();
                            pictureBoxStudentUpdate.Image = null;
                        }
                    }
                    catch
                    {

                    }
                }
                else
                    studentFind();
            }
        }


        private void Update_button_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                if (Int32.Parse(textBox_Update_ID.Text) >= 1)
                {
                    id = Convert.ToInt32(textBox_Update_ID.Text);                    
                }
            }
            catch
            {
                label_ID_errorUpdate.Visible = true;
            }


           
            if (textBox_Fname_Update.TextLength > 0)
            {
                fname = textBox_Fname_Update.Text;               
            }
            else
            {
                labelFnameErrorUpdate.Visible = true;
            }

           
            if (textBox_Lname_Update.TextLength > 0)
            {
                lname = textBox_Lname_Update.Text;               
            }
            else
            {
                labelLnameErrorUpdate.Visible = true;
            }

           
            bdate = dateTimePicker_Update.Value;

            
            if (textBoxUpdatePhoneNumber.TextLength > 0)
            {
                phone = textBoxUpdatePhoneNumber.Text;              
            }
            else
            {
                labelPhoneErrorUpdate.Visible = true;
            }

            
            if (richTextBoxUpdateAddress.TextLength > 0)
            {
                adrs = richTextBoxUpdateAddress.Text;                
            }
            else
            {
                labelAddressErrorUpdate.Visible = true;
            }

            gender = "Male";
            if (radioButtonUpdateFemale.Checked)
            {
                gender = "Female";
            }

            
            if (pictureBoxStudentUpdate.Image == null)
            {
                labelPIctureEmtyUpdate.Visible= true;
            }
            else
            {
                labelPIctureEmtyUpdate.Text = string.Empty;
            }
            if (richTextBoxUpdateAddress.TextLength > 0)
            {
                adrs = richTextBoxUpdateAddress.Text;
               
            }
            else
            {
                labelAddressErrorUpdate.Visible = true;
            }


            int born_year = dateTimePicker_Update.Value.Year;
            int this_year = DateTime.Now.Year;

            if ((this_year - born_year) < 10 || ((this_year - born_year) > 100))
            {

                labelDateTimeErrorUpdate.Visible =true;
            }
            else
            {
               
                if (verif())
                {
                    
                        if (textBox_Update_ID.Text == initialID.ToString())
                        {
                            pictureBoxStudentUpdate.Image.Save(this.pic, pictureBoxStudentUpdate.Image.RawFormat);
                            if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                            {
                               
                                MessageBox.Show("Informations Updated", "Updating student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Updating Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        if (textBox_Update_ID.Text != initialID.ToString())
                        {
                            if (!student.existID(id))
                            {
                                student.deleteStudent(initialID, fname, lname, bdate, phone, adrs, gender);
                                pictureBoxStudentUpdate.Image.Save(this.pic, pictureBoxStudentUpdate.Image.RawFormat);
                                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                                {
                                    this.Owner.Close();
                                    
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
                       
                }
                else
                {
                        MessageBox.Show("Insert Student's Picture", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


            bool verif()
            {
                if ((textBox_Fname_Update.Text.Trim()) == ""
                    || (textBox_Lname_Update.Text.Trim() == "")
                    || (richTextBoxUpdateAddress.Text.Trim() == "")
                    || (textBoxUpdatePhoneNumber.Text.Trim() == "")
                    || (pictureBoxStudentUpdate == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
    }

}

