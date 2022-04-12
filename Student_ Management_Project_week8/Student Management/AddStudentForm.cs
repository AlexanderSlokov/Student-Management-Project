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

namespace Student_Management_Project_week8
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            // reformat the date and time
            dateTimePicker.CustomFormat = "dd - MM - yyyy";
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {

            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            DateTime bdate = dateTimePicker.Value;
            string phone = textBoxPhoneNumber.Text;
            string adrs = richTextBoxAddress.Text;
            string gender = "Male";

            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();

            int born_year = dateTimePicker.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student 's Age Muast Be Between 10 and 100 year", "Invalid Birth date!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verification())
            {
                pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                
                if(student.insertStudent(id,fname,lname,bdate,gender,phone,adrs,pic))
                {
                    MessageBox.Show("New student added!", "Add Student", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Existed Student ID", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               pictureBoxStudentImage.Image = Image.FromFile(openFileDialog.FileName);
               pictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
               pictureBoxStudentImage.Image.Save( pic, pictureBoxStudentImage.Image.RawFormat);
            }
        }
        bool verification()
        {
            if ((textBoxFirstName.Text.Trim() == "")
                        || (textBoxLastName.Text.Trim() == "")
                        || (richTextBoxAddress.Text.Trim() == "")
                        || (textBoxPhoneNumber.Text.Trim() == "")
                        || (pictureBoxStudentImage.Image == null))
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
