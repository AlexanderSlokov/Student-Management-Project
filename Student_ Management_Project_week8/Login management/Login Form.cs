using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using Student_Management_Project_week8;
using Student_Management_Project_week8.HR_Management;


namespace Student_Management_Project_week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MY_DB db = new MY_DB();
        USER user = new USER();

        public static class GLOBAL
        {
            // parameterless constructor required for static class
            static GLOBAL() { CurrentUserID = 0; } // default value

            // public get, and private set for strict access control
            public static int CurrentUserID { get; private set; }


            // GlobalInt can be changed only via this method
            public static void SetGlobalUserID(int newInt)
            {
                CurrentUserID = newInt;
            }
            //// activate the GlobalVariables NameSpace
            //using GlobalVariables;

            //// accessing the global variable
            //int x = Globals.GlobalInt;

            //// setting the global variable
            //Globals.SetGlobalInt(888);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {


            if (radioButtonStudent.Checked)
            {               
                StudentLogin();
            }
               

            if (radioButtonHR.Checked)
            {
                GLOBAL.SetGlobalUserID(user.GetID(textBox_Username.Text.Trim(), textBox_Password.Text.Trim()));
                HumanResoureLogin();
            }
        }      
               
        
        //auto fill for fast tests
        private void Form1_Load(object sender, EventArgs e)
        {           
            if(radioButtonStudent.Checked)
            {
                textBox_Username.Select();
                textBox_Username.Text = "cielta";
                textBox_Password.Text = "123";
            }
            if(radioButtonHR.Checked)
            {
                textBox_Username.Select();
                textBox_Username.Text = "Admin1";
                textBox_Password.Text = "123";
            }
           
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBox_Password.PasswordChar = '\0';
            }
            else
            {
                textBox_Password.PasswordChar = '•';
            }
        }

        private void createAccLabel_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(this);
            this.Hide();
        }

        private void StudentLogin()
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM LoginuserInfo WHERE UserName = @User AND Password = @Pass", db.GetConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_Username.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox_Password.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login Success");
                Main_Form dashBoard = new Main_Form();
                dashBoard.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HumanResoureLogin()
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM hmrsrc WHERE username = @User AND password = @Pass", db.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBox_Username.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox_Password.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login Success");
                HumanResourceMain dashBoard = new HumanResourceMain();
                dashBoard.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelHRM_Register_Click(object sender, EventArgs e)
        {
            Human_Resourse_Register_Form human_Resourse_Register_Form = new Human_Resourse_Register_Form();
            human_Resourse_Register_Form.Show(this);    
        }
    }
}