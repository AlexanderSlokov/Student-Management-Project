namespace Student_Management_Project_week8
{
    partial class HumanResourceMain
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
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEditInfo = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelContactTools = new System.Windows.Forms.Panel();
            this.buttonContact_ShowFullList = new System.Windows.Forms.Button();
            this.buttonContact_Edit = new System.Windows.Forms.Button();
            this.buttonContact_Add = new System.Windows.Forms.Button();
            this.panelRmove_ContactID = new System.Windows.Forms.Panel();
            this.labelRemoveContact = new System.Windows.Forms.Label();
            this.buttonContact_Remove = new System.Windows.Forms.Button();
            this.labelContact = new System.Windows.Forms.Label();
            this.buttonContact_SelectContact = new System.Windows.Forms.Button();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.labelEnterContactID = new System.Windows.Forms.Label();
            this.labelGroupList = new System.Windows.Forms.Label();
            this.dataGridViewGroupList = new System.Windows.Forms.DataGridView();
            this.panelGroup_AddGroup = new System.Windows.Forms.Panel();
            this.buttonGroup_Delete = new System.Windows.Forms.Button();
            this.buttonGroup_Edit = new System.Windows.Forms.Button();
            this.labelAddNewGroup = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxEnter_GroupID = new System.Windows.Forms.TextBox();
            this.buttonGroup_Add = new System.Windows.Forms.Button();
            this.textBoxEnter_GroupName = new System.Windows.Forms.TextBox();
            this.labelEnterGroupName = new System.Windows.Forms.Label();
            this.panelToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelContactTools.SuspendLayout();
            this.panelRmove_ContactID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupList)).BeginInit();
            this.panelGroup_AddGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelToolBar.Controls.Add(this.labelLogOut);
            this.panelToolBar.Controls.Add(this.pictureBoxUser);
            this.panelToolBar.Controls.Add(this.panel1);
            this.panelToolBar.Controls.Add(this.labelEditInfo);
            this.panelToolBar.Controls.Add(this.labelUserName);
            this.panelToolBar.Controls.Add(this.labelWelcome);
            this.panelToolBar.Location = new System.Drawing.Point(13, 13);
            this.panelToolBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(1059, 135);
            this.panelToolBar.TabIndex = 2;
            // 
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLogOut.Location = new System.Drawing.Point(167, 79);
            this.labelLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(69, 20);
            this.labelLogOut.TabIndex = 49;
            this.labelLogOut.Text = "Log Out";
            this.labelLogOut.Click += new System.EventHandler(this.labelLogOut_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBoxUser.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(156, 126);
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(272, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 62);
            this.panel1.TabIndex = 48;
            // 
            // labelEditInfo
            // 
            this.labelEditInfo.AutoSize = true;
            this.labelEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEditInfo.Location = new System.Drawing.Point(167, 59);
            this.labelEditInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEditInfo.Name = "labelEditInfo";
            this.labelEditInfo.Size = new System.Drawing.Size(97, 20);
            this.labelEditInfo.TabIndex = 47;
            this.labelEditInfo.Text = "Edit My Info";
            this.labelEditInfo.Click += new System.EventHandler(this.labelEditInfo_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelUserName.Location = new System.Drawing.Point(286, 6);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(132, 29);
            this.labelUserName.TabIndex = 43;
            this.labelUserName.Text = "MANAGER";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Moccasin;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.labelWelcome.Location = new System.Drawing.Point(166, 6);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(115, 29);
            this.labelWelcome.TabIndex = 42;
            this.labelWelcome.Text = "Welcome";
            // 
            // panelContactTools
            // 
            this.panelContactTools.BackColor = System.Drawing.Color.Cornsilk;
            this.panelContactTools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContactTools.Controls.Add(this.buttonContact_ShowFullList);
            this.panelContactTools.Controls.Add(this.buttonContact_Edit);
            this.panelContactTools.Controls.Add(this.buttonContact_Add);
            this.panelContactTools.Location = new System.Drawing.Point(13, 454);
            this.panelContactTools.Margin = new System.Windows.Forms.Padding(4);
            this.panelContactTools.Name = "panelContactTools";
            this.panelContactTools.Size = new System.Drawing.Size(503, 195);
            this.panelContactTools.TabIndex = 65;
            // 
            // buttonContact_ShowFullList
            // 
            this.buttonContact_ShowFullList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonContact_ShowFullList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContact_ShowFullList.FlatAppearance.BorderSize = 0;
            this.buttonContact_ShowFullList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContact_ShowFullList.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonContact_ShowFullList.ForeColor = System.Drawing.Color.Aqua;
            this.buttonContact_ShowFullList.Location = new System.Drawing.Point(8, 106);
            this.buttonContact_ShowFullList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContact_ShowFullList.Name = "buttonContact_ShowFullList";
            this.buttonContact_ShowFullList.Size = new System.Drawing.Size(472, 65);
            this.buttonContact_ShowFullList.TabIndex = 57;
            this.buttonContact_ShowFullList.Text = "Show Full List";
            this.buttonContact_ShowFullList.UseVisualStyleBackColor = false;
            this.buttonContact_ShowFullList.Click += new System.EventHandler(this.buttonContact_ShowFullList_Click);
            // 
            // buttonContact_Edit
            // 
            this.buttonContact_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonContact_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContact_Edit.FlatAppearance.BorderSize = 0;
            this.buttonContact_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContact_Edit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonContact_Edit.ForeColor = System.Drawing.Color.Aqua;
            this.buttonContact_Edit.Location = new System.Drawing.Point(253, 25);
            this.buttonContact_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContact_Edit.Name = "buttonContact_Edit";
            this.buttonContact_Edit.Size = new System.Drawing.Size(226, 74);
            this.buttonContact_Edit.TabIndex = 52;
            this.buttonContact_Edit.Text = "Edit A Contact";
            this.buttonContact_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonContact_Edit.UseVisualStyleBackColor = false;
            this.buttonContact_Edit.Click += new System.EventHandler(this.buttonContact_Edit_Click);
            // 
            // buttonContact_Add
            // 
            this.buttonContact_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonContact_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContact_Add.FlatAppearance.BorderSize = 0;
            this.buttonContact_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContact_Add.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonContact_Add.ForeColor = System.Drawing.Color.Aqua;
            this.buttonContact_Add.Location = new System.Drawing.Point(9, 25);
            this.buttonContact_Add.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContact_Add.Name = "buttonContact_Add";
            this.buttonContact_Add.Size = new System.Drawing.Size(230, 74);
            this.buttonContact_Add.TabIndex = 51;
            this.buttonContact_Add.Text = "Add A Contact";
            this.buttonContact_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonContact_Add.UseVisualStyleBackColor = false;
            this.buttonContact_Add.Click += new System.EventHandler(this.buttonContact_Add_Click);
            // 
            // panelRmove_ContactID
            // 
            this.panelRmove_ContactID.BackColor = System.Drawing.Color.Cornsilk;
            this.panelRmove_ContactID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRmove_ContactID.Controls.Add(this.labelRemoveContact);
            this.panelRmove_ContactID.Controls.Add(this.buttonContact_Remove);
            this.panelRmove_ContactID.Controls.Add(this.labelContact);
            this.panelRmove_ContactID.Controls.Add(this.buttonContact_SelectContact);
            this.panelRmove_ContactID.Controls.Add(this.textBoxContactID);
            this.panelRmove_ContactID.Controls.Add(this.labelEnterContactID);
            this.panelRmove_ContactID.Location = new System.Drawing.Point(13, 151);
            this.panelRmove_ContactID.Margin = new System.Windows.Forms.Padding(4);
            this.panelRmove_ContactID.Name = "panelRmove_ContactID";
            this.panelRmove_ContactID.Size = new System.Drawing.Size(503, 294);
            this.panelRmove_ContactID.TabIndex = 64;
            // 
            // labelRemoveContact
            // 
            this.labelRemoveContact.AutoSize = true;
            this.labelRemoveContact.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveContact.ForeColor = System.Drawing.Color.Chocolate;
            this.labelRemoveContact.Location = new System.Drawing.Point(3, 171);
            this.labelRemoveContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemoveContact.Name = "labelRemoveContact";
            this.labelRemoveContact.Size = new System.Drawing.Size(186, 28);
            this.labelRemoveContact.TabIndex = 65;
            this.labelRemoveContact.Text = "Remove A Contact";
            // 
            // buttonContact_Remove
            // 
            this.buttonContact_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonContact_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContact_Remove.FlatAppearance.BorderSize = 0;
            this.buttonContact_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContact_Remove.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonContact_Remove.ForeColor = System.Drawing.Color.Aqua;
            this.buttonContact_Remove.Location = new System.Drawing.Point(9, 203);
            this.buttonContact_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContact_Remove.Name = "buttonContact_Remove";
            this.buttonContact_Remove.Size = new System.Drawing.Size(484, 41);
            this.buttonContact_Remove.TabIndex = 56;
            this.buttonContact_Remove.Text = "Remove";
            this.buttonContact_Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonContact_Remove.UseVisualStyleBackColor = false;
            this.buttonContact_Remove.Click += new System.EventHandler(this.buttonContact_Remove_Click);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Nirmala UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.Color.Green;
            this.labelContact.Location = new System.Drawing.Point(184, 0);
            this.labelContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(117, 37);
            this.labelContact.TabIndex = 63;
            this.labelContact.Text = "Contact";
            // 
            // buttonContact_SelectContact
            // 
            this.buttonContact_SelectContact.BackColor = System.Drawing.Color.Maroon;
            this.buttonContact_SelectContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContact_SelectContact.FlatAppearance.BorderSize = 0;
            this.buttonContact_SelectContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContact_SelectContact.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonContact_SelectContact.ForeColor = System.Drawing.Color.Aqua;
            this.buttonContact_SelectContact.Location = new System.Drawing.Point(356, 126);
            this.buttonContact_SelectContact.Margin = new System.Windows.Forms.Padding(4);
            this.buttonContact_SelectContact.Name = "buttonContact_SelectContact";
            this.buttonContact_SelectContact.Size = new System.Drawing.Size(137, 33);
            this.buttonContact_SelectContact.TabIndex = 55;
            this.buttonContact_SelectContact.Text = "Select Contact";
            this.buttonContact_SelectContact.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonContact_SelectContact.UseVisualStyleBackColor = false;
            this.buttonContact_SelectContact.Click += new System.EventHandler(this.buttonContact_SelectContact_Click);
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxContactID.Location = new System.Drawing.Point(9, 130);
            this.textBoxContactID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactID.Multiline = true;
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.Size = new System.Drawing.Size(327, 32);
            this.textBoxContactID.TabIndex = 45;
            // 
            // labelEnterContactID
            // 
            this.labelEnterContactID.AutoSize = true;
            this.labelEnterContactID.BackColor = System.Drawing.Color.Cornsilk;
            this.labelEnterContactID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelEnterContactID.ForeColor = System.Drawing.Color.Black;
            this.labelEnterContactID.Location = new System.Drawing.Point(11, 91);
            this.labelEnterContactID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnterContactID.Name = "labelEnterContactID";
            this.labelEnterContactID.Size = new System.Drawing.Size(147, 23);
            this.labelEnterContactID.TabIndex = 44;
            this.labelEnterContactID.Text = "Enter Contact ID:";
            // 
            // labelGroupList
            // 
            this.labelGroupList.AutoSize = true;
            this.labelGroupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupList.ForeColor = System.Drawing.Color.Chocolate;
            this.labelGroupList.Location = new System.Drawing.Point(727, 380);
            this.labelGroupList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroupList.Name = "labelGroupList";
            this.labelGroupList.Size = new System.Drawing.Size(182, 39);
            this.labelGroupList.TabIndex = 70;
            this.labelGroupList.Text = "Group List:";
            // 
            // dataGridViewGroupList
            // 
            this.dataGridViewGroupList.AllowUserToAddRows = false;
            this.dataGridViewGroupList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroupList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewGroupList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewGroupList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroupList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewGroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupList.Location = new System.Drawing.Point(569, 433);
            this.dataGridViewGroupList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewGroupList.Name = "dataGridViewGroupList";
            this.dataGridViewGroupList.RowHeadersVisible = false;
            this.dataGridViewGroupList.RowHeadersWidth = 51;
            this.dataGridViewGroupList.Size = new System.Drawing.Size(497, 217);
            this.dataGridViewGroupList.TabIndex = 69;
            // 
            // panelGroup_AddGroup
            // 
            this.panelGroup_AddGroup.BackColor = System.Drawing.Color.Cornsilk;
            this.panelGroup_AddGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGroup_AddGroup.Controls.Add(this.buttonGroup_Delete);
            this.panelGroup_AddGroup.Controls.Add(this.buttonGroup_Edit);
            this.panelGroup_AddGroup.Controls.Add(this.labelAddNewGroup);
            this.panelGroup_AddGroup.Controls.Add(this.labelGroup);
            this.panelGroup_AddGroup.Controls.Add(this.labelID);
            this.panelGroup_AddGroup.Controls.Add(this.textBoxEnter_GroupID);
            this.panelGroup_AddGroup.Controls.Add(this.buttonGroup_Add);
            this.panelGroup_AddGroup.Controls.Add(this.textBoxEnter_GroupName);
            this.panelGroup_AddGroup.Controls.Add(this.labelEnterGroupName);
            this.panelGroup_AddGroup.Location = new System.Drawing.Point(569, 151);
            this.panelGroup_AddGroup.Margin = new System.Windows.Forms.Padding(4);
            this.panelGroup_AddGroup.Name = "panelGroup_AddGroup";
            this.panelGroup_AddGroup.Size = new System.Drawing.Size(503, 224);
            this.panelGroup_AddGroup.TabIndex = 68;
            // 
            // buttonGroup_Delete
            // 
            this.buttonGroup_Delete.BackColor = System.Drawing.Color.DarkRed;
            this.buttonGroup_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroup_Delete.FlatAppearance.BorderSize = 0;
            this.buttonGroup_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroup_Delete.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonGroup_Delete.ForeColor = System.Drawing.Color.Aqua;
            this.buttonGroup_Delete.Location = new System.Drawing.Point(360, 171);
            this.buttonGroup_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroup_Delete.Name = "buttonGroup_Delete";
            this.buttonGroup_Delete.Size = new System.Drawing.Size(112, 33);
            this.buttonGroup_Delete.TabIndex = 66;
            this.buttonGroup_Delete.Text = "Delete";
            this.buttonGroup_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGroup_Delete.UseVisualStyleBackColor = false;
            this.buttonGroup_Delete.Click += new System.EventHandler(this.buttonGroup_Delete_Click);
            // 
            // buttonGroup_Edit
            // 
            this.buttonGroup_Edit.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonGroup_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroup_Edit.FlatAppearance.BorderSize = 0;
            this.buttonGroup_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroup_Edit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonGroup_Edit.ForeColor = System.Drawing.Color.Blue;
            this.buttonGroup_Edit.Location = new System.Drawing.Point(185, 171);
            this.buttonGroup_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroup_Edit.Name = "buttonGroup_Edit";
            this.buttonGroup_Edit.Size = new System.Drawing.Size(144, 33);
            this.buttonGroup_Edit.TabIndex = 65;
            this.buttonGroup_Edit.Text = "Edit";
            this.buttonGroup_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGroup_Edit.UseVisualStyleBackColor = false;
            this.buttonGroup_Edit.Click += new System.EventHandler(this.buttonGroup_Edit_Click);
            // 
            // labelAddNewGroup
            // 
            this.labelAddNewGroup.AutoSize = true;
            this.labelAddNewGroup.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelAddNewGroup.ForeColor = System.Drawing.Color.Chocolate;
            this.labelAddNewGroup.Location = new System.Drawing.Point(11, 76);
            this.labelAddNewGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddNewGroup.Name = "labelAddNewGroup";
            this.labelAddNewGroup.Size = new System.Drawing.Size(157, 23);
            this.labelAddNewGroup.TabIndex = 64;
            this.labelAddNewGroup.Text = "Add A New Group";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Nirmala UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.ForeColor = System.Drawing.Color.Green;
            this.labelGroup.Location = new System.Drawing.Point(219, -1);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(97, 37);
            this.labelGroup.TabIndex = 67;
            this.labelGroup.Text = "Group";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Cornsilk;
            this.labelID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelID.ForeColor = System.Drawing.Color.Black;
            this.labelID.Location = new System.Drawing.Point(80, 136);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(88, 23);
            this.labelID.TabIndex = 58;
            this.labelID.Text = "Group ID:";
            // 
            // textBoxEnter_GroupID
            // 
            this.textBoxEnter_GroupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxEnter_GroupID.Location = new System.Drawing.Point(185, 130);
            this.textBoxEnter_GroupID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnter_GroupID.Multiline = true;
            this.textBoxEnter_GroupID.Name = "textBoxEnter_GroupID";
            this.textBoxEnter_GroupID.Size = new System.Drawing.Size(287, 32);
            this.textBoxEnter_GroupID.TabIndex = 57;
            // 
            // buttonGroup_Add
            // 
            this.buttonGroup_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonGroup_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroup_Add.FlatAppearance.BorderSize = 0;
            this.buttonGroup_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroup_Add.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonGroup_Add.ForeColor = System.Drawing.Color.Aqua;
            this.buttonGroup_Add.Location = new System.Drawing.Point(8, 171);
            this.buttonGroup_Add.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroup_Add.Name = "buttonGroup_Add";
            this.buttonGroup_Add.Size = new System.Drawing.Size(146, 33);
            this.buttonGroup_Add.TabIndex = 56;
            this.buttonGroup_Add.Text = "Add";
            this.buttonGroup_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonGroup_Add.UseVisualStyleBackColor = false;
            this.buttonGroup_Add.Click += new System.EventHandler(this.buttonGroup_Add_Click);
            // 
            // textBoxEnter_GroupName
            // 
            this.textBoxEnter_GroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxEnter_GroupName.Location = new System.Drawing.Point(185, 90);
            this.textBoxEnter_GroupName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnter_GroupName.Multiline = true;
            this.textBoxEnter_GroupName.Name = "textBoxEnter_GroupName";
            this.textBoxEnter_GroupName.Size = new System.Drawing.Size(287, 32);
            this.textBoxEnter_GroupName.TabIndex = 45;
            // 
            // labelEnterGroupName
            // 
            this.labelEnterGroupName.AutoSize = true;
            this.labelEnterGroupName.BackColor = System.Drawing.Color.Cornsilk;
            this.labelEnterGroupName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelEnterGroupName.ForeColor = System.Drawing.Color.Black;
            this.labelEnterGroupName.Location = new System.Drawing.Point(4, 99);
            this.labelEnterGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnterGroupName.Name = "labelEnterGroupName";
            this.labelEnterGroupName.Size = new System.Drawing.Size(164, 23);
            this.labelEnterGroupName.TabIndex = 44;
            this.labelEnterGroupName.Text = "Enter Group Name:";
            // 
            // HumanResourceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1085, 657);
            this.Controls.Add(this.labelGroupList);
            this.Controls.Add(this.dataGridViewGroupList);
            this.Controls.Add(this.panelGroup_AddGroup);
            this.Controls.Add(this.panelContactTools);
            this.Controls.Add(this.panelRmove_ContactID);
            this.Controls.Add(this.panelToolBar);
            this.Name = "HumanResourceMain";
            this.Text = "HumanResourceMain";
            this.Load += new System.EventHandler(this.HumanResourceMain_Load);
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelContactTools.ResumeLayout(false);
            this.panelRmove_ContactID.ResumeLayout(false);
            this.panelRmove_ContactID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupList)).EndInit();
            this.panelGroup_AddGroup.ResumeLayout(false);
            this.panelGroup_AddGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.Label labelLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEditInfo;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panelContactTools;
        private System.Windows.Forms.Button buttonContact_ShowFullList;
        private System.Windows.Forms.Button buttonContact_Edit;
        private System.Windows.Forms.Button buttonContact_Add;
        private System.Windows.Forms.Panel panelRmove_ContactID;
        private System.Windows.Forms.Label labelRemoveContact;
        private System.Windows.Forms.Button buttonContact_Remove;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button buttonContact_SelectContact;
        private System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.Label labelEnterContactID;
        private System.Windows.Forms.Label labelGroupList;
        private System.Windows.Forms.DataGridView dataGridViewGroupList;
        private System.Windows.Forms.Panel panelGroup_AddGroup;
        private System.Windows.Forms.Button buttonGroup_Delete;
        private System.Windows.Forms.Button buttonGroup_Edit;
        private System.Windows.Forms.Label labelAddNewGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxEnter_GroupID;
        private System.Windows.Forms.Button buttonGroup_Add;
        private System.Windows.Forms.TextBox textBoxEnter_GroupName;
        private System.Windows.Forms.Label labelEnterGroupName;
    }
}