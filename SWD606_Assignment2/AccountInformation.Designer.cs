namespace SWD606_Assignment2
{
    partial class AccountInformation
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
            labelName = new Label();
            labelEmail = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(333, 94);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name: ";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(333, 162);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(53, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 54);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "My account";
            // 
            // AccountInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Name = "AccountInformation";
            Text = "AccountInformation";
            Load += AccountInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelEmail;
        private Label label1;
    }
}