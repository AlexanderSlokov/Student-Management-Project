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
    public partial class ManageCOURSES : Form
    {
        COURSES course = new COURSES();
        int pos;


        public ManageCOURSES()
        {
            InitializeComponent();
        }

        //constructor for comboBox
        private class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        void reloadListBoxData()
        {
            listBoxCourses.DataSource = course.getAllCourses();
            listBoxCourses.ValueMember = "id";
            listBoxCourses.DisplayMember = "label";

            listBoxCourses.SelectedItem = null;

            buttonTotalCourses.Text = ("Total Courses: " + course.countAllCourses().ToString());
        }
        private void ManageCOURSES_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
            
            labelCourseIDError.Visible = false;
            labelCourseLabelError.Visible = false;
            labelPeriodError.Visible = false;
            labelSemesterError.Visible = false;
            
            comboBoxSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            List<ComboboxItem> items = new List<ComboboxItem>();
            items.Add(new ComboboxItem() { Text = "1", Value = 1 });
            items.Add(new ComboboxItem() { Text = "2", Value = 2 });
            items.Add(new ComboboxItem() { Text = "3", Value = 3 });
            
            comboBoxSemester.DataSource = items;
            comboBoxSemester.DisplayMember = "Text";
            comboBoxSemester.ValueMember = "Value";
        }

        void showData(int index)
        {
            try
            {
                DataRow datarow = course.getAllCourses().Rows[index];
                listBoxCourses.SelectedIndex = index;
                textBoxID.Text = datarow.ItemArray[0].ToString();
                textBoxCourseLabel.Text = datarow.ItemArray[1].ToString();
                numericUpDownHoursNumber.Value = int.Parse(datarow.ItemArray[2].ToString());
                textBoxDescription.Text = datarow.ItemArray[3].ToString();
                List<ComboboxItem> items = new List<ComboboxItem>();
                items.Add(new ComboboxItem() { Text = "1", Value = 1 });
                items.Add(new ComboboxItem() { Text = "2", Value = 2 });
                items.Add(new ComboboxItem() { Text = "3", Value = 3 });
                comboBoxSemester.SelectedIndex = Int32.Parse(datarow.ItemArray[4].ToString()) - 1;
            }
            catch
            {

            }
        }

        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            DataRowView datarowview = (DataRowView)listBoxCourses.SelectedItem;
            pos = listBoxCourses.SelectedIndex;
            comboBoxSemester.Enabled = true;
            showData(pos);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // local variables
            int id = Int32.MinValue, period = Int32.MinValue, semester = Int32.MinValue;
            string label = string.Empty, description = string.Empty;
            bool idValid = false, labelValid = false, periodValid = false, semesterValid = false;
            // initialize 
            Int32.TryParse(textBoxID.Text, out id);
            label = textBoxCourseLabel.Text;
            Int32.TryParse(numericUpDownHoursNumber.Text, out period);

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
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // initialize
            int id = int.Parse(textBoxID.Text);
            string label = textBoxCourseLabel.Text;
            int period = (int)numericUpDownHoursNumber.Value;
            string description = textBoxDescription.Text;
            int semester = (int)comboBoxSemester.SelectedValue;
            bool labelValid = false, periodValid = false;
            //check vailidation
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
            if (labelValid && periodValid /*&& description*/)
            {
                if (course.updateCourse(id, label, period, description, semester))
                {
                    MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = Convert.ToInt32(textBoxID.Text);

                if ((MessageBox.Show("Are You Sure You Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields
                        textBoxID.Text = "";
                        textBoxCourseLabel.Text = "";
                        numericUpDownHoursNumber.Value = 10;
                        textBoxDescription.Text = "";

                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            //
            catch
            {
                MessageBox.Show("Enter A valid Numerid ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
            //
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }
    }
}
