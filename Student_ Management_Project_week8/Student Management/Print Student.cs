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
            dataGridViewPrintView.AllowUserToAddRows = false;
            
            dataGridViewPrintView.DataSource = student.getStudent(command);
            /*
            DataGridViewImageColumn pictureColumn = new DataGridViewImageColumn();
            dataGridViewPrintView.RowTemplate.Height = 80;
            pictureColumn = (DataGridViewImageColumn)dataGridViewPrintView.Columns[7];
            pictureColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            */
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

            DataGridViewImageColumn pictureColumn = new DataGridViewImageColumn();            
            pictureColumn = (DataGridViewImageColumn)dataGridViewPrintView.Columns[7];
            pictureColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //you are here
        }


        private void CreateDocument(DataGridView dataGridView)
        {
            int NoStudent = dataGridView.Rows.Count + 1;

            try
            {
                Microsoft.Office.Interop.Word.Application WindowWord = new Microsoft.Office.Interop.Word.Application();

                //Create missing variable ofr missing value
                object missingVar = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = WindowWord.Documents.Add(ref missingVar, ref missingVar, ref missingVar, ref missingVar);
                document.Application.Visible = true;
                document.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                //Add header to the doc
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 50;
                    headerRange.Text = "Student List";
                }

                //add footer to the doc
                foreach (Microsoft.Office.Interop.Word.Section WordSection in document.Sections)
                {
                    //get footer range and ajust detail
                    Microsoft.Office.Interop.Word.Range FootRange = WordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    FootRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    FootRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    FootRange.Font.Size = 20;
                    FootRange.Text = "ĐẠI HỌC SƯ PHẠM KỸ THUẬT";

                }

                //Add paragraph with Heading 1 Sytle
                Microsoft.Office.Interop.Word.Paragraph paragraph1 = document.Content.Paragraphs.Add(ref missingVar);
                object styleHeading1 = "Heading 1";
                paragraph1.Range.set_Style(ref styleHeading1);
                paragraph1.Range.Text = "FACULTY: HIGH QUALITY";
                paragraph1.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missingVar);
                object styleHeading2 = "Heading 2";
                para1.Range.set_Style(ref styleHeading2);
                para1.Range.Text = "CLASS: OOPPR230279E_03CLC";
                para1.Range.InsertParagraphAfter();

                Table studentTable = document.Tables.Add(paragraph1.Range, NoStudent, 8, ref missingVar, ref missingVar);
                studentTable.Borders.Enable = 1;

                foreach (Row row in studentTable.Rows)
                {
                    //
                    foreach (Cell cell in row.Cells)
                    {
                        //Header row  
                        if (cell.RowIndex == 1)
                        {
                            int index = cell.ColumnIndex;
                            switch (index)
                            {
                                case 1:
                                    cell.Range.Text = "ID";
                                    break;
                                case 2:
                                    cell.Range.Text = "First Name";
                                    break;
                                case 3:
                                    cell.Range.Text = "Last Name";
                                    break;
                                case 4:
                                    cell.Range.Text = "Birthdate";
                                    break;
                                case 5:
                                    cell.Range.Text = "Gender";
                                    break;
                                case 6:
                                    cell.Range.Text = "Phone";
                                    break;
                                case 7:
                                    cell.Range.Text = "Address";
                                    break;
                                case 8:
                                    cell.Range.Text = "Picture";
                                    break;
                            }
                            //cell.Range.Text = ((dataIndex) index).ToString();
                            cell.Range.Font.Bold = 1;
                            //other format properties goes here  
                            cell.Range.Font.Name = "verdana";
                            cell.Range.Font.Size = 8;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells  
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                            //[update]20/4 (1)
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failtal Error: " + ex.Message);
            }
        }
    }
}
