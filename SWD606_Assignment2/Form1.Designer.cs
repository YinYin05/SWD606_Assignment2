namespace SWD606_Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtEmail = new TextBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 128);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtEmail.Location = new Point(174, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 32);
            txtEmail.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LimeGreen;
            btnLogin.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(201, 222);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 52);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(174, 164);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(291, 32);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(42, 171);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 374);
            panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(129, 304);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(268, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Can't Login? Contact the Administrator.";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 28);
            label3.Name = "label3";
            label3.Size = new Size(310, 40);
            label3.TabIndex = 4;
            label3.Text = "RECA Engineering";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(540, 398);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
