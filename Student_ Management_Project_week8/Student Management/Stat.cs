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
using Student_Management_Project_week8;

namespace Student_Management_Project_week8.Student_Management
{
    public partial class Stat : Form
    {
        MY_DB mydb = new MY_DB();
        Chart barChart;
        public Stat()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            this.components = new System.ComponentModel.Container();    
            ChartArea chartArea1 = new ChartArea();
            
            Legend legend1 = new Legend()
            { BackColor = Color.Blue, ForeColor = Color.Black, Title = "gender" };

            Legend legend2 = new Legend()
            { BackColor = Color.Blue, ForeColor = Color.Black, Title = "gender" };

            barChart = new Chart();

            ((ISupportInitialize)(barChart)).BeginInit();

            SuspendLayout();

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
            this.Load += new EventHandler(Stat_Load);           
            ((ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);
        }
        private void Stat_Load(object sender, EventArgs e)
        {
            mydb.openConnection();
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM StudentInfo WHERE gender = 'male'", mydb.GetConnection);
            int male = Convert.ToInt32(((SqlCommand)sqlCommand).ExecuteScalar());

            sqlCommand = new SqlCommand("SELECT COUNT(*) FROM StudentInfo WHERE gender = 'female'", mydb.GetConnection);
            int female = Convert.ToInt32(sqlCommand.ExecuteScalar());

            sqlCommand = new SqlCommand("SELECT COUNT(*) FROM StudentInfo", mydb.GetConnection);
            int total = Convert.ToInt32(sqlCommand.ExecuteScalar());
            CountStudentlabel.Text = "Number of students: " + total;

            LoadBarChart(male, female);
            mydb.closeConnection();
        }

        void LoadBarChart(int male, int female)
        {
            barChart.Series.Clear();
            barChart.BackColor = Color.LightYellow;
            barChart.Palette = ChartColorPalette.Fire;
            barChart.ChartAreas[0].BackColor = Color.Transparent;
            barChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            barChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            Series series = new Series
            {
                Name = "series2",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };
            barChart.Series.Add(series);
            series.Points.Add(male);
            var p1 = series.Points[0];
            p1.Color = Color.Red;
            p1.AxisLabel = "Male";
            p1.LegendText = "Male";
            p1.Label = male.ToString();

            series.Points.Add(female);
            var p2 = series.Points[1];
            p2.Color = Color.LightBlue;
            p2.AxisLabel = "Female";
            p2.LegendText = "Female";
            p2.Label = female.ToString();
            barChart.Invalidate();

            panel1.Controls.Add(barChart);
        }
    }
}
