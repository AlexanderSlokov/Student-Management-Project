using System.Windows.Forms;
using System.Drawing;
namespace Student_Management_Project_week8
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOrDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAStudentToolStripMenuItem,
            this.updateOrDeleteToolStripMenuItem,
            this.seeStudentListToolStripMenuItem,
            this.printViewToolStripMenuItem,
            this.staticToolStripMenuItem,
            this.manageStudentToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sTUDENTToolStripMenuItem.ForeColor = System.Drawing.Color.LightSalmon;
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // addAStudentToolStripMenuItem
            // 
            this.addAStudentToolStripMenuItem.BackColor = System.Drawing.Color.SeaShell;
            this.addAStudentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addAStudentToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSalmon;
            this.addAStudentToolStripMenuItem.Name = "addAStudentToolStripMenuItem";
            this.addAStudentToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.addAStudentToolStripMenuItem.Text = "Add a student";
            this.addAStudentToolStripMenuItem.Click += new System.EventHandler(this.addAStudentToolStripMenuItem_Click);
            // 
            // updateOrDeleteToolStripMenuItem
            // 
            this.updateOrDeleteToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.updateOrDeleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.updateOrDeleteToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSalmon;
            this.updateOrDeleteToolStripMenuItem.Name = "updateOrDeleteToolStripMenuItem";
            this.updateOrDeleteToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.updateOrDeleteToolStripMenuItem.Text = "Update or Delete";
            this.updateOrDeleteToolStripMenuItem.Click += new System.EventHandler(this.updateOrDeleteToolStripMenuItem_Click);
            // 
            // seeStudentListToolStripMenuItem
            // 
            this.seeStudentListToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.seeStudentListToolStripMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.seeStudentListToolStripMenuItem.Name = "seeStudentListToolStripMenuItem";
            this.seeStudentListToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.seeStudentListToolStripMenuItem.Text = "See Student List";
            this.seeStudentListToolStripMenuItem.Click += new System.EventHandler(this.seeStudentListToolStripMenuItem_Click);
            // 
            // printViewToolStripMenuItem
            // 
            this.printViewToolStripMenuItem.Name = "printViewToolStripMenuItem";
            this.printViewToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.printViewToolStripMenuItem.Text = "Print View";
            this.printViewToolStripMenuItem.Click += new System.EventHandler(this.printViewToolStripMenuItem_Click);
            // 
            // staticToolStripMenuItem
            // 
            this.staticToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.staticToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.staticToolStripMenuItem.Name = "staticToolStripMenuItem";
            this.staticToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.staticToolStripMenuItem.Text = "Static";
            this.staticToolStripMenuItem.Click += new System.EventHandler(this.staticToolStripMenuItem_Click);
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            this.manageStudentToolStripMenuItem.Click += new System.EventHandler(this.manageStudentToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 480);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sTUDENTToolStripMenuItem;
        private ToolStripMenuItem addAStudentToolStripMenuItem;
        private ToolStripMenuItem updateOrDeleteToolStripMenuItem;
        private ToolStripMenuItem seeStudentListToolStripMenuItem;
        private ToolStripMenuItem printViewToolStripMenuItem;
        private ToolStripMenuItem staticToolStripMenuItem;
        private ToolStripMenuItem manageStudentToolStripMenuItem;
    }
}