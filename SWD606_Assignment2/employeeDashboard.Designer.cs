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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelId = new Label();
            labelEmail = new Label();
            labelRole = new Label();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(563, 159);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(50, 20);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(477, 159);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 199);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 233);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 3;
            label3.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 121);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 4;
            label4.Text = "Id:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(563, 121);
            labelId.Name = "labelId";
            labelId.Size = new Size(50, 20);
            labelId.TabIndex = 5;
            labelId.Text = "label1";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(563, 199);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(50, 20);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "label1";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(563, 233);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(50, 20);
            labelRole.TabIndex = 7;
            labelRole.Text = "label1";
            // 
            // employeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 597);
            Controls.Add(labelRole);
            Controls.Add(labelEmail);
            Controls.Add(labelId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelFirstName);
            Name = "employeeDashboard";
            Text = "employeeDashboard";
            Load += employeeDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelId;
        private Label labelEmail;
        private Label labelRole;
    }
}