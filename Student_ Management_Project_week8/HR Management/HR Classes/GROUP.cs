using System.Data;
using System.Data.SqlClient;

namespace Student_Management_Project_week8.HR_Management
{
    public class GROUP
    {
        MY_DB myDB = new MY_DB();

        public bool InsertGroup (int id, string gname, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO mygroup (id, name, userid) VALUES (@id, @gn, @uid)", myDB.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int ).Value = id;
            command.Parameters.Add("@gn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            myDB.openConnection();

            if(command.ExecuteNonQuery()== 1)
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

        public bool UpdateID (int gid, string gname, int userID)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroup  SET id = @gid WHERE name = @gname AND uerid = @uid", myDB.GetConnection);
            command.Parameters.Add("@gid", SqlDbType.Int).Value = gid;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userID;

            myDB.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public bool UpdateName(int gid, string gname, int userID)
        {
            SqlCommand command = new SqlCommand("UPDATE mygroup SET name = @name WHERE id = @gid AND userid = @uid", myDB.GetConnection);

            command.Parameters.Add("@gid", SqlDbType.Int).Value = gid;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userID;

            myDB.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public bool DeleteGroup(int groupid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM mygroup WHERE id = @id", myDB.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
            myDB.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public DataTable GetGroupList(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT id[Group ID], name[Group Name] FROM mygroup WHERE userid = @uid", myDB.GetConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Connection = myDB.GetConnection;

            myDB.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }
        public DataTable GetGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM mygroup WHERE userid = @uid", myDB.GetConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Connection = myDB.GetConnection;

            myDB.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }

        public bool GroupExist(string name, int userid, int groupid, string operation)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            // TOn tai mot group
            if (operation == "add")
            {
                query = "SELECT * FROM mygroup WHERE id = @gid";
            }
            // Ton tai mot group nhung ten bi thay doi
            if (operation == "edit name")
            {
                query = "SELECT * FROM mygroup WHERE id = @gid AND name <> @name";

            }
            command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Connection = myDB.GetConnection;
            command.CommandText = query;

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
    }
}
