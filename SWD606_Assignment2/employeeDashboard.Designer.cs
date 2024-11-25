namespace SWD606_Assignment2
{
    partial class employeeDashboard
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
            labelFirstName = new Label();
            labelId = new Label();
            labelEmail = new Label();
            labelRole = new Label();
            labelLeaveStatus = new Label();
            buttonComplain = new Button();
            labelAddress = new Label();
            labelLastName = new Label();
            labelPhone = new Label();
            labelHourlyRate = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(1018, 209);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First name:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(1018, 172);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 20);
            labelId.TabIndex = 5;
            labelId.Text = "Id: ";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(1018, 317);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(1018, 351);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(42, 20);
            labelRole.TabIndex = 7;
            labelRole.Text = "Role:";
            // 
            // labelLeaveStatus
            // 
            labelLeaveStatus.AutoSize = true;
            labelLeaveStatus.Location = new Point(1018, 430);
            labelLeaveStatus.Name = "labelLeaveStatus";
            labelLeaveStatus.Size = new Size(92, 20);
            labelLeaveStatus.TabIndex = 8;
            labelLeaveStatus.Text = "Leave status:";
            // 
            // buttonComplain
            // 
            buttonComplain.Location = new Point(991, 464);
            buttonComplain.Name = "buttonComplain";
            buttonComplain.Size = new Size(149, 29);
            buttonComplain.TabIndex = 9;
            buttonComplain.Text = "Voice grievances";
            buttonComplain.UseVisualStyleBackColor = true;
            buttonComplain.Click += buttonComplain_Click;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(1018, 380);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(65, 20);
            labelAddress.TabIndex = 10;
            labelAddress.Text = "Address:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(1018, 249);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 11;
            labelLastName.Text = "Last name:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(1018, 283);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(53, 20);
            labelPhone.TabIndex = 12;
            labelPhone.Text = "Phone:";
            // 
            // labelHourlyRate
            // 
            labelHourlyRate.AutoSize = true;
            labelHourlyRate.Location = new Point(1018, 410);
            labelHourlyRate.Name = "labelHourlyRate";
            labelHourlyRate.Size = new Size(86, 20);
            labelHourlyRate.TabIndex = 13;
            labelHourlyRate.Text = "Hourly rate:";
            // 
            // button1
            // 
            button1.Location = new Point(627, 197);
            button1.Name = "button1";
            button1.Size = new Size(135, 44);
            button1.TabIndex = 14;
            button1.Text = "Leave Status";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(476, 198);
            button2.Name = "button2";
            button2.Size = new Size(135, 43);
            button2.TabIndex = 15;
            button2.Text = "Payroll";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(476, 308);
            button3.Name = "button3";
            button3.Size = new Size(135, 44);
            button3.TabIndex = 16;
            button3.Text = "Offboarding";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(633, 301);
            button4.Name = "button4";
            button4.Size = new Size(129, 51);
            button4.TabIndex = 17;
            button4.Text = "Grievances";
            button4.UseVisualStyleBackColor = true;
            // 
            // employeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 597);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelHourlyRate);
            Controls.Add(labelPhone);
            Controls.Add(labelLastName);
            Controls.Add(labelAddress);
            Controls.Add(buttonComplain);
            Controls.Add(labelLeaveStatus);
            Controls.Add(labelRole);
            Controls.Add(labelEmail);
            Controls.Add(labelId);
            Controls.Add(labelFirstName);
            Name = "employeeDashboard";
            Text = "employeeDashboard";
            Load += employeeDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private Label labelId;
        private Label labelEmail;
        private Label labelRole;
        private Label labelLeaveStatus;
        private Button buttonComplain;
        private Label labelAddress;
        private Label labelLastName;
        private Label labelPhone;
        private Label labelHourlyRate;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}