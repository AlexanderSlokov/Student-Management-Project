using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

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

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            DateTime startdate = new DateTime();
            DateTime enddate = new DateTime();
            startdate = dateTimePickerStartDate.Value;
            enddate = dateTimePickerEndDate.Value;
            if (radioButtonYes.Checked)
            {
                if (radioButtonMale.Checked)
                {
                    query = "SELECT * FROM StudentInfo WHERE gender = 'Male' AND bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }
                else if (radioButtonFemale.Checked)
                {
                    query = "SELECT * FROM StudentInfo WHERE gender = 'Female' AND bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
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
                if (radioButtonMale.Checked)
                {
                    getMaleData();
                }
                else if (radioButtonFemale.Checked)
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
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewStudentList.RowTemplate.Height = 80;
            dataGridViewStudentList.DataSource = student.getStudent(command);

            picCol = (DataGridViewImageColumn)dataGridViewStudentList.Columns[7];

            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewStudentList.AllowUserToAddRows = false;
        }

        private void getMaleData()
        {
            MY_DB mydb = new MY_DB();
            mydb.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo WHERE gender= 'Male'", mydb.GetConnection);
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
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM StudentInfo WHERE gender= 'Female'", mydb.GetConnection);
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
            catch
            {

            }
        }

        private void Print_Student_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = new DateTime(1995, 01, 01);
            getAllData();
        }

        private void CreateDocument(DataGridView dataGridView)
        {
            int noStudent = dataGridView.RowCount + 1;
            try
            {
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  
                //winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                //winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                document.Application.Visible = true;

                document.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //Add header into the document  
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.  
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 50;
                    headerRange.Text = "Student List";
                }

                //Add the footers into the document  
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.  
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "ĐẠI HỌC SƯ PHẠM KỸ THUẬT";
                }

                //adding text to document 
                /*
                document.Content.SetRange(0, 0);
                document.Content.Text = "CLASS: 191100CLC01 " + Environment.NewLine;
                */

                //Add paragraph with Heading 1 style  
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "FACULTY: HIGH QUALITY";
                para1.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style  
                //Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading2 = "Heading 2";
                //para2.Range.set_Style(ref styleHeading2);
                //para2.Range.Text = "CLASS: 191100CLC01";
                //para2.Range.InsertParagraphAfter();

                Table studentTable = document.Tables.Add(para1.Range, noStudent, 8, ref missing, ref missing);
                studentTable.Borders.Enable = 1;
                //Create a iXj table and insert some dummy record  
                /*
                studentTable.Cell(1, 1).Range.Text = "ID";
                studentTable.Cell(2, 1).Range.Text = "First Name";
                studentTable.Cell(3, 1).Range.Text = "Last Name";
                studentTable.Cell(4, 1).Range.Text = "Birthdate";
                studentTable.Cell(5, 1).Range.Text = "Gender";
                studentTable.Cell(6, 1).Range.Text = "Phone";
                studentTable.Cell(7, 1).Range.Text = "Address";
                studentTable.Cell(8, 1).Range.Text = "Picture";
                */
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

                        }
                        //Data row  
                        else
                        {
                            int index = cell.ColumnIndex;
                            switch (index)
                            {

                                case 1:
                                    //cell.Range.Text = reader["id"].ToString();
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 2:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 3:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 4:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 5:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 6:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 7:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 8:
                                    byte[] imgbyte = (byte[])dataGridView[index - 1, cell.RowIndex - 2].Value;
                                    MemoryStream ms = new MemoryStream(imgbyte);
                                    //Image sparePicture = Image.FromStream(ms);
                                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(100, 100)));
                                    Clipboard.SetDataObject(finalPic);
                                    //document = document.Content.Paragraphs.Add();
                                    //document = document.Content.Paragraphs.Add(ref missing);
                                    cell.Range.Paste();
                                    cell.Range.InsertParagraphAfter();
                                    break;
                            }
                        }
                    }
                    //
                }
                //Save the document  
                object filename = @"E:\\student.docx";
                //document.SaveAs2(ref filename);
                //document.Close(ref missing, ref missing, ref missing);
                //document = null;
                //winword.Quit(ref missing, ref missing, ref missing);
                //winword = null;
                MessageBox.Show("Document created successfully !");
                mydb.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveToTextFile_Click(object sender, EventArgs e)
        {
            CreateDocument(this.dataGridViewStudentList);
        }
    }
}
