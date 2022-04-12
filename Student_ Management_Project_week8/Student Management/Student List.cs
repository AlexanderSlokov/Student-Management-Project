using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
namespace Student_Management_Project_week8
{
    public partial class Student_List : Form
    {
        public Student_List()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();

        private void Student_List_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDate.CustomFormat = "dd - MM - yyyy";
            dateTimePickerEndDate.CustomFormat = "dd - MM - yyyy";            
            dateTimePickerStartDate.Value = new DateTime(1995, 01, 01);

            try
            {
                mydb.openConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo", mydb.GetConnection);
                DataSet dataSet = new DataSet();

                System.Data.DataTable dataTable = new System.Data.DataTable();
                sqlDataAdapter.Fill(dataSet, "StudentInfo");

                dataTable = dataSet.Tables["StudentInfo"];
                dataGridViewStudentList.DataSource = dataTable;
                dataGridViewStudentList.Columns[0].HeaderText = "Student ID";
                dataGridViewStudentList.Columns[1].HeaderText = "Student Familly Name";
                dataGridViewStudentList.Columns[2].HeaderText = "Student Last Name";
                dataGridViewStudentList.Columns[3].HeaderText = "Student Birth Date";
                dataGridViewStudentList.Columns[4].HeaderText = "Student Gender";
                dataGridViewStudentList.Columns[5].HeaderText = "Student Phone Number";
                dataGridViewStudentList.Columns[6].HeaderText = "Student Address";
                dataGridViewStudentList.Columns[7].HeaderText = "Student Image";



                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];

                try
                {
                    DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns["picture"];
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error casting column to image column: " + ex.Message);
                }

                mydb.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);    
            }
        }




        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            this.Close();
            Student_List studentList = new Student_List();
            studentList.Show();
        }




        private void getMaleData()
        {
            MY_DB mydb = new MY_DB();
            mydb.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo WHERE gender = 'male'", mydb.GetConnection);
            DataSet dataSet = new DataSet();

            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "StudentInfo");

            dataTable = dataSet.Tables["StudentInfo"];
            dataGridViewStudentList.DataSource = dataTable;

            mydb.closeConnection();
        }





        private void getFemaleData()
        {
            MY_DB mydb = new MY_DB();
            mydb.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo WHERE gender = 'female'", mydb.GetConnection);
            DataSet dataSet = new DataSet();

            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "StudentInfo");

            dataTable = dataSet.Tables["StudentInfo"];
            dataGridViewStudentList.DataSource = dataTable;

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
                dataGridViewStudentList.DataSource = dataTable;

                mydb.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failtal Erorr: " + ex.Message);
            }
        }

        private void ExportDataGridViewToExcel(DataGridView dataGridView, bool isPrint)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = (_Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (_Worksheet)workbook.ActiveSheet;

            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
 
            // storing header part in Excel  
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            //storing EACH row and column value to excel sheet
            for( int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].GetType() != typeof(DataGridViewImageCell))
                    {
                        if (dataGridView.Columns[j].HeaderText == "Phone")
                            worksheet.Cells[i + 2, j + 1] = "'" + dataGridView.Rows[i].Cells[j].Value.ToString();
                        else
                            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        // Save image from dataGridView to local
                        ((Image)dataGridView.Rows[i].Cells[j].Value).Save(System.Windows.Forms.Application.StartupPath + @"\Download\picAvt.png");
                        
                        string imagString = System.Windows.Forms.Application.StartupPath + @"\Download\picAvt.png";
                        Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + 2, j + 1];
                        float Left = (float)((double)oRange.Left);
                        float Top = (float)((double)oRange.Top);
                        const float ImageSize = 80;
                        worksheet.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                        oRange.RowHeight = ImageSize + 2;

                    }
                }
            }
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            if (isPrint)
                worksheet.PrintPreview();
        }


        private void ButtonToEXcelFileList_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(dataGridViewStudentList, true);
        }

        private void buttonCheckList_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            DateTime startdate = new DateTime();
            DateTime enddate = new DateTime();
            startdate = dateTimePickerStartDate.Value;
            enddate = dateTimePickerEndDate.Value;
            if (radioButtonYes.Checked)
            {
                if (radioButtonMaleList.Checked)
                {
                    query = "SELECT * FROM StudentInfo WHERE gender = 'male' AND bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }
                else if (radioButtonFemaleList.Checked)
                {
                    query = "SELECT * FROM StudentInfo WHERE gender = 'female' AND bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }
                else
                {
                    query = "SELECT * FROM StudentInfo WHERE bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }

                command = new SqlCommand(query, mydb.GetConnection);
                fillGrid(command);
            }
            else
            {
                if (radioButtonMaleList.Checked)
                {
                    getMaleData();
                }
                else if (radioButtonFemaleList.Checked)
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
            dataGridViewStudentList.ReadOnly = true;
            dataGridViewStudentList.DataSource = student.getStudent(command);
            dataGridViewStudentList.AllowUserToAddRows = false;
        }

        private void dataGridViewStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } 
}

//thong tin data grid view bi lo 
//gio sinh bo di
//edit remove them vao main menu