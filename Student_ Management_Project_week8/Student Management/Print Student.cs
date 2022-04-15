using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Student_Management_Project_week8;
namespace Student_Management_Project_week8.Student_Management
{
    public partial class Print_Student : Form
    {
        public Print_Student()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        private void buttonPrintCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
