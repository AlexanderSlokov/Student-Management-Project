using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_Project_week8;

namespace Student_Management_Project_week8.Courses
{
    public partial class DeletingCourses : Form
    {
        public DeletingCourses()
        {
            InitializeComponent();

        }
        MY_DB mydb = new MY_DB();
        COURSES course = new COURSES();
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(textBoxCourseIDSearch.Text, out id);
            if (!course.checkCourseID(id))
            {
                if (course.deleteCourse(id))
                {
                    MessageBox.Show("Course Deleted");
                }
                else
                {
                    MessageBox.Show("Course Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Course Doesn't Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //
        }
    }
}
