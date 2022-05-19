namespace Student_Management_Project_week8.Score
{
    partial class AvergareScore
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
            this.dataGridViewAverageScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAverageScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAverageScore
            // 
            this.dataGridViewAverageScore.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridViewAverageScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAverageScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAverageScore.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAverageScore.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAverageScore.Name = "dataGridViewAverageScore";
            this.dataGridViewAverageScore.RowHeadersWidth = 51;
            this.dataGridViewAverageScore.Size = new System.Drawing.Size(349, 665);
            this.dataGridViewAverageScore.TabIndex = 1;
            this.dataGridViewAverageScore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAverageScore_CellContentClick);
            // 
            // AvergareScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 665);
            this.Controls.Add(this.dataGridViewAverageScore);
            this.Name = "AvergareScore";
            this.Text = "AvergareScore";
            this.Load += new System.EventHandler(this.AvergareScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAverageScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAverageScore;
    }
}