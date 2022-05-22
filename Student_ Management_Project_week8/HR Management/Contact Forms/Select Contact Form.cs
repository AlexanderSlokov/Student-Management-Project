using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Student_Management_Project_week8.Form1;

namespace Student_Management_Project_week8.HR_Management.Contact_Forms
{
    public partial class Select_Contact_Form : Form
    {
        public Select_Contact_Form()
        {
            InitializeComponent();
        }

        private void Select_Contact_Form_Load(object sender, EventArgs e)
        {
            CONTACT contact = new CONTACT();
            //SqlCommand command = new SqlCommand("SELECT  id ,  fname  as'First Name',  lname  as 'Last Name',  group_id  as 'Group ID' FROM  mycontact  WHERE  userid = @uid");
            SqlCommand command = new SqlCommand("SELECT  mycontact.id ,  mycontact.fname  as'First Name',  mycontact.lname  as 'Last Name', mycontact.group_id as 'Group ID' , mygroup.name as 'Group Name' FROM  mycontact, mygroup WHERE mycontact.userid = @uid AND mycontact.group_id = mygroup.id");

            command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.CurrentUserID;
            dataGridViewContact.DataSource = contact.SelectContactList(command);
        }

        private void dataGridViewContact_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
