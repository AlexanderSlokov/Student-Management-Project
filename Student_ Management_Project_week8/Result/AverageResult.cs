using Student_Management_Project_week8.Class;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Font = Xceed.Document.NET.Font;
using Formatting = Xceed.Document.NET.Formatting;
using System.Diagnostics;
using Paragraph = Xceed.Document.NET.Paragraph;
using System.Data.SqlClient;

namespace Student_Management_Project_week8.Result
{
    public partial class AverageResult : Form
    {
        public AverageResult()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        COURSES course = new COURSES();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();

       
       

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT ID, lname, fname FROM StudentInfo WHERE CONCAT(fname, ID) LIKE '%" + textBoxSearch.Text + "%' ", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataTable tableCourse = new DataTable();
            tableCourse = course.getAllCourses();

            //lấy khóa học theo chiều ngang
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                DataColumn CourseNamecolumn = new DataColumn();
                CourseNamecolumn.ColumnName = tableCourse.Rows[i]["label"].ToString();
                table.Columns.Add(CourseNamecolumn);
            }
            //lấy điểm của từng khóa học dựa theo id của học sinh
            DataTable tableScore = new DataTable();
            tableScore = score.getStudentScore();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int c = 0; c < tableScore.Rows.Count; c++)
                {
                    if (table.Rows[i]["id"].ToString() == tableScore.Rows[c]["student_id"].ToString())
                    {
                        for (int k = 3; k < table.Columns.Count; k++)
                        {
                            if (table.Columns[k].ColumnName == tableScore.Rows[c]["label"].ToString())
                            {
                                //string coursename = table.Columns[k].ColumnName;
                                //table.Rows[i][coursename] = tableScore.Rows[c]["student_score"].ToString();
                                table.Rows[i][k] = tableScore.Rows[c]["student_score"].ToString();
                                break;
                            }
                        }
                    }
                }
            }

            table.Columns.Add("AVG_Score", typeof(float));
            table.Columns.Add("Result", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int count = 0;
                float sum = 0;
                for (int j = 3; j < table.Columns.Count - 2; j++)
                {
                    float temp;
                    string coursename = table.Columns[j].ColumnName;
                    if (float.TryParse(table.Rows[i][coursename].ToString(), out temp))
                    {
                        sum += temp;
                        count++;
                    }
                }

                float avg = sum / count;
                Math.Round(avg, 2);
                table.Rows[i]["AVG_Score"] = Math.Round(avg, 2);

                if (avg < 5) table.Rows[i]["Result"] = "Fail";
                if (avg >= 5 && avg <= 6.5) table.Rows[i]["Result"] = "Average";
                if (avg > 6.5 && avg <= 7.9) table.Rows[i]["Result"] = "Goods";
                if (avg >= 8) table.Rows[i]["Result"] = "Excellent";
                if (count == 0) table.Rows[i]["Result"] = "Drop Out Of University!";
                if (avg.ToString() == "NaN") table.Rows[i]["AVG_Score"] = 0;
            }
            dataGridViewResult.DataSource = table;
        }

        private void bt_Print_Click(object sender, EventArgs e)
        {
            #region one
            string fileName = "Export_Student_Result.docx";
            var doc = DocX.Create(fileName);
            #endregion

            #region two
            string title = "REPORT RESULT";

            Formatting titleFormat = new Formatting();
            titleFormat.FontFamily = new Font("Tahoma");
            titleFormat.Size = 20D;
            titleFormat.Position = 40;
            titleFormat.FontColor = Color.BlueViolet;
            titleFormat.UnderlineColor = Color.Gray;
            titleFormat.Italic = true;

            //Formatting Text Paragraph  
            Formatting textParagraphFormat = new Formatting();
            //font family  
            textParagraphFormat.FontFamily = new Font("Tahoma");
            //font size  
            textParagraphFormat.Size = 12D;
            //Spaces between characters  
            textParagraphFormat.Spacing = 1;
            //Insert title  
            Paragraph paragraphTitle = doc.InsertParagraph(title, false, titleFormat);
            paragraphTitle.Alignment = Alignment.center;
            //Insert text  
            //doc.InsertParagraph(textParagraph, false, textParagraphFormat);
            #endregion            
            dataGridViewResult.AllowUserToAddRows = false;
            int temp = dataGridViewResult.RowCount;
            #region four
            doc.InsertParagraph();
            //Create Table
            //var listPlayer = CreateInitData();
            int tempq = dataGridViewResult.ColumnCount;
            Table t = doc.AddTable(temp + 2, tempq);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.ColorfulList;
            // Fill cells by adding text.  
            // First row
            t.Rows[0].Cells[0].Paragraphs.First().Append("ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("First Name");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Last Name");
            temp = dataGridViewResult.RowCount;

            DataTable tableCourse = new DataTable();
            tableCourse = course.getAllCourses();
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                t.Rows[0].Cells[i + 3].Paragraphs.First().Append(tableCourse.Rows[i]["label"].ToString());
            }

            //for (int i = 3; i < tempq - 2; i++)
            //{
            //    t.Rows[0].Cells[i].Paragraphs.First().Append(dataGridView1.Rows[0].Cells[i].Value.ToString());
            //    //dem2++;
            //}

            t.Rows[0].Cells[tempq - 2].Paragraphs.First().Append("Average Course");
            t.Rows[0].Cells[tempq - 1].Paragraphs.First().Append("Result");
            int k = 0;

            for (int i = 1; i <= temp; i++)
            {
                for (int kt = 0; kt < tempq; kt++)
                {
                    t.Rows[i].Cells[kt].Paragraphs.First().Append(dataGridViewResult.Rows[k].Cells[kt].Value.ToString());
                }
                k++;
            }
            doc.InsertTable(t);
            #endregion
           
            doc.Save();
            Process.Start("WINWORD.EXE", fileName);
           
            Console.Read();
        }

        private void AverageResult_Load(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = score.getAllCourseScoreAndResult();
            dataGridViewResult.AutoSize = true;
            dataGridViewResult.AllowUserToAddRows = false;   
            dataGridViewResult.Columns[0].HeaderText = "Student ID";
            dataGridViewResult.Columns[1].HeaderText = "First Name";
            dataGridViewResult.Columns[2].HeaderText = "Last Name";
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_Id.Text = dataGridViewResult.CurrentRow.Cells[0].Value.ToString();
            textBoxLName.Text = dataGridViewResult.CurrentRow.Cells[1].Value.ToString();
            txtb_LName.Text = dataGridViewResult.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
