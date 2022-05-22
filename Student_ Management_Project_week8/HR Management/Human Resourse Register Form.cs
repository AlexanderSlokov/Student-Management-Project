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
using Student_Management_Project_week8.Class;

namespace Student_Management_Project_week8.HR_Management
{
    public partial class Human_Resourse_Register_Form : Form
    {
        public Human_Resourse_Register_Form()
        {
            InitializeComponent();
        }

        MY_DB myDB = new MY_DB();
        USER user = new USER();
        int id;
        MemoryStream picture = new MemoryStream();
        string firstname, lastname, username, password, passwordConfirm;
        bool pictureCheck = false;
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

        private void labelBackToLogIn_Click(object sender, EventArgs e)
        {
            FormClose();
        }

        private void Human_Resourse_Register_Form_Load(object sender, EventArgs e)
        {
            labelConfirmPasswordError.Visible = false;
            labelImageError.Visible = false;
            labelIDError.Visible = false;
            labelUsernameError.Visible = false;
            labelPasswordError.Visible = false;
            labelFirstNameError.Visible = false;
            labelLastNameError.Visible = false;
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png; *.gif; *.jfif)|*.jpg;*.png;*.gif;*.jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
                PictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
                PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);
                pictureCheck = true;
            }
            else
            {
                pictureCheck = false;
            }
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
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool idCheck = false;
            bool lastnameTyped = false, firstnameTyped = false;
            bool usernameCheck = false, passwordCheck = false;
            bool passwordTyped = false, passwordConfirmed = false;

            Int32.TryParse(textBoxID.Text, out id);
            lastname = textBoxLastName.Text;
            firstname = textBoxFirstName.Text;
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            passwordConfirm = textBoxConfirmPassword.Text;

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
            // id exist check
            if (!verif(textBoxID.Text))
            {
                idCheck = false;
                labelIDError.Visible = true;
                labelIDError.Text = "Please Enter Your ID";
            }
            else
            {
                if (user.IDExist(id))
                {
                    id = 0;
                    idCheck = false;
                    labelIDError.Visible = true;
                    labelIDError.Text = "ID exist";
                }
                else
                {
                    Int32.TryParse(textBoxID.Text, out id);
                    idCheck = true;
                    labelIDError.Visible = false;
                    labelIDError.Text = "";
                }
            }
            // check username
            if (!verif(username))
            {
                labelUsernameError.Visible = true;
                labelUsernameError.Text = ("Please enter valid username");
                usernameCheck = false;
            }
            else
            {
                if (user.UsernameExist(username, "register"))
                {
                    labelUsernameError.Visible = true;
                    labelUsernameError.Text = ("Existed Username");
                    usernameCheck = false;
                }
                else
                {
                    labelUsernameError.Visible = false;
                    usernameCheck = true;
                    labelUsernameError.Text = string.Empty;
                }

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
            if (pictureCheck == false)
            {
                labelImageError.Visible = true;
                labelImageError.Text = "Please Insert Your Picture";
            }
            else
            {
                labelImageError.Visible = false;
                labelImageError.Text = "";
            }
            // dieu kien cuoi
            if (idCheck == true && firstnameTyped == true && lastnameTyped == true && passwordCheck == true && usernameCheck == true && pictureCheck == true)
            {
                labelPasswordError.Text = string.Empty;
                PictureBoxStudentImage.Image.Save(picture, PictureBoxStudentImage.Image.RawFormat);

                SqlCommand command = new SqlCommand("INSERT INTO hmrsrc(id, fname, lname, username, password, picture) VALUES (@id, @fn, @ln, @un, @pass, @pic)", myDB.GetConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = firstname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lastname;
                command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

                myDB.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sucessfully Registed");
                    FormClose();
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
        private void FormClose()
        {
            this.Owner.Show();
            this.Owner.BringToFront();
            this.Hide();
        }
    }
}
