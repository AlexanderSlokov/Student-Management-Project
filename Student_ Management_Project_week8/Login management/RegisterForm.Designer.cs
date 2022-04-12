using System.Windows.Forms;

namespace Student_Management_Project_week8
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegisterUserName = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.RegisterSignInButton = new System.Windows.Forms.Button();
            this.labelBackToLogin = new System.Windows.Forms.Label();
            this.checkBoxSeePassRegister = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEreaser = new System.Windows.Forms.Button();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErrorUsername = new System.Windows.Forms.Label();
            this.labelErrorPasswordConfirm = new System.Windows.Forms.Label();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "So you are the new one...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password:";
            // 
            // textBoxRegisterUserName
            // 
            this.textBoxRegisterUserName.Location = new System.Drawing.Point(32, 84);
            this.textBoxRegisterUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterUserName.Name = "textBoxRegisterUserName";
            this.textBoxRegisterUserName.Size = new System.Drawing.Size(296, 22);
            this.textBoxRegisterUserName.TabIndex = 3;
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(32, 150);
            this.textBoxRegisterPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '•';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(296, 22);
            this.textBoxRegisterPassword.TabIndex = 2;
            // 
            // RegisterSignInButton
            // 
            this.RegisterSignInButton.BackColor = System.Drawing.Color.LightPink;
            this.RegisterSignInButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegisterSignInButton.Location = new System.Drawing.Point(31, 371);
            this.RegisterSignInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterSignInButton.Name = "RegisterSignInButton";
            this.RegisterSignInButton.Size = new System.Drawing.Size(296, 46);
            this.RegisterSignInButton.TabIndex = 5;
            this.RegisterSignInButton.Text = "SIGN ME IN!";
            this.RegisterSignInButton.UseVisualStyleBackColor = false;
            this.RegisterSignInButton.Click += new System.EventHandler(this.RegisterSignInButton_Click);
            // 
            // labelBackToLogin
            // 
            this.labelBackToLogin.AutoSize = true;
            this.labelBackToLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelBackToLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBackToLogin.Location = new System.Drawing.Point(84, 419);
            this.labelBackToLogin.Name = "labelBackToLogin";
            this.labelBackToLogin.Size = new System.Drawing.Size(243, 23);
            this.labelBackToLogin.TabIndex = 6;
            this.labelBackToLogin.Text = "Wait! I had an account before!";
            this.labelBackToLogin.Click += new System.EventHandler(this.labelBackToLogin_Click);
            // 
            // checkBoxSeePassRegister
            // 
            this.checkBoxSeePassRegister.AutoSize = true;
            this.checkBoxSeePassRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.checkBoxSeePassRegister.ForeColor = System.Drawing.Color.LightCoral;
            this.checkBoxSeePassRegister.Location = new System.Drawing.Point(31, 293);
            this.checkBoxSeePassRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxSeePassRegister.Name = "checkBoxSeePassRegister";
            this.checkBoxSeePassRegister.Size = new System.Drawing.Size(267, 27);
            this.checkBoxSeePassRegister.TabIndex = 7;
            this.checkBoxSeePassRegister.Text = "Can I see the Password again?";
            this.checkBoxSeePassRegister.UseVisualStyleBackColor = true;
            this.checkBoxSeePassRegister.CheckedChanged += new System.EventHandler(this.checkBoxSeePassRegister_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 444);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEreaser
            // 
            this.buttonEreaser.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEreaser.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonEreaser.Location = new System.Drawing.Point(31, 324);
            this.buttonEreaser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEreaser.Name = "buttonEreaser";
            this.buttonEreaser.Size = new System.Drawing.Size(296, 43);
            this.buttonEreaser.TabIndex = 9;
            this.buttonEreaser.Text = "Oops, do you have an erease?";
            this.buttonEreaser.UseVisualStyleBackColor = false;
            this.buttonEreaser.Click += new System.EventHandler(this.buttonEreaser_Click);
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Location = new System.Drawing.Point(32, 236);
            this.textBoxConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.PasswordChar = '•';
            this.textBoxConfirmPass.Size = new System.Drawing.Size(296, 22);
            this.textBoxConfirmPass.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(28, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "New password you just typed:";
            // 
            // labelErrorUsername
            // 
            this.labelErrorUsername.AutoSize = true;
            this.labelErrorUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelErrorUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.labelErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.labelErrorUsername.Location = new System.Drawing.Point(32, 108);
            this.labelErrorUsername.Name = "labelErrorUsername";
            this.labelErrorUsername.Size = new System.Drawing.Size(85, 20);
            this.labelErrorUsername.TabIndex = 12;
            this.labelErrorUsername.Text = "Error Notice";
            this.labelErrorUsername.Visible = false;
            // 
            // labelErrorPasswordConfirm
            // 
            this.labelErrorPasswordConfirm.AutoSize = true;
            this.labelErrorPasswordConfirm.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelErrorPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.labelErrorPasswordConfirm.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPasswordConfirm.Location = new System.Drawing.Point(31, 275);
            this.labelErrorPasswordConfirm.Name = "labelErrorPasswordConfirm";
            this.labelErrorPasswordConfirm.Size = new System.Drawing.Size(174, 20);
            this.labelErrorPasswordConfirm.TabIndex = 13;
            this.labelErrorPasswordConfirm.Text = "Pass Confirm Error Notice";
            this.labelErrorPasswordConfirm.Visible = false;
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPassword.Location = new System.Drawing.Point(32, 190);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(118, 20);
            this.labelErrorPassword.TabIndex = 14;
            this.labelErrorPassword.Text = "Pass Error Notice";
            this.labelErrorPassword.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(358, 590);
            this.Controls.Add(this.labelErrorPassword);
            this.Controls.Add(this.labelErrorPasswordConfirm);
            this.Controls.Add(this.labelErrorUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.buttonEreaser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxSeePassRegister);
            this.Controls.Add(this.labelBackToLogin);
            this.Controls.Add(this.RegisterSignInButton);
            this.Controls.Add(this.textBoxRegisterPassword);
            this.Controls.Add(this.textBoxRegisterUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxRegisterUserName;
        private TextBox textBoxRegisterPassword;
        private Button RegisterSignInButton;
        private Label labelBackToLogin;
        private CheckBox checkBoxSeePassRegister;
        private PictureBox pictureBox1;
        private Button buttonEreaser;
        private TextBox textBoxConfirmPass;
        private Label label5;
        private Label labelErrorUsername;
        private Label labelErrorPasswordConfirm;
        private Label labelErrorPassword;
    }
}