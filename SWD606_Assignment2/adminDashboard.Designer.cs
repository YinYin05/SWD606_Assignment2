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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 30);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome, Admin!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 100);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Company Name : ";
            // 
            // txtCompany
            // 
            txtCompany.Enabled = false;
            txtCompany.Location = new Point(191, 97);
            txtCompany.Name = "txtCompany";
            txtCompany.ReadOnly = true;
            txtCompany.Size = new Size(227, 27);
            txtCompany.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLeave);
            panel1.Controls.Add(btnPayroll);
            panel1.Controls.Add(btnEmployees);
            panel1.Location = new Point(443, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 243);
            panel1.TabIndex = 3;
            // 
            // btnLeave
            // 
            btnLeave.Location = new Point(93, 162);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(117, 49);
            btnLeave.TabIndex = 2;
            btnLeave.Text = "Leave Management";
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Click += btnLeave_Click;
            // 
            // btnPayroll
            // 
            btnPayroll.Location = new Point(93, 97);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Size = new Size(117, 49);
            btnPayroll.TabIndex = 1;
            btnPayroll.Text = "Payroll";
            btnPayroll.UseVisualStyleBackColor = true;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(93, 33);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(117, 49);
            btnEmployees.TabIndex = 0;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // txtAddress
            // 
            txtAddress.Enabled = false;
            txtAddress.Location = new Point(191, 133);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(227, 79);
            txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 151);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Address :";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(191, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(227, 27);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 221);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 6;
            label4.Text = "Email :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Location = new Point(191, 262);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(227, 27);
            txtPhoneNumber.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 265);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 8;
            label5.Text = "Phone Number :";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(48, 314);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(162, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(335, 392);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtCompany);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "adminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
    }
}