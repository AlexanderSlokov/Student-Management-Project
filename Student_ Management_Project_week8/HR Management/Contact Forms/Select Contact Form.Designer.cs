namespace Student_Management_Project_week8.HR_Management.Contact_Forms
{
    partial class Select_Contact_Form
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
            this.dataGridViewContact = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.AllowUserToAddRows = false;
            this.dataGridViewContact.AllowUserToDeleteRows = false;
            this.dataGridViewContact.AllowUserToOrderColumns = true;
            this.dataGridViewContact.AllowUserToResizeColumns = false;
            this.dataGridViewContact.AllowUserToResizeRows = false;
            this.dataGridViewContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContact.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewContact.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContact.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewContact.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.RowHeadersVisible = false;
            this.dataGridViewContact.RowHeadersWidth = 51;
            this.dataGridViewContact.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewContact.TabIndex = 1;
            this.dataGridViewContact.DoubleClick += new System.EventHandler(this.dataGridViewContact_DoubleClick);
            // 
            // Select_Contact_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewContact);
            this.Name = "Select_Contact_Form";
            this.Text = "Select_Contact_Form";
            this.Load += new System.EventHandler(this.Select_Contact_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewContact;
    }
}