
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
using Student_Management_Project_week8;
using Student_Management_Project_week8.Class;

namespace Student_Management_Project_week8.Score
{
    public partial class Add_Score_Form : Form
    {
        public Add_Score_Form()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        COURSES course = new COURSES();
        STUDENT student = new STUDENT();

        private void Add_Score_Form_Load(object sender, EventArgs e)
        {
            comboBoxSelectCourse.DataSource = course.getAllCourses();
            comboBoxSelectCourse.DisplayMember = "label";
            comboBoxSelectCourse.ValueMember = "id";

            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std");
            dataGridViewStudent.DataSource = student.getStudent(command);
            dataGridViewStudent.Columns[0].Width = 20;
            dataGridViewStudent.Columns[0].HeaderText = "ID";
            dataGridViewStudent.Columns[1].Width = 110;
            dataGridViewStudent.Columns[1].HeaderText = "First Name";
            dataGridViewStudent.Columns[2].Width = 108;
            dataGridViewStudent.Columns[2].HeaderText = "Last Name";
            dataGridViewStudent.AllowUserToAddRows = false;
        }

        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = dataGridViewStudent.CurrentRow.Cells[0].Value.ToString();
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
