using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Student_Management_Project_week8;
namespace Student_Management_Project_week8.Student_Management
{
    public partial class Print_Student : Form
    {
        public Print_Student()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();

        private enum dataIndex
        {
            id = 1,
            fname = 2,
            lname = 3,
            bdate = 4,
            gender = 5,
            phone = 6,  
            address = 7,    
            picture = 8    
        }
        private void buttonPrintCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            
            DateTime startdate = new DateTime();
            DateTime enddate = new DateTime();
            
            startdate = dateTimePickerPrintUP.Value;
            enddate = dateTimePickerPrintDOWN.Value;


            if (radioButtonDateRangeYes.Checked)
            {
                if (radioButtonMalePrint.Checked)
                {
                    query = "SELECT * FROM StudentInfo WHERE gender = 'male' AND bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";       
                }
                else if (radioButtonFemalePrint.Checked)
                {
                    query = "SELECT * FROM StudentInfo WHERE gender = 'female' AND bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }
                else
                {
                    query = "SELECT * FROM StundentInfo WHERE bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }

                command = new SqlCommand(query, mydb.GetConnection);
                fillGrid(command);
            }
            else
            {
                if (radioButtonMalePrint.Checked)
                {
                    getMaleData();
                }
                else if (radioButtonFemalePrint.Checked)
                {
                    getFemaleData();
                }
                else
                {
                    getAllData();
                }
            }
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridViewPrintView.ReadOnly = true;

            DataGridViewImageColumn pictureColumn = new DataGridViewImageColumn();
            dataGridViewPrintView.RowTemplate.Height = 80;
            dataGridViewPrintView.DataSource = student.getStudent(command);

            pictureColumn = (DataGridViewImageColumn)dataGridViewPrintView.Columns[7];
            pictureColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewPrintView.AllowUserToAddRows = false;
        }


        private void getMaleData()
        {
            MY_DB mydb = new MY_DB();
            mydb.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo WHERE gender= 'male'", mydb.GetConnection);
            DataSet dataSet = new DataSet();

            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "StudentInfo");

            dataTable = dataSet.Tables["StudentInfo"];
            dataGridViewPrintView.DataSource = dataTable;

            mydb.closeConnection();
        }
        private void getFemaleData()
        {
            MY_DB mydb = new MY_DB();
            mydb.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo WHERE gender= 'female'", mydb.GetConnection);
            DataSet dataSet = new DataSet();

            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "StudentInfo");

            dataTable = dataSet.Tables["StudentInfo"];
            dataGridViewPrintView.DataSource = dataTable;

            mydb.closeConnection();
        }
        private void getAllData()
        {
            try
            {
                MY_DB mydb = new MY_DB();
                mydb.openConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo", mydb.GetConnection);
                DataSet dataSet = new DataSet();

                System.Data.DataTable dataTable = new System.Data.DataTable();
                sqlDataAdapter.Fill(dataSet, "StudentInfo");

                dataTable = dataSet.Tables["StudentInfo"];
                dataGridViewPrintView.DataSource = dataTable;

                mydb.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failtal Error: " + ex.Message);    
            }
        }

        private void Print_Student_Load(object sender, EventArgs e)
        {
            dateTimePickerPrintUP.Value = new DateTime(1995, 01, 01);
            
            getAllData();
            
            dataGridViewPrintView.Columns[0].HeaderText = "Student ID";
            dataGridViewPrintView.Columns[1].HeaderText = "Student Familly Name";
            dataGridViewPrintView.Columns[2].HeaderText = "Student Last Name";
            dataGridViewPrintView.Columns[3].HeaderText = "Student Birth Date";
            dataGridViewPrintView.Columns[4].HeaderText = "Student Gender";
            dataGridViewPrintView.Columns[5].HeaderText = "Student Phone Number";
            dataGridViewPrintView.Columns[6].HeaderText = "Student Address";
            dataGridViewPrintView.Columns[7].HeaderText = "Student Image";

        //you are here
        }
    }
}
