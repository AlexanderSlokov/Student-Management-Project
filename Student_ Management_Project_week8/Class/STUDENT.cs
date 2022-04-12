using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//SQL command classes based on this 
using System.IO;
using System.Drawing;
using System.Windows.Forms;


namespace Student_Management_Project_week8
{
     class STUDENT
    {
        MY_DB mydb = new MY_DB();

        public bool insertStudent (int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand( "INSERT INTO StudentInfo (ID, fname,lname,bdate, gender, phone, address, picture)" +
                " VALUES (@id, @fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mydb.GetConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

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


        //operator connect with sql database to update student 's profile
        public bool updateStudent(int ID, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE StudentInfo"
            + " SET ID = @id, fname = @fn, lname = @ln, bdate = @bdt, gender = @gdr, phone = @phn, address = @adrs, picture = @pic"
            + " WHERE ID = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
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

        //delete student base on SQL command
        public bool deleteStudent(int Id, string fname, string lname, DateTime bdate, string phone, string address, string gender)
        {
            SqlCommand command = new SqlCommand("DELETE FROM StudentInfo WHERE ID = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;

            mydb.openConnection();
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

        // get data table based on command
        public DataTable getStudent(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            mydb.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "StudentInfo");
            dataTable = dataSet.Tables["StudentInfo"];
            mydb.closeConnection();
            return dataTable;

        }

        // get specific data base on ID
        public bool getData(int Id, ref string fname, ref string lname, ref DateTime bdate, ref string gender, ref string phone,
            ref string address, PictureBox picture)
        {
            try
            {
                //use SQL command to get id 
                SqlCommand command = new SqlCommand("SELECT * FROM StudentInfo WHERE ID = @id", mydb.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                mydb.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                //read data on that id
                while (reader.Read())
                {
                    fname = reader["fname"].ToString();
                    lname = reader["lname"].ToString();
                    bdate = (DateTime)reader["bdate"];
                    gender = reader["gender"].ToString();
                    phone = reader["phone"].ToString();
                    address = reader["address"].ToString();
                    MemoryStream stream = new MemoryStream((byte[])reader["picture"]);
                    Image RetImage = Image.FromStream(stream);
                        
                    picture.Image = RetImage;
                }
                reader.Close();
                mydb.closeConnection();
                return true;
            }
            catch
            {
                return false;
            }


        }

        // if there is no student, return true, otherwise return false.
        public bool existID(int ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM StudentInfo WHERE ID = @id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            mydb.openConnection();
            if (command.ExecuteScalar() == null)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }

        public int studentNumber()
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM std", mydb.GetConnection);
            int stdnum = Convert.ToInt32(sqlCommand.ExecuteScalar());

            mydb.closeConnection();
            return stdnum;
        }

        public bool existUsername(string username)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoginUserInfo WHERE UserName = @username", mydb.GetConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            mydb.openConnection();

            // additional condition to check the valid username, password and system action
            if (command.ExecuteScalar() == null)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }

        }
    }
}
