using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_Project_week8.HR_Management;
using Student_Management_Project_week8.HR_Management.Contact_Forms;
using Student_Management_Project_week8.Login_management;
using static Student_Management_Project_week8.Form1;

namespace Student_Management_Project_week8
{
    public partial class HumanResourceMain : Form
    {
        public HumanResourceMain()
        {
            InitializeComponent();
        }

        MY_DB myDB = new MY_DB();
        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();
        int groupID, initialGroupID;
        string groupName;


        private void HumanResourceMain_Load(object sender, EventArgs e)
        {
            GetImageAndUserName();
            FillGrid();
        }

        public void FillGrid()
        {
            dataGridViewGroupList.DataSource = group.GetGroupList(GLOBAL.CurrentUserID);
            dataGridViewGroupList.Sort(this.dataGridViewGroupList.Columns[0], ListSortDirection.Ascending);
        }


        public void OnUpdateMainForm(object source, EventArgs e)
        {
            GetImageAndUserName();
        }

        public void GetImageAndUserName()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM hmrsrc WHERE id = @uid", myDB.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.CurrentUserID;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxUser.Image = Image.FromStream(picture);
                pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
                labelUserName.Text = table.Rows[0]["fname"].ToString() + " " + table.Rows[0]["lname"].ToString();
            }
        }

        private void buttonContact_Edit_Click(object sender, EventArgs e)
        {
            Edit_Contact_Form editContact = new Edit_Contact_Form();
            editContact.Show(this);
        }

        private void buttonContact_SelectContact_Click(object sender, EventArgs e)
        {
            Select_Contact_Form SelectContactF = new Select_Contact_Form();

            if (contact.ContactEmpty(GLOBAL.CurrentUserID) == false)
            {
                SelectContactF.ShowDialog();
                int contactId = Convert.ToInt32(SelectContactF.dataGridViewContact.CurrentRow.Cells[0].Value.ToString());
                DataTable table = contact.GetContactByID(contactId, GLOBAL.CurrentUserID);
                textBoxContactID.Text = table.Rows[0]["id"].ToString();
            }
            else
            {
                MessageBox.Show("No data!");
            }
        }

        private void buttonContact_Remove_Click(object sender, EventArgs e)
        {
            if (textBoxContactID.Text != "")
            {
                int id;
                Int32.TryParse(textBoxContactID.Text, out id);
                if (contact.DeleteContact(id, GLOBAL.CurrentUserID))
                {
                    MessageBox.Show("Successfully Deleting Contact");
                }
                else
                {
                    MessageBox.Show("ID doesn't exist or deleted");
                }
            }
            else
            {
                MessageBox.Show("Enter an ID");
            }
        }

        private void buttonContact_ShowFullList_Click(object sender, EventArgs e)
        {
            Show_Contact_List_Form showFullList = new Show_Contact_List_Form();
            showFullList.Show(this);
        }

        private void buttonContact_Add_Click(object sender, EventArgs e)
        {
            Add_Contact_Form addContact = new Add_Contact_Form();
            addContact.Show(this);
        }

        private void buttonGroup_Add_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxEnter_GroupID.Text, out groupID);
            groupName = (textBoxEnter_GroupName.Text);
            if (groupID == 0)
            {
                MessageBox.Show("Please Enter A Valid Group ID!");
            }
            else if (groupName.Trim() == "")
            {
                MessageBox.Show("Please Enter A Group Name!");
            }
            else
            {
                if (group.GroupExist(groupName, GLOBAL.CurrentUserID, groupID, "add"))
                {
                    MessageBox.Show("Group Exists");
                }
                else
                {
                    group.InsertGroup(groupID, groupName, GLOBAL.CurrentUserID);

                    MessageBox.Show("New Group Added");
                    FillGrid();
                }
            }
        }

        private void buttonGroup_Edit_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxEnter_GroupID.Text, out groupID);
            groupName = (textBoxEnter_GroupName.Text);
            if (groupID == 0)
            {
                MessageBox.Show("Please Enter A Valid Group ID!");
            }
            else if (groupName.Trim() == "")
            {
                MessageBox.Show("Please Enter A Group Name!");
            }
            else
            {
                if (group.GroupExist(groupName, GLOBAL.CurrentUserID, groupID, "edit name"))
                {
                    group.UpdateName(groupID, groupName, GLOBAL.CurrentUserID);
                    FillGrid();
                }
                else if (!group.GroupExist(groupName, GLOBAL.CurrentUserID, groupID, "add"))
                {
                    group.InsertGroup(groupID, groupName, GLOBAL.CurrentUserID);
                    FillGrid();
                }

            }
        }

        private void labelEditInfo_Click(object sender, EventArgs e)
        {
            HRuserEditInfo editInfo = new HRuserEditInfo(); // publisher

            editInfo.UpdateMainFormEvent += this.OnUpdateMainForm;
            editInfo.Show(this);
        }

        private void labelEditInfo_MouseHover(object sender, EventArgs e)
        {
            labelEditInfo.ForeColor = Color.Red;
        }

        private void labelEditInfo_MouseLeave(object sender, EventArgs e)
        {
            labelEditInfo.ForeColor = Color.Fuchsia;
        }

        private void labelLogOut_MouseHover(object sender, EventArgs e)
        {
            labelLogOut.ForeColor = Color.Red;
        }

        private void labelLogOut_MouseLeave(object sender, EventArgs e)
        {
            labelLogOut.ForeColor = Color.Fuchsia;
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 loginform = new Form1();
            loginform.Show();
        }

        private void buttonGroup_Delete_Click(object sender, EventArgs e)
        {
            Int32.TryParse(textBoxEnter_GroupID.Text, out groupID);
            string groupname = (textBoxEnter_GroupName.Text);
            if (groupID == 0)
            {
                MessageBox.Show("Please Enter A Valid Group ID!");

            }
            else
            if (dataGridViewGroupList.Rows.Count > 0)
            {
                if (!group.GroupExist(groupname, GLOBAL.CurrentUserID, groupID, "add"))
                {
                    MessageBox.Show("Group Doesn't Exist!");
                }
                else
                {
                    group.DeleteGroup(groupID);
                    FillGrid();
                    MessageBox.Show("Group Deleted");
                }
            }
            else
            {
                MessageBox.Show("No Data!");
            }
        }

        private void dataGridViewGroupList_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewGroupList.Rows.Count > 0)
                {
                    textBoxEnter_GroupName.Text = dataGridViewGroupList[1, dataGridViewGroupList.CurrentCell.RowIndex].Value.ToString();
                    textBoxEnter_GroupID.Text = dataGridViewGroupList[0, dataGridViewGroupList.CurrentCell.RowIndex].Value.ToString();

                    Int32.TryParse(textBoxEnter_GroupID.Text, out initialGroupID);
                }
            }
            catch { }
        }





    }
}
