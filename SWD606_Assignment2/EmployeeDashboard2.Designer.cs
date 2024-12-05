namespace SWD606_Assignment2
{
    partial class EmployeeDashboard2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard2));
            panel1 = new Panel();
            AccountInformationButton = new Button();
            OffBoardingButton = new Button();
            VoiceGrievancesButton = new Button();
            RequestLeaveButton = new Button();
            PayrollBTN = new Button();
            labelFN = new Label();
            profileIMG = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIMG).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(AccountInformationButton);
            panel1.Controls.Add(OffBoardingButton);
            panel1.Controls.Add(VoiceGrievancesButton);
            panel1.Controls.Add(RequestLeaveButton);
            panel1.Controls.Add(PayrollBTN);
            panel1.Controls.Add(labelFN);
            panel1.Controls.Add(profileIMG);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 597);
            panel1.TabIndex = 0;
            // 
            // AccountInformationButton
            // 
            AccountInformationButton.FlatAppearance.BorderSize = 0;
            AccountInformationButton.FlatStyle = FlatStyle.Flat;
            AccountInformationButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountInformationButton.Location = new Point(0, 553);
            AccountInformationButton.Name = "AccountInformationButton";
            AccountInformationButton.Size = new Size(186, 42);
            AccountInformationButton.TabIndex = 7;
            AccountInformationButton.Text = "Account Information";
            AccountInformationButton.UseVisualStyleBackColor = true;
            AccountInformationButton.Click += AccountInformationButton_Click;
            // 
            // OffBoardingButton
            // 
            OffBoardingButton.FlatAppearance.BorderSize = 0;
            OffBoardingButton.FlatStyle = FlatStyle.Flat;
            OffBoardingButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OffBoardingButton.Location = new Point(0, 505);
            OffBoardingButton.Name = "OffBoardingButton";
            OffBoardingButton.Size = new Size(186, 42);
            OffBoardingButton.TabIndex = 8;
            OffBoardingButton.Text = "Off Boarding";
            OffBoardingButton.UseVisualStyleBackColor = true;
            OffBoardingButton.Click += OffBoardingButton_Click;
            // 
            // VoiceGrievancesButton
            // 
            VoiceGrievancesButton.FlatAppearance.BorderSize = 0;
            VoiceGrievancesButton.FlatStyle = FlatStyle.Flat;
            VoiceGrievancesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VoiceGrievancesButton.Location = new Point(0, 236);
            VoiceGrievancesButton.Name = "VoiceGrievancesButton";
            VoiceGrievancesButton.Size = new Size(186, 42);
            VoiceGrievancesButton.TabIndex = 6;
            VoiceGrievancesButton.Text = "Voice Grievances";
            VoiceGrievancesButton.UseVisualStyleBackColor = true;
            VoiceGrievancesButton.Click += VoiceGrievancesButton_Click;
            // 
            // RequestLeaveButton
            // 
            RequestLeaveButton.FlatAppearance.BorderSize = 0;
            RequestLeaveButton.FlatStyle = FlatStyle.Flat;
            RequestLeaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RequestLeaveButton.Location = new Point(0, 194);
            RequestLeaveButton.Name = "RequestLeaveButton";
            RequestLeaveButton.Size = new Size(186, 42);
            RequestLeaveButton.TabIndex = 5;
            RequestLeaveButton.Text = "Request Leave";
            RequestLeaveButton.UseVisualStyleBackColor = true;
            RequestLeaveButton.Click += RequestLeaveButton_Click;
            // 
            // PayrollBTN
            // 
            PayrollBTN.FlatAppearance.BorderSize = 0;
            PayrollBTN.FlatStyle = FlatStyle.Flat;
            PayrollBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayrollBTN.Location = new Point(0, 152);
            PayrollBTN.Name = "PayrollBTN";
            PayrollBTN.Size = new Size(186, 42);
            PayrollBTN.TabIndex = 4;
            PayrollBTN.Text = "Salary Details";
            PayrollBTN.UseVisualStyleBackColor = true;
            PayrollBTN.Click += PayrollBTN_Click;
            // 
            // labelFN
            // 
            labelFN.AutoSize = true;
            labelFN.Location = new Point(66, 102);
            labelFN.Name = "labelFN";
            labelFN.Size = new Size(50, 20);
            labelFN.TabIndex = 2;
            labelFN.Text = "label1";
            // 
            // profileIMG
            // 
            profileIMG.Image = (Image)resources.GetObject("profileIMG.Image");
            profileIMG.Location = new Point(60, 22);
            profileIMG.Name = "profileIMG";
            profileIMG.Size = new Size(63, 63);
            profileIMG.SizeMode = PictureBoxSizeMode.Zoom;
            profileIMG.TabIndex = 1;
            profileIMG.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(186, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 597);
            panel2.TabIndex = 1;
            // 
            // EmployeeDashboard2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 597);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeeDashboard2";
            Text = "EmployeeDashboard2";
            Load += EmployeeDashboard2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileIMG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox profileIMG;
        private Label labelFN;
        private Button VoiceGrievancesButton;
        private Button RequestLeaveButton;
        private Button PayrollBTN;
        private Button AccountInformationButton;
        private Button OffBoardingButton;
        private Panel panel2;
    }
}