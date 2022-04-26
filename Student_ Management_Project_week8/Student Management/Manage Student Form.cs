using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_Project_week8;

namespace Student_Management_Project_week8.Student_Management
{
    public partial class Manage_Student_Form : Form
    {
        public Manage_Student_Form()
        {
            InitializeComponent();
        }

        //private variables
        private MemoryStream pic = new MemoryStream();
        private int initialID;
        private int id;
        private string fname = string.Empty,
                        lname = string.Empty,
                        phone = string.Empty,
                        adrs = string.Empty,
                        gender = string.Empty;

        //constructor for picture variable
        public MemoryStream Pic { get => pic; set => pic = value; }

        private void Manage_Student_Form_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM StudentInfo", mydb.GetConnection));
        }

        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();
        DateTime bdate;

       
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = student.getStudent(command);

            DataGridViewImageColumn PicCol = new DataGridViewImageColumn();
            PicCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            PicCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            labelTotalStudent.Text = ("Total students: " + dataGridView1.Rows.Count);

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxID.Text = string.Empty;
            textBoxFNAME.Text = string.Empty;
            textBoxLNAME.Text = string.Empty;
            dateTimePicker.Value = DateTime.Today;
            textBoxPHONE.Text = string.Empty;
            richTextBoxADR.Text = string.Empty;
            radioButtonMALE.Checked = true;
            radioButtonFEMALE.Checked = false;
            if (pictureBoxManage.Image != null)
            {
                pictureBoxManage.Image.Dispose();
                pictureBoxManage.Image = null;
            }
            textBoxID.Focus();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM StudentInfo WHERE CONCAT(fname, lname, address) LIKE'%" + textBoxSearch.Text + "%'", mydb.GetConnection);
            fillGrid(command);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            getImage();
        }

        private MemoryStream getImage()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpfg; *.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxManage.Image = Image.FromFile(opf.FileName);
                pictureBoxManage.Image.Save(Pic, pictureBoxManage.Image.RawFormat);
                pictureBoxManage.Text = string.Empty;
                return Pic;
            }
            else
            {
                if (pictureBoxManage.Image != null)
                {
                    return Pic;
                }
                else
                {
                    Pic = null;
                    labelPictureError.Text = "Xin mời chèn hình học sinh";
                    return null;
                }
            }
        }

        public bool studentFind()
        {
            string fname = string.Empty;
            string lname = string.Empty;
            DateTime bdate = DateTime.MinValue;
            string phone = string.Empty;
            string adrs = string.Empty;
            string gender = string.Empty;
            string address = string.Empty;
            try
            {
                id = Int32.Parse(textBoxID.Text);
                if (id != 0)
                {
                    if (student.getData(id, ref fname, ref lname, ref bdate, ref gender, ref phone, ref address, pictureBoxManage))
                    {
                        if (gender == "Female")
                        {
                            radioButtonMALE.Checked = false;
                            radioButtonFEMALE.Checked = true;
                        }
                        else
                        {
                            radioButtonMALE.Checked = true;
                            radioButtonFEMALE.Checked = false;
                        }
                        textBoxFNAME.Text = fname;
                        textBoxLNAME.Text = lname;
                        try { dateTimePicker.Value = bdate; } catch { }
                        textBoxPHONE.Text = phone;
                        richTextBoxADR.Text = address;
                        buttonEdit.Enabled = true;
                        buttonRemove.Enabled = true;
                        dateTimePicker.Visible = true;
                        return true;
                    }
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Nhập ID tìm kiếm");
                return false;
            }
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
            }
            catch
            {
                MessageBox.Show("Xin mời nhập ID");
            }

            string fname = textBoxFNAME.Text;
            string lname = textBoxLNAME.Text;
            DateTime bdate = dateTimePicker.Value;
            string phone = textBoxPHONE.Text;
            string adrs = richTextBoxADR.Text;
            
            string gender = "Male";
            if (radioButtonFEMALE.Checked)
            {
                gender = "Female";
            }

            if (student.deleteStudent(id, fname, lname, bdate, phone, adrs, gender))
            {
                textBoxID.Text = string.Empty;
                textBoxFNAME.Text = string.Empty;
                textBoxLNAME.Text = string.Empty;
                dateTimePicker.Value = DateTime.Today;
                textBoxPHONE.Text = string.Empty;
                richTextBoxADR.Text = string.Empty;
                radioButtonMALE.Checked = true;
                radioButtonFEMALE.Checked = false;
                pictureBoxManage.Image.Dispose();
                pictureBoxManage.Image = null;
                buttonEdit.Enabled = false;
                buttonRemove.Enabled = false;
                MessageBox.Show("Information Deleted");
                fillGrid(new SqlCommand("SELECT * FROM StudentInfo", mydb.GetConnection));
            }
        }

        bool verif()
        {
            if ((textBoxFNAME.Text.Trim()) == ""
                || (textBoxLNAME.Text.Trim() == "")
                || (richTextBoxADR.Text.Trim() == "")
                || (textBoxPHONE.Text.Trim() == "")
                || (pictureBoxManage == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void refreshfunc()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
