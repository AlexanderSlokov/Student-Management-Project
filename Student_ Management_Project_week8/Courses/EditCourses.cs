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
    public partial class EditCourses : Form
    {
        public EditCourses()
        {
            InitializeComponent();
        }

        COURSES course = new COURSES();

        private class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void EditCourses_Load(object sender, EventArgs e)
        {
            comboBoxSelectCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectCourse.DataSource = course.getAllCourses();
            comboBoxSelectCourse.DisplayMember = "label";
            comboBoxSelectCourse.ValueMember = "id";
            comboBoxSelectCourse.SelectedItem = null;
            //
            labelCourseLabelError.Visible = false;
            labelPeriodError.Visible = false;
            //labelDescriptionError.Visible = false;
            //labelSemesterError.Visible = false;

            comboBoxSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSemester.Enabled = false;
            List<ComboboxItem> items = new List<ComboboxItem>();
            items.Add(new ComboboxItem() { Text = "1", Value = 1 });
            items.Add(new ComboboxItem() { Text = "2", Value = 2 });
            items.Add(new ComboboxItem() { Text = "3", Value = 3 });
            comboBoxSemester.DataSource = items;
            comboBoxSemester.DisplayMember = "Text";
            comboBoxSemester.ValueMember = "Value";
        }

        public void fillCombo(int index)
        {
            comboBoxSelectCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSelectCourse.DataSource = course.getAllCourses();
            comboBoxSelectCourse.DisplayMember = "label";
            comboBoxSelectCourse.ValueMember = "id";
            comboBoxSelectCourse.SelectedItem = index;
        }

        private void comboBoxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                comboBoxSemester.Enabled = true;
                int id = Convert.ToInt32(comboBoxSelectCourse.SelectedValue);

                DataTable table = new DataTable();
                table = course.getCourseByID(id);

                textBoxCourseID.Text = table.Rows[0][1].ToString();
                numericUpDownPeriod.Value = Int32.Parse(table.Rows[0][2].ToString());

                textBoxDescription.Text = table.Rows[0][3].ToString();

                List<ComboboxItem> items = new List<ComboboxItem>();
                items.Add(new ComboboxItem() { Text = "1", Value = 1 });
                items.Add(new ComboboxItem() { Text = "2", Value = 2 });
                items.Add(new ComboboxItem() { Text = "3", Value = 3 });
                comboBoxSemester.SelectedIndex = Int32.Parse(table.Rows[0][4].ToString()) - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // initialize
            string label = textBoxCourseID.Text;
            int period = (int)numericUpDownPeriod.Value;
            string description = textBoxDescription.Text;
            int id = (int)comboBoxSelectCourse.SelectedValue;
            int semester = (int)comboBoxSemester.SelectedValue;
            bool labelValid = false, periodValid = false; //semesterValid = false;
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
                    comboBoxSelectCourse.DataSource = course.getAllCourses();
                }
                else
                {
                    MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //
        }
    }
}
