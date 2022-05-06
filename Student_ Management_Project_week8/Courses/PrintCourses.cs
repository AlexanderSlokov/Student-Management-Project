using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Student_Management_Project_week8;

namespace Student_Management_Project_week8.Courses
{
    public partial class PrintCourses : Form
    {
        public PrintCourses()
        {
            InitializeComponent();
        }
        COURSES course = new COURSES();
        MY_DB mydb = new MY_DB();
        private void buttonToPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDlog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Printed Document";
            printDlog.Document = printDoc;
            printDlog.AllowSelection = true;
            printDlog.AllowSomePages = true;

            if (printDlog.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void PrintCourses_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCourses.AllowUserToAddRows = false;
                mydb.openConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM course", mydb.GetConnection);
                DataSet dataSet = new DataSet();

                System.Data.DataTable dataTable = new System.Data.DataTable();
                sqlDataAdapter.Fill(dataSet, "course");

                dataTable = dataSet.Tables["course"];
                dataGridViewCourses.DataSource = dataTable;
                mydb.closeConnection();
            }
            catch
            {

            }
        }

        private void CreateDocument(DataGridView dataGridView)
        {
            int noCourses = dataGridView.RowCount + 1;
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
                    headerRange.Text = "All Courses";
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
                Table coursesTable = document.Tables.Add(para1.Range, noCourses, 5, ref missing, ref missing);
                coursesTable.Borders.Enable = 1;

                foreach (Row row in coursesTable.Rows)
                {
                    //
                    foreach (Cell cell in row.Cells)
                    {
                        //Header row  
                        if (cell.RowIndex == 1 )
                        {
                            int index = cell.ColumnIndex;
                            switch (index)
                            {
                                case 1:
                                    cell.Range.Text = "ID";
                                    break;
                                case 2:
                                    cell.Range.Text = "Course Name";
                                    break;
                                case 3:
                                    cell.Range.Text = "Period";
                                    break;
                                case 4:
                                    cell.Range.Text = "Description";
                                    break;
                                case 5:
                                    cell.Range.Text = "Semester";
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
                            }
                        }
                    }
                    //
                }
                //Save the document  
                //object filename = @"E:\\Courses List.docx";
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

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Word 2007 or Higher {.docx} | *.docx";
            if (sf.ShowDialog() == DialogResult.OK)
            {
               
            }

        }
        private void buttonToText_Click(object sender, EventArgs e)
        {
            CreateDocument(this.dataGridViewCourses);
        }
    }
    
}
