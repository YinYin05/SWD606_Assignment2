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
            btnLeaveApprovals = new Button();
            OffBoardingButton = new Button();
            VoiceGrievancesButton = new Button();
            RequestLeaveButton = new Button();
            PayrollBTN = new Button();
            labelFN = new Label();
            profileIMG = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIMG).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(btnLeaveApprovals);
            panel1.Controls.Add(OffBoardingButton);
            panel1.Controls.Add(VoiceGrievancesButton);
            panel1.Controls.Add(RequestLeaveButton);
            panel1.Controls.Add(PayrollBTN);
            panel1.Controls.Add(labelFN);
            panel1.Controls.Add(profileIMG);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 596);
            panel1.TabIndex = 0;
            // 
            // btnLeaveApprovals
            // 
            btnLeaveApprovals.FlatAppearance.BorderSize = 0;
            btnLeaveApprovals.FlatStyle = FlatStyle.Flat;
            btnLeaveApprovals.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeaveApprovals.Location = new Point(0, 277);
            btnLeaveApprovals.Name = "btnLeaveApprovals";
            btnLeaveApprovals.Size = new Size(168, 42);
            btnLeaveApprovals.TabIndex = 9;
            btnLeaveApprovals.Text = "Leave Approvals";
            btnLeaveApprovals.UseVisualStyleBackColor = true;
            btnLeaveApprovals.Click += btnLeaveApprovals_Click;
            // 
            // OffBoardingButton
            // 
            OffBoardingButton.FlatAppearance.BorderSize = 0;
            OffBoardingButton.FlatStyle = FlatStyle.Flat;
            OffBoardingButton.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OffBoardingButton.Location = new Point(0, 554);
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
            VoiceGrievancesButton.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VoiceGrievancesButton.Location = new Point(0, 236);
            VoiceGrievancesButton.Name = "VoiceGrievancesButton";
            VoiceGrievancesButton.Size = new Size(168, 42);
            VoiceGrievancesButton.TabIndex = 6;
            VoiceGrievancesButton.Text = "Voice Grievances";
            VoiceGrievancesButton.UseVisualStyleBackColor = true;
            VoiceGrievancesButton.Click += VoiceGrievancesButton_Click;
            // 
            // RequestLeaveButton
            // 
            RequestLeaveButton.FlatAppearance.BorderSize = 0;
            RequestLeaveButton.FlatStyle = FlatStyle.Flat;
            RequestLeaveButton.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RequestLeaveButton.Location = new Point(0, 194);
            RequestLeaveButton.Name = "RequestLeaveButton";
            RequestLeaveButton.Size = new Size(165, 42);
            RequestLeaveButton.TabIndex = 5;
            RequestLeaveButton.Text = "Request Leave";
            RequestLeaveButton.UseVisualStyleBackColor = true;
            RequestLeaveButton.Click += RequestLeaveButton_Click;
            // 
            // PayrollBTN
            // 
            PayrollBTN.FlatAppearance.BorderSize = 0;
            PayrollBTN.FlatStyle = FlatStyle.Flat;
            PayrollBTN.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayrollBTN.Location = new Point(0, 152);
            PayrollBTN.Name = "PayrollBTN";
            PayrollBTN.Size = new Size(168, 42);
            PayrollBTN.TabIndex = 4;
            PayrollBTN.Text = "Salary Details";
            PayrollBTN.UseVisualStyleBackColor = true;
            PayrollBTN.Click += PayrollBTN_Click;
            // 
            // labelFN
            // 
            labelFN.AutoSize = true;
            labelFN.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFN.Location = new Point(22, 105);
            labelFN.Name = "labelFN";
            labelFN.Size = new Size(63, 20);
            labelFN.TabIndex = 2;
            labelFN.Text = "label1";
            labelFN.Click += labelFN_Click;
            // 
            // profileIMG
            // 
            profileIMG.Image = (Image)resources.GetObject("profileIMG.Image");
            profileIMG.Location = new Point(46, 22);
            profileIMG.Name = "profileIMG";
            profileIMG.Size = new Size(63, 63);
            profileIMG.SizeMode = PictureBoxSizeMode.Zoom;
            profileIMG.TabIndex = 1;
            profileIMG.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(168, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 491);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(419, 231);
            label4.Name = "label4";
            label4.Size = new Size(235, 17);
            label4.TabIndex = 1;
            label4.Text = "Navigate using the side panel.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(263, 172);
            label3.Name = "label3";
            label3.Size = new Size(517, 32);
            label3.TabIndex = 0;
            label3.Text = "Welcome To Employee Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Wheat;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(168, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1034, 106);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(946, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(936, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 2;
            label2.Text = "Logout";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(661, 46);
            label1.TabIndex = 0;
            label1.Text = "RECA ENGINEERING COMPANY";
            // 
            // EmployeeDashboard2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 596);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDashboard2";
            Text = "EmployeeDashboard2";
            Load += EmployeeDashboard2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileIMG).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox profileIMG;
        private Label labelFN;
        private Button VoiceGrievancesButton;
        private Button RequestLeaveButton;
        private Button PayrollBTN;
        private Button OffBoardingButton;
        private Panel panel2;
        private Button btnLeaveApprovals;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
    }
}