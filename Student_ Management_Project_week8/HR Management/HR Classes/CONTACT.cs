using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Student_Management_Project_week8.HR_Management
{
    public class CONTACT
    {
        MY_DB myDB = new MY_DB();
        bool CheckCommand(SqlCommand command)
        {
            myDB.openConnection();
            bool result = (command.ExecuteNonQuery() == 1);
            myDB.closeConnection();
            return result;
        }

        // check ID exist in specifi User managemet
        public bool ChecKIdExist(int contactID, int userID)
        {
            string str_command = "SELECT * FROM mycontact WHERE id = @contactID AND userid = @uid";

            SqlCommand command = new SqlCommand(str_command, myDB.GetConnection);

            command.Parameters.Add("@contactID", SqlDbType.Int).Value = contactID;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

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

        public string FullContactList(bool check)
        {
            string command = "SELECT mycontact.id[ID], mycontact.fname[First Name], mycontact.lname[Last Name], mygroup.name[Group Name], mycontact.phone[Phone], mycontact.email[Mail], mycontact.address[Address], mycontact.picture[Picture] FROM mycontact INNER JOIN mygroup ON mygroup.id = mycontact.group_id WHERE  mycontact.userid = @userID";


            if (check == false)
            {
                command += " AND mycontact.group_id = @groupID";
            }
            return command;
        }


        public bool InsertContact(int id, string fname, string lname, string phone, string address,
           string email, int userid, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mycontact (id, fname, lname, group_id, phone, email, address, picture, userid) VALUES" +
                " ( @id, @fn, @ln, @grp, @phone, @mail, @adrs, @pic, @uid)", myDB.GetConnection);


            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            myDB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }

        }

        //check contact exist or not
        public bool ContactEmpty(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mycontact WHERE userid = @uid", myDB.GetConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UpdateContact(int contactid, string fname, string lname, string phone, string address,
            string email, int groupid, MemoryStream picture, int userid)
        {
            SqlCommand command = new SqlCommand("UPDATE mycontact SET fname = @fn, lname = @ln, group_id = @gid, phone = @phone,"
                + " email = @mail, address = @adrs, picture = @pic WHERE id = @id AND userid = @uid", myDB.GetConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            myDB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }

        }

        public bool DeleteContact(int contactid, int userID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mycontact WHERE id = @id AND userid = @uid", myDB.GetConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userID;
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactid;

            myDB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }

        }
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = myDB.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetAllContact(int userID)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, group_id, phone, email, " +
                "address, picture FROM mycontact WHERE userid = @uid", myDB.GetConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }
        public DataTable GetContactByID(int contactID, int userID)
        {
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, group_id, phone, email, " +
                "address, picture FROM mycontact WHERE id = @id AND userid = @uid", myDB.GetConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = contactID;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }
    }
}
