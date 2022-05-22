using Student_Management_Project_week8;
using Student_Management_Project_week8.Student_Management;
using Student_Management_Project_week8.Courses;
using Student_Management_Project_week8.Score;
using Student_Management_Project_week8.Result;
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

        private void printViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print_Student print_Student = new Print_Student();
            print_Student.Show(this);   
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stat stat = new Stat();
            stat.Show(this);
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_Student_Form manageStudentForm = new Manage_Student_Form();  
            manageStudentForm.Show(this);   
        }

        private void aDDCOURSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingCourses addingCourses = new AddingCourses();  
            addingCourses.Show(this);   
        }

        private void eDITCOURSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourses editCourses = new EditCourses();
            editCourses.Show(this);

        }

        private void pRINTCOURSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintCourses printCourses = new PrintCourses(); 
            printCourses.Show(this);    
        }

        private void dELETECOURSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletingCourses deleting = new DeletingCourses();
            deleting.Show(this);    
        }

        private void mANAGECOURSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCOURSES manageCOURSES = new ManageCOURSES();
            manageCOURSES.Show(this);
        }

        private void aDDSCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Score_Form add_Score_Form = new Add_Score_Form();
            add_Score_Form.Show(this);
        }

        private void aVERGARESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvergareScore avergareScore = new AvergareScore();
            avergareScore.Show(this); 
        }

        private void mANAGESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formManageScore manageScore = new formManageScore();
            manageScore.Show(this);
        }

        private void pRINTSCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print_Score_Form print_Score_Form = new Print_Score_Form();
            print_Score_Form.Show(this);
        }

        private void dELETESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Score delete_Score = new Delete_Score();
            delete_Score.Show(this);    
        }

        private void averageResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AverageResult averageResult = new AverageResult();
            averageResult.Show(this);   
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Static_Result static_Result = new Static_Result();  
            static_Result.Show(this);   
        }
    }
}
