using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Student_Management_Project_week8.Form1;

namespace Student_Management_Project_week8.HR_Management.Contact_Forms
{
    public partial class Show_Contact_List_Form : Form
    {
        public Show_Contact_List_Form()
        {
            InitializeComponent();
        }

        MY_DB myDB = new MY_DB();
        GROUP group = new GROUP();
        CONTACT contact = new CONTACT();
        bool all;
        int groupID;

        private void Show_Contact_List_Form_Load(object sender, EventArgs e)
        {
            FillGrid(true, 0);
            listBoxGroup.DisplayMember = "name";
            listBoxGroup.ValueMember = "id";
            listBoxGroup.DataSource = group.GetGroups(GLOBAL.CurrentUserID);
        }

        public void FillGrid(bool all, int groupID)
        {
            if (all)
            {
                string query = contact.FullContactList(all);
                SqlCommand command = new SqlCommand(query);

                command.Connection = myDB.GetConnection;
                command.Parameters.Add("@userID", SqlDbType.Int).Value = GLOBAL.CurrentUserID;

                myDB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();

                adapter.Fill(table);
                myDB.closeConnection();
                dataGridViewContact.DataSource = table;
            }
            else
            {
                string query = contact.FullContactList(all);
                SqlCommand command = new SqlCommand(query);

                command.Connection = myDB.GetConnection;
                command.Parameters.Add("@userID", SqlDbType.Int).Value = GLOBAL.CurrentUserID;
                command.Parameters.Add("@groupID", SqlDbType.Int).Value = groupID;
                myDB.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable table = new System.Data.DataTable();

                adapter.Fill(table);
                myDB.closeConnection();
                dataGridViewContact.DataSource = table;
            }

            dataGridViewContact.Columns[0].Width = 50;
            dataGridViewContact.Columns[1].Width = 100;
            dataGridViewContact.Columns[2].Width = 50;
            dataGridViewContact.Columns[3].Width = 50;
            dataGridViewContact.Columns[4].Width = 100;
            dataGridViewContact.Columns[5].Width = 150;
            dataGridViewContact.Columns[6].Width = 150;
            dataGridViewContact.Columns[7].Width = 120;
            ((DataGridViewImageColumn)dataGridViewContact.Columns[7]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.dataGridViewContact.Sort(this.dataGridViewContact.Columns[0], ListSortDirection.Ascending);
        }

        private void listBoxGroup_Click(object sender, EventArgs e)
        {
            all = false;

            if (listBoxGroup.Items.Count > 0)
            {
                groupID = Int32.Parse(listBoxGroup.SelectedValue.ToString());
                FillGrid(all, groupID);
            }

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            all = true;
            groupID = 0;
            FillGrid(all, groupID);
        }

        private void buttonPrintContact_Click(object sender, EventArgs e)
        {
            CreateDocument(dataGridViewContact);
        }

        private void CreateDocument(DataGridView dataGridView)
        {
            int noScores = dataGridView.RowCount + 1;
            try
            {
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  
                //winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                //winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                document.Application.Visible = true;

                document.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //Add header into the document  
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.  
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 30;
                    headerRange.Text = "Danh Sách Liên Lạc";
                }

                //Add the footers into the document  
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.  
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "ĐẠI HỌC SƯ PHẠM KỸ THUẬT";
                }

                //adding text to document 
                /*
                document.Content.SetRange(0, 0);
                document.Content.Text = "CLASS: 191100CLC01 " + Environment.NewLine;
                */

                //Add paragraph with Heading 1 style  
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "Phòng Đào Tạo";
                para1.Range.InsertParagraphAfter();
                /*
                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "CLASS: 191100CLC01";
                para2.Range.InsertParagraphAfter();
                */
                Table coursesTable = document.Tables.Add(para1.Range, noScores, 8, ref missing, ref missing);
                coursesTable.Borders.Enable = 1;
                //Create a iXj table and insert some dummy record  
                /*
                studentTable.Cell(1, 1).Range.Text = "ID";
                studentTable.Cell(2, 1).Range.Text = "First Name";
                studentTable.Cell(3, 1).Range.Text = "Last Name";
                studentTable.Cell(4, 1).Range.Text = "Birthdate";
                studentTable.Cell(5, 1).Range.Text = "Gender";
                studentTable.Cell(6, 1).Range.Text = "Phone";
                studentTable.Cell(7, 1).Range.Text = "Address";
                studentTable.Cell(8, 1).Range.Text = "Picture";
                */
                foreach (Row row in coursesTable.Rows)
                {
                    //
                    foreach (Cell cell in row.Cells)
                    {
                        //Header row  
                        if (cell.RowIndex == 1)
                        {
                            int index = cell.ColumnIndex;
                            switch (index)
                            {
                                case 1:
                                    cell.Range.Text = "Contact ID";
                                    break;
                                case 2:
                                    cell.Range.Text = "First Name";
                                    break;
                                case 3:
                                    cell.Range.Text = "Last Name";
                                    break;
                                case 4:
                                    cell.Range.Text = "Group Name";
                                    break;
                                case 5:
                                    cell.Range.Text = "Phone";
                                    break;
                                case 6:
                                    cell.Range.Text = "Email";
                                    break;
                                case 7:
                                    cell.Range.Text = "Address";
                                    break;
                                case 8:
                                    cell.Range.Text = "Picture";
                                    break;
                            }
                            //cell.Range.Text = ((dataIndex) index).ToString();
                            cell.Range.Font.Bold = 1;
                            //other format properties goes here  
                            cell.Range.Font.Name = "verdana";
                            cell.Range.Font.Size = 8;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells  
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        }
                        //Data row  
                        else
                        {
                            int index = cell.ColumnIndex;
                            switch (index)
                            {

                                case 1:
                                    //cell.Range.Text = reader["id"].ToString();
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 2:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 3:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 4:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 5:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 6:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 7:
                                    cell.Range.Text = dataGridView[index - 1, cell.RowIndex - 2].Value.ToString();
                                    break;
                                case 8:
                                    byte[] imgbyte = (byte[])dataGridView[index - 1, cell.RowIndex - 2].Value;
                                    MemoryStream ms = new MemoryStream(imgbyte);
                                    //Image sparePicture = Image.FromStream(ms);
                                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(100, 100)));
                                    Clipboard.SetDataObject(finalPic);
                                    //document = document.Content.Paragraphs.Add();
                                    //document = document.Content.Paragraphs.Add(ref missing);
                                    cell.Range.Paste();
                                    cell.Range.InsertParagraphAfter();
                                    break;
                            }
                        }
                    }
                    //
                }
                //Save the document  
                object filename = @"E:\\Contact List.docx";
                //document.SaveAs2(ref filename);
                //document.Close(ref missing, ref missing, ref missing);
                //document = null;
                //winword.Quit(ref missing, ref missing, ref missing);
                //winword = null;
                MessageBox.Show("Document created successfully !");
                myDB.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
