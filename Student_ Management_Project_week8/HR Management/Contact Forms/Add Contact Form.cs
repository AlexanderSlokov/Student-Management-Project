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
    public partial class Add_Contact_Form : Form
    {
        public Add_Contact_Form()
        {
            InitializeComponent();
        }

        CONTACT contact = new CONTACT();
        MY_DB mydb = new MY_DB();
        MemoryStream picture = new MemoryStream();
        bool pictureChecked = false;
        GROUP group = new GROUP();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please Add A Group First!");
            }
            else
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
                    labelIdError.Text = "Type New ID!";
                    idChecked = false;
                }
                else
                {
                    Int32.TryParse(txtContactID.Text, out id);
                    if (id != 0)
                    {
                        if (contact.ChecKIdExist(Convert.ToInt32(txtContactID.Text), GLOBAL.CurrentUserID))
                        {
                            labelIdError.Visible = true;
                            labelIdError.Text = "Existing ID!";
                            idChecked = false;
                        }
                        else
                        {
                            labelIdError.Visible = false;
                            labelIdError.Text = "";
                            idChecked = true;
                        }
                    }
                    else
                    {
                        labelIdError.Visible = true;
                        labelIdError.Text = "Type Valid ID format!";
                        idChecked = false;
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
                if (!pictureChecked)
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

                    MemoryStream picture = new MemoryStream();
                    pictureContactImage.Image.Save(picture, pictureContactImage.Image.RawFormat);

                    CONTACT contact = new CONTACT();
                    if (contact.InsertContact(id, fname, lname, phone, address, email, userid, groupid, picture))
                    {
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill All Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png; *.gif; *.jfif)|*.jpg;*.png;*.gif;*.jfif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureContactImage.Image = Image.FromFile(opf.FileName);
                pictureContactImage.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureContactImage.Image.Save(picture, pictureContactImage.Image.RawFormat);
                pictureChecked = true;
            }
            else
            {
                if (pictureContactImage.Image == null)
                    pictureChecked = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Contact_Form_Load(object sender, EventArgs e)
        {
            comboBoxGroup.DataSource = group.GetGroups(GLOBAL.CurrentUserID);
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.ValueMember = "id";
        }
    }
}
