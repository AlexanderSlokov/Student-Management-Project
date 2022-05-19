using Student_Management_Project_week8.Class;
using Microsoft.Office.Interop.Word;
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

namespace Student_Management_Project_week8.Score
{
    public partial class Print_Score_Form : Form
    {
        public Print_Score_Form()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        COURSES course = new COURSES();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        private void buttonSaveToTextFile_Click(object sender, EventArgs e)
        {
            CreateDocument(this.dataGridViewScores);
        }

        private void formPrintScore_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Id, fname, lname, bdate, gender, phone, address FROM std");
            dataGridViewStudentList.DataSource = student.getStudent(command);
            dataGridViewStudentList.Columns[0].Width = 50;
            dataGridViewStudentList.Columns[0].HeaderText = "Student ID";
            dataGridViewStudentList.Columns[1].Width = 70;
            dataGridViewStudentList.Columns[1].HeaderText = "First Name";
            dataGridViewStudentList.Columns[2].Width = 70;
            dataGridViewStudentList.Columns[2].HeaderText = "Last Name";
            dataGridViewStudentList.Columns[3].Width = 100;
            dataGridViewStudentList.Columns[3].HeaderText = "Birthdate";
            dataGridViewStudentList.Columns[4].Width = 50;
            dataGridViewStudentList.Columns[4].HeaderText = "Gender";
            dataGridViewStudentList.Columns[5].Width = 100;
            dataGridViewStudentList.Columns[5].HeaderText = "Phone";
            dataGridViewStudentList.Columns[6].Width = 120;
            dataGridViewStudentList.Columns[6].HeaderText = "Address";
            this.dataGridViewStudentList.Sort(this.dataGridViewStudentList.Columns[0], ListSortDirection.Ascending);
            //
            dataGridViewScores.DataSource = score.getStudentScore();
            dataGridViewScores.Columns[0].Width = 50;
            dataGridViewScores.Columns[0].HeaderText = "Student ID";
            dataGridViewScores.Columns[1].Width = 120;
            dataGridViewScores.Columns[1].HeaderText = "First Name";
            dataGridViewScores.Columns[2].Width = 120;
            dataGridViewScores.Columns[2].HeaderText = "Last Name";
            dataGridViewScores.Columns[3].Width = 50;
            dataGridViewScores.Columns[3].HeaderText = "Course ID";
            dataGridViewScores.Columns[4].Width = 120;
            dataGridViewScores.Columns[4].HeaderText = "Course Name";
            dataGridViewScores.Columns[5].Width = 100;
            dataGridViewScores.Columns[5].HeaderText = "Student Score";
            this.dataGridViewScores.Sort(this.dataGridViewScores.Columns[0], ListSortDirection.Ascending);

            //
            listBoxCoursesList.DataSource = course.getAllCourses();
            listBoxCoursesList.DisplayMember = "label";
            listBoxCoursesList.ValueMember = "id";
        }

        private void listBoxCoursesList_Click(object sender, EventArgs e)
        {
            dataGridViewScores.DataSource = score.getCourseScores(int.Parse(listBoxCoursesList.SelectedValue.ToString()));
            this.dataGridViewScores.Sort(this.dataGridViewScores.Columns[0], ListSortDirection.Ascending);
            this.dataGridViewStudentList.Sort(this.dataGridViewStudentList.Columns[0], ListSortDirection.Ascending);

        }

        private void dataGridViewStudentList_Click(object sender, EventArgs e)
        {
            dataGridViewScores.DataSource = score.getStudentScores(int.Parse(dataGridViewStudentList.CurrentRow.Cells[0].Value.ToString()));
            this.dataGridViewScores.Sort(this.dataGridViewScores.Columns[0], ListSortDirection.Ascending);
            this.dataGridViewStudentList.Sort(this.dataGridViewStudentList.Columns[0], ListSortDirection.Ascending);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewScores.DataSource = score.getStudentScore();
            this.dataGridViewStudentList.Sort(this.dataGridViewStudentList.Columns[0], ListSortDirection.Ascending);
            this.dataGridViewScores.Sort(this.dataGridViewScores.Columns[0], ListSortDirection.Ascending);

        }
        private void CreateDocument(DataGridView dataGridView)
        {
            int noScores = dataGridView.RowCount + 1;
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
                    headerRange.Font.Size = 30;
                    headerRange.Text = "Student Scores";
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
                /*
                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "CLASS: 191100CLC01";
                para2.Range.InsertParagraphAfter();
                */
                Table coursesTable = document.Tables.Add(para1.Range, noScores, 6, ref missing, ref missing);
                coursesTable.Borders.Enable = 1;
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
                foreach (Row row in coursesTable.Rows)
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
                                    cell.Range.Text = "Student ID";
                                    break;
                                case 2:
                                    cell.Range.Text = "First Name";
                                    break;
                                case 3:
                                    cell.Range.Text = "Last Name";
                                    break;
                                case 4:
                                    cell.Range.Text = "Course ID";
                                    break;
                                case 5:
                                    cell.Range.Text = "Course Name";
                                    break;
                                case 6:
                                    cell.Range.Text = "Student Score";
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
                            }
                        }
                    }
                    //
                }
                //Save the document  
                object filename = @"E:\\Score List.docx";
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
    }
}

