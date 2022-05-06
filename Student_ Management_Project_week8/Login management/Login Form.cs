using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Student_Management_Project_week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            //create table to check validity of username and password
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM LoginUserInfo WHERE UserName = @User AND Password = @Pass", db.GetConnection);
            command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBox_Username.Text;
            command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBox_Password.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if((table.Rows.Count > 0))
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Welcome, my master!");
                //active main form
                Main_Form dashBoard = new Main_Form();
                dashBoard.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password! Please, check again...", "Login Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
            
        
        
        //auto fill for fast tests
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Username.Select();
            textBox_Username.Text = "cielta";
            textBox_Password.Text = "123";


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}