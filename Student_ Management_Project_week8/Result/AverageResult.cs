using Student_Management_Project_week8.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        
        string firstname = string.Empty, lastname = string.Empty;
        int studentID = int.MinValue;


        public void FindPassAndFail(ref int numberOfPass, ref int numberOfFail)
        {
            string studentQuery = "SELECT ID, fname, lname FROM StudentInfo";
            SqlCommand command = new SqlCommand(studentQuery, mydb.GetConnection);

            // Add student query parameters
            if (firstname != string.Empty)
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = firstname;
            if (lastname != string.Empty)
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lastname;
            if (studentID != int.MinValue)
                command.Parameters.Add("@id", SqlDbType.Int).Value = studentID;
            DataTable table = student.getStudent(command);

            //add label
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT label FROM course", mydb.GetConnection);
            DataTable labelTable = new DataTable();
            adpt.Fill(labelTable);

            for (int i = 0; i < labelTable.Rows.Count; i++)
            {
                table.Columns.Add(labelTable.Rows[i][0].ToString(), typeof(int));
            }

            // add value to label header
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 3; j < table.Columns.Count; j++)
                {
                    command = new SqlCommand("SELECT score.student_score FROM StudentInfo, score, course WHERE course.label = @label AND course.id = score.course_id AND score.student_id = @sid", mydb.GetConnection);

                    command.Parameters.Add("@label", SqlDbType.VarChar).Value = table.Columns[j].ColumnName;
                    command.Parameters.Add("@sid", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[i][0]);

                    adpt = new SqlDataAdapter(command);
                    DataTable scoreTable = new DataTable();
                    adpt.Fill(scoreTable);

                    if (scoreTable.Rows.Count > 0)
                    {
                        table.Rows[i][table.Columns[j].ColumnName] = Convert.ToInt32(scoreTable.Rows[0][0]);
                    }
                }
            }
            // add result

            table.Columns.Add("Result", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int sum = 0;
                for (int j = 3; j < table.Columns.Count - 1; j++)
                {
                    if (!(table.Rows[i][j] is DBNull))
                        sum += Convert.ToInt32(table.Rows[i][j]);
                }

                float avg = (float)sum / (table.Columns.Count - 4);

                if (avg < 3)
                {
                    numberOfFail++;
                    table.Rows[i][table.Columns.Count - 1] = "Fail";
                }
                else
                {
                    if (avg >= 3 && avg < 6.5)
                    {

                        table.Rows[i][table.Columns.Count - 1] = "Average";
                    }
                    else if (avg >= 6.5 && avg < 8)
                    {
                        table.Rows[i][table.Columns.Count - 1] = "Good";
                    }
                    else
                    {
                        table.Rows[i][table.Columns.Count - 1] = "Excellent";
                    }
                    numberOfPass++;
                }
            }



           // int x = 2;
        }

        private void AverageResult_Load(object sender, EventArgs e)
        {
            string query = "SELECT ID, fname, lname FROM StudentInfo";
            FillGrid(query);
        }

        private string FindQuery()
        {
            string query = "SELECT ID, fname, lname FROM StudentInfo WHERE", AND = "AND";

            if (textBoxFirstName.Text != "")
            {
                firstname = textBoxFirstName.Text;
                query += " fname = @fn ";

            }
            if (textBoxLastName.Text != "")
            {
                if (textBoxFirstName.Text != "")
                {
                    query += AND;
                    lastname = textBoxLastName.Text;
                    query += " lname = @ln ";
                }
                else
                {
                    lastname = textBoxLastName.Text;
                    query += " lname = @ln ";
                }
            }
            if (textBoxStudentID.Text != "")
            {
                if (textBoxFirstName.Text != "" || textBoxLastName.Text != "")
                {
                    query += AND;
                    query += " id = @id ";
                }
                else
                {
                    query += " id = @id ";
                }
                Int32.TryParse(textBoxStudentID.Text, out studentID);
            }
            if (query == "SELECT ID, fname, lname FROM StudentInfo WHERE")
            {
                return query = "SELECT ID, fname, lname FROM StudentInfo";
            }
            else
                return query;
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            string query = "SELECT ID, fname, lname FROM StudentInfo";
            FillGrid(query);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = FindQuery();
            FillGrid(query);
        }

        private void FillGrid(string studentQuery)
        {

            SqlCommand command = new SqlCommand(studentQuery, mydb.GetConnection);

            // Add student query parameters
            if (firstname != string.Empty)
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = firstname;
            if (lastname != string.Empty)
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lastname;
            if (studentID != int.MinValue)
                command.Parameters.Add("@id", SqlDbType.Int).Value = studentID;
            DataTable table = student.getStudent(command);

            //add label
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT label FROM course", mydb.GetConnection);
            DataTable labelTable = new DataTable();
            adpt.Fill(labelTable);

            for (int i = 0; i < labelTable.Rows.Count; i++)
            {
                table.Columns.Add(labelTable.Rows[i][0].ToString(), typeof(int));
            }

            // add value to label header
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 3; j < table.Columns.Count; j++)
                {
                    command = new SqlCommand("SELECT score.student_score FROM StudentInfo, score, course WHERE course.label = @label AND course.id = score.course_id AND score.student_id = @sid", mydb.GetConnection);

                    command.Parameters.Add("@label", SqlDbType.VarChar).Value = table.Columns[j].ColumnName;
                    command.Parameters.Add("@sid", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[i][0]);

                    adpt = new SqlDataAdapter(command);
                    DataTable scoreTable = new DataTable();
                    adpt.Fill(scoreTable);

                    if (scoreTable.Rows.Count > 0)
                    {
                        table.Rows[i][table.Columns[j].ColumnName] = Convert.ToInt32(scoreTable.Rows[0][0]);
                    }
                }
            }
            // add result

            table.Columns.Add("Result", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int sum = 0;
                for (int j = 3; j < table.Columns.Count - 1; j++)
                {
                    if (!(table.Rows[i][j] is DBNull))
                        sum += Convert.ToInt32(table.Rows[i][j]);
                }

                float avg = (float)sum / (table.Columns.Count - 4);

                if (avg < 3)
                {
                    table.Rows[i][table.Columns.Count - 1] = "Fail";
                }
                else if (avg >= 3 && avg < 6.5)
                {
                    table.Rows[i][table.Columns.Count - 1] = "Average";
                }
                else if (avg >= 6.5 && avg < 8)
                {
                    table.Rows[i][table.Columns.Count - 1] = "Good";
                }
                else
                {
                    table.Rows[i][table.Columns.Count - 1] = "Excellent";
                }
            }

            dataGridViewResult.DataSource = table;
            dataGridViewResult.Columns["ID"].HeaderText = "Student ID";
            dataGridViewResult.Columns["fname"].HeaderText = "First Name";
            dataGridViewResult.Columns["lname"].HeaderText = "Last Name";
            dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
