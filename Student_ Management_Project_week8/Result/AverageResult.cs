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

namespace Student_Management_Project_week8.Result
{
    public partial class AverageResult : Form
    {
        public AverageResult()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        COURSES course = new COURSES();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();

        private void AverageResult_Load(object sender, EventArgs e)
        {
            dataGridViewResult.DataSource = score.getAllStudentScore();
        }
    }
}
