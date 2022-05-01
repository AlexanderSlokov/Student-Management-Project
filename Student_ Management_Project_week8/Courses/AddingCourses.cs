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
    public partial class AddingCourses : Form
    {
        public AddingCourses()
        {
            InitializeComponent();
        }

        COURSES course = new COURSES();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // local variables
            int id = Int32.MinValue, period = Int32.MinValue, semester = Int32.MinValue;
            string label = string.Empty, description = string.Empty;
            bool idValid = false, labelValid = false, periodValid = false, semesterValid = false;
            // initialize 
            Int32.TryParse(textBoxCourseID.Text, out id);
            label = textBoxCourseLabel.Text;
            Int32.TryParse(textBoxPeriod.Text, out period);

            if (comboBoxSemester.SelectedItem as ComboboxItem != null)
            {
                semester = (comboBoxSemester.SelectedItem as ComboboxItem).Value;
                semesterValid = true;
                labelSemesterError.Visible = false;
            }
            else
            {
                semesterValid = false;
                labelSemesterError.Visible = true;
                labelSemesterError.Text = "Please Enter Semester";
            }

            description = textBoxDescription.Text;
            // Check valid input
            if (id == 0)
            {
                labelCourseIDError.Visible = true;
                labelCourseIDError.Text = "Enter a Course ID";
                idValid = false;
            }
            else
            {
                // if don't exist
                if (course.checkCourseID(id))
                {
                    labelCourseIDError.Visible = false;
                    idValid = true;
                }
                // reverse
                else
                {
                    labelCourseIDError.Visible = true;
                    labelCourseIDError.Text = "A Course ID exists";
                    idValid = false;
                }

            }
            if (label.Trim() == "")
            {
                labelCourseLabelError.Visible = true;
                labelCourseLabelError.Text = "Add a Course Name";
                labelValid = false;
            }
            else
            {
                labelCourseLabelError.Visible = false;
                labelValid = true;
            }
            if (period == 0)
            {
                labelPeriodError.Visible = true;
                labelPeriodError.Text = "Please type the number of periods";
                periodValid = false;
            }
            else
            {
                if (period < 10)
                {
                    labelPeriodError.Visible = true;
                    labelPeriodError.Text = "Periods must greater than 10";
                    periodValid = false;
                }
                else
                {
                    labelPeriodError.Visible = false;
                    periodValid = true;
                }
            }

            //
            if (labelValid && periodValid && idValid && semesterValid)
            {
                if (course.insertCourse(id, label, period, description, semester))
                {
                    MessageBox.Show("New Course Inserted");
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //
        }

        private class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void AddingCourses_Load(object sender, EventArgs e)
        {
            labelCourseIDError.Visible = false;
            labelCourseLabelError.Visible = false;
            labelPeriodError.Visible = false;
            labelSemesterError.Visible = false;
            comboBoxSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboboxItem item1 = new ComboboxItem();
            ComboboxItem item2 = new ComboboxItem();
            ComboboxItem item3 = new ComboboxItem();
            item1.Text = "1";
            item1.Value = 1;
            comboBoxSemester.Items.Add(item1);
            item2.Text = "2";
            item2.Value = 2;
            comboBoxSemester.Items.Add(item2);
            item3.Text = "3";
            item3.Value = 3;
            comboBoxSemester.Items.Add(item3);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
