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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeDashboard));
            pnlNav = new Panel();
            infoBTN = new Button();
            resignBTN = new Button();
            grievancesBTN = new Button();
            LeaveBTN = new Button();
            PayrollBTN = new Button();
            panel2 = new Panel();
            labelFN = new Label();
            profileIMG = new PictureBox();
            PnlFormLoader = new Panel();
            labelTitle = new Label();
            pnlNav.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIMG).BeginInit();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.Controls.Add(infoBTN);
            pnlNav.Controls.Add(resignBTN);
            pnlNav.Controls.Add(grievancesBTN);
            pnlNav.Controls.Add(LeaveBTN);
            pnlNav.Controls.Add(PayrollBTN);
            pnlNav.Controls.Add(panel2);
            pnlNav.Dock = DockStyle.Left;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(186, 597);
            pnlNav.TabIndex = 0;
            // 
            // infoBTN
            // 
            infoBTN.Dock = DockStyle.Bottom;
            infoBTN.FlatAppearance.BorderSize = 0;
            infoBTN.FlatStyle = FlatStyle.Flat;
            infoBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoBTN.Location = new Point(0, 555);
            infoBTN.Name = "infoBTN";
            infoBTN.Size = new Size(186, 42);
            infoBTN.TabIndex = 2;
            infoBTN.Text = "Account Information";
            infoBTN.UseVisualStyleBackColor = true;
            infoBTN.Click += infoBTN_Click;
            infoBTN.Leave += infoBTN_Click;
            // 
            // resignBTN
            // 
            resignBTN.FlatAppearance.BorderSize = 0;
            resignBTN.FlatStyle = FlatStyle.Flat;
            resignBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resignBTN.Location = new Point(0, 507);
            resignBTN.Name = "resignBTN";
            resignBTN.Size = new Size(186, 42);
            resignBTN.TabIndex = 4;
            resignBTN.Text = "Off Boarding";
            resignBTN.UseVisualStyleBackColor = true;
            resignBTN.Click += resignBTN_Click;
            resignBTN.Leave += resignBTN_Click;
            // 
            // grievancesBTN
            // 
            grievancesBTN.Dock = DockStyle.Top;
            grievancesBTN.FlatAppearance.BorderSize = 0;
            grievancesBTN.FlatStyle = FlatStyle.Flat;
            grievancesBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grievancesBTN.Location = new Point(0, 228);
            grievancesBTN.Name = "grievancesBTN";
            grievancesBTN.Size = new Size(186, 42);
            grievancesBTN.TabIndex = 3;
            grievancesBTN.Text = "Voice Grievances";
            grievancesBTN.UseVisualStyleBackColor = true;
            grievancesBTN.Click += grievancesBTN_Click;
            grievancesBTN.Leave += grievancesBTN_Click;
            // 
            // LeaveBTN
            // 
            LeaveBTN.Dock = DockStyle.Top;
            LeaveBTN.FlatAppearance.BorderSize = 0;
            LeaveBTN.FlatStyle = FlatStyle.Flat;
            LeaveBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeaveBTN.Location = new Point(0, 186);
            LeaveBTN.Name = "LeaveBTN";
            LeaveBTN.Size = new Size(186, 42);
            LeaveBTN.TabIndex = 2;
            LeaveBTN.Text = "Request Leave";
            LeaveBTN.UseVisualStyleBackColor = true;
            LeaveBTN.Click += LeaveBTN_Click;
            LeaveBTN.Leave += LeaveBTN_Click;
            // 
            // PayrollBTN
            // 
            PayrollBTN.Dock = DockStyle.Top;
            PayrollBTN.FlatAppearance.BorderSize = 0;
            PayrollBTN.FlatStyle = FlatStyle.Flat;
            PayrollBTN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayrollBTN.Location = new Point(0, 144);
            PayrollBTN.Name = "PayrollBTN";
            PayrollBTN.Size = new Size(186, 42);
            PayrollBTN.TabIndex = 1;
            PayrollBTN.Text = "Salary Details";
            PayrollBTN.UseVisualStyleBackColor = true;
            PayrollBTN.Click += PayrollBTN_Click;
            PayrollBTN.Leave += PayrollBTN_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelFN);
            panel2.Controls.Add(profileIMG);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 0;
            // 
            // labelFN
            // 
            labelFN.AutoSize = true;
            labelFN.Location = new Point(66, 102);
            labelFN.Name = "labelFN";
            labelFN.Size = new Size(50, 20);
            labelFN.TabIndex = 1;
            labelFN.Text = "label1";
            labelFN.Click += label1_Click;
            // 
            // profileIMG
            // 
            profileIMG.Image = (Image)resources.GetObject("profileIMG.Image");
            profileIMG.Location = new Point(60, 22);
            profileIMG.Name = "profileIMG";
            profileIMG.Size = new Size(63, 63);
            profileIMG.SizeMode = PictureBoxSizeMode.Zoom;
            profileIMG.TabIndex = 0;
            profileIMG.TabStop = false;
            // 
            // PnlFormLoader
            // 
            PnlFormLoader.Dock = DockStyle.Bottom;
            PnlFormLoader.Location = new Point(186, 120);
            PnlFormLoader.Name = "PnlFormLoader";
            PnlFormLoader.Size = new Size(1068, 477);
            PnlFormLoader.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(215, 37);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(140, 54);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Payroll";
            // 
            // employeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 597);
            Controls.Add(labelTitle);
            Controls.Add(PnlFormLoader);
            Controls.Add(pnlNav);
            Name = "employeeDashboard";
            Text = "employeeDashboard";
            Load += employeeDashboard_Load;
            pnlNav.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileIMG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNav;
        private Panel panel2;
        private Label labelFN;
        private PictureBox profileIMG;
        private Button PayrollBTN;
        private Button infoBTN;
        private Button resignBTN;
        private Button grievancesBTN;
        private Button LeaveBTN;
        private Panel PnlFormLoader;
        private Label labelTitle;
    }
}