using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Student_Management_Project_week8.Form1;

namespace Student_Management_Project_week8.HR_Management.Contact_Forms
{
    public partial class Edit_Contact_Form : Form
    {
        public Edit_Contact_Form()
        {
            InitializeComponent();
        }

        CONTACT contact = new CONTACT();
        MY_DB mydb = new MY_DB();
        MemoryStream picture = new MemoryStream();
        int initialID;
        bool pictureChecked = false;

        private void Edit_Contact_Form_Load(object sender, EventArgs e)
        {
            GROUP group = new GROUP();

            comboBoxGroup.DataSource = group.GetGroups(GLOBAL.CurrentUserID);
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "id";
            labelImageError.Visible = false;    
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png; *.gif; *.jfif)|*.jpg;*.png;*.gif;*.jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxContactImage.Image = Image.FromFile(opf.FileName);
                pictureBoxContactImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxContactImage.Image.Save(picture, pictureBoxContactImage.Image.RawFormat);
                pictureChecked = true;
            }
            else
            {
                if (pictureBoxContactImage.Image == null)
                    pictureChecked = false;
            }
        }

        private void buttonFindContact_Click(object sender, EventArgs e)
        {
            Select_Contact_Form SelectContactF = new Select_Contact_Form();
            SelectContactF.ShowDialog();
            if (SelectContactF.dataGridViewContact.Rows.Count > 1)
            {
                initialID = Convert.ToInt32(SelectContactF.dataGridViewContact.CurrentRow.Cells[0].Value.ToString());

                CONTACT contact = new CONTACT();

                DataTable table = contact.GetContactByID(initialID, GLOBAL.CurrentUserID);
                txtContactID.Text = table.Rows[0]["id"].ToString();
                textBoxFName.Text = table.Rows[0]["fname"].ToString();
                textBoxLName.Text = table.Rows[0]["lname"].ToString();
                comboBoxGroup.SelectedValue = table.Rows[0]["group_id"];
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxEmail.Text = table.Rows[0]["email"].ToString();
                textBoxAddress.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxContactImage.Image = Image.FromStream(picture);

            }
            else
            {
                MessageBox.Show("Add A Contact To Edit");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(txtContactID.Text, out id);
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            string email = textBoxEmail.Text;
            int userid = GLOBAL.CurrentUserID;

            bool idChecked, fnameTyped, lnameTyped;
            //check dieu kien

            //id trùng và trống
            if (txtContactID.Text == "")
            {
                labelIdError.Visible = true;
                labelIdError.Text = "Type a ID!";
                idChecked = false;
            }
            else
            {
                if (id == 0)
                {
                    labelIdError.Visible = true;
                    labelIdError.Text = "Please Type Valid ID Format";
                    idChecked = false;
                }
                else
                {
                    if (id == initialID)
                    {
                        idChecked = true;

                        labelIdError.Visible = false;
                        labelIdError.Text = "";
                    }
                    else
                    {
                        if (contact.ChecKIdExist(Convert.ToInt32(id), userid))
                        {
                            idChecked = false;

                            labelIdError.Visible = true;
                            labelIdError.Text = "ID exists in you group";
                        }
                        else
                        {
                            idChecked = true;

                            labelIdError.Visible = false;
                            labelIdError.Text = "";
                        }
                    }
                }

            }
            //first name trống 
            if (textBoxFName.Text == "")
            {
                labelFirstNameError.Visible = true;
                labelFirstNameError.Text = "Type First Name";
                fnameTyped = false;
            }
            else
            {
                labelFirstNameError.Visible = false;
                labelFirstNameError.Text = "";
                fnameTyped = true;
            }
            // last name trống
            if (textBoxLName.Text == "")
            {
                labelLastNameError.Visible = true;
                labelLastNameError.Text = "Type First Name";
                lnameTyped = false;
            }
            else
            {
                labelLastNameError.Visible = false;
                labelLastNameError.Text = "";
                lnameTyped = true;
            }
            // thông báo picture chưa inserted
            if (pictureBoxContactImage.Image == null)
            {
                labelImageError.Visible = true;
                labelImageError.Text = "Insert A Picture";
            }
            else
            {
                pictureChecked = true;
                labelImageError.Visible = false;
                labelImageError.Text = "";
            }
            // điều kiện cuối
            if (idChecked == true && fnameTyped == true && lnameTyped == true && pictureChecked == true)
            {

                int groupid = (int)comboBoxGroup.SelectedValue;

                pictureBoxContactImage.Image.Save(picture, pictureBoxContactImage.Image.RawFormat);

                CONTACT contact = new CONTACT();
                if (id == initialID)
                {
                    if (contact.UpdateContact(id, fname, lname, phone, address, email, groupid, picture, userid))
                    {
                        MessageBox.Show("Contact Edited", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (!contact.ChecKIdExist(id, userid))
                    {
                        if (contact.DeleteContact(initialID, userid))
                        {
                            if (contact.InsertContact(id, fname, lname, phone, address, email, userid, groupid, picture))
                            {
                                MessageBox.Show("Contact Inserted", "Insert Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                initialID = id;
                            }
                            else
                            {
                                MessageBox.Show("Contact Wasn't Inserted", "Insert Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID exists", "Insert Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }
    }
}
