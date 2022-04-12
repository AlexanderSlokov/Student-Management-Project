using Student_Management_Project_week8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Project_week8
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void addAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdForm = new AddStudentForm();
            addStdForm.Show(this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void updateOrDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.Show(this);
        }

        private void seeStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_List StudentLIst = new Student_List();  
            StudentLIst.Show(this); 
        }
    }
}
