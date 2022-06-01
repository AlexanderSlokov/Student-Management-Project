using Student_Management_Project_week8.Class;
using Student_Management_Project_week8.Result;
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
using System.Windows.Forms.DataVisualization.Charting;


namespace Student_Management_Project_week8.Result
{
    public partial class Static_Result : Form
    {
        public Static_Result()
        {
            InitializeComponent();
            InitializeChart();
        }
        STUDENT student = new STUDENT();
        SCORE score = new SCORE();
        MY_DB mydb = new MY_DB();
        int passNumber, failNumber;
        public delegate void ReturnPassFailEventHandler(ref int pass, ref int fail);
        event ReturnPassFailEventHandler GetPassFail_Event;
        Chart pieChart;
        Chart barChart;

        private void InitializeChart()
        {
            this.components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();

            Legend legend1 = new Legend()
            { BackColor = Color.Green, ForeColor = Color.Black, Title = "Gender" };
            Legend legend2 = new Legend()
            { BackColor = Color.Green, ForeColor = Color.Black, Title = "Gender" };

            pieChart = new Chart();
            barChart = new Chart();

            ((ISupportInitialize)(pieChart)).BeginInit();
            ((ISupportInitialize)(barChart)).BeginInit();

            SuspendLayout();

            //===Pie chart
            chartArea1.Name = "PieChartArea";
            pieChart.ChartAreas.Add(chartArea1);
            pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            pieChart.Legends.Add(legend1);
            pieChart.Location = new System.Drawing.Point(0, 50);

            //====Bar Chart
            chartArea1 = new ChartArea();
            chartArea1.Name = "BarChartArea";
            barChart.ChartAreas.Add(chartArea1);
            barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend3";
            barChart.Legends.Add(legend2);

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(284, 262);           
            //this.Load += new EventHandler(formStatisticResult_Load);
            ((ISupportInitialize)(this.pieChart)).EndInit();
            ((ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);
        }
        protected void OnGetPassFail()
        {

                if (GetPassFail_Event != null)
                    GetPassFail_Event(ref passNumber, ref failNumber);
        }

        

        void LoadPieChart(int passNumber, int failNumber)
        {
                float passRatio = ((float)passNumber / (passNumber + failNumber) * 100);
                float failRatio = ((float)failNumber / (passNumber + failNumber) * 100);
                pieChart.Series.Clear();
                pieChart.Palette = ChartColorPalette.Fire;
                pieChart.BackColor = Color.DarkGray;
                pieChart.ChartAreas[0].BackColor = Color.Transparent;
                Series series1 = new Series
                {
                    Name = "series1",
                    IsVisibleInLegend = true,
                    Color = System.Drawing.Color.Green,
                    ChartType = SeriesChartType.Pie
                };
                pieChart.Series.Add(series1);
                series1.Points.Add(70000);
                series1.Points.Add(30000);
                var p1 = series1.Points[0];
                //
                p1.Color = Color.LightBlue;
                p1.AxisLabel = passRatio.ToString("#.##") + "%";
                p1.LegendText = "Pass";
                var p2 = series1.Points[1];
                //
                p2.Color = Color.OrangeRed;
                p2.AxisLabel = failRatio.ToString("#.##") + "%";
                p2.LegendText = "Fail";
                pieChart.Invalidate();
                pnlPie.Controls.Add(pieChart);
        
        }

        private void Static_Result_Load(object sender, EventArgs e)
        {
            GetPassFail_Event += FindPassAndFail;
            OnGetPassFail();
            labelPassNumber.Text = passNumber.ToString();
            labelFailNumber.Text = failNumber.ToString();

            LoadPieChart(passNumber, failNumber);
            dataGridViewAverageScore.DataSource = score.getAverageScoreByCourse();
            dataGridViewAverageScore.Columns[0].Width = 150;
            dataGridViewAverageScore.Columns[1].Width = 200;
            dataGridViewAverageScore.Columns[1].DefaultCellStyle.Font = new Font(dataGridViewAverageScore.DefaultCellStyle.Font, FontStyle.Underline);

        }

        public void FindPassAndFail(ref int numberOfPass, ref int numberOfFail)
        {
            string firstname = string.Empty, lastname = string.Empty;
            int studentID = int.MinValue;
            string studentQuery = "SELECT ID, fname, lname FROM StudentInfo";
            SqlCommand command = new SqlCommand(studentQuery, mydb.GetConnection);

            // Add student query parameters
            if (firstname != string.Empty)
                command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = firstname;
            if (lastname != string.Empty)
                command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lastname;
            if (studentID != int.MinValue)
                command.Parameters.Add("@id", SqlDbType.Int).Value = studentID;
            DataTable table = student.getStudent(command);

            //add label
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT label FROM course", mydb.GetConnection);
            DataTable labelTable = new DataTable();
            adpt.Fill(labelTable);

            for (int i = 0; i < labelTable.Rows.Count; i++)
            {
                table.Columns.Add(labelTable.Rows[i][0].ToString(), typeof(int));
            }

            // add value to label header
            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 3; j < table.Columns.Count; j++)
                {
                    command = new SqlCommand("SELECT score.student_score FROM StudentInfo, score, course WHERE course.label = @label AND course.id = score.course_id AND score.student_id = @sid", mydb.GetConnection);

                    command.Parameters.Add("@label", SqlDbType.VarChar).Value = table.Columns[j].ColumnName;
                    command.Parameters.Add("@sid", SqlDbType.Int).Value = Convert.ToInt32(table.Rows[i][0]);

                    adpt = new SqlDataAdapter(command);
                    DataTable scoreTable = new DataTable();
                    adpt.Fill(scoreTable);

                    if (scoreTable.Rows.Count > 0)
                    {
                        table.Rows[i][table.Columns[j].ColumnName] = Convert.ToInt32(scoreTable.Rows[0][0]);
                    }
                }
            }
            // add result

            table.Columns.Add("Result", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int sum = 0;
                for (int j = 3; j < table.Columns.Count - 1; j++)
                {
                    if (!(table.Rows[i][j] is DBNull))
                        sum += Convert.ToInt32(table.Rows[i][j]);
                }

                float avg = (float)sum / (table.Columns.Count - 4);

                if (avg < 3)
                {
                    numberOfFail++;
                    table.Rows[i][table.Columns.Count - 1] = "Fail";
                }
                else
                {
                    if (avg >= 3 && avg < 6.5)
                    {

                        table.Rows[i][table.Columns.Count - 1] = "Average";
                    }
                    else if (avg >= 6.5 && avg < 8)
                    {
                        table.Rows[i][table.Columns.Count - 1] = "Good";
                    }
                    else
                    {
                        table.Rows[i][table.Columns.Count - 1] = "Excellent";
                    }
                    numberOfPass++;
                }
            }



           
        }
    }
}
