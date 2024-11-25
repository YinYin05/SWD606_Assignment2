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
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(563, 91);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First name:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(563, 54);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 20);
            labelId.TabIndex = 5;
            labelId.Text = "Id: ";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(563, 199);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(563, 233);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(42, 20);
            labelRole.TabIndex = 7;
            labelRole.Text = "Role:";
            // 
            // labelLeaveStatus
            // 
            labelLeaveStatus.AutoSize = true;
            labelLeaveStatus.Location = new Point(563, 312);
            labelLeaveStatus.Name = "labelLeaveStatus";
            labelLeaveStatus.Size = new Size(92, 20);
            labelLeaveStatus.TabIndex = 8;
            labelLeaveStatus.Text = "Leave status:";
            // 
            // buttonComplain
            // 
            buttonComplain.Location = new Point(536, 346);
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
            labelAddress.Location = new Point(563, 262);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(65, 20);
            labelAddress.TabIndex = 10;
            labelAddress.Text = "Address:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(563, 131);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 11;
            labelLastName.Text = "Last name:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(563, 165);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(53, 20);
            labelPhone.TabIndex = 12;
            labelPhone.Text = "Phone:";
            // 
            // labelHourlyRate
            // 
            labelHourlyRate.AutoSize = true;
            labelHourlyRate.Location = new Point(563, 292);
            labelHourlyRate.Name = "labelHourlyRate";
            labelHourlyRate.Size = new Size(86, 20);
            labelHourlyRate.TabIndex = 13;
            labelHourlyRate.Text = "Hourly rate:";
            // 
            // employeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 597);
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
    }
}