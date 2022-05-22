using Student_Management_Project_week8.HR_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Student_Management_Project_week8.Form1;

namespace Student_Management_Project_week8.Login_management
{
    public partial class HRuserEditInfo : Form
    {
        public HRuserEditInfo()
        {
            InitializeComponent();
        }

        MY_DB myDB = new MY_DB();
        USER user = new USER();
        PictureBox picture = new PictureBox();
        string firstname, lastname, username, password, passwordConfirm;
        bool pictureCheck;
        public event EventHandler UpdateMainFormEvent;


        protected virtual void OnUpdateMainForm()
        {
            if (UpdateMainFormEvent != null)
            {
                UpdateMainFormEvent(this, EventArgs.Empty);
            }
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxConfirmPassword.PasswordChar = '•';
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png; *.gif; *.jfif)|*.jpg;*.png;*.gif;*.jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
                PictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureCheck = true;
            }
        }

        private void HRuserEditInfo_Load(object sender, EventArgs e)
        {
            labelConfirmPasswordError.Visible = false;
            labelImageError.Visible = false;
            labelPasswordError.Visible = false;
            labelFirstNameError.Visible = false;
            labelLastNameError.Visible = false;

            checkBoxShowPassword.Checked = false;

            LoadInfo();

            textBoxUsername.Text = username;
            textBoxID.Text = GLOBAL.CurrentUserID.ToString();
            textBoxFirstName.Text = firstname;
            textBoxLastName.Text = lastname;
            textBoxPassword.Text = password;
            textBoxConfirmPassword.Text = passwordConfirm;
            PictureBoxStudentImage.Image = picture.Image;
        }

        
        bool verif(string input)
        {
            if ((input.Trim()) == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LoadInfo()
        {
            user.GetUserInformation(GLOBAL.CurrentUserID, ref firstname, ref lastname, ref username, ref password, picture);
            passwordConfirm = password;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool lastnameTyped = false, firstnameTyped = false, passwordCheck = false, passwordTyped = false, passwordConfirmed = false;
            firstname = textBoxFirstName.Text;
            lastname = textBoxLastName.Text;
            password = textBoxPassword.Text;
            passwordConfirm = textBoxConfirmPassword.Text;
            picture = PictureBoxStudentImage;
            // lastname empty check
            if (!verif(lastname))
            {
                labelLastNameError.Visible = true;
                labelLastNameError.Text = ("Please enter your last name");
                lastnameTyped = false;
            }
            else
            {
                lastnameTyped = true;
                labelLastNameError.Text = string.Empty;
                labelLastNameError.Visible = false;
            }
            // firstname empty check
            if (!verif(firstname))
            {
                labelFirstNameError.Visible = true;
                labelFirstNameError.Text = ("Please enter your first name");
                firstnameTyped = false;
            }
            else
            {
                firstnameTyped = true;
                labelFirstNameError.Text = string.Empty;
                labelFirstNameError.Visible = false;
            }
            // check password
            if (password == "")
            {
                labelPasswordError.Visible = true;
                labelPasswordError.Text = ("Please Enter Password");
                passwordCheck = false;
                passwordTyped = false;
            }
            else
            {
                labelPasswordError.Text = string.Empty;
                passwordTyped = true;
            }
            // check password 2
            if (passwordConfirm == "")
            {
                labelConfirmPasswordError.Visible = true;
                labelConfirmPasswordError.Text = ("Please Confirm Your Password");
                passwordCheck = false;
                passwordConfirmed = false;
            }
            else
            {
                labelConfirmPasswordError.Text = string.Empty;
                passwordConfirmed = true;
            }
            // check 2 password giongnhau
            if (password == passwordConfirm && password.Length != 0 && passwordConfirm.Length != 0)
            {
                passwordCheck = true;

            }
            else
            {
                if (passwordTyped && passwordConfirmed)
                {
                    labelConfirmPasswordError.Visible = true;
                    labelConfirmPasswordError.Text = ("Passwords are not the same");
                    passwordCheck = false;
                }
            }
            // check picture
            if (PictureBoxStudentImage.Image == null)
            {
                labelImageError.Visible = true;
                labelImageError.Text = "Please Insert Your Picture";
                pictureCheck = false;
            }
            else
            {
                labelImageError.Visible = false;
                labelImageError.Text = "";
                pictureCheck = true;
            }
            // dieu kien cuoi
            if (firstnameTyped == true && lastnameTyped == true && passwordCheck == true && pictureCheck == true)
            {
                labelPasswordError.Text = string.Empty;
                MemoryStream pic = new MemoryStream();

                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);

                SqlCommand command = new SqlCommand("UPDATE hmrsrc SET fname = @fn, lname = @ln, username = @un, password = @pass, picture = @pic WHERE id = @uid", myDB.GetConnection);

                command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.CurrentUserID;
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lastname;
                command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();

                myDB.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(this.Parent, "Sucessfully Modified Informations");
                    OnUpdateMainForm();
                    this.Close();
                    myDB.closeConnection();
                }
                else
                {
                    myDB.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Information");
            }
        }
    }
}
