using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_Project_week8.Class;

namespace Student_Management_Project_week8.Score
{
    public partial class Delete_Score : Form
    {
        public Delete_Score()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        COURSES course = new COURSES();
        STUDENT student = new STUDENT();
        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(dataGridViewScore.CurrentRow.Cells[0].Value.ToString());
                int courseID = int.Parse(dataGridViewScore.CurrentRow.Cells[3].Value.ToString());

                if (MessageBox.Show("Do You Want To Delete This Score", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(studentID, courseID))
                    {
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewScore.DataSource = score.getStudentScore();
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

        private void formRemoveScore_Load(object sender, EventArgs e)
        {
            dataGridViewScore.AllowUserToAddRows = false;
            dataGridViewScore.DataSource = score.getStudentScore();
            dataGridViewScore.Columns[0].Width = 100;
            dataGridViewScore.Columns[0].HeaderText = "Student's ID";
            dataGridViewScore.Columns[1].Width = 120;
            dataGridViewScore.Columns[1].HeaderText = "First Name";
            dataGridViewScore.Columns[2].Width = 120;
            dataGridViewScore.Columns[2].HeaderText = "Last Name";
            dataGridViewScore.Columns[3].Width = 50;
            dataGridViewScore.Columns[3].HeaderText = "Course ID";
            dataGridViewScore.Columns[4].Width = 120;
            dataGridViewScore.Columns[4].HeaderText = "Course Name";
            dataGridViewScore.Columns[5].Width = 50;
            dataGridViewScore.Columns[5].HeaderText = "Score";
            dataGridViewScore.AllowUserToAddRows = false;
            this.dataGridViewScore.Sort(this.dataGridViewScore.Columns[0], ListSortDirection.Ascending);
        }
    }
}
