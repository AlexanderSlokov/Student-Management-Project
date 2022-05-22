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
using Word = Microsoft.Office.Interop.Word;

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

            
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (dataGridViewPrintView.Rows.Count != 0)
            {
                int RowCount = dataGridViewPrintView.Rows.Count;
                int ColumnCount = dataGridViewPrintView.Columns.Count;
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = " ";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + dataGridViewPrintView.Rows[r].Cells[c].Value + "\t";
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])dataGridViewPrintView.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                   Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    //oTemp += "\n";
                }
                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        private void buttonToTextFilePrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridViewPrintView, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
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
    }
}
