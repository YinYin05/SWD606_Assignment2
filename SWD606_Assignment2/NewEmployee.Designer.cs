namespace SWD606_Assignment2
{
    partial class NewEmployee
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
            btnCancel = new Button();
            btnSave = new Button();
            txtRole = new TextBox();
            label10 = new Label();
            txtPassword = new TextBox();
            label9 = new Label();
            txtHourlyRate = new TextBox();
            label8 = new Label();
            txtPosition = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(256, 465);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 51);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            btnSave.Location = new Point(120, 465);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 51);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtRole.Location = new Point(148, 401);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(291, 32);
            txtRole.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label10.Location = new Point(24, 404);
            label10.Name = "label10";
            label10.Size = new Size(53, 23);
            label10.TabIndex = 40;
            label10.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(148, 366);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(291, 32);
            txtPassword.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label9.Location = new Point(24, 369);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 38;
            label9.Text = "Password";
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtHourlyRate.Location = new Point(148, 331);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(291, 32);
            txtHourlyRate.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(24, 334);
            label8.Name = "label8";
            label8.Size = new Size(122, 23);
            label8.TabIndex = 36;
            label8.Text = "Hourly Rate";
            // 
            // txtPosition
            // 
            txtPosition.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtPosition.Location = new Point(148, 294);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(291, 32);
            txtPosition.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(24, 297);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 34;
            label7.Text = "Position";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtPhone.Location = new Point(147, 258);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(292, 32);
            txtPhone.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.Location = new Point(24, 261);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 32;
            label6.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtEmail.Location = new Point(148, 222);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 32);
            txtEmail.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(24, 225);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtAddress.Location = new Point(148, 187);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(291, 32);
            txtAddress.TabIndex = 29;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(24, 190);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 28;
            label4.Text = "Address";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtLastName.Location = new Point(148, 151);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(291, 32);
            txtLastName.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(24, 154);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 26;
            label3.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtFirstName.Location = new Point(148, 115);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(291, 32);
            txtFirstName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 118);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 24;
            label2.Text = "First Name";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtID.Location = new Point(148, 79);
            txtID.Name = "txtID";
            txtID.Size = new Size(291, 32);
            txtID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(24, 82);
            label1.Name = "label1";
            label1.Size = new Size(30, 23);
            label1.TabIndex = 22;
            label1.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtRole);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtHourlyRate);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPosition);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPhone);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 549);
            panel1.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(127, 12);
            label11.Name = "label11";
            label11.Size = new Size(220, 34);
            label11.TabIndex = 43;
            label11.Text = "New Employee";
            // 
            // NewEmployee
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(491, 573);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewEmployee";
            Text = "NewEmployee";
            Load += NewEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtRole;
        private Label label10;
        private TextBox txtPassword;
        private Label label9;
        private TextBox txtHourlyRate;
        private Label label8;
        private TextBox txtPosition;
        private Label label7;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Panel panel1;
        private Label label11;
    }
}