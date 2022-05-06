using Student_Management_Project_week8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Project_week8
{
    public partial class RegisterForm : Form
    {
        public RegisterForm() => InitializeComponent();

        MY_DB myDB = new MY_DB();
        string username, password, passwordConfirm;
        STUDENT student = new STUDENT();
        private void buttonEreaser_Click(object sender, EventArgs e)
        {
            textBoxRegisterUserName.Text = "";
            textBoxRegisterPassword.Text = "";
            textBoxConfirmPass.Text = "";
            
            textBoxRegisterUserName.Focus();
        }

        private void labelBackToLogin_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(this);
            this.Hide();
        }

        private void RegisterSignInButton_Click(object sender, EventArgs e)
        {
            bool usernameCheck = false, passwordCheck = false;
            bool passwordTyped = false, passwordConfirmed = false;

            //put in vars the user 's input
            username = textBoxRegisterUserName.Text;
            password = textBoxRegisterPassword.Text;
            passwordConfirm = textBoxConfirmPass.Text;

            if (!verif(username))
            {
                labelErrorUsername.Visible = true;
                labelErrorUsername.Text = ("Please enter valid username");
                usernameCheck = false;
            }

          
            else
            {
                if (student.existUsername(username))
                {
                    labelErrorUsername.Visible = true;
                    labelErrorUsername.Text = ("Existed Username");
                    usernameCheck = false;
                }
               
                else
                {
                    usernameCheck = true;
                    labelErrorUsername.Text = string.Empty;
                }

            }
           

            //passwords catching errors
            if (password == "")
            {
                labelErrorPassword.Visible = true;
                labelErrorPassword.Text = ("Please Enter Password");
                passwordCheck = false;
                passwordTyped = false;
            }
            else
            {
                labelErrorPassword.Text = string.Empty;
                passwordTyped = true;
            }

            // password confirm catching errors
            if (passwordConfirm == "")
            {
                labelErrorPasswordConfirm.Visible = true;
                labelErrorPasswordConfirm.Text = ("Please confirm your password!");
                passwordCheck = false;
                passwordConfirmed = false;
            }
            else
            {
                labelErrorPasswordConfirm.Text = string.Empty;
                passwordConfirmed = true;
            }

            if (password == passwordConfirm && password.Length != 0 && passwordConfirm.Length != 0)
            {
                passwordCheck = true;
            }
            else
            {
                if (passwordTyped && passwordConfirmed)
                {
                    labelErrorPasswordConfirm.Visible = true;
                    labelErrorPasswordConfirm.Text = ("Passwords are not the same!");
                    passwordCheck = false;
                }
            }

            //if both of newusername and new password are correct
            if (passwordCheck == true && usernameCheck == true)
            {
                labelErrorPassword.Text = string.Empty;

                SqlCommand command = new SqlCommand("INSERT INTO LoginUserInfo (ID, UserName, Password)" + " VALUES ((SELECT MAX(ID) FROM LoginUserInfo) + 1, @username, @password)", myDB.GetConnection);
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                myDB.openConnection();

                try
                {
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        myDB.closeConnection();
                    }
                    else
                    {
                        myDB.closeConnection();
                    }

                }
                catch { }

                MessageBox.Show("Successfuly Registed!");
                this.Close();


            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSeePassRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSeePassRegister.Checked)
            {
                textBoxRegisterPassword.PasswordChar = '\0';
                textBoxConfirmPass.PasswordChar = '\0'; 
            }
            else
            {
                textBoxRegisterPassword.PasswordChar = '•';
                textBoxConfirmPass.PasswordChar = '•'; 
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
        
        
        
    }
}
