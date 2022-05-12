using Student_Management_Project_week8;
using Student_Management_Project_week8.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Project_week8.Score
{
    public partial class AvergareScore : Form
    {
        SCORE score = new SCORE();
        COURSES course = new COURSES();
        STUDENT student = new STUDENT();

        public AvergareScore()
        {
            InitializeComponent();
        }
        private void formAverageScore_Load(object sender, EventArgs e)
        {
            dataGridViewAverageScore.DataSource = score.getAverageScoreByCourse();
        }
    }
}
