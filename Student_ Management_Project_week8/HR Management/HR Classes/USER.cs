using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_Project_week8.HR_Management
{
    public class USER
    {
        MY_DB db = new MY_DB();
        public bool GetUserInformation(int userid, ref string fname, ref string lname, ref string username, ref string password, PictureBox picture)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM hmrsrc WHERE id = @uid", db.GetConnection);

                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                db.openConnection();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    fname = reader["fname"].ToString();
                    lname = reader["lname"].ToString();
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                    MemoryStream stream = new MemoryStream((byte[])reader["picture"]);
                    Image RetImage = Image.FromStream(stream);
                    picture.Image = RetImage;
                }
                reader.Close();
                db.closeConnection();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public DataTable GetUserByID(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM hmrsrc WHERE id = @uid", db.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            return table;
        }
        public int GetID(string username, string password)
        {
            SqlCommand command = new SqlCommand("SELECT id FROM hmrsrc WHERE username = @uname AND password = @password", db.GetConnection);

            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            db.openConnection();
            int id = Convert.ToInt32(command.ExecuteScalar());
            db.closeConnection();
            return id;
        }
        //function to insert a new user
        public bool InsertUser(int uid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO hmrsrc(id, fname, lname, username, password, picture) VALUES (@id, @fn, @ln, @un, @pass, @pic", db.GetConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = uid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }
        public bool UsernameExist(string username, string operation, int userid = 0)
        {
            string query = "";

            if (operation == "register")
            {
                query = "SELECT * FROM hmrsrc WHERE username = @un";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM hmrsrc WHERE username = @un AND id <> @id";
            }

            SqlCommand command = new SqlCommand(query, db.GetConnection);

            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE hmrsrc"
            + "SET fname = @fn, lname = @ln, username = @un, password = @pass, picture = @pic"
            + "WHERE id = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool IDExist(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hmrsrc WHERE id = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            db.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}

