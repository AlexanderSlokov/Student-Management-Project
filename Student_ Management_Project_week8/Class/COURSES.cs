using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Student_Management_Project_week8
{
    class COURSES
    { 
        MY_DB mydb = new MY_DB();

        public bool checkCourseName(string courseName, int courseId = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE label = @cName And ID <> @cID", mydb.GetConnection);

            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            // neu ton tai
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            // nguoc lai
            else
            {
                mydb.closeConnection();

                return true;
            }
        }

        public bool insertCourse(int id, string label, int period, string description, int semester)
        {
            //
            SqlCommand command = new SqlCommand("INSERT INTO course(id, label, period, description, semester)"
                + "VALUES(@id, @label, @period, @desc, @semes)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@desc", SqlDbType.Text).Value = description;
            command.Parameters.Add("@semes", SqlDbType.Int).Value = semester;
            mydb.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    mydb.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập ID tìm kiếm" + ex);
                return false;
            }
            //
        }

        public bool checkCourseID(int ID)
        {
            //
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE id = @cID", mydb.GetConnection);

            command.Parameters.Add("@cID", SqlDbType.Int).Value = ID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            // neu ton tai
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            // nguoc lai
            else
            {
                return true;
            }
            //
        }
        public DataTable getAllCourses()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course", mydb.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseByID(int ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE id = @cID", mydb.GetConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = ID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public bool updateCourse(int ID, string courseName, int period, string description, int semester)
        {
            SqlCommand command = new SqlCommand("UPDATE course"
            + " SET label = @cName, period = @period, description = @desc, semester = @sem WHERE id = @cID", mydb.GetConnection);

            command.Parameters.Add("@cID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("@sem", SqlDbType.Int).Value = semester;

            mydb.openConnection();
            try
            {
                // update thanh cong
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.closeConnection();
                    return true;
                }
                // nguoc lai
                else
                {
                    mydb.closeConnection();
                    return false;
                }
            }
            catch
            {
                mydb.closeConnection();
                return false;
            }
            //
        }
        public bool deleteCourse(int ID)
        {
            //
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE id= @cID", mydb.GetConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = ID;

            mydb.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    // Delete thanh cong
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    // nguoc lai
                    mydb.closeConnection();
                    return false;
                }
            }
            catch
            {
                mydb.closeConnection();
                return false;
            }
            //
        }
        public int countAllCourses()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM course", mydb.GetConnection);
            int stdnum = Convert.ToInt32(sqlCommand.ExecuteScalar());

            mydb.closeConnection();
            return stdnum;
        }
    }
}

