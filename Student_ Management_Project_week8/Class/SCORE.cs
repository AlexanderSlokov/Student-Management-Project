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

            command.CommandText = "SELECT course.Label, AVG(score.student_score) As AverageGrade FROM course, score WHERE course.ID = score.course_id GROUP BY course.label";
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

            command.CommandText = "SELECT score.student_id, std.fname, std.lname, score.course_id, course.label, score.student_score FROM std INNER JOIN score ON std.id = score.student_id INNER JOIN course ON score.course_id = course.id WHERE score.course_id = @cid";
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

            command.CommandText = "SELECT score.student_id, std.fname, std.lname, score.course_id, course.label, score.student_score FROM std INNER JOIN score ON std.id = score.student_id INNER JOIN course ON score.course_id = course.id WHERE score.student_id = @sid";
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
            SqlCommand command = new SqlCommand("SELECT score.student_id, std.fname, std.lname, score.course_id, course.label, score.student_score FROM std INNER JOIN score ON std.id = score.student_id INNER JOIN course ON score.course_id = course.id", mydb.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        // Fields: score.student_id, std.fname, std.lname,
        public DataTable getAllStudentScore()
        {
            SqlCommand command = new SqlCommand("SELECT std.id, std.fname, std.lname FROM course INNER JOIN ", mydb.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            int v = adapter.Fill(table);

            return table;
        }
     }
}

