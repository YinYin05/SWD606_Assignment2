namespace SWD606_Assignment2
{
    partial class adminDashboard
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
            label1 = new Label();
            label2 = new Label();
            txtCompany = new TextBox();
            panel1 = new Panel();
            btnLeave = new Button();
            btnPayroll = new Button();
            btnEmployees = new Button();
            txtAddress = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            btnEdit = new Button();
            btnSave = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 21);
            label1.Name = "label1";
            label1.Size = new Size(339, 44);
            label1.TabIndex = 0;
            label1.Text = "Welcome, Admin!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 111);
            label2.Name = "label2";
            label2.Size = new Size(192, 23);
            label2.TabIndex = 1;
            label2.Text = "Company Name : ";
            // 
            // txtCompany
            // 
            txtCompany.Enabled = false;
            txtCompany.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtCompany.ForeColor = Color.Black;
            txtCompany.Location = new Point(226, 109);
            txtCompany.Name = "txtCompany";
            txtCompany.ReadOnly = true;
            txtCompany.Size = new Size(365, 32);
            txtCompany.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btnLeave);
            panel1.Controls.Add(btnPayroll);
            panel1.Controls.Add(btnEmployees);
            panel1.Location = new Point(617, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 225);
            panel1.TabIndex = 3;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.FromArgb(255, 128, 255);
            btnLeave.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLeave.Location = new Point(47, 151);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(216, 60);
            btnLeave.TabIndex = 2;
            btnLeave.Text = "Leave Management";
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnPayroll
            // 
            btnPayroll.BackColor = Color.FromArgb(192, 192, 255);
            btnPayroll.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnPayroll.Location = new Point(47, 84);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(216, 60);
            btnPayroll.TabIndex = 1;
            btnPayroll.Text = "Payroll";
            btnPayroll.UseVisualStyleBackColor = false;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.Cyan;
            btnEmployees.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnEmployees.Location = new Point(47, 17);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(216, 60);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // txtAddress
            // 
            txtAddress.Enabled = false;
            txtAddress.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtAddress.ForeColor = Color.Black;
            txtAddress.Location = new Point(226, 148);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(365, 102);
            txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(24, 154);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "Address :";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(226, 259);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(365, 32);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(24, 262);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 6;
            label4.Text = "Email :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtPhoneNumber.ForeColor = Color.Black;
            txtPhoneNumber.Location = new Point(226, 300);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(365, 32);
            txtPhoneNumber.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(24, 303);
            label5.Name = "label5";
            label5.Size = new Size(167, 23);
            label5.TabIndex = 8;
            label5.Text = "Phone Number :";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 255, 128);
            btnEdit.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnEdit.Location = new Point(280, 363);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 60);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnSave.Location = new Point(406, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 60);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(532, 363);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 60);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(txtCompany);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtAddress);
            panel2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 439);
            panel2.TabIndex = 13;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(962, 463);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "adminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCompany;
        private Panel panel1;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label5;
        private Button btnEdit;
        private Button btnSave;
        private Button btnExit;
        private Button btnLeave;
        private Button btnPayroll;
        private Button btnEmployees;
        private Panel panel2;
    }
}