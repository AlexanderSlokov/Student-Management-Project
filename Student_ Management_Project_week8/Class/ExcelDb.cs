using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace Student_Management_Project_week8.Class
{
    public class ExcelDb
    {
        public void exportToExcel(DataGridView datagrid, string location_Slash_string, string File_name)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            //get header
            for (int i = 0; i < datagrid.Columns.Count; i++)
            {
                obj.Cells[1, i + 1] = datagrid.Columns[i].HeaderText;
            }
            for (int i = 0; i < datagrid.Rows.Count + 1; i++)
            {
                for ( int j = 0; j < datagrid.Columns.Count; j++)
                {
                    if (datagrid.Rows[i].Cells[j].Value != null)
                    {                    
                        obj.Cells[i + 2, j + 1] = datagrid.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            obj.ActiveWorkbook.SaveCopyAs(location_Slash_string + File_name + "xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        
    }
}
