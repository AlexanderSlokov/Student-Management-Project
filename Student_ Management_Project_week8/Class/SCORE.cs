using Student_Management_Project_week8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Management_Project_week8.Class
{
     class SCORE
    {
        COURSES courses = new COURSES();
        MY_DB mydb = new MY_DB();
        public bool insertScore(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO score (student_id, course_id, student_score, description)" +
                "VALUES (@sid, @cid, @scr, @descr)", mydb.GetConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("descr", SqlDbType.VarChar).Value = description;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
            //
        }
        public bool studentScoreExist(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE student_id = @sid AND course_id = @cid", mydb.GetConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
            //
        }
        public DataTable getAverageScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;

            command.CommandText = "SELECT course.label, AVG(score.student_score) As AverageGrade FROM course, score WHERE course.id = score.course_id GROUP BY course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
            //
        }
        public DataTable getCourseScores(int courseID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;

            command.CommandText = "SELECT score.student_id, StudentInfo.fname, StudentInfo.lname, score.course_id, course.label, score.student_score FROM StudentInfo INNER JOIN score ON StudentInfo.ID = score.student_id INNER JOIN course ON score.course_id = course.id WHERE score.course_id = @cid";
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
            //
        }
        //get scores by ID
        public DataTable getStudentScores(int studentID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.GetConnection;

            command.CommandText = "SELECT score.student_id, StudentInfo.fname, StudentInfo.lname, score.course_id, course.label, score.student_score FROM StudentInfo INNER JOIN score ON StudentInfo.ID = score.student_id INNER JOIN course ON score.course_id = course.id WHERE score.student_id = @sid";
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
            //
        }
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE student_id = @sid AND course_id = @cid", mydb.GetConnection);

            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Fields: score.student_id, std.fname, std.lname, score.course_id, course.label, score.student_score
        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand("SELECT score.student_id, StudentInfo.fname, StudentInfo.lname, score.course_id, course.label, score.student_score FROM StudentInfo INNER JOIN score ON StudentInfo.ID = score.student_id INNER JOIN course ON score.course_id = course.id", mydb.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        // Fields: score.student_id, std.fname, std.lname,
        public DataTable getAllStudentScore()
        {
            SqlCommand command = new SqlCommand("SELECT StudentInfo.id, StudentInfo.fname, StudentInfo.lname FROM course INNER JOIN ", mydb.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            int v = adapter.Fill(table);

            return table;
        }

        public DataTable getAllCourseScoreAndResult()
        {
            SqlCommand command = new SqlCommand("SELECT ID , fname , lname  FROM StudentInfo", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataTable tableCourse = new DataTable();
            tableCourse = courses.getAllCourses();

            //lấy khóa học theo chiều ngang
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                DataColumn CourseNamecolumn = new DataColumn();
                CourseNamecolumn.ColumnName = tableCourse.Rows[i]["label"].ToString();
                table.Columns.Add(CourseNamecolumn);
            }
            //lấy điểm của từng khóa học dựa theo id của học sinh
            DataTable tableScore = new DataTable();
            tableScore = this.getStudentScore();

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
                if (avg > 6.5 && avg <= 7.9) table.Rows[i]["Result"] = "Good";
                if (avg >= 8) table.Rows[i]["Result"] = "Excellent";
                if (count == 0) table.Rows[i]["Result"] = "Drop Out Of University!";
                if (avg.ToString() == "NaN") table.Rows[i]["AVG_Score"] = 0;
            }

            return table;
        }
    }
}

