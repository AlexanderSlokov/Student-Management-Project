namespace Student_Management_Project_week8.Score
{
    partial class Delete_Score
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
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(12, 8);
            this.dataGridViewScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.Size = new System.Drawing.Size(845, 575);
            this.dataGridViewScore.TabIndex = 2;
            this.dataGridViewScore.Click += new System.EventHandler(this.formRemoveScore_Load);
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveScore.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonRemoveScore.Location = new System.Drawing.Point(12, 589);
            this.buttonRemoveScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Size = new System.Drawing.Size(845, 32);
            this.buttonRemoveScore.TabIndex = 3;
            this.buttonRemoveScore.Text = "Remove Score";
            this.buttonRemoveScore.UseVisualStyleBackColor = false;
            this.buttonRemoveScore.Click += new System.EventHandler(this.buttonRemoveScore_Click);
            // 
            // Delete_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 626);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.buttonRemoveScore);
            this.Name = "Delete_Score";
            this.Text = "Delete_Score";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Button buttonRemoveScore;
    }
}