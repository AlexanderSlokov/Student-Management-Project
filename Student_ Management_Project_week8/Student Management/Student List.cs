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
using Student_Management_Project_week8.Class;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
        ExcelDb excelDb = new ExcelDb();
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
                dataGridViewStudentList.AllowUserToAddRows = false; 
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


        private void ButtonToPdfFileList_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentList.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Student List Output.pdf"; bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridViewStudentList.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dataGridViewStudentList.Rows)
                            {
                               
                                string id = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(id);
                                string Fname = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(Fname);
                                string Lname = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(Lname);
                                string Bdate = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(Bdate);
                                string gender = row.Cells[4].Value.ToString();
                                pdfTable.AddCell(gender);
                                string phone = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(phone);
                                string address = row.Cells[6].Value.ToString();
                                pdfTable.AddCell(address);
                                byte[] imageByte = (byte[])row.Cells[7].Value;
                                iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                pdfTable.AddCell(Image);
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream); pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
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