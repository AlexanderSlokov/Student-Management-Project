namespace Student_Management_Project_week8.Result
{
    partial class Static_Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChartDocked = new System.Windows.Forms.Panel();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.labelFailNumber = new System.Windows.Forms.Label();
            this.labelPassNumber = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.dataGridViewAverageScore = new System.Windows.Forms.DataGridView();
            this.labelProportion = new System.Windows.Forms.Label();
            this.labelAverageAllCourses = new System.Windows.Forms.Label();
            this.panelChartDocked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAverageScore)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChartDocked
            // 
            this.panelChartDocked.Controls.Add(this.pnlPie);
            this.panelChartDocked.Location = new System.Drawing.Point(726, 114);
            this.panelChartDocked.Margin = new System.Windows.Forms.Padding(4);
            this.panelChartDocked.Name = "panelChartDocked";
            this.panelChartDocked.Size = new System.Drawing.Size(664, 385);
            this.panelChartDocked.TabIndex = 20;
            // 
            // pnlPie
            // 
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPie.Location = new System.Drawing.Point(0, 0);
            this.pnlPie.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(664, 385);
            this.pnlPie.TabIndex = 7;
            // 
            // labelFailNumber
            // 
            this.labelFailNumber.AutoSize = true;
            this.labelFailNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFailNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFailNumber.ForeColor = System.Drawing.Color.Black;
            this.labelFailNumber.Location = new System.Drawing.Point(1346, 51);
            this.labelFailNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFailNumber.Name = "labelFailNumber";
            this.labelFailNumber.Size = new System.Drawing.Size(44, 45);
            this.labelFailNumber.TabIndex = 19;
            this.labelFailNumber.Text = "...";
            // 
            // labelPassNumber
            // 
            this.labelPassNumber.AutoSize = true;
            this.labelPassNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPassNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassNumber.ForeColor = System.Drawing.Color.Black;
            this.labelPassNumber.Location = new System.Drawing.Point(914, 51);
            this.labelPassNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassNumber.Name = "labelPassNumber";
            this.labelPassNumber.Size = new System.Drawing.Size(44, 45);
            this.labelPassNumber.TabIndex = 18;
            this.labelPassNumber.Text = "...";
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFail.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFail.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelFail.Location = new System.Drawing.Point(1252, 51);
            this.labelFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(83, 45);
            this.labelFail.TabIndex = 17;
            this.labelFail.Text = "Fail:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.Cyan;
            this.labelPass.Location = new System.Drawing.Point(800, 51);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(100, 45);
            this.labelPass.TabIndex = 16;
            this.labelPass.Text = "Pass:";
            // 
            // dataGridViewAverageScore
            // 
            this.dataGridViewAverageScore.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewAverageScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAverageScore.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewAverageScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAverageScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAverageScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAverageScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAverageScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAverageScore.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAverageScore.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAverageScore.Enabled = false;
            this.dataGridViewAverageScore.Location = new System.Drawing.Point(9, 114);
            this.dataGridViewAverageScore.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAverageScore.Name = "dataGridViewAverageScore";
            this.dataGridViewAverageScore.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAverageScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAverageScore.RowHeadersVisible = false;
            this.dataGridViewAverageScore.RowHeadersWidth = 51;
            this.dataGridViewAverageScore.RowTemplate.Height = 50;
            this.dataGridViewAverageScore.Size = new System.Drawing.Size(660, 385);
            this.dataGridViewAverageScore.TabIndex = 15;
            // 
            // labelProportion
            // 
            this.labelProportion.AutoSize = true;
            this.labelProportion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProportion.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProportion.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelProportion.Location = new System.Drawing.Point(1013, 9);
            this.labelProportion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProportion.Name = "labelProportion";
            this.labelProportion.Size = new System.Drawing.Size(198, 45);
            this.labelProportion.TabIndex = 14;
            this.labelProportion.Text = "Proportion";
            // 
            // labelAverageAllCourses
            // 
            this.labelAverageAllCourses.AutoSize = true;
            this.labelAverageAllCourses.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAverageAllCourses.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverageAllCourses.ForeColor = System.Drawing.Color.PaleGreen;
            this.labelAverageAllCourses.Location = new System.Drawing.Point(144, 9);
            this.labelAverageAllCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAverageAllCourses.Name = "labelAverageAllCourses";
            this.labelAverageAllCourses.Size = new System.Drawing.Size(396, 45);
            this.labelAverageAllCourses.TabIndex = 13;
            this.labelAverageAllCourses.Text = "Average Of All Courses";
            // 
            // Static_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1431, 610);
            this.Controls.Add(this.panelChartDocked);
            this.Controls.Add(this.labelFailNumber);
            this.Controls.Add(this.labelPassNumber);
            this.Controls.Add(this.labelFail);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.dataGridViewAverageScore);
            this.Controls.Add(this.labelProportion);
            this.Controls.Add(this.labelAverageAllCourses);
            this.Name = "Static_Result";
            this.Text = "Static_Result";
            this.Load += new System.EventHandler(this.Static_Result_Load);
            this.panelChartDocked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAverageScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelChartDocked;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label labelFailNumber;
        private System.Windows.Forms.Label labelPassNumber;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.DataGridView dataGridViewAverageScore;
        private System.Windows.Forms.Label labelProportion;
        private System.Windows.Forms.Label labelAverageAllCourses;
    }
}