using Student_Management_Project_week8;
using Student_Management_Project_week8.Class;
using Student_Management_Project_week8.Score;
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

namespace Student_Management_Project_week8.Class
{
    public partial class formManageScore : Form
    {
        public formManageScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        COURSES course = new COURSES();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        string data;
       

        private void buttonShowStudents_Click(object sender, EventArgs e)
        {
            data = "student";
            SqlCommand command = new SqlCommand("SELECT Id, fname, lname, bdate, gender, phone, address FROM StudentInfo");
            dataGridViewStudentScore.DataSource = student.getStudent(command);

            dataGridViewStudentScore.Columns[0].Width = 50;
            dataGridViewStudentScore.Columns[0].HeaderText = "Student ID";
            dataGridViewStudentScore.Columns[1].Width = 70;
            dataGridViewStudentScore.Columns[1].HeaderText = "First Name";
            dataGridViewStudentScore.Columns[2].Width = 70;
            dataGridViewStudentScore.Columns[2].HeaderText = "Last Name";
            dataGridViewStudentScore.Columns[3].Width = 100;
            dataGridViewStudentScore.Columns[3].HeaderText = "Birthdate";
            dataGridViewStudentScore.Columns[4].Width = 50;
            dataGridViewStudentScore.Columns[4].HeaderText = "Gender";
            dataGridViewStudentScore.Columns[5].Width = 100;
            dataGridViewStudentScore.Columns[5].HeaderText = "Phone";
            dataGridViewStudentScore.Columns[6].Width = 100;
            dataGridViewStudentScore.Columns[6].HeaderText = "Address";

            dataGridViewStudentScore.AllowUserToAddRows = false;
        }

        private void buttonShowScores_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridViewStudentScore.DataSource = score.getStudentScore();
            this.dataGridViewStudentScore.Sort(this.dataGridViewStudentScore.Columns[0], ListSortDirection.Ascending);

            dataGridViewStudentScore.Columns[0].Width = 50;
            dataGridViewStudentScore.Columns[0].HeaderText = "Student ID";
            dataGridViewStudentScore.Columns[1].Width = 120;
            dataGridViewStudentScore.Columns[1].HeaderText = "First Name";
            dataGridViewStudentScore.Columns[2].Width = 120;
            dataGridViewStudentScore.Columns[2].HeaderText = "Last Name";
            dataGridViewStudentScore.Columns[3].Width = 50;
            dataGridViewStudentScore.Columns[3].HeaderText = "Course ID";
            dataGridViewStudentScore.Columns[4].Width = 120;
            dataGridViewStudentScore.Columns[4].HeaderText = "Course Name";
            dataGridViewStudentScore.Columns[5].Width = 100;
            dataGridViewStudentScore.Columns[5].HeaderText = "Student Score";

            dataGridViewStudentScore.AllowUserToAddRows = false;
        }
        public void getDataFromdDataGridView()
        {
            if (data == "student")
            {
                textBoxStudentID.Text = dataGridViewStudentScore.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data == "score")
            {
                textBoxStudentID.Text = dataGridViewStudentScore.CurrentRow.Cells[0].Value.ToString();
                comboBoxSelectCourse.SelectedValue = dataGridViewStudentScore.CurrentRow.Cells[5].Value;
            }

        }

        private void dataGridViewStudentScore_Click(object sender, EventArgs e)
        {
            getDataFromdDataGridView();
        }

        

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(dataGridViewStudentScore.CurrentRow.Cells[0].Value.ToString());
                int courseID = int.Parse(dataGridViewStudentScore.CurrentRow.Cells[3].Value.ToString());

                if (MessageBox.Show("Do You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentID, courseID))
                    {
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewStudentScore.DataSource = score.getStudentScore();
                        this.dataGridViewStudentScore.Sort(this.dataGridViewStudentScore.Columns[0], ListSortDirection.Ascending);
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }
        // show form with average score
        private void buttonAverageScore_Click(object sender, EventArgs e)
        {
            AvergareScore averageScore = new AvergareScore();
            averageScore.Show(this);
        }

        private void formManageScore_Load(object sender, EventArgs e)
        {
            comboBoxSelectCourse.DataSource = course.getAllCourses();
            comboBoxSelectCourse.DisplayMember = "label";
            comboBoxSelectCourse.ValueMember = "id";
            data = "student";
            //dataGridViewStudentScore.DataSource = score.getStudentScore();
            SqlCommand command = new SqlCommand("SELECT Id, fname, lname, bdate, gender, phone, address FROM StudentInfo");
            dataGridViewStudentScore.DataSource = student.getStudent(command);

            dataGridViewStudentScore.Columns[0].Width = 50;
            dataGridViewStudentScore.Columns[0].HeaderText = "Student ID";
            dataGridViewStudentScore.Columns[1].Width = 70;
            dataGridViewStudentScore.Columns[1].HeaderText = "First Name";
            dataGridViewStudentScore.Columns[2].Width = 70;
            dataGridViewStudentScore.Columns[2].HeaderText = "Last Name";
            dataGridViewStudentScore.Columns[3].Width = 100;
            dataGridViewStudentScore.Columns[3].HeaderText = "Birthdate";
            dataGridViewStudentScore.Columns[4].Width = 50;
            dataGridViewStudentScore.Columns[4].HeaderText = "Gender";
            dataGridViewStudentScore.Columns[5].Width = 100;
            dataGridViewStudentScore.Columns[5].HeaderText = "Phone";
            dataGridViewStudentScore.Columns[6].Width = 100;
            dataGridViewStudentScore.Columns[6].HeaderText = "Address";

            this.dataGridViewStudentScore.Sort(this.dataGridViewStudentScore.Columns[0], ListSortDirection.Ascending);
            dataGridViewStudentScore.AllowUserToAddRows = false;
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxStudentID.Text);
                int courseID = Convert.ToInt32(comboBoxSelectCourse.SelectedValue);
                float scoreValue = Convert.ToInt32(textBoxScore.Text);
                string description = textBoxDescription.Text;
                if (scoreValue < 0 || scoreValue > 10)
                {
                    MessageBox.Show("Score must varries between 0 and 10");
                }
                else
                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                    {
                        textBoxStudentID.Text = "";
                        comboBoxSelectCourse.SelectedItem = null;
                        textBoxScore.Text = "";
                        textBoxDescription.Text = "";
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //
        }
    }
}
