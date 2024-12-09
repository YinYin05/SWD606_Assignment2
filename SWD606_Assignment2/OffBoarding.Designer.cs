namespace SWD606_Assignment2
{
    partial class OffBoarding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OffBoarding));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            openFileBTN = new LinkLabel();
            fileNameTXT = new Label();
            openFileDialog = new OpenFileDialog();
            submitBTN = new Button();
            label1 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 268);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 14;
            label4.Text = "Employee Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 204);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 13;
            label3.Text = "Employee ID:";
            // 
            // label2
            // 
            label2.Location = new Point(55, 26);
            label2.Name = "label2";
            label2.Size = new Size(691, 135);
            label2.TabIndex = 12;
            label2.Text = resources.GetString("label2.Text");
            // 
            // openFileBTN
            // 
            openFileBTN.AutoSize = true;
            openFileBTN.Location = new Point(402, 192);
            openFileBTN.Name = "openFileBTN";
            openFileBTN.Size = new Size(153, 20);
            openFileBTN.TabIndex = 23;
            openFileBTN.TabStop = true;
            openFileBTN.Text = "Attach Resume Letter:";
            openFileBTN.LinkClicked += openFileBTN_LinkClicked;
            // 
            // fileNameTXT
            // 
            fileNameTXT.Location = new Point(402, 227);
            fileNameTXT.Name = "fileNameTXT";
            fileNameTXT.Size = new Size(325, 65);
            fileNameTXT.TabIndex = 24;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // submitBTN
            // 
            submitBTN.Location = new Point(333, 358);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new Size(132, 63);
            submitBTN.TabIndex = 25;
            submitBTN.Text = "Send Resignation";
            submitBTN.UseVisualStyleBackColor = true;
            submitBTN.Click += submitBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 204);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 26;
            label1.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 268);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 27;
            label5.Text = "label5";
            // 
            // OffBoarding
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(submitBTN);
            Controls.Add(fileNameTXT);
            Controls.Add(openFileBTN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "OffBoarding";
            Text = "OffBoarding";
            Load += OffBoarding_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel openFileBTN;
        private Label fileNameTXT;
        private OpenFileDialog openFileDialog;
        private Button submitBTN;
        private Label label1;
        private Label label5;
    }
}