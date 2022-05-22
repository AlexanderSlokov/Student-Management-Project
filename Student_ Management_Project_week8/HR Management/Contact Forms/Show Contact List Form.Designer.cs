namespace Student_Management_Project_week8.HR_Management.Contact_Forms
{
    partial class Show_Contact_List_Form
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
            this.buttonPrintContact = new System.Windows.Forms.Button();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.labelContactList = new System.Windows.Forms.Label();
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.dataGridViewContact = new System.Windows.Forms.DataGridView();
            this.labelContact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrintContact
            // 
            this.buttonPrintContact.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonPrintContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrintContact.FlatAppearance.BorderSize = 0;
            this.buttonPrintContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintContact.ForeColor = System.Drawing.Color.White;
            this.buttonPrintContact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPrintContact.Location = new System.Drawing.Point(902, 507);
            this.buttonPrintContact.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrintContact.Name = "buttonPrintContact";
            this.buttonPrintContact.Size = new System.Drawing.Size(561, 43);
            this.buttonPrintContact.TabIndex = 64;
            this.buttonPrintContact.Text = "To File Doc";
            this.buttonPrintContact.UseVisualStyleBackColor = false;
            this.buttonPrintContact.Click += new System.EventHandler(this.buttonPrintContact_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAll.FlatAppearance.BorderSize = 0;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.White;
            this.buttonShowAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonShowAll.Location = new System.Drawing.Point(353, 507);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(541, 43);
            this.buttonShowAll.TabIndex = 63;
            this.buttonShowAll.Text = "SHOW ALL";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // labelContactList
            // 
            this.labelContactList.AutoSize = true;
            this.labelContactList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactList.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelContactList.Location = new System.Drawing.Point(817, 12);
            this.labelContactList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContactList.Name = "labelContactList";
            this.labelContactList.Size = new System.Drawing.Size(196, 39);
            this.labelContactList.TabIndex = 62;
            this.labelContactList.Text = "Contact List";
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.BackColor = System.Drawing.Color.Pink;
            this.listBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxGroup.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.ItemHeight = 38;
            this.listBoxGroup.Location = new System.Drawing.Point(18, 64);
            this.listBoxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.Size = new System.Drawing.Size(309, 380);
            this.listBoxGroup.TabIndex = 60;
            this.listBoxGroup.Click += new System.EventHandler(this.listBoxGroup_Click);
            // 
            // dataGridViewContact
            // 
            this.dataGridViewContact.AllowUserToAddRows = false;
            this.dataGridViewContact.AllowUserToOrderColumns = true;
            this.dataGridViewContact.AllowUserToResizeColumns = false;
            this.dataGridViewContact.AllowUserToResizeRows = false;
            this.dataGridViewContact.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContact.Location = new System.Drawing.Point(353, 64);
            this.dataGridViewContact.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewContact.Name = "dataGridViewContact";
            this.dataGridViewContact.ReadOnly = true;
            this.dataGridViewContact.RowHeadersVisible = false;
            this.dataGridViewContact.RowHeadersWidth = 51;
            this.dataGridViewContact.RowTemplate.Height = 70;
            this.dataGridViewContact.Size = new System.Drawing.Size(1110, 436);
            this.dataGridViewContact.TabIndex = 61;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.Color.FloralWhite;
            this.labelContact.Location = new System.Drawing.Point(10, 12);
            this.labelContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(111, 39);
            this.labelContact.TabIndex = 59;
            this.labelContact.Text = "Group";
            // 
            // Show_Contact_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1521, 606);
            this.Controls.Add(this.buttonPrintContact);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.labelContactList);
            this.Controls.Add(this.listBoxGroup);
            this.Controls.Add(this.dataGridViewContact);
            this.Controls.Add(this.labelContact);
            this.Name = "Show_Contact_List_Form";
            this.Text = "Show_Contact_List_Form";
            this.Load += new System.EventHandler(this.Show_Contact_List_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintContact;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Label labelContactList;
        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.DataGridView dataGridViewContact;
        private System.Windows.Forms.Label labelContact;
    }
}